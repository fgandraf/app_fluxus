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
        public FaturasENT dado = new FaturasENT();
        public string contrato = null;


        public frmRPFatura(string _contrato, string subtotal_os, string subtotal_desloc, string total)
        {
            InitializeComponent();
            
            dado.subtotal_os = subtotal_os;
            dado.subtotal_desloc = subtotal_desloc;
            dado.total = total;
        }


        private void frmRPFatura_Load(object sender, EventArgs e)
        {
            rpvFatura.LocalReport.DataSources.Clear();
            rpvFatura.LocalReport.DataSources.Add(new ReportDataSource("dtFat", Datos));

            this.rpvFatura.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("edital", Globais.Edital));
            this.rpvFatura.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("contrato", Globais.Contrato));
            this.rpvFatura.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("subtotal_os", dado.subtotal_os));
            this.rpvFatura.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("subtotal_desloc", dado.subtotal_desloc));
            this.rpvFatura.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("total", dado.total));
            this.rpvFatura.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("razao", Globais.Razao));
            this.rpvFatura.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cnpj", Globais.Cnpj));

            rpvFatura.RefreshReport();

            rpvFatura.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvFatura.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

            
        }

    }


}
