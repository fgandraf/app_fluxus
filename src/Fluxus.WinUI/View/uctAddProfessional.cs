using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using Fluxus.App.Application;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Enums;

namespace Fluxus.WinUI.View
{
    public partial class uctAddProfessional : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly int _id;
        private readonly string _nameId;
        private EnumMethod _method;
        private IProfessionalRepository _professionalRepository;

        public uctAddProfessional(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _professionalRepository = new ProfessionalRepository();
            _method = EnumMethod.Insert;
        }

        public uctAddProfessional(frmMain frm1, Professional professional)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _professionalRepository = new ProfessionalRepository();
            _method = EnumMethod.Update;

            _id = professional.Id;
            _nameId = professional.Nameid;
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
            if (_method == EnumMethod.Update)
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
                txtUsrNome.Enabled = false;
                txtNome.Focus();
            }
            else
                txtCodigo.Focus();

            if (Logged.ProfessionalTag == txtCodigo.Text && chkRL.Checked)
                chkRL.Enabled = false;
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            var service = new ProfessionalService(_professionalRepository);
            service.Professional = PopulateObject();

            var success = service.Execute(_method);

            if (success > 0)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(service.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Professional profesional = new Professional(
                id: _id,
                tag: txtCodigo.Text,
                nameid: _nameId,
                name: txtNome.Text,
                cpf: txtCPF.Text,
                birthday: dtpBirthday.Value,
                profession: txtProfissao.Text,
                permitNumber: txtCarteira.Text,
                association: cboEntidade.Text,
                phone1: txtTelefone1.Text,
                phone2: txtTelefone2.Text,
                email: txtEmail.Text,
                technicianResponsible: chkRT.Checked,
                legalResponsible: chkRL.Checked,
                userActive: chkUsrAtivo.Checked,
                userName: txtUsrNome.Text,
                userPassword: txtUsrSenha.Text,
                userPasswordConfirmation: txtUsrSenha2.Text
            );
            return profesional;
        }

    }

}
