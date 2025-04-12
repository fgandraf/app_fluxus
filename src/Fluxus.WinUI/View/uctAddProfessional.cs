using Fluxus.Core.Models;
using Fluxus.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.UseCases;
using System.Text.RegularExpressions;

namespace Fluxus.WinUI.View
{
    public partial class uctAddProfessional : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly long _professionalId;
        private readonly long _userId;
        private readonly string _email;
        private EMethod _method;
        private IServiceProvider _serviceProvider;
        private UserUseCases _userService;
        private ProfessionalUseCases _professionalService;

        public uctAddProfessional(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetService<UserUseCases>();
            _professionalService = _serviceProvider.GetService<ProfessionalUseCases>();

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EMethod.Insert;
        }

        public uctAddProfessional(frmMain frm1, Professional professional, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetService<UserUseCases>();
            _professionalService = _serviceProvider.GetService<ProfessionalUseCases>();

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EMethod.Update;

            _professionalId = professional.Id;
            txtCodigo.Text = professional.Tag;
            txtNome.Text = professional.Name;
            txtCPF.Text = professional.Cpf;
            dtpBirthday.Value = professional.Birthday;
            txtProfissao.Text = professional.Profession;
            txtCarteira.Text = professional.PermitNumber;
            cboEntidade.Text = professional.Association;

            if (professional.Phone1.Length == 11)
            {
                txtTelefone1.Text = string.Format("({0}) {1}-{2}",
                professional.Phone1.Substring(0, 2),
                professional.Phone1.Substring(2, 5),
                professional.Phone1.Substring(7, 4));
            }
            if (professional.Phone1.Length == 10)
            {
                txtTelefone1.Text = string.Format("({0}) {1}-{2}",
                professional.Phone1.Substring(0, 2),
                professional.Phone1.Substring(2, 4),
                professional.Phone1.Substring(6, 4));
            }

            if (professional.Phone2.Length == 11)
            {
                txtTelefone2.Text = string.Format("({0}) {1}-{2}",
                professional.Phone2.Substring(0, 2),
                professional.Phone2.Substring(2, 5),
                professional.Phone2.Substring(7, 4));
            }
            if (professional.Phone2.Length == 10)
            {
                txtTelefone2.Text = string.Format("({0}) {1}-{2}",
                professional.Phone2.Substring(0, 2),
                professional.Phone2.Substring(2, 4),
                professional.Phone2.Substring(6, 4));
            }


            var user = _userService.GetByProfessionalId(professional.Id);

            _email = user.Value.Email;
            _userId = user.Value.Id;
            txtEmail.Text = user.Value.Email;
            chkRL.Checked = user.Value.LegalResponsible;
            chkRT.Checked = user.Value.TechnicianResponsible;
            chkUsrAtivo.Checked = user.Value.Active;
            txtUsrSenha.Text = "0000000000";
            txtUsrSenha2.Text = "0000000000";

            txtEmail.Enabled = Logged.Rl;
            chkRT.Enabled = Logged.Rl;
            chkRL.Enabled = Logged.Rl;
            chkUsrAtivo.Enabled = Logged.Rl;
            txtUsrSenha.Enabled = Logged.Rl;
            txtUsrSenha2.Enabled = Logged.Rl;

        }

        private void frmAddProfissional_Load(object sender, EventArgs e)
        {
            if (_method == EMethod.Update)
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
                txtNome.Focus();
            }
            else
                txtCodigo.Focus();

            if (Logged.ProfessionalTag == txtCodigo.Text && chkRL.Checked)
                chkRL.Enabled = false;
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            var professional = PopulateProfessional();
            var user = PopulateUser();

            var emailUpdated = txtEmail.Text != _email;
            dynamic result = _method == EMethod.Insert ? _professionalService.Insert(professional, user) : _professionalService.Update(professional, user, emailUpdated);

            if (result.Success)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctProfessional formFilho = new uctProfessional(_frmPrincipal,_serviceProvider);
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

        private Professional PopulateProfessional()
        {
            var profesional = new Professional(
                id: _professionalId,
                tag: txtCodigo.Text,
                name: txtNome.Text,
                cpf: Regex.Replace(txtCPF.Text, @"[^\d]", ""),
                birthday: dtpBirthday.Value,
                profession: txtProfissao.Text,
                permitNumber: txtCarteira.Text,
                association: cboEntidade.Text,
                phone1: Regex.Replace(txtTelefone1.Text, @"[^\d]", ""),
                phone2: Regex.Replace(txtTelefone2.Text, @"[^\d]", ""),
                email: txtEmail.Text
            );
            return profesional;
        }

        private User PopulateUser()
        {
            var user = new User(
                id: _userId,
                professionalId: _professionalId,
                technicianResponsible: chkRT.Checked,
                legalResponsible: chkRL.Checked,
                active: chkUsrAtivo.Checked,
                email: txtEmail.Text,
                password: txtUsrSenha.Text,
                passwordConfirmation: txtUsrSenha2.Text
            ) ;
            return user;
        }

    }

}
