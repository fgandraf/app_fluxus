namespace Arqueng.RELATORIOS
{
    partial class frmRPFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvFatura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvFatura
            // 
            this.rpvFatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rpvFatura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtsOSFaturadas";
            this.rpvFatura.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFatura.LocalReport.ReportEmbeddedResource = "Arqueng.RELATORIOS.rpFatura.rdlc";
            this.rpvFatura.Location = new System.Drawing.Point(0, 0);
            this.rpvFatura.Margin = new System.Windows.Forms.Padding(0);
            this.rpvFatura.Name = "rpvFatura";
            this.rpvFatura.ServerReport.BearerToken = null;
            this.rpvFatura.Size = new System.Drawing.Size(784, 661);
            this.rpvFatura.TabIndex = 0;
            // 
            // frmRPFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.rpvFatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRPFatura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRPFatura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvFatura;
    }
}