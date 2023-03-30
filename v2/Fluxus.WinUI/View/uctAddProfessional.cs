using Fluxus.Domain.Entities;
using Fluxus.App;

namespace Fluxus.WinUI.View
{
    public partial class uctAddProfessional : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly int _id;

        public uctAddProfessional(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public uctAddProfessional(frmMain frm1, Professional professional)
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
            Professional professional = PopulateObject();
            var result = new ProfessionalApp().InsertOrUpdate(professional, txtUsrSenha2.Text, btnAddSave.Text);
            
            MessageBox.Show(result, "Profissionais", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctProfessional formFilho = new uctProfessional(_frmPrincipal);
            _frmPrincipal.OpenUserControl(formFilho);
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
