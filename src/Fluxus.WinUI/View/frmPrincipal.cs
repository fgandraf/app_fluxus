using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Fluxus.Services;
using Fluxus.Domain.Entities;
using System.Threading.Tasks;

namespace Fluxus.WinUI.View
{
    public partial class frmPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        Form _formAtivo;

        


        //:METHODS
        public void AbrirFormInPanel(Form Formfilho, Panel pnl)
        {
            if (pnl.Controls.Count > 0)
                _formAtivo.Close();
            

            Form fh = Formfilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnl.Controls.Clear();
            
            pnl.Controls.Add(fh);
            pnl.Tag = fh;
            
            fh.Show();
            GC.Collect();
        }

        private void OcultaControles()
        {
            pnlCtrlOS.Hide();
            pnlCtrlAgencias.Hide();
            pnlCtrlAtividades.Hide();
            pnlCtrlProfissionais.Hide();
            pnlCtrlDadosCadastrais.Hide();
            pnlCtrlFaturas.Hide();
        }





        //:EVENTS
        ///_______Form
        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Logged.Usr_nome;
            lblVersao.Text = "v. " + Logged.Versao;
            btnOS.PerformClick();


            string fantasia = null;
            await Task.Run(() => fantasia = new CadastraisService().GetFantasia());

            
            if (fantasia != null)
                btnDadosCadastrais.Text = fantasia;
            else
                btnDadosCadastrais.Text = "Dados Cadastrais";




        }





        ///_______Panel
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }





        ///_______Button (Form Controls)
        private void btnAppFechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAppMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAppMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnAppMaximizar.Hide();
            btnAppRestaurar.Show();
        }

        private void btnAppRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnAppMaximizar.Show();
            btnAppRestaurar.Hide();
        }





        ///_______Button (Menu)
        private void btnDadosCadastrais_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlDadosCadastrais.Show();
            lblTitulo.Text = "Dados Cadastrais";

            frmDadosCadastrais frm = new frmDadosCadastrais(this);
            AbrirFormInPanel(frm, pnlMain);
            _formAtivo = frm;
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlOS.Show();

            lblTitulo.Text = "Ordens de Serviços";

            frmOS frm = new frmOS(this);
            AbrirFormInPanel(frm, pnlMain);
            _formAtivo = frm;
        }

        private void btnFaturas_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlFaturas.Show();
            lblTitulo.Text = "Faturas";
            frmFaturas frm = new frmFaturas();
            AbrirFormInPanel(frm, pnlMain);
            _formAtivo = frm;
        }

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlAtividades.Show();
            lblTitulo.Text = "Atividades";

            frmAtividades frm = new frmAtividades(this);
            AbrirFormInPanel(frm, pnlMain);
            _formAtivo = frm;
        }

        private void btnAgencias_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlAgencias.Show();
            lblTitulo.Text = "Agências Demandantes";

            frmAgencias frm = new frmAgencias(this);
            AbrirFormInPanel(frm, pnlMain);
            _formAtivo = frm;
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlProfissionais.Show();
            lblTitulo.Text = "Profissionais";
            
            frmProfissionais frm = new frmProfissionais(this);
            
            AbrirFormInPanel(frm, pnlMain);
            _formAtivo = frm;
        }

    
    
    
    }



}
