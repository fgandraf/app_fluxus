using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Arqueng.Globais;
using MySql.Data.MySqlClient;

namespace Arqueng.Formularios
{
    public partial class frmAddAgencia : Form
    {
        public frmAddAgencia()
        {
            InitializeComponent();
        }


        public frmAddAgencia (string Agencia, string Nome, string Endereco, string Complemento, string Bairro, string Cidade, string CEP, string UF, string Contato, string Telefone1, string Telefone2, string Email)
        {
            InitializeComponent();
            txtAgencia.Text = Agencia;
            txtNome.Text = Nome;
            txtEndereco.Text = Endereco;
            txtComplemento.Text = Complemento;
            txtBairro.Text = Bairro;
            txtCidade.Text = Cidade;
            txtCEP.Text = CEP;
            cboUF.Text = UF;
            txtContato.Text = Contato;
            txtTelefone1.Text = Telefone1;
            txtTelefone2.Text = Telefone2;
            txtEmail.Text = Email;
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (btnAddSave.Text == "&Adicionar")
            {
                if (txtAgencia.Text == "")
                    MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        My.conexaoDB = new MySqlConnection(My.dadosdb);
                        My.comando = new MySqlCommand("INSERT INTO  tb_agencias(agencia, nome, endereco, complemento, bairro, cidade, CEP, UF, contato, telefone1, telefone2, email) VALUES (@agencia, @nome, @endereco, @complemento, @bairro, @cidade, @CEP, @UF, @contato, @telefone1, @telefone2, @email)", My.conexaoDB);
                        My.comando.Parameters.AddWithValue("@agencia", txtAgencia.Text);
                        My.comando.Parameters.AddWithValue("@nome", txtNome.Text);
                        My.comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        My.comando.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        My.comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        My.comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        My.comando.Parameters.AddWithValue("@CEP", txtCEP.Text);
                        My.comando.Parameters.AddWithValue("@UF", cboUF.Text);
                        My.comando.Parameters.AddWithValue("@contato", txtContato.Text);
                        My.comando.Parameters.AddWithValue("@telefone1", txtTelefone1.Text);
                        My.comando.Parameters.AddWithValue("@telefone2", txtTelefone2.Text);
                        My.comando.Parameters.AddWithValue("@email", txtEmail.Text);
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
                        this.Close();
                    }
                    
                }
            }
            else
            {
                try
                {
                    My.conexaoDB = new MySqlConnection(My.dadosdb);
                    My.comando = new MySqlCommand("UPDATE tb_agencias SET nome = @nome, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, CEP = @CEP, UF = @UF, contato = @contato, telefone1 = @telefone1, telefone2 = @telefone2, email = @email WHERE agencia = @agencia", My.conexaoDB);
                    My.comando.Parameters.AddWithValue("@agencia", txtAgencia.Text);
                    My.comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    My.comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    My.comando.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    My.comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    My.comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    My.comando.Parameters.AddWithValue("@CEP", txtCEP.Text);
                    My.comando.Parameters.AddWithValue("@UF", cboUF.Text);
                    My.comando.Parameters.AddWithValue("@contato", txtContato.Text);
                    My.comando.Parameters.AddWithValue("@telefone1", txtTelefone1.Text);
                    My.comando.Parameters.AddWithValue("@telefone2", txtTelefone2.Text);
                    My.comando.Parameters.AddWithValue("@email", txtEmail.Text);

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
                    this.Close();
                }
            }
        }


        private void frmAddAgencia_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtAgencia.Enabled = false;
            }
        }

        private void frmAddAgencia_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frmAddAgencia_Leave(object sender, EventArgs e)
        {
          
        }
    }
}
