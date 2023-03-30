
namespace Fluxus.WinUI.View
{
    public partial class uctServiceOrder : UserControl
    {
        frmMain _frmPrincipal;

        public uctServiceOrder(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public uctServiceOrder(frmMain frm1, int index)
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

            uctOrderFlow formFluxo = new uctOrderFlow(_frmPrincipal);
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

            uctOrderList formList = new uctOrderList(_frmPrincipal);
            formList.Dock = DockStyle.Fill;
            tabList.Controls.Clear();
            tabList.Controls.Add(formList);
            tabList.Tag = formList;
            formList.Show();
        }

    }

}
