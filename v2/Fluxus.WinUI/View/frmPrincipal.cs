using Fluxus.Services;
using Fluxus.Domain.Entities;

namespace Fluxus.WinUI.View
{
    public partial class frmPrincipal : Form
    {
        Form _formAtivo;

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
            await Task.Run(() => fantasia = new ProfileService().GetFantasia());

            if (fantasia != null)
                btnDadosCadastrais.Text = fantasia;
            else
                btnDadosCadastrais.Text = "Dados Cadastrais";
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
                        form = new frmDadosCadastrais(this);
                        break;
                    }
                case "btnOS":
                    {
                        pnlCtrlOS.Show();
                        form = new frmOS(this);
                        break;
                    }
                case "btnFaturas":
                    {
                        pnlCtrlFaturas.Show();
                        form = new frmFaturas();
                        break;
                    }
                case "btnAtividades":
                    {
                        pnlCtrlAtividades.Show();
                        form = new frmAtividades(this);
                        break;
                    }
                case "btnAgencias":
                    {
                        pnlCtrlAgencias.Show();
                        form = new frmAgencias(this);
                        break;
                    }
                case "btnProfissionais":
                    {
                        pnlCtrlProfissionais.Show();
                        form = new frmProfissionais(this);
                        break;
                    }
                default:break;
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
