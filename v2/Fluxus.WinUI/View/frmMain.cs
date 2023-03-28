using Fluxus.Services;
using Fluxus.Domain.Entities;

namespace Fluxus.WinUI.View
{
    public partial class frmMain : Form
    {
        Form _formAtivo;

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
            var form = new Form();

            switch (((Button)sender).Name)
            {
                case "btnDadosCadastrais":
                    {
                        pnlCtrlDadosCadastrais.Show();
                        form = new frmProfile(this);
                        break;
                    }
                case "btnOS":
                    {
                        pnlCtrlOS.Show();
                        form = new frmServiceOrder(this);
                        break;
                    }
                case "btnFaturas":
                    {
                        pnlCtrlFaturas.Show();
                        form = new frmInvoice();
                        break;
                    }
                case "btnAtividades":
                    {
                        pnlCtrlAtividades.Show();
                        form = new frmService(this);
                        break;
                    }
                case "btnAgencias":
                    {
                        pnlCtrlAgencias.Show();
                        form = new frmBankBranch(this);
                        break;
                    }
                case "btnProfissionais":
                    {
                        pnlCtrlProfissionais.Show();
                        form = new frmProfessional(this);
                        break;
                    }
                default: break;
            }
            AbrirFormInPanel(form);
        }

        public void AbrirFormInPanel(Form activeForm)
        {
            if (pnlMain.Controls.Count > 0)
                _formAtivo.Close();

            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();

            pnlMain.Controls.Add(activeForm);
            pnlMain.Tag = activeForm;

            activeForm.Show();
            _formAtivo = activeForm;
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
