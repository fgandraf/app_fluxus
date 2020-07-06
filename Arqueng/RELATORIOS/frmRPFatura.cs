using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arqueng.RELATORIOS
{
    public partial class frmRPFatura : Form
    {
        public frmRPFatura()
        {
            InitializeComponent();
        }

        private void frmRPFatura_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cef_dbDataSet.tbInnerOsAtiv'. Você pode movê-la ou removê-la conforme necessário.
            this.tbInnerOsAtivTableAdapter.Fill(this.cef_dbDataSet.tbInnerOsAtiv);

            this.rpvFatura.RefreshReport();
            rpvFatura.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvFatura.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            
        }

    }
}
