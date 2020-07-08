using Arqueng.ENTIDADES;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Arqueng.RELATORIOS
{
    public partial class frmRPFatura : Form
    {
        public List<RepFaturaENT> Datos = new List<RepFaturaENT>();

        public frmRPFatura()
        {
            InitializeComponent();
        }


        private void frmRPFatura_Load(object sender, EventArgs e)
        {
            rpvFatura.LocalReport.DataSources.Clear();
            rpvFatura.LocalReport.DataSources.Add(new ReportDataSource("dtsFatura", Datos));
            rpvFatura.RefreshReport();


            rpvFatura.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvFatura.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            
        }

    }
}
