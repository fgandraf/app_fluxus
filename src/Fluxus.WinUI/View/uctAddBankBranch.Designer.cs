namespace Fluxus.WinUI.View
{
    partial class uctAddBankBranch
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
            txtTelefone2 = new MaskedTextBox();
            txtTelefone1 = new MaskedTextBox();
            txtEmail = new TextBox();
            lblContato = new Label();
            txtContato = new TextBox();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            cboUF = new ComboBox();
            lblUF = new Label();
            lblCEP = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            button1 = new Button();
            txtAgencia = new TextBox();
            lblAgencia = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnCancelar = new Button();
            btnAddSave = new Button();
            txtCEP = new MaskedTextBox();
            panel1 = new Panel();
            pnlMainAddAgencia = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pnlTitLinhaContato = new Panel();
            lblTitContato = new Label();
            lblTelefone1 = new Label();
            lblEmail = new Label();
            lblTelefone2 = new Label();
            panel1.SuspendLayout();
            pnlMainAddAgencia.SuspendLayout();
            SuspendLayout();
            // 
            // txtTelefone2
            // 
            txtTelefone2.Anchor = AnchorStyles.Top;
            txtTelefone2.BackColor = Color.White;
            txtTelefone2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone2.ForeColor = Color.Black;
            txtTelefone2.Location = new Point(1140, 1150);
            txtTelefone2.Margin = new Padding(6, 7, 6, 7);
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.Size = new Size(320, 39);
            txtTelefone2.TabIndex = 10;
            txtTelefone2.Tag = "telefone";
            txtTelefone2.Enter += OnEnter_MaskedTextBox;
            txtTelefone2.Validated += OnValidated_MaskedTextBox;
            // 
            // txtTelefone1
            // 
            txtTelefone1.Anchor = AnchorStyles.Top;
            txtTelefone1.BackColor = Color.White;
            txtTelefone1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone1.ForeColor = Color.Black;
            txtTelefone1.Location = new Point(653, 1150);
            txtTelefone1.Margin = new Padding(6, 7, 6, 7);
            txtTelefone1.Name = "txtTelefone1";
            txtTelefone1.Size = new Size(320, 39);
            txtTelefone1.TabIndex = 9;
            txtTelefone1.Tag = "telefone";
            txtTelefone1.Enter += OnEnter_MaskedTextBox;
            txtTelefone1.Validated += OnValidated_MaskedTextBox;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.White;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(653, 1258);
            txtEmail.Margin = new Padding(6, 7, 6, 7);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(808, 39);
            txtEmail.TabIndex = 11;
            // 
            // lblContato
            // 
            lblContato.Anchor = AnchorStyles.Top;
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContato.ForeColor = SystemColors.ControlDarkDark;
            lblContato.Location = new Point(455, 1037);
            lblContato.Margin = new Padding(6, 0, 6, 0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(73, 30);
            lblContato.TabIndex = 254;
            lblContato.Text = "Nome";
            // 
            // txtContato
            // 
            txtContato.Anchor = AnchorStyles.Top;
            txtContato.BackColor = Color.White;
            txtContato.CharacterCasing = CharacterCasing.Upper;
            txtContato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContato.ForeColor = Color.Black;
            txtContato.Location = new Point(653, 1041);
            txtContato.Margin = new Padding(6, 7, 6, 7);
            txtContato.MaxLength = 20;
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(808, 39);
            txtContato.TabIndex = 8;
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.Top;
            txtEndereco.BackColor = Color.White;
            txtEndereco.CharacterCasing = CharacterCasing.Upper;
            txtEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.ForeColor = Color.Black;
            txtEndereco.Location = new Point(653, 479);
            txtEndereco.Margin = new Padding(6, 7, 6, 7);
            txtEndereco.MaxLength = 100;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(808, 39);
            txtEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.Anchor = AnchorStyles.Top;
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereco.ForeColor = SystemColors.ControlDarkDark;
            lblEndereco.Location = new Point(455, 484);
            lblEndereco.Margin = new Padding(6, 0, 6, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(104, 30);
            lblEndereco.TabIndex = 253;
            lblEndereco.Text = "Endereço";
            // 
            // cboUF
            // 
            cboUF.Anchor = AnchorStyles.Top;
            cboUF.BackColor = Color.White;
            cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboUF.ForeColor = Color.Black;
            cboUF.FormattingEnabled = true;
            cboUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboUF.Location = new Point(1301, 774);
            cboUF.Margin = new Padding(6, 7, 6, 7);
            cboUF.MaxLength = 2;
            cboUF.Name = "cboUF";
            cboUF.Size = new Size(158, 40);
            cboUF.TabIndex = 7;
            // 
            // lblUF
            // 
            lblUF.Anchor = AnchorStyles.Top;
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUF.ForeColor = SystemColors.ControlDarkDark;
            lblUF.Location = new Point(1229, 784);
            lblUF.Margin = new Padding(6, 0, 6, 0);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(39, 30);
            lblUF.TabIndex = 252;
            lblUF.Text = "UF";
            // 
            // lblCEP
            // 
            lblCEP.Anchor = AnchorStyles.Top;
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCEP.ForeColor = SystemColors.ControlDarkDark;
            lblCEP.Location = new Point(455, 390);
            lblCEP.Margin = new Padding(6, 0, 6, 0);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(50, 30);
            lblCEP.TabIndex = 251;
            lblCEP.Text = "CEP";
            // 
            // lblCidade
            // 
            lblCidade.Anchor = AnchorStyles.Top;
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCidade.ForeColor = SystemColors.ControlDarkDark;
            lblCidade.Location = new Point(458, 784);
            lblCidade.Margin = new Padding(6, 0, 6, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(81, 30);
            lblCidade.TabIndex = 250;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top;
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBairro.ForeColor = SystemColors.ControlDarkDark;
            lblBairro.Location = new Point(458, 682);
            lblBairro.Margin = new Padding(6, 0, 6, 0);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(71, 30);
            lblBairro.TabIndex = 249;
            lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top;
            txtCidade.BackColor = Color.White;
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.ForeColor = Color.Black;
            txtCidade.Location = new Point(653, 775);
            txtCidade.Margin = new Padding(6, 7, 6, 7);
            txtCidade.MaxLength = 100;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(471, 39);
            txtCidade.TabIndex = 6;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top;
            txtBairro.BackColor = Color.White;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.ForeColor = Color.Black;
            txtBairro.Location = new Point(653, 677);
            txtBairro.Margin = new Padding(6, 7, 6, 7);
            txtBairro.MaxLength = 100;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(808, 39);
            txtBairro.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top;
            txtComplemento.BackColor = Color.White;
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.ForeColor = Color.Black;
            txtComplemento.Location = new Point(653, 581);
            txtComplemento.Margin = new Padding(6, 7, 6, 7);
            txtComplemento.MaxLength = 100;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(808, 39);
            txtComplemento.TabIndex = 4;
            // 
            // lblComplemento
            // 
            lblComplemento.Anchor = AnchorStyles.Top;
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblComplemento.ForeColor = SystemColors.ControlDarkDark;
            lblComplemento.Location = new Point(458, 586);
            lblComplemento.Margin = new Padding(6, 0, 6, 0);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(152, 30);
            lblComplemento.TabIndex = 248;
            lblComplemento.Text = "Complemento";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(698, 564);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 247;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtAgencia
            // 
            txtAgencia.Anchor = AnchorStyles.Top;
            txtAgencia.BackColor = Color.White;
            txtAgencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgencia.ForeColor = Color.Black;
            txtAgencia.Location = new Point(653, 101);
            txtAgencia.Margin = new Padding(6, 7, 6, 7);
            txtAgencia.MaxLength = 4;
            txtAgencia.Name = "txtAgencia";
            txtAgencia.Size = new Size(212, 39);
            txtAgencia.TabIndex = 0;
            // 
            // lblAgencia
            // 
            lblAgencia.Anchor = AnchorStyles.Top;
            lblAgencia.AutoSize = true;
            lblAgencia.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgencia.ForeColor = SystemColors.ControlDarkDark;
            lblAgencia.Location = new Point(458, 111);
            lblAgencia.Margin = new Padding(6, 0, 6, 0);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(105, 30);
            lblAgencia.TabIndex = 246;
            lblAgencia.Text = "* Agência";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top;
            txtNome.BackColor = Color.White;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(1127, 101);
            txtNome.Margin = new Padding(6, 7, 6, 7);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(333, 39);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlDarkDark;
            lblNome.Location = new Point(1012, 111);
            lblNome.Margin = new Padding(6, 0, 6, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(73, 30);
            lblNome.TabIndex = 245;
            lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(1205, 32);
            btnCancelar.Margin = new Padding(6, 7, 6, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(271, 62);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAddSave
            // 
            btnAddSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddSave.BackColor = Color.MediumBlue;
            btnAddSave.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnAddSave.FlatStyle = FlatStyle.Flat;
            btnAddSave.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSave.ForeColor = SystemColors.Control;
            btnAddSave.Location = new Point(1488, 32);
            btnAddSave.Margin = new Padding(6, 7, 6, 7);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(433, 62);
            btnAddSave.TabIndex = 0;
            btnAddSave.Text = "&Salvar";
            btnAddSave.UseVisualStyleBackColor = false;
            btnAddSave.Click += btnAddSave_Click;
            // 
            // txtCEP
            // 
            txtCEP.Anchor = AnchorStyles.Top;
            txtCEP.BackColor = Color.White;
            txtCEP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.ForeColor = Color.Black;
            txtCEP.Location = new Point(653, 380);
            txtCEP.Margin = new Padding(6, 7, 6, 7);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(320, 39);
            txtCEP.TabIndex = 2;
            txtCEP.Tag = "cep";
            txtCEP.Enter += OnEnter_MaskedTextBox;
            txtCEP.Leave += txtCEP_Leave;
            txtCEP.Validated += OnValidated_MaskedTextBox;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(btnAddSave);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1305);
            panel1.Margin = new Padding(6, 7, 6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1993, 123);
            panel1.TabIndex = 1;
            // 
            // pnlMainAddAgencia
            // 
            pnlMainAddAgencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMainAddAgencia.AutoScroll = true;
            pnlMainAddAgencia.Controls.Add(panel2);
            pnlMainAddAgencia.Controls.Add(panel3);
            pnlMainAddAgencia.Controls.Add(label1);
            pnlMainAddAgencia.Controls.Add(pnlTitLinhaContato);
            pnlMainAddAgencia.Controls.Add(lblTitContato);
            pnlMainAddAgencia.Controls.Add(lblTelefone1);
            pnlMainAddAgencia.Controls.Add(lblEmail);
            pnlMainAddAgencia.Controls.Add(lblTelefone2);
            pnlMainAddAgencia.Controls.Add(lblAgencia);
            pnlMainAddAgencia.Controls.Add(lblNome);
            pnlMainAddAgencia.Controls.Add(txtCEP);
            pnlMainAddAgencia.Controls.Add(txtNome);
            pnlMainAddAgencia.Controls.Add(txtAgencia);
            pnlMainAddAgencia.Controls.Add(txtTelefone2);
            pnlMainAddAgencia.Controls.Add(button1);
            pnlMainAddAgencia.Controls.Add(txtTelefone1);
            pnlMainAddAgencia.Controls.Add(lblComplemento);
            pnlMainAddAgencia.Controls.Add(txtComplemento);
            pnlMainAddAgencia.Controls.Add(txtBairro);
            pnlMainAddAgencia.Controls.Add(txtCidade);
            pnlMainAddAgencia.Controls.Add(txtEmail);
            pnlMainAddAgencia.Controls.Add(lblBairro);
            pnlMainAddAgencia.Controls.Add(lblContato);
            pnlMainAddAgencia.Controls.Add(lblCidade);
            pnlMainAddAgencia.Controls.Add(txtContato);
            pnlMainAddAgencia.Controls.Add(lblCEP);
            pnlMainAddAgencia.Controls.Add(txtEndereco);
            pnlMainAddAgencia.Controls.Add(lblUF);
            pnlMainAddAgencia.Controls.Add(lblEndereco);
            pnlMainAddAgencia.Controls.Add(cboUF);
            pnlMainAddAgencia.Location = new Point(0, 0);
            pnlMainAddAgencia.Margin = new Padding(6, 7, 6, 7);
            pnlMainAddAgencia.Name = "pnlMainAddAgencia";
            pnlMainAddAgencia.Size = new Size(1993, 1304);
            pnlMainAddAgencia.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(493, 1350);
            panel2.Margin = new Padding(6, 7, 6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 2);
            panel2.TabIndex = 294;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Location = new Point(384, 310);
            panel3.Margin = new Padding(6, 7, 6, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(1192, 2);
            panel3.TabIndex = 293;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(384, 244);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 292;
            label1.Text = "Endereço";
            // 
            // pnlTitLinhaContato
            // 
            pnlTitLinhaContato.Anchor = AnchorStyles.Top;
            pnlTitLinhaContato.BackColor = SystemColors.ControlDark;
            pnlTitLinhaContato.Location = new Point(384, 973);
            pnlTitLinhaContato.Margin = new Padding(6, 7, 6, 7);
            pnlTitLinhaContato.Name = "pnlTitLinhaContato";
            pnlTitLinhaContato.Size = new Size(1192, 2);
            pnlTitLinhaContato.TabIndex = 288;
            // 
            // lblTitContato
            // 
            lblTitContato.Anchor = AnchorStyles.Top;
            lblTitContato.AutoSize = true;
            lblTitContato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitContato.ForeColor = Color.DimGray;
            lblTitContato.Location = new Point(384, 906);
            lblTitContato.Margin = new Padding(6, 0, 6, 0);
            lblTitContato.Name = "lblTitContato";
            lblTitContato.Size = new Size(105, 32);
            lblTitContato.TabIndex = 287;
            lblTitContato.Text = "Contato";
            // 
            // lblTelefone1
            // 
            lblTelefone1.Anchor = AnchorStyles.Top;
            lblTelefone1.AutoSize = true;
            lblTelefone1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone1.ForeColor = SystemColors.ControlDarkDark;
            lblTelefone1.Location = new Point(455, 1145);
            lblTelefone1.Margin = new Padding(6, 0, 6, 0);
            lblTelefone1.Name = "lblTelefone1";
            lblTelefone1.Size = new Size(114, 30);
            lblTelefone1.TabIndex = 289;
            lblTelefone1.Text = "Telefone 1";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlDarkDark;
            lblEmail.Location = new Point(455, 1253);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 30);
            lblEmail.TabIndex = 290;
            lblEmail.Text = "Email";
            // 
            // lblTelefone2
            // 
            lblTelefone2.Anchor = AnchorStyles.Top;
            lblTelefone2.AutoSize = true;
            lblTelefone2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone2.ForeColor = SystemColors.ControlDarkDark;
            lblTelefone2.Location = new Point(997, 1160);
            lblTelefone2.Margin = new Padding(6, 0, 6, 0);
            lblTelefone2.Name = "lblTelefone2";
            lblTelefone2.Size = new Size(114, 30);
            lblTelefone2.TabIndex = 291;
            lblTelefone2.Text = "Telefone 2";
            // 
            // uctAddBankBranch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(pnlMainAddAgencia);
            Controls.Add(panel1);
            Margin = new Padding(6, 7, 6, 7);
            Name = "uctAddBankBranch";
            Size = new Size(1993, 1428);
            Tag = "";
            Load += frmAddAgencia_Load;
            panel1.ResumeLayout(false);
            pnlMainAddAgencia.ResumeLayout(false);
            pnlMainAddAgencia.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel2;
    }
}