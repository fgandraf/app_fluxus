using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Arqueng.Entidades;


namespace Arqueng
{
    public partial class frmAddAtividade : Form
    {


        public frmAddAtividade()
        {
            InitializeComponent();
        }


        public frmAddAtividade(string Codigo, string Descricao, string Valor, string Deslocamento)
        {
            InitializeComponent();
            txtCodigo.Text = Codigo;
            txtDescricao.Text = Descricao;
            txtValor.Text = Valor;
            txtDeslocamento.Text = Deslocamento;

        }


        private void frmAddAtividade_Load(object sender, EventArgs e)
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
                        My.comando = new MySqlCommand("INSERT INTO  tb_atividades(codigo, descricao, valor_atividade, valor_deslocamento) VALUES (@codigo, @descricao, @valor_atividade, @valor_deslocamento)", My.conexaoDB);
                        My.comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        My.comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        My.comando.Parameters.AddWithValue("@valor_atividade", txtValor.Text.Replace(',','.'));
                        My.comando.Parameters.AddWithValue("@valor_deslocamento", txtDeslocamento.Text.Replace(',','.'));

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
                    My.comando = new MySqlCommand("UPDATE tb_atividades SET descricao = @descricao, valor_atividade = @valor_atividade, valor_deslocamento = @valor_deslocamento WHERE codigo = @codigo", My.conexaoDB);
                    My.comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    My.comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    My.comando.Parameters.AddWithValue("@valor_atividade", txtValor.Text.Replace(',', '.'));
                    My.comando.Parameters.AddWithValue("@valor_deslocamento", txtDeslocamento.Text.Replace(',', '.'));

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
