using Fluxus.App.Services;
using Fluxus.Domain.Entities;
using Fluxus.Infra.Records;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;

namespace Fluxus.WinUI.View
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private IServiceProvider _serviceProvider;
        private UserService _userService;

        public frmLogin(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _userService = _serviceProvider.GetService<UserService>();
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnAppFechar_Click(object sender, EventArgs e)
            => Environment.Exit(0);


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var result = _userService.GetByUsername(txtUsuario.Text);

            if (result != null)
            {
                if (string.IsNullOrEmpty(((User)result.Value).UserName.ToString()))
                {
                    MessageBox.Show("Usuário não encontrado", "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (((User)result.Value).UserPassword.ToString() != txtSenha.Text)
                {
                    MessageBox.Show("Senha incorreta", "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            User user = result.Value;

            Logged.Usr_nome = user.UserName;
            Logged.ProfessionalId = user.Id;
            Logged.Rt = user.TechnicianResponsible;
            Logged.Rl = user.LegalResponsible;
            Logged.ProfessionalTag = "A01"; //TO DO: REFATORAR

            this.DialogResult = DialogResult.OK;
        }

        private void imgShowPwd_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            imgShowPwd.Hide();
        }

        private void imgHidePwd_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            imgShowPwd.Show();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }

}
