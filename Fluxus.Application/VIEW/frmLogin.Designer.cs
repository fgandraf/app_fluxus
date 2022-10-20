namespace Fluxus.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.imgShowPwd = new System.Windows.Forms.PictureBox();
            this.pnlLinhaSenha = new System.Windows.Forms.Panel();
            this.imgSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlLinhaUsuario = new System.Windows.Forms.Panel();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.imgHidePwd = new System.Windows.Forms.PictureBox();
            this.btnAppFechar = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpLogin = new System.Windows.Forms.ToolTip(this.components);
            this.lblLoad = new System.Windows.Forms.Label();
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidePwd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEntrar.Location = new System.Drawing.Point(30, 149);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(280, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.Window;
            this.pnlLogin.Controls.Add(this.imgShowPwd);
            this.pnlLogin.Controls.Add(this.pnlLinhaSenha);
            this.pnlLogin.Controls.Add(this.imgSenha);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.pnlLinhaUsuario);
            this.pnlLogin.Controls.Add(this.imgUsuario);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.imgHidePwd);
            this.pnlLogin.Location = new System.Drawing.Point(40, 50);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(340, 200);
            this.pnlLogin.TabIndex = 0;
            // 
            // imgShowPwd
            // 
            this.imgShowPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgShowPwd.Image = ((System.Drawing.Image)(resources.GetObject("imgShowPwd.Image")));
            this.imgShowPwd.Location = new System.Drawing.Point(291, 98);
            this.imgShowPwd.Name = "imgShowPwd";
            this.imgShowPwd.Size = new System.Drawing.Size(15, 15);
            this.imgShowPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgShowPwd.TabIndex = 232;
            this.imgShowPwd.TabStop = false;
            this.ttpLogin.SetToolTip(this.imgShowPwd, "Mostrar senha");
            this.imgShowPwd.Click += new System.EventHandler(this.imgShowPwd_Click);
            // 
            // pnlLinhaSenha
            // 
            this.pnlLinhaSenha.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLinhaSenha.Location = new System.Drawing.Point(33, 114);
            this.pnlLinhaSenha.Name = "pnlLinhaSenha";
            this.pnlLinhaSenha.Size = new System.Drawing.Size(280, 1);
            this.pnlLinhaSenha.TabIndex = 231;
            // 
            // imgSenha
            // 
            this.imgSenha.Image = ((System.Drawing.Image)(resources.GetObject("imgSenha.Image")));
            this.imgSenha.Location = new System.Drawing.Point(40, 97);
            this.imgSenha.Name = "imgSenha";
            this.imgSenha.Size = new System.Drawing.Size(15, 15);
            this.imgSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSenha.TabIndex = 230;
            this.imgSenha.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSenha.Location = new System.Drawing.Point(65, 91);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(225, 24);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "123456";
            this.ttpLogin.SetToolTip(this.txtSenha, "Senha");
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // pnlLinhaUsuario
            // 
            this.pnlLinhaUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLinhaUsuario.Location = new System.Drawing.Point(30, 58);
            this.pnlLinhaUsuario.Name = "pnlLinhaUsuario";
            this.pnlLinhaUsuario.Size = new System.Drawing.Size(280, 1);
            this.pnlLinhaUsuario.TabIndex = 227;
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgUsuario.Image")));
            this.imgUsuario.Location = new System.Drawing.Point(40, 41);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(15, 15);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuario.TabIndex = 226;
            this.imgUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUsuario.Location = new System.Drawing.Point(65, 35);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(240, 24);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "fgandraf";
            this.ttpLogin.SetToolTip(this.txtUsuario, "Nome de usuário");
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // imgHidePwd
            // 
            this.imgHidePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgHidePwd.Image = ((System.Drawing.Image)(resources.GetObject("imgHidePwd.Image")));
            this.imgHidePwd.Location = new System.Drawing.Point(291, 98);
            this.imgHidePwd.Name = "imgHidePwd";
            this.imgHidePwd.Size = new System.Drawing.Size(15, 15);
            this.imgHidePwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHidePwd.TabIndex = 233;
            this.imgHidePwd.TabStop = false;
            this.ttpLogin.SetToolTip(this.imgHidePwd, "Ocultar senha");
            this.imgHidePwd.Click += new System.EventHandler(this.imgHidePwd_Click);
            // 
            // btnAppFechar
            // 
            this.btnAppFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnAppFechar.FlatAppearance.BorderSize = 0;
            this.btnAppFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnAppFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAppFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppFechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppFechar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAppFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnAppFechar.Image")));
            this.btnAppFechar.Location = new System.Drawing.Point(380, -1);
            this.btnAppFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAppFechar.Name = "btnAppFechar";
            this.btnAppFechar.Size = new System.Drawing.Size(40, 25);
            this.btnAppFechar.TabIndex = 10;
            this.btnAppFechar.UseVisualStyleBackColor = false;
            this.btnAppFechar.Click += new System.EventHandler(this.btnAppFechar_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVersao.Location = new System.Drawing.Point(41, 253);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(30, 13);
            this.lblVersao.TabIndex = 12;
            this.lblVersao.Text = "v. ---";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fluxus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoad
            // 
            this.lblLoad.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblLoad.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLoad.Location = new System.Drawing.Point(0, 278);
            this.lblLoad.Margin = new System.Windows.Forms.Padding(0);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(420, 13);
            this.lblLoad.TabIndex = 14;
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prbProgress
            // 
            this.prbProgress.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.prbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prbProgress.Location = new System.Drawing.Point(0, 296);
            this.prbProgress.Maximum = 9;
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(420, 4);
            this.prbProgress.Step = 8;
            this.prbProgress.TabIndex = 15;
            this.prbProgress.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.prbProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnAppFechar);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxus";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidePwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlLinhaUsuario;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlLinhaSenha;
        private System.Windows.Forms.PictureBox imgSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAppFechar;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttpLogin;
        private System.Windows.Forms.PictureBox imgShowPwd;
        private System.Windows.Forms.PictureBox imgHidePwd;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.ProgressBar prbProgress;
    }
}