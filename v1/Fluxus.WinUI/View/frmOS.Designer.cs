namespace Fluxus.WinUI.View
{
    partial class frmOS
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
            this.tabOS = new System.Windows.Forms.TabControl();
            this.tabFluxo = new System.Windows.Forms.TabPage();
            this.tabList = new System.Windows.Forms.TabPage();
            this.tabOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOS
            // 
            this.tabOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOS.Controls.Add(this.tabFluxo);
            this.tabOS.Controls.Add(this.tabList);
            this.tabOS.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabOS.HotTrack = true;
            this.tabOS.ItemSize = new System.Drawing.Size(160, 40);
            this.tabOS.Location = new System.Drawing.Point(10, 10);
            this.tabOS.Margin = new System.Windows.Forms.Padding(0);
            this.tabOS.Name = "tabOS";
            this.tabOS.Padding = new System.Drawing.Point(0, 0);
            this.tabOS.SelectedIndex = 0;
            this.tabOS.Size = new System.Drawing.Size(900, 561);
            this.tabOS.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabOS.TabIndex = 0;
            this.tabOS.SelectedIndexChanged += new System.EventHandler(this.tabOS_SelectedIndexChanged);
            // 
            // tabFluxo
            // 
            this.tabFluxo.Location = new System.Drawing.Point(4, 44);
            this.tabFluxo.Margin = new System.Windows.Forms.Padding(0);
            this.tabFluxo.Name = "tabFluxo";
            this.tabFluxo.Size = new System.Drawing.Size(892, 512);
            this.tabFluxo.TabIndex = 0;
            this.tabFluxo.Text = "Fluxo";
            this.tabFluxo.UseVisualStyleBackColor = true;
            // 
            // tabList
            // 
            this.tabList.Location = new System.Drawing.Point(4, 44);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(892, 513);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "Lista";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.tabOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordens de Serviços";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.tabOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOS;
        private System.Windows.Forms.TabPage tabFluxo;
        private System.Windows.Forms.TabPage tabList;
    }
}