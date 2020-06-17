using System;
using System.Windows.Forms;
using Arqueng.MODEL;

namespace Arqueng.VIEW
{

    public partial class frmOSLista : Form
    {

        OsMODEL model = new OsMODEL();


        public void ListarOS()
        {
            try
            {
                //if (cboFaturadas.Text == "Não faturadas")
                //    dgvOS.DataSource = model.ListarOsNaoFatModel();

                //if (cboFaturadas.Text == "Faturadas")
                //    dgvOS.DataSource = model.ListarOsFatModel();

                //if (cboFaturadas.Text == "Todas")
                    dgvOS.DataSource = model.ListarOsModel();
                
                
                
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
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Referencia = dgvOS.CurrentRow.Cells[0].Value.ToString();
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
                dgvOS.CurrentRow.Cells[0].Value.ToString(),
                dgvOS.CurrentRow.Cells[1].Value.ToString(),
                dgvOS.CurrentRow.Cells[2].Value.ToString(),
                dgvOS.CurrentRow.Cells[3].Value.ToString(),
                dgvOS.CurrentRow.Cells[4].Value.ToString(),
                dgvOS.CurrentRow.Cells[5].Value.ToString(),
                dgvOS.CurrentRow.Cells[6].Value.ToString(),
                dgvOS.CurrentRow.Cells[7].Value.ToString(),
                dgvOS.CurrentRow.Cells[8].Value.ToString(),
                dgvOS.CurrentRow.Cells[9].Value.ToString(),
                dgvOS.CurrentRow.Cells[10].Value.ToString(),
                dgvOS.CurrentRow.Cells[11].Value.ToString(),
                dgvOS.CurrentRow.Cells[12].Value.ToString(),
                dgvOS.CurrentRow.Cells[13].Value.ToString(),
                dgvOS.CurrentRow.Cells[14].Value.ToString(),
                dgvOS.CurrentRow.Cells[15].Value.ToString(),
                dgvOS.CurrentRow.Cells[16].Value.ToString()
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

 
    }
}