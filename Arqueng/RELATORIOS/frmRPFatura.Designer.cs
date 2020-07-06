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
            this.tbInnerOsAtivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cefdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cef_dbDataSet = new Arqueng.cef_dbDataSet();
            this.rpvFatura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbInnerOsAtivTableAdapter = new Arqueng.cef_dbDataSetTableAdapters.tbInnerOsAtivTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbInnerOsAtivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cefdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cef_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInnerOsAtivBindingSource
            // 
            this.tbInnerOsAtivBindingSource.DataMember = "tbInnerOsAtiv";
            this.tbInnerOsAtivBindingSource.DataSource = this.cefdbDataSetBindingSource;
            // 
            // cefdbDataSetBindingSource
            // 
            this.cefdbDataSetBindingSource.DataSource = this.cef_dbDataSet;
            this.cefdbDataSetBindingSource.Position = 0;
            // 
            // cef_dbDataSet
            // 
            this.cef_dbDataSet.DataSetName = "cef_dbDataSet";
            this.cef_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvFatura
            // 
            this.rpvFatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rpvFatura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtsFatura";
            reportDataSource1.Value = this.tbInnerOsAtivBindingSource;
            this.rpvFatura.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFatura.LocalReport.ReportEmbeddedResource = "Arqueng.RELATORIOS.rpFatura.rdlc";
            this.rpvFatura.Location = new System.Drawing.Point(0, 0);
            this.rpvFatura.Margin = new System.Windows.Forms.Padding(0);
            this.rpvFatura.Name = "rpvFatura";
            this.rpvFatura.ServerReport.BearerToken = null;
            this.rpvFatura.Size = new System.Drawing.Size(784, 661);
            this.rpvFatura.TabIndex = 0;
            // 
            // tbInnerOsAtivTableAdapter
            // 
            this.tbInnerOsAtivTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.tbInnerOsAtivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cefdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cef_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvFatura;
        private System.Windows.Forms.BindingSource cefdbDataSetBindingSource;
        private cef_dbDataSet cef_dbDataSet;
        private System.Windows.Forms.BindingSource tbInnerOsAtivBindingSource;
        private cef_dbDataSetTableAdapters.tbInnerOsAtivTableAdapter tbInnerOsAtivTableAdapter;
    }
}