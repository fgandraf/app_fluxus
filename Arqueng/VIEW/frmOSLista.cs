using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Data;

namespace Arqueng.VIEW
{

    public partial class frmOSLista : Form
    {

        frmPrincipal _frmPrincipal;
        DataView dvOSFiltrada;



        //:MÉTODOS

        private void EditarOS(DataGridView dgv)
        {
            frmAddOS formNeto = new frmAddOS
            (
                _frmPrincipal, this.Name,
                dgv.CurrentRow.Cells[0].Value.ToString(),//referencia
                dgv.CurrentRow.Cells[1].Value.ToString(),//agencia
                dgv.CurrentRow.Cells[2].Value.ToString(),//titulo
                dgv.CurrentRow.Cells[3].Value.ToString(),//data_ordem
                dgv.CurrentRow.Cells[4].Value.ToString(),//prazo_execucao
                dgv.CurrentRow.Cells[5].Value.ToString(),//profissional_cod
                dgv.CurrentRow.Cells[6].Value.ToString(),//atividade_cod
                Convert.ToBoolean(dgv.CurrentRow.Cells[7].Value),//siopi
                dgv.CurrentRow.Cells[8].Value.ToString(),//nome_cliente
                dgv.CurrentRow.Cells[9].Value.ToString(),//cidade
                dgv.CurrentRow.Cells[10].Value.ToString(),//nome_contato
                dgv.CurrentRow.Cells[11].Value.ToString(),//telefone_contato
                dgv.CurrentRow.Cells[12].Value.ToString(),//coordenada
                dgv.CurrentRow.Cells[13].Value.ToString(),//status
                dgv.CurrentRow.Cells[14].Value.ToString(),//data_pendente
                dgv.CurrentRow.Cells[15].Value.ToString(),//data_vistoria
                dgv.CurrentRow.Cells[16].Value.ToString(),//data_concluida
                dgv.CurrentRow.Cells[17].Value.ToString(),//obs
                dgv.CurrentRow.Cells[18].Value.ToString()//fatura_cod
            );
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
                    OsMODEL model = new OsMODEL();
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Referencia = dgv.CurrentRow.Cells["referencia"].Value.ToString();
                    model.DeleteOsModel(dado);
                    DT.OS = model.ListarOsModel();
                    ListarOS(dgv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListarOS(DataGridView dgv)
        {
            try
            {
                dgvOS.DataSource = DT.OS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        private string GerarFiltro()
        {
            string faturadas;
            {
                if (cboFaturadas.SelectedIndex == 0)
                    faturadas = ">= 0";
                else if (cboFaturadas.SelectedIndex == 1)
                    faturadas = "> 0";
                else
                    faturadas = "= 0";
            }

            string profissional;
            {
                if (cboProfissional.SelectedValue.ToString() == "")
                    profissional = "<> ' '";
                else
                    profissional = "= '" + cboProfissional.SelectedValue.ToString() + "'";
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

            string filtro = String.Format("profissional_cod {0} AND atividade_cod {1} AND cidade {2} AND status {3} AND fatura_cod {4}", profissional, atividade, cidade, status, faturadas);

            return filtro;
        }

        private void LimparFiltro()
        {
            cboProfissional.SelectedIndex = 0;
            cboCidade.SelectedIndex = 0;
            cboAtividade.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtPesquisar.Text = null;
            dvOSFiltrada = new DataView();
        }







        //:EVENTOS

        ///_______FORMULÁRIO
        public frmOSLista(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            cboProfissional.DataSource = Globais.Profissionais(true);
            cboCidade.DataSource = Globais.Cidades();
            cboAtividade.DataSource = Globais.Atividades(true);
            LimparFiltro();
            ListarOS(dgvOS);
        }





        ///_______BOTÔES
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.CurrentRow.Cells["fatura_cod"].Value.ToString() != "0")
            {
                MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                ExcluirOS(dgvOS);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarOS(dgvOS);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dvOSFiltrada = new DataView(DT.OS);
            dvOSFiltrada.RowFilter = GerarFiltro();
            dgvOS.DataSource = dvOSFiltrada;
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            LimparFiltro();
            ListarOS(dgvOS);
            btnLimparFiltro.Hide();
        }





        ///_______DATAGRIDVIEW
        private void dgvOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvOS.CurrentCell.Selected)
            {
                if (dgvOS.CurrentRow.Cells["fatura_cod"].Value.ToString() != "0")
                {
                    MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ExcluirOS(dgvOS);
                }
            }
        }

        private void dgvOS_DoubleClick(object sender, EventArgs e)
        {
            EditarOS(dgvOS);
        }





        ///_______TEXTBOX PESQUISAR
        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisar.Text == "" && btnLimparFiltro.Visible == false)
                dgvOS.DataSource = DT.OS;
            else if (txtPesquisar.Text == "" && btnLimparFiltro.Visible == true)
                dgvOS.DataSource = dvOSFiltrada;
            else
            {
                if (btnLimparFiltro.Visible == true)
                {
                    DataTable dtFiltrada = dvOSFiltrada.ToTable();
                    DataView dvPesquisa = new DataView(dtFiltrada);
                    dvPesquisa.RowFilter = String.Format("nome_cliente LIKE '%{0}%' OR referencia LIKE '%{0}%' OR atividade_cod LIKE '%{0}%' OR cidade LIKE '%{0}%' OR nome_contato LIKE '%{0}%' OR profissional_cod LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
                else
                {
                    DataView dvPesquisa = new DataView(DT.OS);
                    dvPesquisa.RowFilter = String.Format("nome_cliente LIKE '%{0}%' OR referencia LIKE '%{0}%' OR atividade_cod LIKE '%{0}%' OR cidade LIKE '%{0}%' OR nome_contato LIKE '%{0}%' OR profissional_cod LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }
    }


}