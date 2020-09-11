using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Arqueng.VIEW;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Data;

namespace Arqueng
{


    public partial class frmPrincipal : Form
    {


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Form FormAtivo = null;





        //:MÉTODOS

        public void AbrirFormInPanel(Form Formfilho, Panel pnl)
        {
            if (pnl.Controls.Count > 0)
                FormAtivo.Close();
            

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









        //:EVENTOS

        ///_______FORMULÁRIO
        
        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Globais.Usr_nome;
            if (Globais.Fantasia != null)
                btnDadosCadastrais.Text = Globais.Fantasia;

            lblVersao.Text = "v. " + Globais.Versao;
            btnOS.PerformClick();
        }







        ///_______PAINEL
        
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }







        ///_______BOTÕES DE CONTROLE

        private void btnAppFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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







        ///_______MENU

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
            {
                pnlMenu.Width = 50;
                ttpMenu.Active = true;
                btnDadosCadastrais.Hide();


                if (pnlCtrlDadosCadastrais.Visible == true)
                    pnlCtrlDadosCadastrais.Width = 20;
            }
            else
            {
                pnlMenu.Width = 200;
                ttpMenu.Active = false;
                btnDadosCadastrais.Show();
                pnlCtrlDadosCadastrais.Width = 150;
            }
        }

        private void btnDadosCadastrais_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlDadosCadastrais.Show();
            lblTitulo.Text = "Dados Cadastrais";

            frmDadosCadastrais frm = new frmDadosCadastrais(this);
            AbrirFormInPanel(frm, pnlMain);
            FormAtivo = frm;
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlOS.Show();

            lblTitulo.Text = "Ordens de Serviços";

            frmOS frm = new frmOS(this);
            AbrirFormInPanel(frm, pnlMain);
            FormAtivo = frm;
        }

        private void btnFaturas_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlFaturas.Show();
            lblTitulo.Text = "Faturas";
            frmFaturas frm = new frmFaturas();
            AbrirFormInPanel(frm, pnlMain);
            FormAtivo = frm;
        }

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlAtividades.Show();
            lblTitulo.Text = "Atividades";

            frmAtividades frm = new frmAtividades(this);
            AbrirFormInPanel(frm, pnlMain);
            FormAtivo = frm;
        }

        private void btnAgencias_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlAgencias.Show();
            lblTitulo.Text = "Agências Demandantes";

            frmAgencias frm = new frmAgencias(this);
            AbrirFormInPanel(frm, pnlMain);
            FormAtivo = frm;
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlProfissionais.Show();
            lblTitulo.Text = "Profissionais";
            
            frmProfissionais frm = new frmProfissionais(this);
            
            AbrirFormInPanel(frm, pnlMain);
            FormAtivo = frm;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }
    
    
    
    
    
    }


}
