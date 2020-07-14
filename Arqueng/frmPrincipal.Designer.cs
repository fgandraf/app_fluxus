namespace Arqueng
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.Button();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCtrlDashboard = new System.Windows.Forms.Panel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.pnlCtrlOS = new System.Windows.Forms.Panel();
            this.btnOS = new System.Windows.Forms.Button();
            this.btnOSFluxo = new System.Windows.Forms.Button();
            this.btnOSLista = new System.Windows.Forms.Button();
            this.pnlCtrlFluxo = new System.Windows.Forms.Panel();
            this.pnlCtrlLista = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.pnlCtrlRelatorios = new System.Windows.Forms.Panel();
            this.btnProfissionais = new System.Windows.Forms.Button();
            this.btnAtividades = new System.Windows.Forms.Button();
            this.btnAgencias = new System.Windows.Forms.Button();
            this.pnlCtrlProfissionais = new System.Windows.Forms.Panel();
            this.pnlCtrlAtividades = new System.Windows.Forms.Panel();
            this.pnlCtrlAgencias = new System.Windows.Forms.Panel();
            this.btnFaturas = new System.Windows.Forms.Button();
            this.pnlCtrlFaturas = new System.Windows.Forms.Panel();
            this.pnlCtrlDadosCadastrais = new System.Windows.Forms.Panel();
            this.btnDadosCadastrais = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnAppMinimizar = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAppFechar = new System.Windows.Forms.Button();
            this.btnAppMaximizar = new System.Windows.Forms.Button();
            this.btnAppRestaurar = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ttpMenu = new System.Windows.Forms.ToolTip(this.components);
            this.ttpSempre = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlMenu.SuspendLayout();
            this.tblMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlMenu.Controls.Add(this.btnSlide);
            this.pnlMenu.Controls.Add(this.tblMenu);
            this.pnlMenu.Controls.Add(this.pnlCtrlDadosCadastrais);
            this.pnlMenu.Controls.Add(this.btnDadosCadastrais);
            this.pnlMenu.Controls.Add(this.imgLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 630);
            this.pnlMenu.TabIndex = 160;
            // 
            // btnSlide
            // 
            this.btnSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSlide.FlatAppearance.BorderSize = 0;
            this.btnSlide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSlide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(166, 13);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(20, 20);
            this.btnSlide.TabIndex = 133;
            this.ttpSempre.SetToolTip(this.btnSlide, "Recolher/Expandir Menu");
            this.btnSlide.UseVisualStyleBackColor = true;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // tblMenu
            // 
            this.tblMenu.AutoSize = true;
            this.tblMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblMenu.ColumnCount = 2;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tblMenu.Controls.Add(this.pnlCtrlDashboard, 0, 0);
            this.tblMenu.Controls.Add(this.btnDashBoard, 1, 0);
            this.tblMenu.Controls.Add(this.pnlCtrlOS, 0, 1);
            this.tblMenu.Controls.Add(this.btnOS, 1, 1);
            this.tblMenu.Controls.Add(this.btnOSFluxo, 1, 2);
            this.tblMenu.Controls.Add(this.btnOSLista, 1, 4);
            this.tblMenu.Controls.Add(this.pnlCtrlFluxo, 1, 3);
            this.tblMenu.Controls.Add(this.pnlCtrlLista, 1, 5);
            this.tblMenu.Controls.Add(this.btnRelatorios, 1, 10);
            this.tblMenu.Controls.Add(this.pnlCtrlRelatorios, 0, 10);
            this.tblMenu.Controls.Add(this.btnProfissionais, 1, 9);
            this.tblMenu.Controls.Add(this.btnAtividades, 1, 8);
            this.tblMenu.Controls.Add(this.btnAgencias, 1, 7);
            this.tblMenu.Controls.Add(this.pnlCtrlProfissionais, 0, 9);
            this.tblMenu.Controls.Add(this.pnlCtrlAtividades, 0, 8);
            this.tblMenu.Controls.Add(this.pnlCtrlAgencias, 0, 7);
            this.tblMenu.Controls.Add(this.btnFaturas, 1, 6);
            this.tblMenu.Controls.Add(this.pnlCtrlFaturas, 0, 6);
            this.tblMenu.Location = new System.Drawing.Point(0, 190);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 11;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMenu.Size = new System.Drawing.Size(200, 404);
            this.tblMenu.TabIndex = 132;
            // 
            // pnlCtrlDashboard
            // 
            this.pnlCtrlDashboard.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlCtrlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlDashboard.Name = "pnlCtrlDashboard";
            this.pnlCtrlDashboard.Size = new System.Drawing.Size(5, 50);
            this.pnlCtrlDashboard.TabIndex = 128;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(5, 0);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDashBoard.Size = new System.Drawing.Size(195, 50);
            this.btnDashBoard.TabIndex = 18;
            this.btnDashBoard.Text = "    Dashboard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnDashBoard, "Dashboard");
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // pnlCtrlOS
            // 
            this.pnlCtrlOS.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlOS.Location = new System.Drawing.Point(0, 50);
            this.pnlCtrlOS.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlOS.Name = "pnlCtrlOS";
            this.pnlCtrlOS.Size = new System.Drawing.Size(5, 50);
            this.pnlCtrlOS.TabIndex = 126;
            this.pnlCtrlOS.Visible = false;
            // 
            // btnOS
            // 
            this.btnOS.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOS.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOS.FlatAppearance.BorderSize = 0;
            this.btnOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOS.Image = ((System.Drawing.Image)(resources.GetObject("btnOS.Image")));
            this.btnOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOS.Location = new System.Drawing.Point(5, 50);
            this.btnOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnOS.Name = "btnOS";
            this.btnOS.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOS.Size = new System.Drawing.Size(195, 50);
            this.btnOS.TabIndex = 2;
            this.btnOS.Text = "    Ordens de Serviços";
            this.btnOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnOS, "Ordens de Serviço");
            this.btnOS.UseVisualStyleBackColor = false;
            this.btnOS.Click += new System.EventHandler(this.btnOS_Click);
            // 
            // btnOSFluxo
            // 
            this.btnOSFluxo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSFluxo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOSFluxo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOSFluxo.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSFluxo.FlatAppearance.BorderSize = 0;
            this.btnOSFluxo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSFluxo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSFluxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOSFluxo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOSFluxo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOSFluxo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOSFluxo.Location = new System.Drawing.Point(5, 100);
            this.btnOSFluxo.Margin = new System.Windows.Forms.Padding(0);
            this.btnOSFluxo.Name = "btnOSFluxo";
            this.btnOSFluxo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnOSFluxo.Size = new System.Drawing.Size(195, 25);
            this.btnOSFluxo.TabIndex = 132;
            this.btnOSFluxo.Text = "-- fluxo";
            this.btnOSFluxo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOSFluxo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnOSFluxo, "Ordens de Serviço");
            this.btnOSFluxo.UseVisualStyleBackColor = false;
            this.btnOSFluxo.Click += new System.EventHandler(this.btnOSFluxo_Click);
            // 
            // btnOSLista
            // 
            this.btnOSLista.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOSLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOSLista.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSLista.FlatAppearance.BorderSize = 0;
            this.btnOSLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOSLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOSLista.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOSLista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOSLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOSLista.Location = new System.Drawing.Point(5, 127);
            this.btnOSLista.Margin = new System.Windows.Forms.Padding(0);
            this.btnOSLista.Name = "btnOSLista";
            this.btnOSLista.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnOSLista.Size = new System.Drawing.Size(195, 25);
            this.btnOSLista.TabIndex = 133;
            this.btnOSLista.Text = "-- lista";
            this.btnOSLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOSLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnOSLista, "Ordens de Serviço");
            this.btnOSLista.UseVisualStyleBackColor = false;
            this.btnOSLista.Click += new System.EventHandler(this.btnOSLista_Click);
            // 
            // pnlCtrlFluxo
            // 
            this.pnlCtrlFluxo.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlFluxo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlFluxo.Location = new System.Drawing.Point(55, 125);
            this.pnlCtrlFluxo.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.pnlCtrlFluxo.Name = "pnlCtrlFluxo";
            this.pnlCtrlFluxo.Size = new System.Drawing.Size(145, 2);
            this.pnlCtrlFluxo.TabIndex = 134;
            this.pnlCtrlFluxo.Visible = false;
            // 
            // pnlCtrlLista
            // 
            this.pnlCtrlLista.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlLista.Location = new System.Drawing.Point(55, 152);
            this.pnlCtrlLista.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.pnlCtrlLista.Name = "pnlCtrlLista";
            this.pnlCtrlLista.Size = new System.Drawing.Size(145, 2);
            this.pnlCtrlLista.TabIndex = 135;
            this.pnlCtrlLista.Visible = false;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(5, 354);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(0);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(195, 50);
            this.btnRelatorios.TabIndex = 130;
            this.btnRelatorios.Text = "    Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnRelatorios, "Relatórios");
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Visible = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // pnlCtrlRelatorios
            // 
            this.pnlCtrlRelatorios.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlRelatorios.Location = new System.Drawing.Point(0, 354);
            this.pnlCtrlRelatorios.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlRelatorios.Name = "pnlCtrlRelatorios";
            this.pnlCtrlRelatorios.Size = new System.Drawing.Size(5, 50);
            this.pnlCtrlRelatorios.TabIndex = 131;
            this.pnlCtrlRelatorios.Visible = false;
            // 
            // btnProfissionais
            // 
            this.btnProfissionais.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProfissionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfissionais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfissionais.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProfissionais.FlatAppearance.BorderSize = 0;
            this.btnProfissionais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfissionais.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfissionais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfissionais.Image = ((System.Drawing.Image)(resources.GetObject("btnProfissionais.Image")));
            this.btnProfissionais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfissionais.Location = new System.Drawing.Point(5, 304);
            this.btnProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfissionais.Name = "btnProfissionais";
            this.btnProfissionais.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnProfissionais.Size = new System.Drawing.Size(195, 50);
            this.btnProfissionais.TabIndex = 5;
            this.btnProfissionais.Text = "    Profissionais";
            this.btnProfissionais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfissionais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnProfissionais, "Profissionais");
            this.btnProfissionais.UseVisualStyleBackColor = false;
            this.btnProfissionais.Click += new System.EventHandler(this.btnProfissionais_Click);
            // 
            // btnAtividades
            // 
            this.btnAtividades.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAtividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtividades.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAtividades.FlatAppearance.BorderSize = 0;
            this.btnAtividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtividades.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtividades.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtividades.Image = ((System.Drawing.Image)(resources.GetObject("btnAtividades.Image")));
            this.btnAtividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtividades.Location = new System.Drawing.Point(5, 254);
            this.btnAtividades.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAtividades.Size = new System.Drawing.Size(195, 50);
            this.btnAtividades.TabIndex = 4;
            this.btnAtividades.Text = "    Atividades";
            this.btnAtividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnAtividades, "Atividades");
            this.btnAtividades.UseVisualStyleBackColor = false;
            this.btnAtividades.Click += new System.EventHandler(this.btnAtividades_Click);
            // 
            // btnAgencias
            // 
            this.btnAgencias.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgencias.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgencias.FlatAppearance.BorderSize = 0;
            this.btnAgencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgencias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgencias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgencias.Image = ((System.Drawing.Image)(resources.GetObject("btnAgencias.Image")));
            this.btnAgencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgencias.Location = new System.Drawing.Point(5, 204);
            this.btnAgencias.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgencias.Name = "btnAgencias";
            this.btnAgencias.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgencias.Size = new System.Drawing.Size(195, 50);
            this.btnAgencias.TabIndex = 3;
            this.btnAgencias.Text = "    Agências";
            this.btnAgencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnAgencias, "Agências");
            this.btnAgencias.UseVisualStyleBackColor = false;
            this.btnAgencias.Click += new System.EventHandler(this.btnAgencias_Click);
            // 
            // pnlCtrlProfissionais
            // 
            this.pnlCtrlProfissionais.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlProfissionais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlProfissionais.Location = new System.Drawing.Point(0, 304);
            this.pnlCtrlProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlProfissionais.Name = "pnlCtrlProfissionais";
            this.pnlCtrlProfissionais.Size = new System.Drawing.Size(5, 50);
            this.pnlCtrlProfissionais.TabIndex = 123;
            this.pnlCtrlProfissionais.Visible = false;
            // 
            // pnlCtrlAtividades
            // 
            this.pnlCtrlAtividades.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlAtividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlAtividades.Location = new System.Drawing.Point(0, 254);
            this.pnlCtrlAtividades.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlAtividades.Name = "pnlCtrlAtividades";
            this.pnlCtrlAtividades.Size = new System.Drawing.Size(5, 50);
            this.pnlCtrlAtividades.TabIndex = 124;
            this.pnlCtrlAtividades.Visible = false;
            // 
            // pnlCtrlAgencias
            // 
            this.pnlCtrlAgencias.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlAgencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlAgencias.Location = new System.Drawing.Point(0, 204);
            this.pnlCtrlAgencias.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCtrlAgencias.Name = "pnlCtrlAgencias";
            this.pnlCtrlAgencias.Size = new System.Drawing.Size(5, 50);
            this.pnlCtrlAgencias.TabIndex = 125;
            this.pnlCtrlAgencias.Visible = false;
            // 
            // btnFaturas
            // 
            this.btnFaturas.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFaturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFaturas.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFaturas.FlatAppearance.BorderSize = 0;
            this.btnFaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFaturas.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturas.Image")));
            this.btnFaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturas.Location = new System.Drawing.Point(5, 154);
            this.btnFaturas.Margin = new System.Windows.Forms.Padding(0);
            this.btnFaturas.Name = "btnFaturas";
            this.btnFaturas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnFaturas.Size = new System.Drawing.Size(195, 50);
            this.btnFaturas.TabIndex = 3;
            this.btnFaturas.Text = "    Faturas";
            this.btnFaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnFaturas, "Faturas");
            this.btnFaturas.UseVisualStyleBackColor = false;
            this.btnFaturas.Click += new System.EventHandler(this.btnFaturas_Click);
            // 
            // pnlCtrlFaturas
            // 
            this.pnlCtrlFaturas.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlFaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlFaturas.Location = new System.Drawing.Point(0, 155);
            this.pnlCtrlFaturas.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.pnlCtrlFaturas.Name = "pnlCtrlFaturas";
            this.pnlCtrlFaturas.Size = new System.Drawing.Size(5, 49);
            this.pnlCtrlFaturas.TabIndex = 125;
            this.pnlCtrlFaturas.Visible = false;
            // 
            // pnlCtrlDadosCadastrais
            // 
            this.pnlCtrlDadosCadastrais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCtrlDadosCadastrais.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlCtrlDadosCadastrais.Location = new System.Drawing.Point(25, 156);
            this.pnlCtrlDadosCadastrais.Name = "pnlCtrlDadosCadastrais";
            this.pnlCtrlDadosCadastrais.Size = new System.Drawing.Size(150, 2);
            this.pnlCtrlDadosCadastrais.TabIndex = 129;
            // 
            // btnDadosCadastrais
            // 
            this.btnDadosCadastrais.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDadosCadastrais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosCadastrais.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDadosCadastrais.FlatAppearance.BorderSize = 0;
            this.btnDadosCadastrais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnDadosCadastrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosCadastrais.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosCadastrais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDadosCadastrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDadosCadastrais.Location = new System.Drawing.Point(-3, 135);
            this.btnDadosCadastrais.Name = "btnDadosCadastrais";
            this.btnDadosCadastrais.Size = new System.Drawing.Size(200, 20);
            this.btnDadosCadastrais.TabIndex = 128;
            this.btnDadosCadastrais.Text = "Dados Cadastrais";
            this.btnDadosCadastrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpMenu.SetToolTip(this.btnDadosCadastrais, "Dashboard");
            this.ttpSempre.SetToolTip(this.btnDadosCadastrais, "Dados Cadastrais");
            this.btnDadosCadastrais.UseVisualStyleBackColor = false;
            this.btnDadosCadastrais.Click += new System.EventHandler(this.btnDadosCadastrais_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(50, 55);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(100, 79);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 17;
            this.imgLogo.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Lavender;
            this.pnlTitulo.Controls.Add(this.btnAppMinimizar);
            this.pnlTitulo.Controls.Add(this.btnUsuario);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.btnAppFechar);
            this.pnlTitulo.Controls.Add(this.btnAppMaximizar);
            this.pnlTitulo.Controls.Add(this.btnAppRestaurar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(200, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(920, 50);
            this.pnlTitulo.TabIndex = 2;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnAppMinimizar
            // 
            this.btnAppMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAppMinimizar.FlatAppearance.BorderSize = 0;
            this.btnAppMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMinimizar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAppMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAppMinimizar.Image")));
            this.btnAppMinimizar.Location = new System.Drawing.Point(786, -1);
            this.btnAppMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAppMinimizar.Name = "btnAppMinimizar";
            this.btnAppMinimizar.Size = new System.Drawing.Size(45, 30);
            this.btnAppMinimizar.TabIndex = 123;
            this.ttpSempre.SetToolTip(this.btnAppMinimizar, "Minimizar");
            this.btnAppMinimizar.UseVisualStyleBackColor = false;
            this.btnAppMinimizar.Click += new System.EventHandler(this.btnAppMinimizar_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Enabled = false;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnUsuario.Location = new System.Drawing.Point(745, 32);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(175, 18);
            this.btnUsuario.TabIndex = 121;
            this.btnUsuario.Text = "Nome do Usuário  ▼";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 37);
            this.lblTitulo.TabIndex = 120;
            this.lblTitulo.Text = "Dashboard";
            // 
            // btnAppFechar
            // 
            this.btnAppFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnAppFechar.FlatAppearance.BorderSize = 0;
            this.btnAppFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppFechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppFechar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAppFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnAppFechar.Image")));
            this.btnAppFechar.Location = new System.Drawing.Point(876, -1);
            this.btnAppFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAppFechar.Name = "btnAppFechar";
            this.btnAppFechar.Size = new System.Drawing.Size(45, 30);
            this.btnAppFechar.TabIndex = 114;
            this.ttpSempre.SetToolTip(this.btnAppFechar, "Fechar");
            this.btnAppFechar.UseVisualStyleBackColor = false;
            this.btnAppFechar.Click += new System.EventHandler(this.btnAppFechar_Click);
            // 
            // btnAppMaximizar
            // 
            this.btnAppMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAppMaximizar.FlatAppearance.BorderSize = 0;
            this.btnAppMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppMaximizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMaximizar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAppMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAppMaximizar.Image")));
            this.btnAppMaximizar.Location = new System.Drawing.Point(831, -1);
            this.btnAppMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAppMaximizar.Name = "btnAppMaximizar";
            this.btnAppMaximizar.Size = new System.Drawing.Size(45, 30);
            this.btnAppMaximizar.TabIndex = 122;
            this.ttpSempre.SetToolTip(this.btnAppMaximizar, "Maximizar");
            this.btnAppMaximizar.UseVisualStyleBackColor = false;
            this.btnAppMaximizar.Click += new System.EventHandler(this.btnAppMaximizar_Click);
            // 
            // btnAppRestaurar
            // 
            this.btnAppRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnAppRestaurar.FlatAppearance.BorderSize = 0;
            this.btnAppRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppRestaurar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppRestaurar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAppRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnAppRestaurar.Image")));
            this.btnAppRestaurar.Location = new System.Drawing.Point(831, -1);
            this.btnAppRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAppRestaurar.Name = "btnAppRestaurar";
            this.btnAppRestaurar.Size = new System.Drawing.Size(45, 30);
            this.btnAppRestaurar.TabIndex = 124;
            this.ttpSempre.SetToolTip(this.btnAppRestaurar, "Restaurar");
            this.btnAppRestaurar.UseVisualStyleBackColor = false;
            this.btnAppRestaurar.Visible = false;
            this.btnAppRestaurar.Click += new System.EventHandler(this.btnAppRestaurar_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 50);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(920, 580);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1120, 630);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arqueng";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.tblMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnProfissionais;
        private System.Windows.Forms.Button btnAtividades;
        private System.Windows.Forms.Button btnAgencias;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnAppFechar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ToolTip ttpMenu;
        private System.Windows.Forms.ToolTip ttpSempre;
        private System.Windows.Forms.Panel pnlCtrlOS;
        private System.Windows.Forms.Panel pnlCtrlAgencias;
        private System.Windows.Forms.Panel pnlCtrlAtividades;
        private System.Windows.Forms.Panel pnlCtrlProfissionais;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCtrlDadosCadastrais;
        private System.Windows.Forms.Panel pnlCtrlRelatorios;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnAppMaximizar;
        private System.Windows.Forms.Button btnAppMinimizar;
        private System.Windows.Forms.Button btnAppRestaurar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private System.Windows.Forms.Panel pnlCtrlDashboard;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnOSFluxo;
        private System.Windows.Forms.Button btnOSLista;
        private System.Windows.Forms.Panel pnlCtrlFluxo;
        private System.Windows.Forms.Panel pnlCtrlLista;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.Button btnFaturas;
        private System.Windows.Forms.Panel pnlCtrlFaturas;
        public System.Windows.Forms.Button btnDadosCadastrais;
        public System.Windows.Forms.Label lblTitulo;
    }
}

