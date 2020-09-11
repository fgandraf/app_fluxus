using System;
using System.Windows.Forms;


namespace Arqueng.VIEW
{
    public partial class frmOS : Form
    {
        frmPrincipal _frmPrincipal;


        private void CarregarOsLista()
        {
            if (tabList.Controls.Count > 0)
                tabList.Controls.RemoveAt(0);
            frmOSLista formList = new frmOSLista(_frmPrincipal);
            formList.TopLevel = false;
            formList.Dock = DockStyle.Fill;
            tabList.Controls.Clear();
            tabList.Controls.Add(formList);
            tabList.Tag = formList;
            formList.Show();
        }


        public frmOS(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmOS(frmPrincipal frm1, int index)
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
            frmOSFluxo formFluxo = new frmOSFluxo(_frmPrincipal);
            formFluxo.TopLevel = false;
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


    }
}
