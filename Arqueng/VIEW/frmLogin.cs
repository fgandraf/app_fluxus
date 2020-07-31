using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Arqueng.ENTIDADES;
using Arqueng.MODEL;

namespace Arqueng.VIEW
{
    public partial class frmLogin : Form
    {

        ProfissionaisMODEL model = new ProfissionaisMODEL();
        ProfissionaisENT dado = new ProfissionaisENT();



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAppFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            dado.Usr_nome = txtUsuario.Text;
            model.BuscarUsuarioModel(dado);



            if (Globais.Usr_nome == null || txtSenha.Text != Globais.Usr_senha || Globais.Usr_ativo == false)
                MessageBox.Show("Nome de usuário/senha incorreto(s) ou usuário não está ativo");
            else
                this.Close();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEntrar.PerformClick();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblVersao.Text = Globais.Versao;
        }
    }
}
