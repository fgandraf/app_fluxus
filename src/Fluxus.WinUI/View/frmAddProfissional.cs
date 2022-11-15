using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmAddProfissional : Form
    {


        frmPrincipal _frmPrincipal;
        private long _id;
        private string _usr_nome;





        //:METHODS
        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            box.Mask = Util.MaskValidated(sender);
        }


        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            box.Mask = Util.MaskEnter(sender);
        }


        private string CreateNameId(string profissao, string nome)
        {
            string retorno = "";

            if (profissao != "")
                retorno = profissao.Substring(0, 3) + ". ";

            string[] nomeCompleto = nome.Split(' ');
            retorno += nomeCompleto[0] + " " + nomeCompleto[nomeCompleto.Length - 1];

            return retorno;
        }


        private Profissional PopulateObject()
        {
            Profissional dado = new Profissional
            {
                Id = _id,
                Codigo = txtCodigo.Text,
                Nomeid = CreateNameId(txtProfissao.Text, txtNome.Text),
                Nome = txtNome.Text,
                Cpf = txtCPF.Text,
                Nascimento = Util.ValidateDateString(txtNascimento.Text),
                Profissao = txtProfissao.Text,
                Carteira = txtCarteira.Text,
                Entidade = cboEntidade.Text,
                Telefone1 = txtTelefone1.Text,
                Telefone2 = txtTelefone2.Text,
                Email = txtEmail.Text,
                ResponsavelTecnico = chkRT.Checked,
                ResponsavelLegal = chkRL.Checked,
                Usr_ativo = chkUsrAtivo.Checked,
                UsuarioNome = txtUsrNome.Text,
                UsuarioSenha = txtUsrSenha.Text
            };

            return dado;
        }


        private void Back()
        {
            this.Close();
            frmProfissionais formfilho = new frmProfissionais(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formfilho, _frmPrincipal.pnlMain);
        }





        //:EVENTS
        public frmAddProfissional(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddProfissional(frmPrincipal frm1, Profissional dado)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            _id = dado.Id;
            txtCodigo.Text = dado.Codigo;
            txtNome.Text = dado.Nome;
            txtCPF.Text = dado.Cpf;
            txtNascimento.Text = (Convert.ToDateTime(dado.Nascimento)).ToString("dd/MM/yyyy");
            txtProfissao.Text = dado.Profissao;
            txtCarteira.Text = dado.Carteira;
            cboEntidade.Text = dado.Entidade;
            txtTelefone1.Text = dado.Telefone1;
            txtTelefone2.Text = dado.Telefone2;
            txtEmail.Text = dado.Email;
            chkRT.Checked = dado.ResponsavelTecnico;
            chkRL.Checked = dado.ResponsavelLegal;
            chkUsrAtivo.Checked = dado.Usr_ativo;
            _usr_nome = dado.UsuarioNome;
            txtUsrNome.Text = dado.UsuarioNome;
            txtUsrSenha.Text = dado.UsuarioSenha;
            txtUsrSenha2.Text = dado.UsuarioSenha;
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

            if (Logged.Codpro == txtCodigo.Text && chkRL.Checked)
                chkRL.Enabled = false;
        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {

            //VERIFICA SE CODIGO É NULO
            if (txtCodigo.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //VALIDA CAMPOS DO USUÁRIO
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



            //VERIFICA SE NOME DE USUÁRIO JÁ EXISTE NO SISTEMA
            if (txtUsrNome.Text != _usr_nome)
            {
                DataTable dtPro = new ProfissionalService().GetUser(txtUsrNome.Text);

                if (dtPro.Rows.Count > 0)
                {
                    MessageBox.Show("Nome de usuário já existente", "Nome de usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsrNome.Focus();
                    return;
                }
            }



            //POPULATE
            Profissional dado = PopulateObject();



            //ATUALIZA RT E RL DO USUÁRIO LOGADO
            if (Logged.Codpro == txtCodigo.Text)
            {
                Logged.Rt = chkRT.Checked;
                Logged.Rl = chkRL.Checked;
            }



            //VERIFICA SE OPERAÇÃO É INSERT(POST) OU UPDATE(PUT) E EXECUTA
            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new ProfissionalService().Insert(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    new ProfissionalService().Update(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Back();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }


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
