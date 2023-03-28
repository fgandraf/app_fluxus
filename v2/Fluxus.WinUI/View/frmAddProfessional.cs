using Fluxus.Domain.Entities;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmAddProfessional : Form
    {
        frmMain _frmPrincipal;
        private int _id;
        private string _usr_nome;

        public frmAddProfessional(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddProfessional(frmMain frm1, Professional professional)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            _id = professional.Id;
            txtCodigo.Text = professional.Tag;
            txtNome.Text = professional.Name;
            txtCPF.Text = professional.Cpf;
            dtpBirthday.Value = professional.Birthday;
            txtProfissao.Text = professional.Profession;
            txtCarteira.Text = professional.PermitNumber;
            cboEntidade.Text = professional.Association;
            txtTelefone1.Text = professional.Phone1;
            txtTelefone2.Text = professional.Phone2;
            txtEmail.Text = professional.Email;
            chkRT.Checked = professional.TechnicianResponsible;
            chkRL.Checked = professional.LegalResponsible;
            chkUsrAtivo.Checked = professional.UserActive;
            _usr_nome = professional.UserName;
            txtUsrNome.Text = professional.UserName;
            txtUsrSenha.Text = professional.UserPassword;
            txtUsrSenha2.Text = professional.UserPassword;
        }

        private void frmAddProfissional_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
                txtUsrNome.Enabled = false;
                txtNome.Focus();
            }
            else
                txtCodigo.Focus();

            if (Logged.ProfessionalId == txtCodigo.Text && chkRL.Checked)
                chkRL.Enabled = false;
        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNome.Text == "" || txtUsrNome.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Professional professional = PopulateObject();
            bool isValid = new ProfessionalService().IsValid(txtUsrNome.Text, txtUsrSenha.Text, txtUsrSenha2.Text, _usr_nome);
           
            if (btnAddSave.Text == "&Adicionar")
            {
                if (!isValid)
                {
                    MessageBox.Show("Verifique os campos Nome de Usuário e Senha", "Usuário ou senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                bool userExists = new ProfessionalService().UserExists(txtUsrNome.Text);
                if (userExists)
                {
                    MessageBox.Show("Nome de usuário já existente", "Nome de usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                new ProfessionalService().Insert(professional);
            }
            else
            {
                if (!isValid)
                {
                    MessageBox.Show("Verifique os campos Nome de Usuário e Senha", "Usuário ou senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                new ProfessionalService().Update(professional);
            }

            //ATUALIZA RT E RL DO USUÁRIO LOGADO
            if (Logged.ProfessionalId == txtCodigo.Text)
            {
                Logged.Rt = chkRT.Checked;
                Logged.Rl = chkRL.Checked;
            }

            btnCancelar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            frmProfessional formFilho = new frmProfessional(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho);
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

        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskValidated(sender);

        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskEnter(sender);

        private Professional PopulateObject()
        {
            string nameId = string.Empty;

            if (txtProfissao.Text != "")
                nameId = txtProfissao.Text.Substring(0, 3) + ". ";
            string[] nomeCompleto = txtNome.Text.Split(' ');

            nameId += nomeCompleto[0] + " " + nomeCompleto[nomeCompleto.Length - 1];


            Professional profesional = new Professional
            {
                Id = _id,
                Tag = txtCodigo.Text,
                Nameid = nameId,
                Name = txtNome.Text,
                Cpf = txtCPF.Text,
                Birthday = dtpBirthday.Value,
                Profession = txtProfissao.Text,
                PermitNumber = txtCarteira.Text,
                Association = cboEntidade.Text,
                Phone1 = txtTelefone1.Text,
                Phone2 = txtTelefone2.Text,
                Email = txtEmail.Text,
                TechnicianResponsible = chkRT.Checked,
                LegalResponsible = chkRL.Checked,
                UserActive = chkUsrAtivo.Checked,
                UserName = txtUsrNome.Text,
                UserPassword = txtUsrSenha.Text
            };

            return profesional;
        }

    }

}
