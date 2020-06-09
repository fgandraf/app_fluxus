using System;
using System.Windows.Forms;
using Arqueng.Formularios;
using Arqueng.Model;

namespace Arqueng
{


    public partial class frmProfissionais : Form
    {

        Profissionais_Model model = new Profissionais_Model();
        public void ListarProfissionais()
        {
            try
            {
                dgvProfissionais.DataSource = model.ListarProfissionaisModel();
                if (dgvProfissionais.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvProfissionais.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvProfissionais.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmProfissionais()
        {
            InitializeComponent();
        }

        private void frmProfissionais_Load(object sender, EventArgs e)
        {
            ListarProfissionais();
            txtPesquisar.Focus();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENT.Profissionais_ENT dado = new ENT.Profissionais_ENT();
                    dado.Codigo = dgvProfissionais.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteProfissionalModel(dado);
                    ListarProfissionais();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddProfissional form = new frmAddProfissional
                (
                dgvProfissionais.CurrentRow.Cells[0].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[1].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[2].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[3].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[4].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[5].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[6].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[7].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[8].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[9].Value.ToString()
                );
            form.Text = "Alterar";
            form.ShowDialog();
            ListarProfissionais();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddProfissional form = new frmAddProfissional();
            form.Text = "Adicionar";
            form.ShowDialog();
            ListarProfissionais();
        }
        
    }
}
