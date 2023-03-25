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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlCtrlOS = new System.Windows.Forms.Panel();
            this.pnlCtrlProfissionais = new System.Windows.Forms.Panel();
            this.btnProfissionais = new System.Windows.Forms.Button();
            this.btnOS = new System.Windows.Forms.Button();
            this.pnlCtrlAtividades = new System.Windows.Forms.Panel();
            this.lblVersao = new System.Windows.Forms.Label();
            this.pnlCtrlAgencias = new System.Windows.Forms.Panel();
            this.pnlCtrlDadosCadastrais = new System.Windows.Forms.Panel();
            this.pnlCtrlFaturas = new System.Windows.Forms.Panel();
            this.btnFaturas = new System.Windows.Forms.Button();
            this.btnDadosCadastrais = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnAgencias = new System.Windows.Forms.Button();
            this.btnAtividades = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ttpMenu = new System.Windows.Forms.ToolTip(this.components);
            this.ttpSempre = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.lblUsuario);
            this.pnlMenu.Controls.Add(this.pnlCtrlOS);
            this.pnlMenu.Controls.Add(this.pnlCtrlProfissionais);
            this.pnlMenu.Controls.Add(this.btnProfissionais);
            this.pnlMenu.Controls.Add(this.btnOS);
            this.pnlMenu.Controls.Add(this.pnlCtrlAtividades);
            this.pnlMenu.Controls.Add(this.lblVersao);
            this.pnlMenu.Controls.Add(this.pnlCtrlAgencias);
            this.pnlMenu.Controls.Add(this.pnlCtrlDadosCadastrais);
            this.pnlMenu.Controls.Add(this.pnlCtrlFaturas);
            this.pnlMenu.Controls.Add(this.btnFaturas);
            this.pnlMenu.Controls.Add(this.btnDadosCadastrais);
            this.pnlMenu.Controls.Add(this.imgLogo);
            this.pnlMenu.Controls.Add(this.btnAgencias);
            this.pnlMenu.Controls.Add(this.btnAtividades);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(433, 1493);
            this.pnlMenu.TabIndex = 160;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(0, 1453);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(290, 32);
            this.lblUsuario.TabIndex = 126;
            this.lblUsuario.Text = "Usuário: null";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCtrlOS
            // 
            this.pnlCtrlOS.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlOS.Location = new System.Drawing.Point(0, 529);
            this.pnlCtrlOS.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlOS.Name = "pnlCtrlOS";
            this.pnlCtrlOS.Size = new System.Drawing.Size(11, 124);
            this.pnlCtrlOS.TabIndex = 126;
            this.pnlCtrlOS.Visible = false;
            // 
            // pnlCtrlProfissionais
            // 
            this.pnlCtrlProfissionais.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlProfissionais.Location = new System.Drawing.Point(0, 1022);
            this.pnlCtrlProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlProfissionais.Name = "pnlCtrlProfissionais";
            this.pnlCtrlProfissionais.Size = new System.Drawing.Size(11, 124);
            this.pnlCtrlProfissionais.TabIndex = 123;
            this.pnlCtrlProfissionais.Visible = false;
            // 
            // btnProfissionais
            // 
            this.btnProfissionais.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfissionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfissionais.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProfissionais.FlatAppearance.BorderSize = 0;
            this.btnProfissionais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfissionais.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfissionais.ForeColor = System.Drawing.Color.Black;
            this.btnProfissionais.Image = ((System.Drawing.Image)(resources.GetObject("btnProfissionais.Image")));
            this.btnProfissionais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfissionais.Location = new System.Drawing.Point(0, 1022);
            this.btnProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfissionais.Name = "btnProfissionais";
            this.btnProfissionais.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnProfissionais.Size = new System.Drawing.Size(433, 124);
            this.btnProfissionais.TabIndex = 5;
            this.btnProfissionais.Text = "    Profissionais";
            this.btnProfissionais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfissionais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnProfissionais, "Profissionais");
            this.btnProfissionais.UseVisualStyleBackColor = false;
            this.btnProfissionais.Click += new System.EventHandler(this.MenuButtonClick);
            // 
            // btnOS
            // 
            this.btnOS.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOS.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOS.FlatAppearance.BorderSize = 0;
            this.btnOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOS.ForeColor = System.Drawing.Color.Black;
            this.btnOS.Image = ((System.Drawing.Image)(resources.GetObject("btnOS.Image")));
            this.btnOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOS.Location = new System.Drawing.Point(0, 529);
            this.btnOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnOS.Name = "btnOS";
            this.btnOS.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnOS.Size = new System.Drawing.Size(433, 124);
            this.btnOS.TabIndex = 1;
            this.btnOS.Text = "    Ordens de Serviços";
            this.btnOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnOS, "Ordens de Serviço");
            this.btnOS.UseVisualStyleBackColor = false;
            this.btnOS.Click += new System.EventHandler(this.MenuButtonClick);
            // 
            // pnlCtrlAtividades
            // 
            this.pnlCtrlAtividades.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlAtividades.Location = new System.Drawing.Point(0, 774);
            this.pnlCtrlAtividades.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlAtividades.Name = "pnlCtrlAtividades";
            this.pnlCtrlAtividades.Size = new System.Drawing.Size(11, 124);
            this.pnlCtrlAtividades.TabIndex = 124;
            this.pnlCtrlAtividades.Visible = false;
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(303, 1453);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(130, 32);
            this.lblVersao.TabIndex = 134;
            this.lblVersao.Text = "v. ---";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCtrlAgencias
            // 
            this.pnlCtrlAgencias.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlAgencias.Location = new System.Drawing.Point(0, 898);
            this.pnlCtrlAgencias.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlAgencias.Name = "pnlCtrlAgencias";
            this.pnlCtrlAgencias.Size = new System.Drawing.Size(11, 124);
            this.pnlCtrlAgencias.TabIndex = 125;
            this.pnlCtrlAgencias.Visible = false;
            // 
            // pnlCtrlDadosCadastrais
            // 
            this.pnlCtrlDadosCadastrais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCtrlDadosCadastrais.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlDadosCadastrais.Location = new System.Drawing.Point(54, 384);
            this.pnlCtrlDadosCadastrais.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlCtrlDadosCadastrais.Name = "pnlCtrlDadosCadastrais";
            this.pnlCtrlDadosCadastrais.Size = new System.Drawing.Size(325, 4);
            this.pnlCtrlDadosCadastrais.TabIndex = 129;
            // 
            // pnlCtrlFaturas
            // 
            this.pnlCtrlFaturas.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlFaturas.Location = new System.Drawing.Point(0, 653);
            this.pnlCtrlFaturas.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlCtrlFaturas.Name = "pnlCtrlFaturas";
            this.pnlCtrlFaturas.Size = new System.Drawing.Size(11, 122);
            this.pnlCtrlFaturas.TabIndex = 125;
            this.pnlCtrlFaturas.Visible = false;
            // 
            // btnFaturas
            // 
            this.btnFaturas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFaturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturas.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFaturas.FlatAppearance.BorderSize = 0;
            this.btnFaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFaturas.ForeColor = System.Drawing.Color.Black;
            this.btnFaturas.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturas.Image")));
            this.btnFaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturas.Location = new System.Drawing.Point(0, 653);
            this.btnFaturas.Margin = new System.Windows.Forms.Padding(0);
            this.btnFaturas.Name = "btnFaturas";
            this.btnFaturas.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnFaturas.Size = new System.Drawing.Size(433, 124);
            this.btnFaturas.TabIndex = 2;
            this.btnFaturas.Text = "    Faturas";
            this.btnFaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnFaturas, "Faturas");
            this.btnFaturas.UseVisualStyleBackColor = false;
            this.btnFaturas.Click += new System.EventHandler(this.MenuButtonClick);
            // 
            // btnDadosCadastrais
            // 
            this.btnDadosCadastrais.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDadosCadastrais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosCadastrais.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDadosCadastrais.FlatAppearance.BorderSize = 0;
            this.btnDadosCadastrais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDadosCadastrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosCadastrais.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnDadosCadastrais.ForeColor = System.Drawing.Color.Black;
            this.btnDadosCadastrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDadosCadastrais.Location = new System.Drawing.Point(0, 333);
            this.btnDadosCadastrais.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDadosCadastrais.Name = "btnDadosCadastrais";
            this.btnDadosCadastrais.Size = new System.Drawing.Size(433, 49);
            this.btnDadosCadastrais.TabIndex = 0;
            this.btnDadosCadastrais.Text = "Carregando...";
            this.btnDadosCadastrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnDadosCadastrais, "Dashboard");
            this.ttpSempre.SetToolTip(this.btnDadosCadastrais, "Dados Cadastrais");
            this.btnDadosCadastrais.UseVisualStyleBackColor = false;
            this.btnDadosCadastrais.Click += new System.EventHandler(this.MenuButtonClick);
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(130, 134);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(173, 196);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 17;
            this.imgLogo.TabStop = false;
            // 
            // btnAgencias
            // 
            this.btnAgencias.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgencias.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgencias.FlatAppearance.BorderSize = 0;
            this.btnAgencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAgencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgencias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgencias.ForeColor = System.Drawing.Color.Black;
            this.btnAgencias.Image = ((System.Drawing.Image)(resources.GetObject("btnAgencias.Image")));
            this.btnAgencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgencias.Location = new System.Drawing.Point(0, 898);
            this.btnAgencias.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgencias.Name = "btnAgencias";
            this.btnAgencias.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAgencias.Size = new System.Drawing.Size(433, 124);
            this.btnAgencias.TabIndex = 4;
            this.btnAgencias.Text = "    Agências";
            this.btnAgencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnAgencias, "Agências");
            this.btnAgencias.UseVisualStyleBackColor = false;
            this.btnAgencias.Click += new System.EventHandler(this.MenuButtonClick);
            // 
            // btnAtividades
            // 
            this.btnAtividades.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtividades.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAtividades.FlatAppearance.BorderSize = 0;
            this.btnAtividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtividades.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtividades.ForeColor = System.Drawing.Color.Black;
            this.btnAtividades.Image = ((System.Drawing.Image)(resources.GetObject("btnAtividades.Image")));
            this.btnAtividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtividades.Location = new System.Drawing.Point(0, 774);
            this.btnAtividades.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAtividades.Size = new System.Drawing.Size(433, 124);
            this.btnAtividades.TabIndex = 3;
            this.btnAtividades.Text = "    Atividades";
            this.btnAtividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnAtividades, "Atividades");
            this.btnAtividades.UseVisualStyleBackColor = false;
            this.btnAtividades.Click += new System.EventHandler(this.MenuButtonClick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(433, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1888, 1493);
            this.pnlMain.TabIndex = 161;
            // 
            // ttpMenu
            // 
            this.ttpMenu.Active = false;
            this.ttpMenu.AutomaticDelay = 50;
            this.ttpMenu.AutoPopDelay = 5000;
            this.ttpMenu.InitialDelay = 50;
            this.ttpMenu.ReshowDelay = 10;
            // 
            // ttpSempre
            // 
            this.ttpSempre.AutomaticDelay = 50;
            this.ttpSempre.AutoPopDelay = 5000;
            this.ttpSempre.InitialDelay = 50;
            this.ttpSempre.ReshowDelay = 10;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(2321, 1493);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxus";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnProfissionais;
        private System.Windows.Forms.Button btnAtividades;
        private System.Windows.Forms.Button btnAgencias;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ToolTip ttpMenu;
        private System.Windows.Forms.ToolTip ttpSempre;
        private System.Windows.Forms.Panel pnlCtrlOS;
        private System.Windows.Forms.Panel pnlCtrlAgencias;
        private System.Windows.Forms.Panel pnlCtrlAtividades;
        private System.Windows.Forms.Panel pnlCtrlProfissionais;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCtrlDadosCadastrais;
        private System.Windows.Forms.Button btnFaturas;
        private System.Windows.Forms.Panel pnlCtrlFaturas;
        public System.Windows.Forms.Button btnDadosCadastrais;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblVersao;
    }
}

