using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Arqueng.VIEW;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng
{


    public partial class frmPrincipal : Form
    {


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        CadastraisMODEL cadmodel = new CadastraisMODEL();


        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }


        public void AbrirFormInPanel(Form Formfilho, Panel pnl)
        {
            if (pnl.Controls.Count > 0)
                pnl.Controls.RemoveAt(0);

            Form fh = Formfilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnl.Controls.Add(fh);
            pnl.Tag = fh;
            fh.Show();
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


        public void BuscarDadosEmpresa()
        {
            try
            {
                ENTIDADES.CadastraisENT dado = new ENTIDADES.CadastraisENT();
                cadmodel.BuscarDadosEmpModel(dado);

                if (Globais.Fantasia != null)
                    btnDadosCadastrais.Text = Globais.Fantasia;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Globais.Usr_nome;
            BuscarDadosEmpresa();

            lblVersao.Text = "v. " + Globais.Versao;
            btnOS.PerformClick();
        }


        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlProfissionais.Show();
            lblTitulo.Text = "Profissionais";

            frmProfissionais frm = new frmProfissionais(this);
            AbrirFormInPanel(frm, pnlMain);
        }


        private void btnAtividades_Click(object sender, EventArgs e)
        {
            OcultaControles();
            
            pnlCtrlAtividades.Show();
            lblTitulo.Text = "Atividades";

            frmAtividades frm = new frmAtividades(this);
            AbrirFormInPanel(frm, pnlMain);
        }


        private void btnAgencias_Click(object sender, EventArgs e)
        {
            OcultaControles();
            
            pnlCtrlAgencias.Show();
            lblTitulo.Text = "Agências Demandantes";

            frmAgencias frm = new frmAgencias(this);
            AbrirFormInPanel(frm, pnlMain);
        }


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
        }


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


        private void btnOS_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlOS.Show();

            lblTitulo.Text = "Ordens de Serviços";

            frmOSFluxo frm = new frmOSFluxo(this);
            AbrirFormInPanel(frm, pnlMain);
        }


        private void btnFaturas_Click(object sender, EventArgs e)
        {
            OcultaControles();

            pnlCtrlFaturas.Show();
            lblTitulo.Text = "Faturas";

            frmFaturas frm = new frmFaturas();
            AbrirFormInPanel(frm, pnlMain);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

    }


}
