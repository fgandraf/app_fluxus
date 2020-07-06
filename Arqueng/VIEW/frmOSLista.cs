using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{

    public partial class frmOSLista : Form
    {

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
        }


        public frmOSLista()
        {
            InitializeComponent();
        }


        private void frmOS_Load(object sender, EventArgs e)
        {
            cboFaturadas.Text = "Todas";
            ListarOS();
            txtPesquisar.Focus();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.CurrentRow.Cells[17].Value.ToString() != "0")
            {
                MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Id = dgvOS.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteOsModel(dado);
                    ListarOS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddOS form = new frmAddOS
            (
                dgvOS.CurrentRow.Cells[0].Value.ToString(),//id
                dgvOS.CurrentRow.Cells[1].Value.ToString(),//titulo
                dgvOS.CurrentRow.Cells[2].Value.ToString(),//referencia
                dgvOS.CurrentRow.Cells[3].Value.ToString(),//data_ordem
                dgvOS.CurrentRow.Cells[4].Value.ToString(),//prazo_execucao
                dgvOS.CurrentRow.Cells[5].Value.ToString(),//profissional_cod
                dgvOS.CurrentRow.Cells[6].Value.ToString(),//atividade_cod
                dgvOS.CurrentRow.Cells[7].Value.ToString(),//siopi
                dgvOS.CurrentRow.Cells[8].Value.ToString(),//nome_cliente
                dgvOS.CurrentRow.Cells[9].Value.ToString(),//cidade
                dgvOS.CurrentRow.Cells[10].Value.ToString(),//nome_contato
                dgvOS.CurrentRow.Cells[11].Value.ToString(),//telefone_contato
                dgvOS.CurrentRow.Cells[12].Value.ToString(),//status
                dgvOS.CurrentRow.Cells[13].Value.ToString(),//data_pendente
                dgvOS.CurrentRow.Cells[14].Value.ToString(),//data_vistoria
                dgvOS.CurrentRow.Cells[15].Value.ToString(),//data_concluida
                dgvOS.CurrentRow.Cells[16].Value.ToString(),//obs
                dgvOS.CurrentRow.Cells[17].Value.ToString()//fatura_cod   
            );
            form.Text = "Alterar";
            form.ShowDialog();
            ListarOS();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS form = new frmAddOS();
            form.Text = "Adicionar";
            form.ShowDialog();
            ListarOS();
        }


        private void cboFaturadas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListarOS();
        }

        private void dgvOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}