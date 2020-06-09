using System;
using System.Windows.Forms;
using Arqueng.Formularios;
using Arqueng.Model;

namespace Arqueng
{
    public partial class frmAgencias : Form
    {
        Agencias_Model model = new Agencias_Model();
        public void ListarAgencias()
        {
            try
            {
                dgvAgencias.DataSource = model.ListarAgenciasModel();
                if (dgvAgencias.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvAgencias.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvAgencias.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmAgencias()
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
                    ENT.Agencias_ENT dado = new ENT.Agencias_ENT();
                    dado.Agencia = dgvAgencias.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteAgenciaModel(dado);
                    ListarAgencias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmAgencias_Load(object sender, EventArgs e)
        {
            ListarAgencias();
            txtPesquisar.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddAgencia form = new frmAddAgencia
                (dgvAgencias.CurrentRow.Cells[0].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[1].Value.ToString(),        
                dgvAgencias.CurrentRow.Cells[2].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[3].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[4].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[5].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[6].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[7].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[8].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[9].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[10].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[11].Value.ToString()
                );
            form.Text = "Alterar";
            form.ShowDialog();
            ListarAgencias();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddAgencia form = new frmAddAgencia();
            form.Text = "Adicionar";
            form.ShowDialog();
            ListarAgencias();
        }


    }
}
