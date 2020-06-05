using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Arqueng.Entidades;
using System.Linq;
//using MySqlX.XDevAPI.Relational;

namespace Arqueng
{
    public partial class frmAtividades : Form
    {


        public void  AtualizarDGAtividades()
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.da = new MySqlDataAdapter("SELECT * FROM tb_atividades order by codigo", My.conexaoDB);
                DataTable dt = new DataTable();
                My.da.Fill(dt);
                dgvAtividades.DataSource = dt;
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
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
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
                    My.conexaoDB = new MySqlConnection(My.dadosdb);
                    My.comando = new MySqlCommand("DELETE FROM tb_atividades WHERE codigo = @codigo", My.conexaoDB);
                    My.comando.Parameters.AddWithValue("@codigo", dgvAtividades.CurrentRow.Cells[0].Value.ToString());
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
                AtualizarDGAtividades();
            }

        }


        private void frmAtividades_Load(object sender, EventArgs e)
        {
            AtualizarDGAtividades();
            txtPesquisar.Focus();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddAtividade form = new frmAddAtividade(dgvAtividades.CurrentRow.Cells[0].Value.ToString(), dgvAtividades.CurrentRow.Cells[1].Value.ToString(), dgvAtividades.CurrentRow.Cells[2].Value.ToString(), dgvAtividades.CurrentRow.Cells[3].Value.ToString());
            form.Text = "Alterar";
            form.ShowDialog();
            AtualizarDGAtividades();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
             frmAddAtividade form = new frmAddAtividade();
             form.Text = "Adicionar";
             form.ShowDialog();
             AtualizarDGAtividades();
        }
    }
}
