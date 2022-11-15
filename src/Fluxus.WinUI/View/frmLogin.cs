using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Fluxus.Services;
using Fluxus.Domain.Entities;


namespace Fluxus.WinUI.View
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        //:EVENTS
        ///_______Form
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "v. " + Logged.Versao;
        }





        ///_______Button
        private void btnAppFechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lblLoad.Text = "Validando usuário";


            DataTable dtUsuario = new ProfissionalService().GetUser(txtUsuario.Text);

            DataRow[] dataRow;

            if (dtUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLoad.Text = "";
                return;
            }
            else
            {
                dataRow = dtUsuario.Select();
                if (dataRow[0]["usr_senha"].ToString() != txtSenha.Text || Convert.ToBoolean(dataRow[0]["usr_ativo"]) == false)
                {
                    MessageBox.Show("Senha incorreta ou usuário não está ativo", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblLoad.Text = "";
                    return;
                }
            }
            Logged.Usr_nome = dataRow[0]["usr_nome"].ToString();
            Logged.Codpro = dataRow[0]["codigo"].ToString();
            Logged.Rt = Convert.ToBoolean(dataRow[0]["rt"]);
            Logged.Rl = Convert.ToBoolean(dataRow[0]["rl"]);


            lblLoad.Text = "";
            this.Close();
        }





        ///_______TextBox
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEntrar.PerformClick();
        }





        ///_______PictureBox
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



    }



}
