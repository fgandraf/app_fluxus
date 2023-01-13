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
        frmPrincipal _frmPrincipal;
        DataView _dvOSFiltrada;
        DataTable dtOS;



        //:METHODS

        private void EditarOS(DataGridView dgv)
        {
            Os ordemDeServico = new OsService().GetBy(Convert.ToInt64(dgv.CurrentRow.Cells[0].Value));

            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name, ordemDeServico);


            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }


        private void ExcluirOS(DataGridView dgv)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    new OsService().Delete((Convert.ToInt64(dgv.CurrentRow.Cells[0].Value)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListarOS(DataGridView dgv)
        {

            dtOS = new OsService().GetOrdensComFiltro(GerarStringSQL());
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
            string profissional;
            {
                if (cboProfissional.SelectedValue.ToString() == "")
                    profissional = "<> ' '";
                else
                    profissional = "= '" + cboProfissional.SelectedValue.ToString() + "'";
            }

            string faturadas;
            {
                if (cboFaturadas.SelectedIndex == 0)
                    faturadas = ">= 0";
                else if (cboFaturadas.SelectedIndex == 1)
                    faturadas = "> 0";
                else
                    faturadas = "= 0";
            }



            string atividade;
            {
                if (cboAtividade.SelectedIndex == 0)
                    atividade = "<> ' '";
                else
                    atividade = "= '" + cboAtividade.SelectedValue.ToString() + "'";
            }

            string cidade;
            {
                if (cboCidade.SelectedIndex == 0)
                    cidade = "<> ' '";
                else
                    cidade = "= '" + cboCidade.SelectedValue.ToString() + "'";
            }

            string status;
            {
                if (cboStatus.SelectedIndex == 0)
                    status = "<> ' '";
                else
                    status = "= '" + cboStatus.SelectedItem + "'";
            }

            string filtro = String.Format("SELECT * from tb_os WHERE profissional_cod {0} AND atividade_cod {1} AND cidade {2} AND status {3} AND fatura_cod {4} ORDER BY data_ordem", profissional, atividade, cidade, status, faturadas);

            return filtro;
        }





        //:EVENTS
        ///_______Form
        public frmOSLista(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmOS_Load(object sender, EventArgs e)
        {

            cboProfissional.DataSource = new ProfissionalService().ListarCodigoENomeid(true);
            cboCidade.DataSource = new OsService().GetCidadesDasOrdens(true);
            cboAtividade.DataSource = new AtividadeService().ListarAtividades(true);



            LimparFiltro();
            if (Logged.Rt)
                cboProfissional.SelectedValue = Logged.Codpro;
            else
                cboProfissional.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 2;



            ListarOS(dgvOS);
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();


        }





        ///_______Button
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(dgvOS.CurrentRow.Cells["fatura_cod"].Value) != 0)
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
                    XcelApp.Cells[1, 1] = dgvOS.Columns["profissional_cod"].HeaderText;
                    XcelApp.Cells[1, 2] = dgvOS.Columns["status"].HeaderText;
                    XcelApp.Cells[1, 3] = dgvOS.Columns["data_ordem"].HeaderText;
                    XcelApp.Cells[1, 4] = dgvOS.Columns["prazo_execucao"].HeaderText;
                    XcelApp.Cells[1, 5] = dgvOS.Columns["referencia"].HeaderText;
                    XcelApp.Cells[1, 6] = dgvOS.Columns["atividade_cod"].HeaderText;
                    XcelApp.Cells[1, 7] = dgvOS.Columns["cidade"].HeaderText;
                    XcelApp.Cells[1, 8] = dgvOS.Columns["agencia"].HeaderText;
                    XcelApp.Cells[1, 9] = dgvOS.Columns["siopi"].HeaderText;
                    XcelApp.Cells[1, 10] = dgvOS.Columns["nome_cliente"].HeaderText;
                    XcelApp.Cells[1, 11] = dgvOS.Columns["nome_contato"].HeaderText;
                    XcelApp.Cells[1, 12] = dgvOS.Columns["telefone_contato"].HeaderText;
                    XcelApp.Cells[1, 13] = dgvOS.Columns["data_pendente"].HeaderText;
                    XcelApp.Cells[1, 14] = dgvOS.Columns["data_vistoria"].HeaderText;
                    XcelApp.Cells[1, 15] = dgvOS.Columns["data_concluida"].HeaderText;
                    XcelApp.Cells[1, 16] = dgvOS.Columns["coordenada"].HeaderText;
                    XcelApp.Cells[1, 17] = dgvOS.Columns["obs"].HeaderText;


                    //Linhas
                    for (int i = 0; i < dgvOS.RowCount - 1; i++)
                    {
                        XcelApp.Cells[i + 2, 1] = dgvOS.Rows[i].Cells["profissional_cod"].Value.ToString();
                        XcelApp.Cells[i + 2, 2] = dgvOS.Rows[i].Cells["status"].Value.ToString();

                        if (((DateTime)dgvOS.Rows[i].Cells["data_ordem"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 3] = ((DateTime)dgvOS.Rows[i].Cells["data_ordem"].Value).ToString("MM/dd/yyyy");

                        if (((DateTime)dgvOS.Rows[i].Cells["prazo_execucao"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 4] = ((DateTime)dgvOS.Rows[i].Cells["prazo_execucao"].Value).ToString("MM/dd/yyyy");

                        XcelApp.Cells[i + 2, 5] = dgvOS.Rows[i].Cells["referencia"].Value.ToString();
                        XcelApp.Cells[i + 2, 6] = dgvOS.Rows[i].Cells["atividade_cod"].Value.ToString();
                        XcelApp.Cells[i + 2, 7] = dgvOS.Rows[i].Cells["cidade"].Value.ToString();
                        XcelApp.Cells[i + 2, 8] = dgvOS.Rows[i].Cells["agencia"].Value.ToString();

                        if (Convert.ToBoolean(dgvOS.Rows[i].Cells["siopi"].Value) == true)
                            XcelApp.Cells[i + 2, 9] = "✔";
                        else
                            XcelApp.Cells[i + 2, 9] = "✘";

                        XcelApp.Cells[i + 2, 10] = dgvOS.Rows[i].Cells["nome_cliente"].Value.ToString();
                        XcelApp.Cells[i + 2, 11] = dgvOS.Rows[i].Cells["nome_contato"].Value.ToString();
                        XcelApp.Cells[i + 2, 12] = dgvOS.Rows[i].Cells["telefone_contato"].Value.ToString();

                        if (((DateTime)dgvOS.Rows[i].Cells["data_pendente"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 13] = ((DateTime)dgvOS.Rows[i].Cells["data_pendente"].Value).ToString("MM/dd/yyyy");

                        if (((DateTime)dgvOS.Rows[i].Cells["data_vistoria"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 14] = ((DateTime)dgvOS.Rows[i].Cells["data_vistoria"].Value).ToString("MM/dd/yyyy");

                        if (((DateTime)dgvOS.Rows[i].Cells["data_concluida"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 15] = ((DateTime)dgvOS.Rows[i].Cells["data_concluida"].Value).ToString("MM/dd/yyyy");

                        XcelApp.Cells[i + 2, 16] = dgvOS.Rows[i].Cells["coordenada"].Value.ToString();
                        XcelApp.Cells[i + 2, 17] = dgvOS.Rows[i].Cells["obs"].Value.ToString();
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
                if (Convert.ToInt64(dgvOS.CurrentRow.Cells["fatura_cod"].Value) != 0)
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
                    dvPesquisa.RowFilter = String.Format("nome_cliente LIKE '%{0}%' OR referencia LIKE '%{0}%' OR atividade_cod LIKE '%{0}%' OR cidade LIKE '%{0}%' OR nome_contato LIKE '%{0}%' OR profissional_cod LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
                else
                {
                    DataView dvPesquisa = new DataView(dtOS);
                    dvPesquisa.RowFilter = String.Format("nome_cliente LIKE '%{0}%' OR referencia LIKE '%{0}%' OR atividade_cod LIKE '%{0}%' OR cidade LIKE '%{0}%' OR nome_contato LIKE '%{0}%' OR profissional_cod LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }



    }



}


