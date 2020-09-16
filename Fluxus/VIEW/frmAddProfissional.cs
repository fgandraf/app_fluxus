using System;
using System.Windows.Forms;
using Fluxus.MODEL;
using Fluxus.ENTIDADES;
using System.Text.RegularExpressions;
using System.Data;

namespace Fluxus.VIEW
{
    public partial class frmAddProfissional : Form
    {
        frmPrincipal _frmPrincipal;
        ProfissionaisENT dado = new ProfissionaisENT();
        private string NomeId = null;



        //:METHODS





        //:EVENTS
        ///_______Form
        public frmAddProfissional(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddProfissional(frmPrincipal frm1, string codigo, string nome, string nomeid, string cpf, string nascimento, string profissao, string carteira, string entidade, string telefone1, string telefone2, string email, bool rt, bool rl, bool usrativo, string usrnome, string usrsenha)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            NomeId = nomeid;
            txtCPF.Text = cpf;
            txtNascimento.Text = (Convert.ToDateTime(nascimento)).ToString("dd/MM/yyyy");
            txtProfissao.Text = profissao;
            txtCarteira.Text = carteira;
            cboEntidade.Text = entidade;
            txtTelefone1.Text = telefone1;
            txtTelefone2.Text = telefone2;
            txtEmail.Text = email;
            chkRT.Checked = rt;
            chkRL.Checked = rl;
            chkUsrAtivo.Checked = usrativo;
            txtUsrNome.Text = usrnome;
            txtUsrSenha.Text = usrsenha;
            txtUsrSenha2.Text = usrsenha;

            if (Globais.Codpro == txtCodigo.Text && chkRL.Checked)
                chkRL.Enabled = false;
        }

        private void frmAddProfissional_Load(object sender, EventArgs e)
        {


            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
                txtNome.Focus();
            }
            else
                txtCodigo.Focus();
        }





        ///_______Button
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkUsrAtivo.Checked == true)
            {
                if (txtUsrNome.Text == "" || txtUsrSenha.Text == "" || txtUsrSenha2.Text == "")
                {
                    MessageBox.Show("Nome de usuário e/ou senha inválidos", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtUsrSenha.Text != txtUsrSenha2.Text)
                {
                    MessageBox.Show("Senhas não correspondem", "Senha do usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                txtUsrSenha.Text = "";
                txtUsrSenha2.Text = "";
            }

            ProfissionaisMODEL model = new ProfissionaisMODEL();
            DataTable dtPro = model.BuscarUsuarioMODEL(txtUsrNome.Text);

            if (dtPro.Rows.Count > 0)
            {
                MessageBox.Show("Nome de usuário já existente", "Nome de usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsrNome.Focus();
                return;
            }

            //CRIAÇÃO DO NOME ID
            if (txtProfissao.Text != "")
                NomeId = txtProfissao.Text.Substring(0, 3) + ". ";
            string[] nomecomp = txtNome.Text.Split(' ');
            NomeId = NomeId + nomecomp[0] + " " + nomecomp[nomecomp.Length - 1];

            //POPULATE
            dado.Codigo = txtCodigo.Text;
            dado.Nomeid = NomeId;
            dado.Nome = txtNome.Text;
            dado.Cpf = txtCPF.Text;
            if (txtNascimento.Text != "")
                dado.Nascimento = Convert.ToDateTime(txtNascimento.Text);
            dado.Profissao = txtProfissao.Text;
            dado.Carteira = txtCarteira.Text;
            dado.Entidade = cboEntidade.Text;
            dado.Telefone1 = txtTelefone1.Text;
            dado.Telefone2 = txtTelefone2.Text;
            dado.Email = txtEmail.Text;
            dado.Rt = chkRT.Checked;
            dado.Rl = chkRL.Checked;
            dado.Usr_ativo = chkUsrAtivo.Checked;
            dado.Usr_nome = txtUsrNome.Text;
            dado.Usr_senha = txtUsrSenha.Text;
            
            if (Globais.Codpro == txtCodigo.Text)
            {
                Globais.Rt = chkRT.Checked;
                Globais.Rl = chkRL.Checked;
            }

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    model.InsertProfissionalMODEL(dado);
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
                    model.UpdateProfissionalMODEL(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
            frmProfissionais formFilho = new frmProfissionais(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProfissionais formfilho = new frmProfissionais(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formfilho, _frmPrincipal.pnlMain);
        }




        ///_______MaskedTextBox
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
            else if (apenasDigitos.Replace(txtTelefone1.Text, "").Length == 11)
                txtTelefone1.Mask = "(99) ##########";

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
            else if (apenasDigitos.Replace(txtTelefone2.Text, "").Length == 11)
                txtTelefone2.Mask = "(99) ##########";
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





        ///_______PictureBox
        private void imgShowPwd_Click(object sender, EventArgs e)
        {
            txtUsrSenha.PasswordChar = '\0';
            imgShowPwd.Hide();
        }

        private void imgHidePwd_Click(object sender, EventArgs e)
        {
            txtUsrSenha.PasswordChar = '*';
            imgShowPwd.Show();
        }
   
    
    
    }



}
