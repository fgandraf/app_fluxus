using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Data;

namespace Arqueng.VIEW
{

    public partial class frmRelatorios : Form
    {

        frmPrincipal _frmPrincipal;
        OsMODEL model = new OsMODEL();
        //OsENT dado = new OsENT();
        DataTable dtOS = new DataTable();
        DataView dvOS;


        //:MÉTODOS


        private void EditarOS()
        {
            frmAddOS formNeto = new frmAddOS
            (
                _frmPrincipal, this.Name,
                dgvOS.CurrentRow.Cells["titulo"].Value.ToString(),
                dgvOS.CurrentRow.Cells["referencia"].Value.ToString(),
                dgvOS.CurrentRow.Cells["agencia"].Value.ToString(),
                dgvOS.CurrentRow.Cells["data_ordem"].Value.ToString(),
                dgvOS.CurrentRow.Cells["prazo_execucao"].Value.ToString(),
                dgvOS.CurrentRow.Cells["profissional_cod"].Value.ToString(),
                dgvOS.CurrentRow.Cells["atividade_cod"].Value.ToString(),
                Convert.ToBoolean(dgvOS.CurrentRow.Cells["siopi"].Value),
                dgvOS.CurrentRow.Cells["nome_cliente"].Value.ToString(),
                dgvOS.CurrentRow.Cells["cidade"].Value.ToString(),
                dgvOS.CurrentRow.Cells["nome_contato"].Value.ToString(),
                dgvOS.CurrentRow.Cells["telefone_contato"].Value.ToString(),
                dgvOS.CurrentRow.Cells["coordenada"].Value.ToString(),
                dgvOS.CurrentRow.Cells["status"].Value.ToString(),
                dgvOS.CurrentRow.Cells["data_pendente"].Value.ToString(),
                dgvOS.CurrentRow.Cells["data_vistoria"].Value.ToString(),
                dgvOS.CurrentRow.Cells["data_concluida"].Value.ToString(),
                dgvOS.CurrentRow.Cells["obs"].Value.ToString(),
                dgvOS.CurrentRow.Cells["fatura_cod"].Value.ToString()
            );
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void ExcluirOS()
        {
            try
            {
                ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                dado.Referencia = dgvOS.CurrentRow.Cells["referencia"].Value.ToString();
                model.DeleteOsModel(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCidades()
        {
            OsMODEL model = new OsMODEL();
            try
            {
                DataTable dt = model.ListarCidadesModel();
                DataRow linha = dt.NewRow();
                linha[0] = "--TODAS--";
                dt.Rows.InsertAt(linha, 0);
                cboCidade.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarProfissionais()
        {
            ProfissionaisMODEL profmodel = new ProfissionaisMODEL();
            try
            {
                DataTable dt = profmodel.ListarCodNomeProModel();
                DataRow linha = dt.NewRow();
                linha[1] = "--TODOS--";
                dt.Rows.InsertAt(linha, 0);
                cboProfissional.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarAtividades()
        {
            AtividadesMODEL model = new AtividadesMODEL();
            try
            {
                DataTable dt = model.ListarCodigoAtividadesModel();
                DataRow linha = dt.NewRow();
                linha[0] = "--TODAS--";
                dt.Rows.InsertAt(linha, 0);
                cboAtividade.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarOS()
        {
            try
            {
                dtOS = model.ListarOsModel();
                dgvOS.DataSource = dtOS;
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

            string sql = String.Format("profissional_cod {0} AND atividade_cod {1} AND cidade {2} AND status {3} AND fatura_cod {4}", profissional, atividade, cidade, status, faturadas);

            return sql;
        }

        private void LimparFiltro()
        {
            cboProfissional.SelectedIndex = 0;
            cboCidade.SelectedIndex = 0;
            cboAtividade.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtPesquisar.Text = null;
        }







        //:EVENTOS

        ///_______FORMULÁRIO
        public frmRelatorios(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            ListarProfissionais();
            ListarCidades();
            ListarAtividades();
            LimparFiltro();
            ListarOS();
        }





        ///_______BOTÔES
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.CurrentRow.Cells["fatura_cod"].Value.ToString() != "0")
            {
                MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ExcluirOS();
                ListarOS();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarOS();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dvOS = new DataView(dtOS);
            dvOS.RowFilter = GerarFiltro();
            dgvOS.DataSource = dvOS;
            btnLimparFiltro.Show();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            LimparFiltro();
            dgvOS.DataSource = dtOS;
            btnLimparFiltro.Hide();
        }





        ///_______DATAGRIDVIEW
        private void dgvOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvOS.CurrentCell.Selected)
            {
                var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    ExcluirOS();
                    ListarOS();
                }
            }
        }

        private void dgvOS_DoubleClick(object sender, EventArgs e)
        {
            EditarOS();
        }





        ///_______TEXTBOX PESQUISAR
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
                dgvOS.DataSource = dtOS;
            else
            {
                dvOS = new DataView(dtOS);
                dvOS.RowFilter = String.Format("nome_cliente LIKE '%{0}%' OR referencia LIKE '%{0}%' OR atividade_cod LIKE '%{0}%' OR cidade LIKE '%{0}%' OR nome_contato LIKE '%{0}%' OR profissional_cod LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                dgvOS.DataSource = dvOS;
            }
        }


    }


}