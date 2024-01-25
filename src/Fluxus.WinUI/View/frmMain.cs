using Fluxus.UseCases;
using Fluxus.Core.Models;
using Fluxus.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI.View
{
    public partial class frmMain : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private UserControl _userControlActive;

        public frmMain(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Logged.Usr_nome;
            btnOS.PerformClick();

            var profileService = _serviceProvider.GetService<ProfileUseCases>();


            OperationResult<string> fantasia = null;
            await Task.Run(() => fantasia = profileService.GetTradingName());
            if (fantasia.Success)
                btnDadosCadastrais.Text = fantasia.Value.Trim('\"');
            else
                btnDadosCadastrais.Text = "Dados Cadastrais";


            OperationResult<byte[]> logo = null;
            await Task.Run(() => logo = profileService.GetLogo());
            if (logo.Success)
            {
                using (var stream = new MemoryStream(logo.Value))
                    imgLogo.Image = System.Drawing.Image.FromStream(stream);
            }
            
        }

        private void MenuButtonClick(object sender, EventArgs e)
        {
            HideControls();

            var uct = new UserControl();
            switch (((Button)sender).Name)
            {
                case "btnDadosCadastrais":
                    {
                        pnlCtrlDadosCadastrais.Show();
                        uct = new uctProfile(this, _serviceProvider);
                        break;
                    }
                case "btnOS":
                    {
                        pnlCtrlOS.Show();
                        uct = new uctServiceOrder(this, _serviceProvider);
                        break;
                    }
                case "btnFaturas":
                    {
                        pnlCtrlFaturas.Show();
                        uct = new uctInvoice(_serviceProvider);
                        break;
                    }
                case "btnAtividades":
                    {
                        pnlCtrlAtividades.Show();
                        uct = new uctService(this, _serviceProvider);
                        break;
                    }
                case "btnAgencias":
                    {
                        pnlCtrlAgencias.Show();
                        uct = new uctBankBranch(this, _serviceProvider);
                        break;
                    }
                case "btnProfissionais":
                    {
                        pnlCtrlProfissionais.Show();
                        uct = new uctProfessional(this, _serviceProvider);
                        break;
                    }
                default: break;
            }

            OpenUserControl(uct);
        }

        public void OpenUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.Show();

            _userControlActive = userControl;

            GC.Collect();
        }

        private void HideControls()
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
