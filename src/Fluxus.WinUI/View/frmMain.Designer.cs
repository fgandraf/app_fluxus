namespace Fluxus.WinUI.View
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlMenu = new Panel();
            lblUsuario = new Label();
            pnlCtrlOS = new Panel();
            pnlCtrlProfissionais = new Panel();
            btnProfissionais = new Button();
            btnOS = new Button();
            pnlCtrlAtividades = new Panel();
            lblVersao = new Label();
            pnlCtrlAgencias = new Panel();
            pnlCtrlDadosCadastrais = new Panel();
            pnlCtrlFaturas = new Panel();
            btnFaturas = new Button();
            btnDadosCadastrais = new Button();
            imgLogo = new PictureBox();
            btnAgencias = new Button();
            btnAtividades = new Button();
            pnlMain = new Panel();
            ttpMenu = new ToolTip(components);
            ttpSempre = new ToolTip(components);
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.SteelBlue;
            pnlMenu.Controls.Add(lblUsuario);
            pnlMenu.Controls.Add(pnlCtrlOS);
            pnlMenu.Controls.Add(pnlCtrlProfissionais);
            pnlMenu.Controls.Add(btnProfissionais);
            pnlMenu.Controls.Add(btnOS);
            pnlMenu.Controls.Add(pnlCtrlAtividades);
            pnlMenu.Controls.Add(lblVersao);
            pnlMenu.Controls.Add(pnlCtrlAgencias);
            pnlMenu.Controls.Add(pnlCtrlDadosCadastrais);
            pnlMenu.Controls.Add(pnlCtrlFaturas);
            pnlMenu.Controls.Add(btnFaturas);
            pnlMenu.Controls.Add(btnDadosCadastrais);
            pnlMenu.Controls.Add(imgLogo);
            pnlMenu.Controls.Add(btnAgencias);
            pnlMenu.Controls.Add(btnAtividades);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(7, 6, 7, 6);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(433, 1493);
            pnlMenu.TabIndex = 160;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsuario.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(0, 1453);
            lblUsuario.Margin = new Padding(7, 0, 7, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(290, 32);
            lblUsuario.TabIndex = 126;
            lblUsuario.Text = "Usuário: null";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCtrlOS
            // 
            pnlCtrlOS.BackColor = Color.LimeGreen;
            pnlCtrlOS.Location = new Point(0, 529);
            pnlCtrlOS.Margin = new Padding(0);
            pnlCtrlOS.Name = "pnlCtrlOS";
            pnlCtrlOS.Size = new Size(11, 124);
            pnlCtrlOS.TabIndex = 126;
            pnlCtrlOS.Visible = false;
            // 
            // pnlCtrlProfissionais
            // 
            pnlCtrlProfissionais.BackColor = Color.LimeGreen;
            pnlCtrlProfissionais.Location = new Point(0, 1022);
            pnlCtrlProfissionais.Margin = new Padding(0);
            pnlCtrlProfissionais.Name = "pnlCtrlProfissionais";
            pnlCtrlProfissionais.Size = new Size(11, 124);
            pnlCtrlProfissionais.TabIndex = 123;
            pnlCtrlProfissionais.Visible = false;
            // 
            // btnProfissionais
            // 
            btnProfissionais.BackColor = Color.SteelBlue;
            btnProfissionais.Cursor = Cursors.Hand;
            btnProfissionais.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnProfissionais.FlatAppearance.BorderSize = 0;
            btnProfissionais.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnProfissionais.FlatStyle = FlatStyle.Flat;
            btnProfissionais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfissionais.ForeColor = Color.Black;
            btnProfissionais.Image = Properties.Resources.professionalIcon;
            btnProfissionais.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfissionais.Location = new Point(0, 1022);
            btnProfissionais.Margin = new Padding(0);
            btnProfissionais.Name = "btnProfissionais";
            btnProfissionais.Padding = new Padding(17, 0, 0, 0);
            btnProfissionais.Size = new Size(433, 124);
            btnProfissionais.TabIndex = 5;
            btnProfissionais.Text = "    Profissionais";
            btnProfissionais.TextAlign = ContentAlignment.MiddleLeft;
            btnProfissionais.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpMenu.SetToolTip(btnProfissionais, "Profissionais");
            btnProfissionais.UseVisualStyleBackColor = false;
            btnProfissionais.Click += MenuButtonClick;
            // 
            // btnOS
            // 
            btnOS.BackColor = Color.SteelBlue;
            btnOS.Cursor = Cursors.Hand;
            btnOS.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnOS.FlatAppearance.BorderSize = 0;
            btnOS.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnOS.FlatStyle = FlatStyle.Flat;
            btnOS.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOS.ForeColor = Color.Black;
            btnOS.Image = Properties.Resources.serviceorderIcon;
            btnOS.ImageAlign = ContentAlignment.MiddleLeft;
            btnOS.Location = new Point(0, 529);
            btnOS.Margin = new Padding(0);
            btnOS.Name = "btnOS";
            btnOS.Padding = new Padding(17, 0, 0, 0);
            btnOS.Size = new Size(433, 124);
            btnOS.TabIndex = 1;
            btnOS.Text = "    Ordens de Serviços";
            btnOS.TextAlign = ContentAlignment.MiddleLeft;
            btnOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpMenu.SetToolTip(btnOS, "Ordens de Serviço");
            btnOS.UseVisualStyleBackColor = false;
            btnOS.Click += MenuButtonClick;
            // 
            // pnlCtrlAtividades
            // 
            pnlCtrlAtividades.BackColor = Color.LimeGreen;
            pnlCtrlAtividades.Location = new Point(0, 774);
            pnlCtrlAtividades.Margin = new Padding(0);
            pnlCtrlAtividades.Name = "pnlCtrlAtividades";
            pnlCtrlAtividades.Size = new Size(11, 124);
            pnlCtrlAtividades.TabIndex = 124;
            pnlCtrlAtividades.Visible = false;
            // 
            // lblVersao
            // 
            lblVersao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblVersao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersao.ForeColor = Color.White;
            lblVersao.Location = new Point(303, 1453);
            lblVersao.Margin = new Padding(7, 0, 7, 0);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(130, 32);
            lblVersao.TabIndex = 134;
            lblVersao.Text = "v. 1.0.0.";
            lblVersao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlCtrlAgencias
            // 
            pnlCtrlAgencias.BackColor = Color.LimeGreen;
            pnlCtrlAgencias.Location = new Point(0, 898);
            pnlCtrlAgencias.Margin = new Padding(0);
            pnlCtrlAgencias.Name = "pnlCtrlAgencias";
            pnlCtrlAgencias.Size = new Size(11, 124);
            pnlCtrlAgencias.TabIndex = 125;
            pnlCtrlAgencias.Visible = false;
            // 
            // pnlCtrlDadosCadastrais
            // 
            pnlCtrlDadosCadastrais.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCtrlDadosCadastrais.BackColor = Color.LimeGreen;
            pnlCtrlDadosCadastrais.Location = new Point(54, 384);
            pnlCtrlDadosCadastrais.Margin = new Padding(7, 6, 7, 6);
            pnlCtrlDadosCadastrais.Name = "pnlCtrlDadosCadastrais";
            pnlCtrlDadosCadastrais.Size = new Size(325, 4);
            pnlCtrlDadosCadastrais.TabIndex = 129;
            // 
            // pnlCtrlFaturas
            // 
            pnlCtrlFaturas.BackColor = Color.LimeGreen;
            pnlCtrlFaturas.Location = new Point(0, 653);
            pnlCtrlFaturas.Margin = new Padding(0, 2, 0, 0);
            pnlCtrlFaturas.Name = "pnlCtrlFaturas";
            pnlCtrlFaturas.Size = new Size(11, 122);
            pnlCtrlFaturas.TabIndex = 125;
            pnlCtrlFaturas.Visible = false;
            // 
            // btnFaturas
            // 
            btnFaturas.BackColor = Color.SteelBlue;
            btnFaturas.Cursor = Cursors.Hand;
            btnFaturas.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnFaturas.FlatAppearance.BorderSize = 0;
            btnFaturas.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFaturas.FlatStyle = FlatStyle.Flat;
            btnFaturas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFaturas.ForeColor = Color.Black;
            btnFaturas.Image = Properties.Resources.invoiceIcon;
            btnFaturas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFaturas.Location = new Point(0, 653);
            btnFaturas.Margin = new Padding(0);
            btnFaturas.Name = "btnFaturas";
            btnFaturas.Padding = new Padding(17, 0, 0, 0);
            btnFaturas.Size = new Size(433, 124);
            btnFaturas.TabIndex = 2;
            btnFaturas.Text = "    Faturas";
            btnFaturas.TextAlign = ContentAlignment.MiddleLeft;
            btnFaturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpMenu.SetToolTip(btnFaturas, "Faturas");
            btnFaturas.UseVisualStyleBackColor = false;
            btnFaturas.Click += MenuButtonClick;
            // 
            // btnDadosCadastrais
            // 
            btnDadosCadastrais.BackColor = Color.SteelBlue;
            btnDadosCadastrais.Cursor = Cursors.Hand;
            btnDadosCadastrais.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnDadosCadastrais.FlatAppearance.BorderSize = 0;
            btnDadosCadastrais.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDadosCadastrais.FlatStyle = FlatStyle.Flat;
            btnDadosCadastrais.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Italic, GraphicsUnit.Point);
            btnDadosCadastrais.ForeColor = Color.Black;
            btnDadosCadastrais.ImageAlign = ContentAlignment.MiddleLeft;
            btnDadosCadastrais.Location = new Point(0, 333);
            btnDadosCadastrais.Margin = new Padding(7, 6, 7, 6);
            btnDadosCadastrais.Name = "btnDadosCadastrais";
            btnDadosCadastrais.Size = new Size(433, 49);
            btnDadosCadastrais.TabIndex = 0;
            btnDadosCadastrais.Text = "Carregando...";
            btnDadosCadastrais.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpMenu.SetToolTip(btnDadosCadastrais, "Dashboard");
            ttpSempre.SetToolTip(btnDadosCadastrais, "Dados Cadastrais");
            btnDadosCadastrais.UseVisualStyleBackColor = false;
            btnDadosCadastrais.Click += MenuButtonClick;
            // 
            // imgLogo
            // 
            imgLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgLogo.Image = Properties.Resources.suaLogoAqui;
            imgLogo.Location = new Point(130, 134);
            imgLogo.Margin = new Padding(7, 6, 7, 6);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(173, 196);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 17;
            imgLogo.TabStop = false;
            // 
            // btnAgencias
            // 
            btnAgencias.BackColor = Color.SteelBlue;
            btnAgencias.Cursor = Cursors.Hand;
            btnAgencias.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAgencias.FlatAppearance.BorderSize = 0;
            btnAgencias.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgencias.FlatStyle = FlatStyle.Flat;
            btnAgencias.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgencias.ForeColor = Color.Black;
            btnAgencias.Image = Properties.Resources.branchIcon;
            btnAgencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgencias.Location = new Point(0, 898);
            btnAgencias.Margin = new Padding(0);
            btnAgencias.Name = "btnAgencias";
            btnAgencias.Padding = new Padding(17, 0, 0, 0);
            btnAgencias.Size = new Size(433, 124);
            btnAgencias.TabIndex = 4;
            btnAgencias.Text = "    Agências";
            btnAgencias.TextAlign = ContentAlignment.MiddleLeft;
            btnAgencias.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpMenu.SetToolTip(btnAgencias, "Agências");
            btnAgencias.UseVisualStyleBackColor = false;
            btnAgencias.Click += MenuButtonClick;
            // 
            // btnAtividades
            // 
            btnAtividades.BackColor = Color.SteelBlue;
            btnAtividades.Cursor = Cursors.Hand;
            btnAtividades.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAtividades.FlatAppearance.BorderSize = 0;
            btnAtividades.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAtividades.FlatStyle = FlatStyle.Flat;
            btnAtividades.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtividades.ForeColor = Color.Black;
            btnAtividades.Image = Properties.Resources.servicesIcon;
            btnAtividades.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtividades.Location = new Point(0, 774);
            btnAtividades.Margin = new Padding(0);
            btnAtividades.Name = "btnAtividades";
            btnAtividades.Padding = new Padding(17, 0, 0, 0);
            btnAtividades.Size = new Size(433, 124);
            btnAtividades.TabIndex = 3;
            btnAtividades.Text = "    Atividades";
            btnAtividades.TextAlign = ContentAlignment.MiddleLeft;
            btnAtividades.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpMenu.SetToolTip(btnAtividades, "Atividades");
            btnAtividades.UseVisualStyleBackColor = false;
            btnAtividades.Click += MenuButtonClick;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(433, 0);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1888, 1493);
            pnlMain.TabIndex = 161;
            // 
            // ttpMenu
            // 
            ttpMenu.Active = false;
            ttpMenu.AutomaticDelay = 50;
            ttpMenu.AutoPopDelay = 5000;
            ttpMenu.InitialDelay = 50;
            ttpMenu.ReshowDelay = 10;
            // 
            // ttpSempre
            // 
            ttpSempre.AutomaticDelay = 50;
            ttpSempre.AutoPopDelay = 5000;
            ttpSempre.InitialDelay = 50;
            ttpSempre.ReshowDelay = 10;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(2321, 1493);
            Controls.Add(pnlMain);
            Controls.Add(pnlMenu);
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fluxus";
            Load += frmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnProfissionais;
        private Button btnAtividades;
        private Button btnAgencias;
        private Button btnOS;
        private ToolTip ttpMenu;
        private ToolTip ttpSempre;
        private Panel pnlCtrlOS;
        private Panel pnlCtrlAgencias;
        private Panel pnlCtrlAtividades;
        private Panel pnlCtrlProfissionais;
        public Panel pnlMain;
        private Panel pnlCtrlDadosCadastrais;
        private Button btnFaturas;
        private Panel pnlCtrlFaturas;
        public Button btnDadosCadastrais;
        private Label lblUsuario;
        private Label lblVersao;
        public PictureBox imgLogo;
    }
}

