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
            pnlCtrlDashboard.Hide();
            pnlCtrlOS.Hide();
            pnlCtrlAgencias.Hide();
            pnlCtrlAtividades.Hide();
            pnlCtrlProfissionais.Hide();
            pnlCtrlDadosCadastrais.Hide();
            pnlCtrlRelatorios.Hide();
            pnlCtrlFaturas.Hide();
            pnlCtrlFluxo.Hide();
            pnlCtrlLista.Hide();
        }


        private void ExpandSubMenuOS()
        {
            tblMenu.RowStyles[2].Height = 25;
            tblMenu.RowStyles[3].Height = 2;
            tblMenu.RowStyles[4].Height = 25;
            tblMenu.RowStyles[5].Height = 2;
        }


        private void RecolheSubMenuOS()
        {
            tblMenu.RowStyles[2].Height = 0;
            tblMenu.RowStyles[3].Height = 0;
            tblMenu.RowStyles[4].Height = 0;
            tblMenu.RowStyles[5].Height = 0;
        }


        public void BuscarDadosEmpresa()
        {
            try
            {
                ENTIDADES.CadastraisENT dado = new ENTIDADES.CadastraisENT();
                cadmodel.BuscarDadosEmpModel(dado);

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
            lblUsuario.Text = "Usuário: " + Globais.Usr_nome;
            BuscarDadosEmpresa();
            if (Globais.Rl == false)
                tblMenu.RowStyles[6].Height = 0;

            lblVersao.Text = "v. " + Globais.Versao;
            btnDashBoard.PerformClick();
        }


        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            OcultaControles();
            RecolheSubMenuOS();

            pnlCtrlProfissionais.Show();
            lblTitulo.Text = "Profissionais";

            frmProfissionais frm = new frmProfissionais(this);
            AbrirFormInPanel(frm, pnlMain);
        }


        private void btnAtividades_Click(object sender, EventArgs e)
        {
            OcultaControles();
            RecolheSubMenuOS();
            
            pnlCtrlAtividades.Show();
            lblTitulo.Text = "Atividades";

            frmAtividades frm = new frmAtividades(this);
            AbrirFormInPanel(frm, pnlMain);
        }


        private void btnAgencias_Click(object sender, EventArgs e)
        {
            OcultaControles();
            RecolheSubMenuOS();
            
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
                RecolheSubMenuOS();
                tblMenu.RowStyles[3].Height = 0;
                tblMenu.RowStyles[5].Height = 0;
                pnlCtrlFluxo.Hide();
                pnlCtrlLista.Hide();

                if (pnlCtrlDadosCadastrais.Visible == true)
                    pnlCtrlDadosCadastrais.Width = 20;
            }
            else
            {
                pnlMenu.Width = 200;
                ttpMenu.Active = false;
                btnDadosCadastrais.Show();
                pnlCtrlDadosCadastrais.Width = 150;
                if (lblTitulo.Text == "Ordens de Serviços - Em lista")
                {
                    ExpandSubMenuOS();
                    tblMenu.RowStyles[3].Height = 2;
                    tblMenu.RowStyles[5].Height = 2;
                    pnlCtrlLista.Show();
                }
                else if (lblTitulo.Text == "Ordens de Serviços - Em fluxo")
                {
                    ExpandSubMenuOS();
                    tblMenu.RowStyles[3].Height = 2;
                    tblMenu.RowStyles[5].Height = 2;
                    pnlCtrlFluxo.Show();
                }
            }
        }


        private void btnDadosCadastrais_Click(object sender, EventArgs e)
        {
            OcultaControles();
            RecolheSubMenuOS();

            pnlCtrlDadosCadastrais.Show();
            lblTitulo.Text = "Dados Cadastrais";

            frmDadosCadastrais frm = new frmDadosCadastrais(this);
            AbrirFormInPanel(frm, pnlMain);
        }


        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OcultaControles();
            RecolheSubMenuOS();
            
            pnlCtrlDashboard.Show();
            lblTitulo.Text = "Dashboard";

            frmDashboard frm = new frmDashboard();
            AbrirFormInPanel(frm, pnlMain);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            OcultaControles();
            RecolheSubMenuOS();
            
            pnlCtrlRelatorios.Show();
            lblTitulo.Text = "Relatórios";

            frmRelatorios frm = new frmRelatorios();
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


        private void btnOSLista_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlFluxo.Hide();
            
            pnlCtrlLista.Show();
            pnlCtrlOS.Show();
            lblTitulo.Text = "Ordens de Serviços - Em lista";

            frmOSLista frm = new frmOSLista(this);
            AbrirFormInPanel(frm, pnlMain);
        }

        private void btnOS_Click(object sender, EventArgs e)
        {


            if (tblMenu.RowStyles[2].Height == 0)
            {
                ExpandSubMenuOS();

                if (lblTitulo.Text == "Ordens de Serviços - Em lista")
                    pnlCtrlLista.Show();
                else if (lblTitulo.Text == "Ordens de Serviços - Em fluxo")
                    pnlCtrlFluxo.Show();
                else
                {
                    pnlCtrlFluxo.Hide();
                    pnlCtrlLista.Hide();
                }
            }
            else
            {
                RecolheSubMenuOS();
                pnlCtrlFluxo.Hide();
                pnlCtrlLista.Hide();
            }
            if (pnlMenu.Width == 50)
                btnSlide.PerformClick();
        }

        private void btnOSFluxo_Click(object sender, EventArgs e)
        {
            OcultaControles();
            pnlCtrlLista.Hide();

            pnlCtrlOS.Show();
            pnlCtrlFluxo.Show();
            lblTitulo.Text = "Ordens de Serviços - Em fluxo";

            frmOSFluxo frm = new frmOSFluxo(this);
            AbrirFormInPanel(frm, pnlMain);
        }

        private void btnFaturas_Click(object sender, EventArgs e)
        {
            OcultaControles();
            RecolheSubMenuOS();

            pnlCtrlFaturas.Show();
            lblTitulo.Text = "Faturas";

            frmFaturas frm = new frmFaturas();
            AbrirFormInPanel(frm, pnlMain);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            menuUsuario.Show(Cursor.Position.X-132, Cursor.Position.Y+9);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }


}
