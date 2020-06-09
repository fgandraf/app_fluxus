using System;
using System.Windows.Forms;
using Arqueng.Model;

namespace Arqueng.Formularios
{
    public partial class frmAddAgencia : Form
    {

        Agencias_Model model = new Agencias_Model();


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

        private void frmAddAgencia_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtAgencia.Enabled = false;
            }
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
                        ENT.Agencias_ENT dado = new ENT.Agencias_ENT();
                        dado.Agencia = txtAgencia.Text;
                        dado.Nome = txtNome.Text;
                        dado.Endereco = txtEndereco.Text;
                        dado.Complemento = txtComplemento.Text;
                        dado.Bairro = txtBairro.Text;
                        dado.Cidade = txtCidade.Text;
                        dado.CEP = txtCEP.Text;
                        dado.UF = cboUF.Text;
                        dado.Contato = txtContato.Text;
                        dado.Telefone1 = txtTelefone1.Text;
                        dado.Telefone2 = txtTelefone2.Text;
                        dado.Email = txtEmail.Text;
                        model.InsertAgenciaModel(dado);
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
                    ENT.Agencias_ENT dado = new ENT.Agencias_ENT();
                    dado.Agencia = txtAgencia.Text;
                    dado.Nome = txtNome.Text;
                    dado.Endereco = txtEndereco.Text;
                    dado.Complemento = txtComplemento.Text;
                    dado.Bairro = txtBairro.Text;
                    dado.Cidade = txtCidade.Text;
                    dado.CEP = txtCEP.Text;
                    dado.UF = cboUF.Text;
                    dado.Contato = txtContato.Text;
                    dado.Telefone1 = txtTelefone1.Text;
                    dado.Telefone2 = txtTelefone2.Text;
                    dado.Email = txtEmail.Text;
                    model.UpdateAgenciaModel(dado);
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
