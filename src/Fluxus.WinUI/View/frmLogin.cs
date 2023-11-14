using Fluxus.App;
using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Runtime.InteropServices;

namespace Fluxus.WinUI.View
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        public frmLogin()
            => InitializeComponent();

        private void btnAppFechar_Click(object sender, EventArgs e)
            => Environment.Exit(0);

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var user = new ProfessionalRepository().GetUser(txtUsuario.Text);

            if (string.IsNullOrEmpty(user.UserName.ToString()))
            {
                MessageBox.Show("Usuário não encontrado", "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            if (user.UserPassword.ToString() != txtSenha.Text)
            {
                MessageBox.Show("Senha incorreta", "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Logged.Usr_nome = user.UserName;
            Logged.ProfessionalId = user.Id;
            Logged.Rt = user.TechnicianResponsible;
            Logged.Rl = user.LegalResponsible;
            Logged.ProfessionalTag = user.Tag;

            this.DialogResult = DialogResult.OK;
            this.Close();

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
