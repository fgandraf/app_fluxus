namespace Fluxus.WinUI.View
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnEntrar = new Button();
            pnlLogin = new Panel();
            imgShowPwd = new PictureBox();
            pnlLinhaSenha = new Panel();
            imgSenha = new PictureBox();
            txtSenha = new TextBox();
            pnlLinhaUsuario = new Panel();
            imgUsuario = new PictureBox();
            txtUsuario = new TextBox();
            imgHidePwd = new PictureBox();
            btnAppFechar = new Button();
            lblVersao = new Label();
            label1 = new Label();
            ttpLogin = new ToolTip(components);
            lblLoad = new Label();
            prbProgress = new ProgressBar();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgShowPwd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHidePwd).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.DarkSlateBlue;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(65, 367);
            btnEntrar.Margin = new Padding(6, 7, 6, 7);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(607, 57);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(imgShowPwd);
            pnlLogin.Controls.Add(pnlLinhaSenha);
            pnlLogin.Controls.Add(imgSenha);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(pnlLinhaUsuario);
            pnlLogin.Controls.Add(imgUsuario);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(btnEntrar);
            pnlLogin.Controls.Add(imgHidePwd);
            pnlLogin.Location = new Point(87, 123);
            pnlLogin.Margin = new Padding(6, 7, 6, 7);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(737, 492);
            pnlLogin.TabIndex = 0;
            // 
            // imgShowPwd
            // 
            imgShowPwd.Cursor = Cursors.Hand;
            imgShowPwd.Image = (Image)resources.GetObject("imgShowPwd.Image");
            imgShowPwd.Location = new Point(630, 241);
            imgShowPwd.Margin = new Padding(6, 7, 6, 7);
            imgShowPwd.Name = "imgShowPwd";
            imgShowPwd.Size = new Size(32, 37);
            imgShowPwd.SizeMode = PictureBoxSizeMode.Zoom;
            imgShowPwd.TabIndex = 232;
            imgShowPwd.TabStop = false;
            ttpLogin.SetToolTip(imgShowPwd, "Mostrar senha");
            imgShowPwd.Click += imgShowPwd_Click;
            // 
            // pnlLinhaSenha
            // 
            pnlLinhaSenha.BackColor = Color.SteelBlue;
            pnlLinhaSenha.Location = new Point(72, 281);
            pnlLinhaSenha.Margin = new Padding(6, 7, 6, 7);
            pnlLinhaSenha.Name = "pnlLinhaSenha";
            pnlLinhaSenha.Size = new Size(607, 2);
            pnlLinhaSenha.TabIndex = 231;
            // 
            // imgSenha
            // 
            imgSenha.Image = (Image)resources.GetObject("imgSenha.Image");
            imgSenha.Location = new Point(87, 239);
            imgSenha.Margin = new Padding(6, 7, 6, 7);
            imgSenha.Name = "imgSenha";
            imgSenha.Size = new Size(32, 37);
            imgSenha.SizeMode = PictureBoxSizeMode.Zoom;
            imgSenha.TabIndex = 230;
            imgSenha.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.SteelBlue;
            txtSenha.Location = new Point(141, 224);
            txtSenha.Margin = new Padding(0);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(488, 47);
            txtSenha.TabIndex = 1;
            txtSenha.Text = "123456";
            ttpLogin.SetToolTip(txtSenha, "Senha");
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // pnlLinhaUsuario
            // 
            pnlLinhaUsuario.BackColor = Color.SteelBlue;
            pnlLinhaUsuario.Location = new Point(65, 143);
            pnlLinhaUsuario.Margin = new Padding(6, 7, 6, 7);
            pnlLinhaUsuario.Name = "pnlLinhaUsuario";
            pnlLinhaUsuario.Size = new Size(607, 2);
            pnlLinhaUsuario.TabIndex = 227;
            // 
            // imgUsuario
            // 
            imgUsuario.Image = (Image)resources.GetObject("imgUsuario.Image");
            imgUsuario.Location = new Point(87, 101);
            imgUsuario.Margin = new Padding(6, 7, 6, 7);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Size = new Size(32, 37);
            imgUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            imgUsuario.TabIndex = 226;
            imgUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.SteelBlue;
            txtUsuario.Location = new Point(141, 86);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(520, 47);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "fgandraf";
            ttpLogin.SetToolTip(txtUsuario, "Nome de usuário");
            txtUsuario.KeyDown += txtSenha_KeyDown;
            // 
            // imgHidePwd
            // 
            imgHidePwd.Cursor = Cursors.Hand;
            imgHidePwd.Image = (Image)resources.GetObject("imgHidePwd.Image");
            imgHidePwd.Location = new Point(630, 241);
            imgHidePwd.Margin = new Padding(6, 7, 6, 7);
            imgHidePwd.Name = "imgHidePwd";
            imgHidePwd.Size = new Size(32, 37);
            imgHidePwd.SizeMode = PictureBoxSizeMode.Zoom;
            imgHidePwd.TabIndex = 233;
            imgHidePwd.TabStop = false;
            ttpLogin.SetToolTip(imgHidePwd, "Ocultar senha");
            imgHidePwd.Click += imgHidePwd_Click;
            // 
            // btnAppFechar
            // 
            btnAppFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAppFechar.BackColor = Color.Transparent;
            btnAppFechar.FlatAppearance.BorderSize = 0;
            btnAppFechar.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnAppFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAppFechar.FlatStyle = FlatStyle.Flat;
            btnAppFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAppFechar.ForeColor = Color.Black;
            btnAppFechar.Image = (Image)resources.GetObject("btnAppFechar.Image");
            btnAppFechar.Location = new Point(823, -2);
            btnAppFechar.Margin = new Padding(0);
            btnAppFechar.Name = "btnAppFechar";
            btnAppFechar.Size = new Size(87, 62);
            btnAppFechar.TabIndex = 10;
            btnAppFechar.UseVisualStyleBackColor = false;
            btnAppFechar.Click += btnAppFechar_Click;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersao.ForeColor = Color.Black;
            lblVersao.Location = new Point(89, 623);
            lblVersao.Margin = new Padding(0);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(62, 30);
            lblVersao.TabIndex = 12;
            lblVersao.Text = "v. ---";
            lblVersao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(76, 34);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(122, 57);
            label1.TabIndex = 13;
            label1.Text = "Fluxus";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLoad
            // 
            lblLoad.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoad.ForeColor = Color.White;
            lblLoad.Location = new Point(0, 684);
            lblLoad.Margin = new Padding(0);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(910, 32);
            lblLoad.TabIndex = 14;
            lblLoad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prbProgress
            // 
            prbProgress.BackColor = Color.DarkSlateBlue;
            prbProgress.Dock = DockStyle.Bottom;
            prbProgress.Location = new Point(0, 728);
            prbProgress.Margin = new Padding(6, 7, 6, 7);
            prbProgress.Maximum = 9;
            prbProgress.Name = "prbProgress";
            prbProgress.Size = new Size(910, 10);
            prbProgress.Step = 8;
            prbProgress.TabIndex = 15;
            prbProgress.Visible = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(910, 738);
            Controls.Add(lblLoad);
            Controls.Add(prbProgress);
            Controls.Add(label1);
            Controls.Add(lblVersao);
            Controls.Add(btnAppFechar);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fluxus";
            Load += frmLogin_Load;
            MouseDown += frmLogin_MouseDown;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgShowPwd).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHidePwd).EndInit();
            ResumeLayout(false);
            PerformLayout();
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