using System;
using System.Windows.Forms;
using Arqueng.Model;

namespace Arqueng
{
    public partial class frmAtividades : Form
    {
        Atividades_Model model = new Atividades_Model();
        public void ListarAtividades()
        {
            try
            {
                dgvAtividades.DataSource = model.ListarAtividadesModel();
                if (dgvAtividades.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvAtividades.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvAtividades.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmAtividades()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENT.Atividades_ENT dado = new ENT.Atividades_ENT();
                    dado.Codigo = dgvAtividades.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteAtividadeModel(dado);
                    ListarAtividades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void frmAtividades_Load(object sender, EventArgs e)
        {
            ListarAtividades();
            txtPesquisar.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddAtividade form = new frmAddAtividade(dgvAtividades.CurrentRow.Cells[0].Value.ToString(), dgvAtividades.CurrentRow.Cells[1].Value.ToString(), dgvAtividades.CurrentRow.Cells[2].Value.ToString(), dgvAtividades.CurrentRow.Cells[3].Value.ToString());
            form.Text = "Alterar";
            form.ShowDialog();
            ListarAtividades();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
             frmAddAtividade form = new frmAddAtividade();
             form.Text = "Adicionar";
             form.ShowDialog();
             ListarAtividades();
        }
    }
}
