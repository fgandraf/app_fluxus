using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arqueng.Formularios;
using Arqueng.Entidades;
using MySql.Data.MySqlClient;

namespace Arqueng
{
    public partial class frmOS : Form
    {
        public frmOS()
        {
            InitializeComponent();
        }

        public void AtualizarDGOS()
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.da = new MySqlDataAdapter("SELECT * FROM tb_os order by data_ordem", My.conexaoDB);
                DataTable dt = new DataTable();
                My.da.Fill(dt);
                dgvOS.DataSource = dt;
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
            }
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            AtualizarDGOS();
            txtPesquisar.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS form = new frmAddOS();
            form.Text = "Adicionar";
            form.ShowDialog();
            AtualizarDGOS();
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
        dgvOS.CurrentRow.Cells[14].Value.ToString()
        ) ;
            form.Text = "Alterar";
            form.ShowDialog();
            AtualizarDGOS();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    My.conexaoDB = new MySqlConnection(My.dadosdb);
                    My.comando = new MySqlCommand("DELETE FROM tb_os WHERE referencia = @referencia", My.conexaoDB);
                    My.comando.Parameters.AddWithValue("@referencia", dgvOS.CurrentRow.Cells[0].Value.ToString());
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
                AtualizarDGOS();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}