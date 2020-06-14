using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{
    public partial class frmAddAgencia : Form
    {

        AgenciasMODEL model = new AgenciasMODEL();
        AgenciasENT dado = new AgenciasENT();

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
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //POPULATE
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

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    model.InsertAgenciaModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    model.UpdateAgenciaModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }


    }
}
