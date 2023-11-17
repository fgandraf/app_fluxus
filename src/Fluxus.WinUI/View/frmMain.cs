using Fluxus.App;
using Fluxus.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;

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
            string fantasia = null;

            var profileService = _serviceProvider.GetService<ProfileService>();
            await Task.Run(() => fantasia = profileService.GetTradingName());

            if (fantasia != null)
                btnDadosCadastrais.Text = fantasia;
            else
                btnDadosCadastrais.Text = "Dados Cadastrais";

            byte[] logoByte = null;
            await Task.Run(() => logoByte = profileService.GetLogo());
            if (logoByte != null)
            {
                using (var stream = new MemoryStream(logoByte))
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
                        
                        uctProfile uctProfile = _serviceProvider.GetService<uctProfile>();
                        uctProfile.Initialize(this);
                        uct = uctProfile;

                        break;
                    }
                case "btnOS":
                    {
                        pnlCtrlOS.Show();
                        uct = new uctServiceOrder(this);
                        break;
                    }
                case "btnFaturas":
                    {
                        pnlCtrlFaturas.Show();
                        uct = new uctInvoice();
                        break;
                    }
                case "btnAtividades":
                    {
                        pnlCtrlAtividades.Show();
                        uct = new uctService(this);
                        break;
                    }
                case "btnAgencias":
                    {
                        pnlCtrlAgencias.Show();
                        uct = new uctBankBranch(this);
                        break;
                    }
                case "btnProfissionais":
                    {
                        pnlCtrlProfissionais.Show();
                        uct = new uctProfessional(this);
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
