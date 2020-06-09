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
    public partial class frmAddProfissional : Form
    {

        public frmAddProfissional()
        {
            InitializeComponent();
        }


        public frmAddProfissional(string Codigo, string Nome, string CPF, string Nascimento, string Profissao, string Carteira, string Entidade, string Telefone1, string Telefone2, string Email)
        {
            InitializeComponent();
            txtCodigo.Text = Codigo;
            txtNome.Text = Nome;
            txtCPF.Text = CPF;
            dtpNascimento.Text = Nascimento;
            txtProfissao.Text = Profissao;
            txtCarteira.Text = Carteira;
            txtEntidade.Text = Entidade;
            txtTelefone1.Text = Telefone1;
            txtTelefone2.Text = Telefone2;
            txtEmail.Text = Email;
        }


        private void frmAddProfissional_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
            } 
        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
                if (btnAddSave.Text == "&Adicionar")
                {
                    if (txtCodigo.Text == "")
                    MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    {
                        try
                        {
                            My.conexaoDB = new MySqlConnection(My.dadosdb);
                            My.comando = new MySqlCommand("INSERT INTO tb_profissionais(codigo, nome, cpf, nascimento, profissao, carteira, entidade, telefone1, telefone2, email) VALUES (@codigo, @nome, @cpf, @nascimento, @profissao, @carteira, @entidade, @telefone1, @telefone2, @email)", My.conexaoDB);
                            
                            My.comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            My.comando.Parameters.AddWithValue("@nome", txtNome.Text);
                            My.comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
                            My.comando.Parameters.AddWithValue("@nascimento", dtpNascimento.Value);
                            My.comando.Parameters.AddWithValue("@profissao", txtProfissao.Text);
                            My.comando.Parameters.AddWithValue("@carteira", txtCarteira.Text);
                            My.comando.Parameters.AddWithValue("@entidade", txtEntidade.Text);
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
                        My.comando = new MySqlCommand("UPDATE tb_profissionais SET nome = @nome, cpf = @cpf, nascimento = @nascimento, profissao = @profissao, carteira = @carteira, entidade = @entidade, telefone1 = @telefone1, telefone2 = @telefone2, email = @email WHERE codigo = @codigo", My.conexaoDB);
                       
                        My.comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        My.comando.Parameters.AddWithValue("@nome", txtNome.Text);
                        My.comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
                        My.comando.Parameters.AddWithValue("@nascimento", dtpNascimento.Value);
                        My.comando.Parameters.AddWithValue("@profissao", txtProfissao.Text);
                        My.comando.Parameters.AddWithValue("@carteira", txtCarteira.Text);
                        My.comando.Parameters.AddWithValue("@entidade", txtEntidade.Text);
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
    }
}
