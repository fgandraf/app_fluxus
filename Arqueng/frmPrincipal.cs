using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Arqueng.VIEW;
using Arqueng.MODEL;

namespace Arqueng
{
    public partial class frmPrincipal : Form
    {

        CadastraisMODEL cadmodel = new CadastraisMODEL();

        public frmPrincipal()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /*
         
        private void AbrirFormInPanel(object Formfilho)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            
            Form fh = Formfilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(fh);
            this.pnlMain.Tag = fh;
            fh.Show();
        }

        */
        
        private void OcultaControles()
        {
            pnlCtrlDashboard.Hide();
            pnlCtrlOS.Hide();
            pnlCtrlAgencias.Hide();
            pnlCtrlAtividades.Hide();
            pnlCtrlProfissionais.Hide();
            pnlCtrlDadosCadastrais.Hide();
            pnlCtrlRelatorios.Hide();
        }

        
        public void BuscarNomeFantasia()
        {
            try
            {
                ENTIDADES.CadastraisENT dado = new ENTIDADES.CadastraisENT();
                cadmodel.BuscarFantasiaModel(dado);

                if (dado.Fantasia != null)
                    btnDadosCadastrais.Text = dado.Fantasia;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            BuscarNomeFantasia();
            btnDashBoard.PerformClick();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlOS.Visible = true;
            lblTitulo.Text = "Ordens de Serviços";

            frmOS frm = new frmOS { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }


        private void btnSobre_Click(object sender, EventArgs e)
        {
            OcultaControles();
            lblTitulo.Text = "Sobre";

            frmSobre frm = new frmSobre { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }


        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlProfissionais.Visible = true;
            lblTitulo.Text = "Profissionais";
            
            frmProfissionais frm = new frmProfissionais { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }


        private void btnAtividades_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlAtividades.Visible = true;
            lblTitulo.Text = "Atividades";

            frmAtividades frm = new frmAtividades { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }


        private void btnAgencias_Click(object sender, EventArgs e)
        {
             OcultaControles();
             pnlCtrlAgencias.Visible = true;
             lblTitulo.Text = "Agências Demandantes";
            
            frmAgencias frm = new frmAgencias { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();

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
            
            frmDadosCadastrais frm = new frmDadosCadastrais { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }


        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlDashboard.Visible = true;
            lblTitulo.Text = "Dashboard";

            frmDashboard frm = new frmDashboard { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlRelatorios.Visible = true;
            lblTitulo.Text = "Relatórios";

            frmRelatorios frm = new frmRelatorios { TopLevel = false, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
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
    }
}
