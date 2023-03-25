using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using Fluxus.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Fluxus.WinUI.View
{
    public partial class frmOSLista : Form
    {
        frmMain _frmPrincipal;
        DataView _dvOSFiltrada;
        DataTable dtOS;



        //:METHODS

        private void EditarOS(DataGridView dgv)
        {
            ServiceOrder ordemDeServico = new Services.ServiceOrderService().GetBy(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));

            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name, ordemDeServico);


            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto);
        }


        private void ExcluirOS(DataGridView dgv)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    new Services.ServiceOrderService().Delete((Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListarOS(DataGridView dgv)
        {
            dtOS = new Services.ServiceOrderService().GetOrdensComFiltro(GerarStringSQL());
            dgv.DataSource = dtOS;

        }

        private void LimparFiltro()
        {
            cboProfissional.SelectedIndex = 0;
            cboCidade.SelectedIndex = 0;
            cboAtividade.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtPesquisar.Text = null;
            _dvOSFiltrada = new DataView();
        }

        private string GerarStringSQL()
        {
            string professional = cboProfissional.SelectedIndex == 0 ? "%" : $"{cboProfissional.SelectedValue.ToString()}";
            string status = cboStatus.SelectedIndex == 0 ? "%" : $"{cboStatus.Text}";
            string city = cboCidade.SelectedIndex == 0 ? "%" : $"{cboCidade.Text}";
            string service = cboAtividade.SelectedIndex == 0 ? "%" : $"{cboAtividade.Text}";

            string invoiced = cboFaturadas.SelectedIndex.ToString();

            //switch (cboFaturadas.SelectedIndex)
            //{
            //    case 1: invoiced = "1"; break;
            //    case 2: invoiced = "0"; break;
            //    default: invoiced = "%"; break;
            //}

            return $"{professional},{service},{city},{status},{invoiced}";
        }





        //:EVENTS
        ///_______Form
        public frmOSLista(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmOS_Load(object sender, EventArgs e)
        {

            cboProfissional.DataSource = new ProfessionalService().GetCodeNameid(true);
            cboCidade.DataSource = new Services.ServiceOrderService().GetCidadesDasOrdens(true);
            cboAtividade.DataSource = new ServiceService().ListarAtividades(true);



            LimparFiltro();
            if (Logged.Rt)
                cboProfissional.SelectedIndex = Convert.ToInt32(Logged.ProfessionalId);
            else
                cboProfissional.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 0;



            ListarOS(dgvOS);
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();


        }





        ///_______Button
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(dgvOS.CurrentRow.Cells["invoiceId"].Value) != 0)
            {
                MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ExcluirOS(dgvOS);
                ListarOS(dgvOS);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarOS(dgvOS);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ListarOS(dgvOS);
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente prosseguir?" + "\n\n" + "Isto irá retornar todas as ordens de serviços existentes no banco de dados." + "\n\n" + "O processo pode ser lento dependendo do tamanho da base.", "Limpar filtro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                LimparFiltro();
                ListarOS(dgvOS);
                btnLimparFiltro.Hide();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                Excel.Application XcelApp = new Excel.Application();
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);


                    ////Titulo das células

                    XcelApp.Cells[1, 1] = dgvOS.Columns["status"].HeaderText;
                    XcelApp.Cells[1, 2] = dgvOS.Columns["professional"].HeaderText;
                    XcelApp.Cells[1, 3] = dgvOS.Columns["orderDate"].HeaderText;
                    XcelApp.Cells[1, 4] = dgvOS.Columns["referenceCode"].HeaderText;
                    XcelApp.Cells[1, 5] = dgvOS.Columns["service"].HeaderText;
                    XcelApp.Cells[1, 6] = dgvOS.Columns["city"].HeaderText;
                    XcelApp.Cells[1, 7] = dgvOS.Columns["customerName"].HeaderText;
                    XcelApp.Cells[1, 8] = dgvOS.Columns["surveyDate"].HeaderText;
                    XcelApp.Cells[1, 9] = dgvOS.Columns["doneDate"].HeaderText;


                    //Linhas
                    for (int i = 0; i < dgvOS.RowCount - 1; i++)
                    {
                        XcelApp.Cells[i + 2, 1] = dgvOS.Rows[i].Cells["status"].Value.ToString();
                        XcelApp.Cells[i + 2, 2] = dgvOS.Rows[i].Cells["professional"].Value.ToString();
                        XcelApp.Cells[i + 2, 3] = dgvOS.Rows[i].Cells["orderDate"].Value.ToString();
                        XcelApp.Cells[i + 2, 4] = dgvOS.Rows[i].Cells["referenceCode"].Value.ToString();
                        XcelApp.Cells[i + 2, 5] = dgvOS.Rows[i].Cells["service"].Value.ToString();
                        XcelApp.Cells[i + 2, 6] = dgvOS.Rows[i].Cells["city"].Value.ToString();
                        XcelApp.Cells[i + 2, 7] = dgvOS.Rows[i].Cells["customerName"].Value.ToString();
                        XcelApp.Cells[i + 2, 8] = dgvOS.Rows[i].Cells["surveyDate"].Value.ToString();
                        XcelApp.Cells[i + 2, 9] = dgvOS.Rows[i].Cells["doneDate"].Value.ToString();
                    }


                    //Configurações
                    XcelApp.Columns.AutoFit();
                    XcelApp.Rows.RowHeight = 15;


                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    XcelApp.Quit();
                }

            }
        }





        ///_______DataGridView
        private void dgvOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvOS.CurrentCell.Selected)
            {
                if (Convert.ToInt64(dgvOS.CurrentRow.Cells["invoiceId"].Value) != 0)
                {
                    MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ExcluirOS(dgvOS);
                    ListarOS(dgvOS);
                }
            }
        }

        private void dgvOS_DoubleClick(object sender, EventArgs e)
        {
            EditarOS(dgvOS);
        }





        ///_______TextBox
        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisar.Text == "")
                dgvOS.DataSource = dtOS;
            else
            {
                if (btnLimparFiltro.Visible == true)
                {
                    System.Data.DataTable dtFiltrada = dtOS.Copy();
                    DataView dvPesquisa = new DataView(dtFiltrada);
                    dvPesquisa.RowFilter = String.Format("customerName LIKE '%{0}%' OR referenceCode LIKE '%{0}%' OR service LIKE '%{0}%' OR city LIKE '%{0}%' OR professional LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
                else
                {
                    DataView dvPesquisa = new DataView(dtOS);
                    dvPesquisa.RowFilter = String.Format("customerName LIKE '%{0}%' OR referenceCode LIKE '%{0}%' OR service LIKE '%{0}%' OR city LIKE '%{0}%' OR professional LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }



    }



}


