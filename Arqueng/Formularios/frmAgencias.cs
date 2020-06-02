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
using MySql.Data.MySqlClient;
using Arqueng.Entidades;

namespace Arqueng
{
    public partial class frmAgencias : Form
    {

        public frmAgencias()
        {
            InitializeComponent();
        }

        

        public void AtualizarDGAgencias()
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.da = new MySqlDataAdapter("SELECT * FROM tb_agencias order by agencia", My.conexaoDB);
                DataTable dt = new DataTable();
                My.da.Fill(dt);
                dgvAgencias.DataSource = dt;
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
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddAgencia form = new frmAddAgencia();
            form.Text = "Adicionar";
            form.ShowDialog();
            AtualizarDGAgencias();



            //Formulário Neto em desenvolvimento

            //frmAddAgencia frm = new frmAddAgencia
            //{
            //    TopLevel = false,
            //    Dock = DockStyle.Fill 
            //};

            //var Principal = this.ParentForm;
            //var pnlContentPrincipal = Controls.Find("pnlMain", true).FirstOrDefault();
            //pnlContentPrincipal.Controls.Clear();
            //pnlContentPrincipal.Refresh();
            //pnlContentPrincipal.Controls.Add(frm);
            ////pnlMain.Visible = true;
            //frm.Show();

            //Principal.Refresh();
            //this.Close();

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddAgencia form = new frmAddAgencia
                (
                dgvAgencias.CurrentRow.Cells[0].Value.ToString(),
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
            AtualizarDGAgencias();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    My.conexaoDB = new MySqlConnection(My.dadosdb);
                    My.comando = new MySqlCommand("DELETE FROM tb_agencias WHERE agencia = @agencia", My.conexaoDB);
                    My.comando.Parameters.AddWithValue("@agencia", dgvAgencias.CurrentRow.Cells[0].Value.ToString());
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
                AtualizarDGAgencias();
            }
        }

        private void frmAgencias_Load(object sender, EventArgs e)
        {
            AtualizarDGAgencias();
            txtPesquisar.Focus();
        }

        private void frmAgencias_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
