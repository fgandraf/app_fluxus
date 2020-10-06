using System;
using System.Windows.Forms;
using Fluxus.Model.ENT;
using System.Text.RegularExpressions;
using System.Data;
using Fluxus.Model;

namespace Fluxus.View
{
    public partial class frmAddProfissional : Form
    {
        frmPrincipal _frmPrincipal;
        
        private string _nomeId;
        private long _id;
        private string _usr_nome;





        //:EVENTS
        ///_______Form
        public frmAddProfissional(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddProfissional(frmPrincipal frm1, ProfissionalENT dado)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            _id = dado.Id;
            txtCodigo.Text = dado.Codigo;
            txtNome.Text = dado.Nome;
            _nomeId = dado.Nomeid;
            txtCPF.Text = dado.Cpf;
            txtNascimento.Text = (Convert.ToDateTime(dado.Nascimento)).ToString("dd/MM/yyyy");
            txtProfissao.Text = dado.Profissao;
            txtCarteira.Text = dado.Carteira;
            cboEntidade.Text = dado.Entidade;
            txtTelefone1.Text = dado.Telefone1;
            txtTelefone2.Text = dado.Telefone2;
            txtEmail.Text = dado.Email;
            chkRT.Checked = dado.Rt;
            chkRL.Checked = dado.Rl;
            chkUsrAtivo.Checked = dado.Usr_ativo;
            _usr_nome = dado.Usr_nome;
            txtUsrNome.Text = dado.Usr_nome;
            txtUsrSenha.Text = dado.Usr_senha;
            txtUsrSenha2.Text = dado.Usr_senha;

            if (Logged.Codpro == txtCodigo.Text && chkRL.Checked)
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
                txtUsrNome.Text = "";
            }


            
            
            if (txtUsrNome.Text != _usr_nome)
            {
                DataTable dtPro = new ProfissionalModel().BuscarUsuario(txtUsrNome.Text);

                if (dtPro.Rows.Count > 0)
                {
                    MessageBox.Show("Nome de usuário já existente", "Nome de usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsrNome.Focus();
                    return;
                }
            }

            

            //CRIAÇÃO DO NOME ID
            if (txtProfissao.Text != "")
                _nomeId = txtProfissao.Text.Substring(0, 3) + ". ";
            string[] nomecomp = txtNome.Text.Split(' ');
            _nomeId = _nomeId + nomecomp[0] + " " + nomecomp[nomecomp.Length - 1];

            //POPULATE
            ProfissionalENT dado = new ProfissionalENT();
            dado.Codigo = txtCodigo.Text;
            dado.Nomeid = _nomeId;
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
            
            if (Logged.Codpro == txtCodigo.Text)
            {
                Logged.Rt = chkRT.Checked;
                Logged.Rl = chkRL.Checked;
            }

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new ProfissionalModel().Insert(dado);
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
                    new ProfissionalModel().Update(_id, dado);
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
