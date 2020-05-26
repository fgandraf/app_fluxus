using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Arqueng
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        // Importação de bibliotecas para função de mover janela -------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // -------------------------------------------------------------------------
        
        // Abrir Formulário dentro do painel principal (pnlMain) -------------------
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
        // -------------------------------------------------------------------------

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ordens de Serviços";
            AbrirFormInPanel(new frmOS());
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Sobre";
            AbrirFormInPanel(new frmSobre());
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Profissionais";
            AbrirFormInPanel(new frmProfissionais());
        }

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Atividades";
            AbrirFormInPanel(new frmAtividades());
        }

        private void btnAgencias_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Agências Demandantes";
            AbrirFormInPanel(new frmAgencias());
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 180)
            {
                pnlMenu.Width = 50;
                ttpMenu.Active = true;
                //imgLogo.Width = 50;
                //imgLogo.Height = 50;
                //imgLogo.Location = new Point(0,60);
            }
            else
            {
                pnlMenu.Width = 180;
                ttpMenu.Active = false;
                //imgLogo.Width = 100;
                //imgLogo.Height = 100;
                //imgLogo.Location = new Point(40,60);
            }
                

        }

        private void btnDadosCadastrais_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Dados Cadastrais";
            AbrirFormInPanel(new frmDadosCadastrais());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Dashboard";
            AbrirFormInPanel(new frmDashboard());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmDashboard());
        }
    }
}
