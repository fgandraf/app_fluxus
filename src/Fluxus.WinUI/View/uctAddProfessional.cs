using Fluxus.Domain.Models;
using Fluxus.App.Services;
using Fluxus.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI.View
{
    public partial class uctAddProfessional : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly int _professionalId;
        private readonly int _userId;
        private EMethod _method;
        private IServiceProvider _serviceProvider;
        private UserService _userService;
        private ProfessionalService _professionalService;

        public uctAddProfessional(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetService<UserService>();
            _professionalService = _serviceProvider.GetService<ProfessionalService>();

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EMethod.Insert;
        }

        public uctAddProfessional(frmMain frm1, Professional professional, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetService<UserService>();
            _professionalService = _serviceProvider.GetService<ProfessionalService>();

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
            txtTelefone1.Text = professional.Phone1;
            txtTelefone2.Text = professional.Phone2;
            txtEmail.Text = professional.Email;

            _userId = Logged.Id;
            chkRT.Checked = Logged.Rt;
            chkRL.Checked = Logged.Rl;
            chkUsrAtivo.Checked = Logged.Usr_ativo;
            txtUsrNome.Text = Logged.Usr_nome;
            txtUsrSenha.Text = Logged.UsrPassword;
            txtUsrSenha2.Text = Logged.UsrPassword;
            
        }

        private void frmAddProfissional_Load(object sender, EventArgs e)
        {
            if (_method == EMethod.Update)
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
            var professional = PopulateProfessional();
            var user = PopulateUser();

            dynamic result = _method == EMethod.Insert ? _professionalService.Insert(professional, user) : _professionalService.Update(professional, user);

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
                cpf: txtCPF.Text,
                birthday: dtpBirthday.Value,
                profession: txtProfissao.Text,
                permitNumber: txtCarteira.Text,
                association: cboEntidade.Text,
                phone1: txtTelefone1.Text,
                phone2: txtTelefone2.Text,
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
                userActive: chkUsrAtivo.Checked,
                userName: txtUsrNome.Text,
                userPassword: txtUsrSenha.Text,
                userPasswordConfirmation: txtUsrSenha2.Text
            ) ;
            return user;
        }

    }

}
