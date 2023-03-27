namespace Fluxus.WinUI.View
{
    partial class frmServiceOrder
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
            tabOS.Font = new Font("Segoe UI", 10.125F);
            tabOS.HotTrack = true;
            tabOS.ItemSize = new Size(300, 60);
            tabOS.Location = new Point(10, 10);
            tabOS.Margin = new Padding(0);
            tabOS.Name = "tabOS";
            tabOS.Padding = new Point(0, 0);
            tabOS.SelectedIndex = 0;
            tabOS.Size = new Size(900, 561);
            tabOS.SizeMode = TabSizeMode.Fixed;
            tabOS.TabIndex = 0;
            tabOS.SelectedIndexChanged += tabOS_SelectedIndexChanged;
            // 
            // tabFluxo
            // 
            tabFluxo.Location = new Point(4, 44);
            tabFluxo.Margin = new Padding(0);
            tabFluxo.Name = "tabFluxo";
            tabFluxo.Size = new Size(892, 512);
            tabFluxo.TabIndex = 0;
            tabFluxo.Text = "Fluxo";
            tabFluxo.UseVisualStyleBackColor = true;
            // 
            // tabList
            // 
            tabList.Location = new Point(4, 44);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(892, 513);
            tabList.TabIndex = 1;
            tabList.Text = "Lista";
            tabList.UseVisualStyleBackColor = true;
            // 
            // frmOS
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 580);
            Controls.Add(tabOS);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOS";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordens de Serviços";
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