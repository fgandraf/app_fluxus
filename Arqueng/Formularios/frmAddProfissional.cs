using System;
using System.Windows.Forms;
using Arqueng.Model;

namespace Arqueng.Formularios
{
    public partial class frmAddProfissional : Form
    {

        Profissionais_Model model = new Profissionais_Model();

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
                            ENT.Profissionais_ENT dado = new ENT.Profissionais_ENT();
                            dado.Codigo = txtCodigo.Text;
                            dado.Nome = txtNome.Text;
                            dado.Cpf = txtCPF.Text;
                            dado.Nascimento = Convert.ToDateTime(dtpNascimento.Value);
                            dado.Profissao = txtProfissao.Text;
                            dado.Carteira = txtCarteira.Text;
                            dado.Entidade = txtEntidade.Text;
                            dado.Telefone1 = txtTelefone1.Text;
                            dado.Telefone2 = txtTelefone2.Text;
                            dado.Email = txtEmail.Text;
                            model.InsertProfissionalModel(dado);
                        }
                        catch (Exception ex)
                        {  
                            MessageBox.Show(ex.Message);
                        }    
                        finally
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    try
                    {
                        ENT.Profissionais_ENT dado = new ENT.Profissionais_ENT();
                        dado.Codigo = txtCodigo.Text;
                        dado.Nome = txtNome.Text;
                        dado.Cpf = txtCPF.Text;
                        dado.Nascimento = Convert.ToDateTime(dtpNascimento.Value);
                        dado.Profissao = txtProfissao.Text;
                        dado.Carteira = txtCarteira.Text;
                        dado.Entidade = txtEntidade.Text;
                        dado.Telefone1 = txtTelefone1.Text;
                        dado.Telefone2 = txtTelefone2.Text;
                        dado.Email = txtEmail.Text;
                        model.UpdateProfissionalModel(dado);
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.Close();
                    }
                } 
        }
    }
}
