namespace Fluxus.WinUI.View
{
    partial class uctServiceOrder
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
            tabOS = new TabControl();
            tabFluxo = new TabPage();
            tabList = new TabPage();
            tabOS.SuspendLayout();
            SuspendLayout();
            // 
            // tabOS
            // 
            tabOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabOS.Controls.Add(tabFluxo);
            tabOS.Controls.Add(tabList);
            tabOS.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tabOS.HotTrack = true;
            tabOS.ItemSize = new Size(300, 60);
            tabOS.Location = new Point(22, 25);
            tabOS.Margin = new Padding(0);
            tabOS.Name = "tabOS";
            tabOS.Padding = new Point(0, 0);
            tabOS.SelectedIndex = 0;
            tabOS.Size = new Size(1950, 1380);
            tabOS.SizeMode = TabSizeMode.Fixed;
            tabOS.TabIndex = 0;
            tabOS.SelectedIndexChanged += tabOS_SelectedIndexChanged;
            // 
            // tabFluxo
            // 
            tabFluxo.Location = new Point(8, 68);
            tabFluxo.Margin = new Padding(0);
            tabFluxo.Name = "tabFluxo";
            tabFluxo.Size = new Size(1934, 1304);
            tabFluxo.TabIndex = 0;
            tabFluxo.Text = "Fluxo";
            tabFluxo.UseVisualStyleBackColor = true;
            // 
            // tabList
            // 
            tabList.Location = new Point(8, 68);
            tabList.Margin = new Padding(6, 7, 6, 7);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(6, 7, 6, 7);
            tabList.Size = new Size(1934, 1304);
            tabList.TabIndex = 1;
            tabList.Text = "Lista";
            tabList.UseVisualStyleBackColor = true;
            // 
            // uctServiceOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabOS);
            Margin = new Padding(6, 7, 6, 7);
            Name = "uctServiceOrder";
            Size = new Size(1993, 1428);
            Load += frmOS_Load;
            tabOS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabOS;
        private System.Windows.Forms.TabPage tabFluxo;
        private System.Windows.Forms.TabPage tabList;
    }
}