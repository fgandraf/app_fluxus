using Fluxus.Services;
using Fluxus.Domain.Entities;
using System.Security.Policy;

namespace Fluxus.WinUI.View
{
    public partial class frmMain : Form
    {
        UserControl _uclAtivo;

        public frmMain()
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
            await Task.Run(() => fantasia = new ProfileService().GetTradingName());
            if (fantasia != null)
                btnDadosCadastrais.Text = fantasia;
            else
                btnDadosCadastrais.Text = "Dados Cadastrais";

            byte[] logoByte = null;
            await Task.Run(() => logoByte = new ProfileService().GetLogo());
            if (logoByte != null)
            {
                using (var stream = new MemoryStream(logoByte))
                    imgLogo.Image = System.Drawing.Image.FromStream(stream);
            }
        }

        private void MenuButtonClick(object sender, EventArgs e)
        {
            OcultaControles();
            var uct = new UserControl();

            switch (((Button)sender).Name)
            {
                case "btnDadosCadastrais":
                    {
                        pnlCtrlDadosCadastrais.Show();
                        uct = new frmProfile(this);
                        break;
                    }
                case "btnOS":
                    {
                        pnlCtrlOS.Show();
                        uct = new frmServiceOrder(this);
                        break;
                    }
                case "btnFaturas":
                    {
                        pnlCtrlFaturas.Show();
                        uct = new frmInvoice();
                        break;
                    }
                case "btnAtividades":
                    {
                        pnlCtrlAtividades.Show();
                        uct = new frmService(this);
                        break;
                    }
                case "btnAgencias":
                    {
                        pnlCtrlAgencias.Show();
                        uct = new frmBankBranch(this);
                        break;
                    }
                case "btnProfissionais":
                    {
                        pnlCtrlProfissionais.Show();
                        uct = new frmProfessional(this);
                        break;
                    }
                default: break;
            }
            AbrirUserControlInPanel(uct);
        }

        public void AbrirUserControlInPanel(UserControl activeUserControl)
        {
            //if (pnlMain.Controls.Count > 0)
            //_uclAtivo.Close();

            activeUserControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();

            pnlMain.Controls.Add(activeUserControl);
            pnlMain.Tag = activeUserControl;

            activeUserControl.Show();
            _uclAtivo = activeUserControl;
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
    }
}
