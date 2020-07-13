using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Text.RegularExpressions;

namespace Arqueng.VIEW
{


    public partial class frmAddProfissional : Form
    {

        frmPrincipal _frmPrincipal;
        ProfissionaisMODEL model = new ProfissionaisMODEL();
        ProfissionaisENT dado = new ProfissionaisENT();


        public frmAddProfissional(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        public frmAddProfissional(frmPrincipal frm1, string Codigo, string Nome, string CPF, string Nascimento, string Profissao, string Carteira, string Entidade, string Telefone1, string Telefone2, string Email)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            txtCodigo.Text = Codigo;
            txtNome.Text = Nome;
            txtCPF.Text = CPF;
            txtNascimento.Text = (Convert.ToDateTime(Nascimento)).ToString("dd/MM/yyyy");
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
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //POPULATE
            dado.Codigo = txtCodigo.Text;
            dado.Nome = txtNome.Text;
            dado.Cpf = txtCPF.Text;
            if (txtNascimento.Text != "")
            dado.Nascimento = Convert.ToDateTime(txtNascimento.Text);
            dado.Profissao = txtProfissao.Text;
            dado.Carteira = txtCarteira.Text;
            dado.Entidade = txtEntidade.Text;
            dado.Telefone1 = txtTelefone1.Text;
            dado.Telefone2 = txtTelefone2.Text;
            dado.Email = txtEmail.Text;

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    model.InsertProfissionalModel(dado);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicata du champ"))
                    {
                        MessageBox.Show($"Profissional com o código '{txtCodigo.Text}' já cadastrado!", "Código existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    model.UpdateProfissionalModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
            frmProfissionais formfilho = new frmProfissionais(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formfilho, _frmPrincipal.pnlMain);
        }


        private void txtTelefone1_Enter(object sender, EventArgs e)
        {
           txtTelefone1.Mask = "(99) ##########";
        }

        private void txtTelefone1_Validated(object sender, EventArgs e)
        {
            if (txtTelefone1.Text == "(  ) ")
            {
                txtTelefone1.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefone1.Text, "").Length == 10)
                txtTelefone1.Mask = "(99) #########";

        }

        private void txtTelefone2_Enter(object sender, EventArgs e)
        {
            txtTelefone2.Mask = "(99) ##########";
        }

        private void txtTelefone2_Validated(object sender, EventArgs e)
        {
            if (txtTelefone2.Text == "(  ) ")
            {
                txtTelefone2.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefone2.Text, "").Length == 10)
                txtTelefone2.Mask = "(99) #########";
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.Mask = "000,000,000-00";
        }

        private void txtCPF_Validated(object sender, EventArgs e)
        {
            if (txtCPF.Text == "   .   .   -")
                txtCPF.Mask = "";
        }

        private void txtNascimento_Validated(object sender, EventArgs e)
        {
            if (txtNascimento.Text == "  /  /")
                txtNascimento.Mask = "";
        }

        private void txtNascimento_Enter(object sender, EventArgs e)
        {
            txtNascimento.Mask = "00/00/0000";
        }

        private void frmAddProfissional_Leave(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProfissionais formfilho = new frmProfissionais(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formfilho, _frmPrincipal.pnlMain);
        }
    }


}
