using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{


    public partial class frmAgencias : Form
    {


        AgenciasMODEL model = new AgenciasMODEL();


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
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public frmAgencias()
        {
            InitializeComponent();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    AgenciasENT dado = new AgenciasENT();
                    dado.Agencia = dgvAgencias.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteAgenciaModel(dado);
                    ListarAgencias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
