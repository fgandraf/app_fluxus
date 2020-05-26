using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arqueng.Entidades;
using Arqueng.Formularios;
using MySql.Data.MySqlClient;

namespace Arqueng
{
    public partial class frmProfissionais : Form
    {
        public frmProfissionais()
        {
            InitializeComponent();
        }

        public void AtualizarDGProfissionais()
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.da = new MySqlDataAdapter("SELECT * FROM tb_profissionais order by codigo", My.conexaoDB);
                DataTable dt = new DataTable();
                My.da.Fill(dt);
                dgvProfissionais.DataSource = dt;
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
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
            }
        }

        private void frmProfissionais_Load(object sender, EventArgs e)
        {
            AtualizarDGProfissionais();
            txtPesquisar.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddProfissional form = new frmAddProfissional();
            form.Text = "Adicionar";
            form.ShowDialog();
            AtualizarDGProfissionais();
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
            AtualizarDGProfissionais();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    My.conexaoDB = new MySqlConnection(My.dadosdb);
                    My.comando = new MySqlCommand("DELETE FROM tb_profissionais WHERE codigo = @codigo", My.conexaoDB);
                    My.comando.Parameters.AddWithValue("@codigo", dgvProfissionais.CurrentRow.Cells[0].Value.ToString());
                    My.conexaoDB.Open();
                    My.comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    My.conexaoDB.Close();
                    My.conexaoDB = null;
                    My.comando = null;
                }
                AtualizarDGProfissionais();
            }
        }
    }
}
