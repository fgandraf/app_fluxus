using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{

    public partial class frmOSLista : Form
    {

        frmPrincipal _frmPrincipal;
        OsMODEL model = new OsMODEL();
        OsENT dado = new OsENT();


        public void ListarOS()
        {
            try
            {
                dado.Status = null;
                dgvOS.DataSource = model.ListarOsStatusModel(dado);

                if (dgvOS.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvOS.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvOS.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }


        public void ExcluirOS()
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


        public frmOSLista(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        private void frmOS_Load(object sender, EventArgs e)
        {
            ListarOS();
            txtPesquisar.Focus();
        }


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
            frmAddOS formNeto = new frmAddOS
            (
                _frmPrincipal, this.Name,
                dgvOS.CurrentRow.Cells["titulo"].Value.ToString(),
                dgvOS.CurrentRow.Cells["referencia"].Value.ToString(),
                dgvOS.CurrentRow.Cells["data_ordem"].Value.ToString(),
                dgvOS.CurrentRow.Cells["prazo_execucao"].Value.ToString(),
                dgvOS.CurrentRow.Cells["profissional_cod"].Value.ToString(),
                dgvOS.CurrentRow.Cells["atividade_cod"].Value.ToString(),
                dgvOS.CurrentRow.Cells["siopi"].Value.ToString(),
                dgvOS.CurrentRow.Cells["nome_cliente"].Value.ToString(),
                dgvOS.CurrentRow.Cells["cidade"].Value.ToString(),
                dgvOS.CurrentRow.Cells["nome_contato"].Value.ToString(),
                dgvOS.CurrentRow.Cells["telefone_contato"].Value.ToString(),
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


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }


        private void cboFaturadas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListarOS();
        }

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

    }


}