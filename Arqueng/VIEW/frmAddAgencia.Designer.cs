namespace Arqueng.VIEW
{
    partial class frmAddAgencia
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
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMainAddAgencia = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitLinhaContato = new System.Windows.Forms.Panel();
            this.lblTitContato = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMainAddAgencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone2.Location = new System.Drawing.Point(501, 422);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone2.TabIndex = 10;
            this.txtTelefone2.Enter += new System.EventHandler(this.txtTelefone2_Enter);
            this.txtTelefone2.Validated += new System.EventHandler(this.txtTelefone2_Validated);
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone1.Location = new System.Drawing.Point(309, 422);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone1.TabIndex = 9;
            this.txtTelefone1.Enter += new System.EventHandler(this.txtTelefone1_Enter);
            this.txtTelefone1.Validated += new System.EventHandler(this.txtTelefone1_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(309, 466);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(375, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // lblContato
            // 
            this.lblContato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContato.Location = new System.Drawing.Point(218, 376);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(37, 13);
            this.lblContato.TabIndex = 254;
            this.lblContato.Text = "Nome";
            // 
            // txtContato
            // 
            this.txtContato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContato.Location = new System.Drawing.Point(309, 378);
            this.txtContato.MaxLength = 20;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(375, 23);
            this.txtContato.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndereco.Location = new System.Drawing.Point(309, 148);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(375, 23);
            this.txtEndereco.TabIndex = 2;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEndereco.Location = new System.Drawing.Point(220, 152);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(55, 13);
            this.lblEndereco.TabIndex = 253;
            this.lblEndereco.Text = "Endereço";
            // 
            // cboUF
            // 
            this.cboUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboUF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboUF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUF.Location = new System.Drawing.Point(534, 280);
            this.cboUF.MaxLength = 2;
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(75, 23);
            this.cboUF.TabIndex = 7;
            // 
            // lblUF
            // 
            this.lblUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUF.Location = new System.Drawing.Point(475, 284);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 252;
            this.lblUF.Text = "UF";
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCEP.Location = new System.Drawing.Point(218, 284);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(26, 13);
            this.lblCEP.TabIndex = 251;
            this.lblCEP.Text = "CEP";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCidade.Location = new System.Drawing.Point(475, 240);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 250;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBairro.Location = new System.Drawing.Point(218, 240);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 249;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCidade.Location = new System.Drawing.Point(534, 236);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(150, 23);
            this.txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBairro.Location = new System.Drawing.Point(309, 236);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(150, 23);
            this.txtBairro.TabIndex = 4;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtComplemento.Location = new System.Drawing.Point(309, 192);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(375, 23);
            this.txtComplemento.TabIndex = 3;
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplemento.Location = new System.Drawing.Point(219, 196);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(79, 13);
            this.lblComplemento.TabIndex = 248;
            this.lblComplemento.Text = "Complemento";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(330, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 247;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAgencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgencia.Location = new System.Drawing.Point(309, 41);
            this.txtAgencia.MaxLength = 4;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 23);
            this.txtAgencia.TabIndex = 0;
            // 
            // lblAgencia
            // 
            this.lblAgencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAgencia.Location = new System.Drawing.Point(219, 45);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(56, 13);
            this.lblAgencia.TabIndex = 246;
            this.lblAgencia.Text = "* Agência";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(528, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(475, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(37, 13);
            this.lblNome.TabIndex = 245;
            this.lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(556, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSave.Location = new System.Drawing.Point(687, 13);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(200, 25);
            this.btnAddSave.TabIndex = 0;
            this.btnAddSave.Text = "&Adicionar";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCEP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCEP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCEP.Location = new System.Drawing.Point(309, 280);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(150, 23);
            this.txtCEP.TabIndex = 6;
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Enter);
            this.txtCEP.Validated += new System.EventHandler(this.txtCEP_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnAddSave);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 50);
            this.panel1.TabIndex = 1;
            // 
            // pnlMainAddAgencia
            // 
            this.pnlMainAddAgencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainAddAgencia.AutoScroll = true;
            this.pnlMainAddAgencia.Controls.Add(this.panel3);
            this.pnlMainAddAgencia.Controls.Add(this.label1);
            this.pnlMainAddAgencia.Controls.Add(this.pnlTitLinhaContato);
            this.pnlMainAddAgencia.Controls.Add(this.lblTitContato);
            this.pnlMainAddAgencia.Controls.Add(this.lblTelefone1);
            this.pnlMainAddAgencia.Controls.Add(this.lblEmail);
            this.pnlMainAddAgencia.Controls.Add(this.lblTelefone2);
            this.pnlMainAddAgencia.Controls.Add(this.lblAgencia);
            this.pnlMainAddAgencia.Controls.Add(this.lblNome);
            this.pnlMainAddAgencia.Controls.Add(this.txtCEP);
            this.pnlMainAddAgencia.Controls.Add(this.txtNome);
            this.pnlMainAddAgencia.Controls.Add(this.txtAgencia);
            this.pnlMainAddAgencia.Controls.Add(this.txtTelefone2);
            this.pnlMainAddAgencia.Controls.Add(this.button1);
            this.pnlMainAddAgencia.Controls.Add(this.txtTelefone1);
            this.pnlMainAddAgencia.Controls.Add(this.lblComplemento);
            this.pnlMainAddAgencia.Controls.Add(this.txtComplemento);
            this.pnlMainAddAgencia.Controls.Add(this.txtBairro);
            this.pnlMainAddAgencia.Controls.Add(this.txtCidade);
            this.pnlMainAddAgencia.Controls.Add(this.txtEmail);
            this.pnlMainAddAgencia.Controls.Add(this.lblBairro);
            this.pnlMainAddAgencia.Controls.Add(this.lblContato);
            this.pnlMainAddAgencia.Controls.Add(this.lblCidade);
            this.pnlMainAddAgencia.Controls.Add(this.txtContato);
            this.pnlMainAddAgencia.Controls.Add(this.lblCEP);
            this.pnlMainAddAgencia.Controls.Add(this.txtEndereco);
            this.pnlMainAddAgencia.Controls.Add(this.lblUF);
            this.pnlMainAddAgencia.Controls.Add(this.lblEndereco);
            this.pnlMainAddAgencia.Controls.Add(this.cboUF);
            this.pnlMainAddAgencia.Location = new System.Drawing.Point(0, 0);
            this.pnlMainAddAgencia.Name = "pnlMainAddAgencia";
            this.pnlMainAddAgencia.Size = new System.Drawing.Size(920, 530);
            this.pnlMainAddAgencia.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(185, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 1);
            this.panel3.TabIndex = 293;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(185, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 292;
            this.label1.Text = "Endereço";
            // 
            // pnlTitLinhaContato
            // 
            this.pnlTitLinhaContato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTitLinhaContato.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTitLinhaContato.Location = new System.Drawing.Point(185, 350);
            this.pnlTitLinhaContato.Name = "pnlTitLinhaContato";
            this.pnlTitLinhaContato.Size = new System.Drawing.Size(550, 1);
            this.pnlTitLinhaContato.TabIndex = 288;
            // 
            // lblTitContato
            // 
            this.lblTitContato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitContato.AutoSize = true;
            this.lblTitContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitContato.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitContato.Location = new System.Drawing.Point(185, 323);
            this.lblTitContato.Name = "lblTitContato";
            this.lblTitContato.Size = new System.Drawing.Size(51, 15);
            this.lblTitContato.TabIndex = 287;
            this.lblTitContato.Text = "Contato";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone1.Location = new System.Drawing.Point(218, 420);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone1.TabIndex = 289;
            this.lblTelefone1.Text = "Telefone 1";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(218, 464);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 290;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone2.Location = new System.Drawing.Point(425, 426);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone2.TabIndex = 291;
            this.lblTelefone2.Text = "Telefone 2";
            // 
            // frmAddAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.pnlMainAddAgencia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAgencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Adicionar Agência";
            this.Load += new System.EventHandler(this.frmAddAgencia_Load);
            this.panel1.ResumeLayout(false);
            this.pnlMainAddAgencia.ResumeLayout(false);
            this.pnlMainAddAgencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMainAddAgencia;
        private System.Windows.Forms.Panel pnlTitLinhaContato;
        private System.Windows.Forms.Label lblTitContato;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}