
namespace Fluxus.WinUI.View
{
    public partial class frmServiceOrder : UserControl
    {
        frmMain _frmPrincipal;

        public frmServiceOrder(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmServiceOrder(frmMain frm1, int index)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            if (index == 1)
            {
                tabOS.SelectedIndex = 1;
                CarregarOsLista();
            }
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            if (tabFluxo.Controls.Count > 0)
                tabFluxo.Controls.RemoveAt(0);

            frmOrderFlow formFluxo = new frmOrderFlow(_frmPrincipal);
            formFluxo.Dock = DockStyle.Fill;
            tabFluxo.Controls.Clear();
            tabFluxo.Controls.Add(formFluxo);
            tabFluxo.Tag = formFluxo;
            formFluxo.Show();
        }

        private void tabOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabOS.SelectedTab.Name == "tabList" && tabList.Controls.Count == 0)
                CarregarOsLista();
        }

        private void CarregarOsLista()
        {
            if (tabList.Controls.Count > 0)
                tabList.Controls.RemoveAt(0);

            frmOSLista formList = new frmOSLista(_frmPrincipal);
            formList.Dock = DockStyle.Fill;
            tabList.Controls.Clear();
            tabList.Controls.Add(formList);
            tabList.Tag = formList;
            formList.Show();
        }

    }

}
