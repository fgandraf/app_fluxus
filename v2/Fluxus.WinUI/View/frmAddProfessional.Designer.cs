namespace Fluxus.WinUI.View
{
    partial class frmAddProfessional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProfessional));
            txtCPF = new MaskedTextBox();
            lblDataNascimento = new Label();
            txtTelefone2 = new MaskedTextBox();
            txtTelefone1 = new MaskedTextBox();
            lblTelefone2 = new Label();
            lblEmail = new Label();
            lblTelefone1 = new Label();
            txtEmail = new TextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblCarteiraProfissional = new Label();
            txtCarteira = new TextBox();
            lblEntidadedeClasse = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtProfissao = new TextBox();
            lblProfissao = new Label();
            pnlLinha2 = new Panel();
            btnAddSave = new Button();
            btnCancelar = new Button();
            panel5 = new Panel();
            label2 = new Label();
            pnlTitLinhaContato = new Panel();
            lblTitContato = new Label();
            panel4 = new Panel();
            label1 = new Label();
            chkRT = new CheckBox();
            label3 = new Label();
            pnlMainAddProfissional = new Panel();
            dtpBirthday = new DateTimePicker();
            cboEntidade = new ComboBox();
            imgShowPwd = new PictureBox();
            imgHidePwd = new PictureBox();
            txtUsrSenha2 = new TextBox();
            txtUsrSenha = new TextBox();
            label10 = new Label();
            chkUsrAtivo = new CheckBox();
            panel3 = new Panel();
            label6 = new Label();
            txtUsrNome = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            chkRL = new CheckBox();
            panel1 = new Panel();
            ttpAddProfissional = new ToolTip(components);
            pnlLinha2.SuspendLayout();
            pnlMainAddProfissional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgShowPwd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHidePwd).BeginInit();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Anchor = AnchorStyles.Top;
            txtCPF.BackColor = Color.White;
            txtCPF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.ForeColor = Color.Black;
            txtCPF.Location = new Point(780, 640);
            txtCPF.Margin = new Padding(6, 7, 6, 7);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(266, 39);
            txtCPF.TabIndex = 4;
            txtCPF.Tag = "cpf";
            txtCPF.Enter += OnEnter_MaskedTextBox;
            txtCPF.Validated += OnValidated_MaskedTextBox;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.Top;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataNascimento.ForeColor = SystemColors.ControlDarkDark;
            lblDataNascimento.Location = new Point(1064, 650);
            lblDataNascimento.Margin = new Padding(6, 0, 6, 0);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(177, 30);
            lblDataNascimento.TabIndex = 284;
            lblDataNascimento.Text = "Data Nascimento";
            // 
            // txtTelefone2
            // 
            txtTelefone2.Anchor = AnchorStyles.Top;
            txtTelefone2.BackColor = Color.White;
            txtTelefone2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone2.ForeColor = Color.Black;
            txtTelefone2.Location = new Point(1237, 1413);
            txtTelefone2.Margin = new Padding(6, 7, 6, 7);
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.Size = new Size(255, 39);
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
            txtTelefone1.Location = new Point(780, 1413);
            txtTelefone1.Margin = new Padding(6, 7, 6, 7);
            txtTelefone1.Name = "txtTelefone1";
            txtTelefone1.Size = new Size(255, 39);
            txtTelefone1.TabIndex = 9;
            txtTelefone1.Tag = "telefone";
            txtTelefone1.Enter += OnEnter_MaskedTextBox;
            txtTelefone1.Validated += OnValidated_MaskedTextBox;
            // 
            // lblTelefone2
            // 
            lblTelefone2.Anchor = AnchorStyles.Top;
            lblTelefone2.AutoSize = true;
            lblTelefone2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone2.ForeColor = SystemColors.ControlDarkDark;
            lblTelefone2.Location = new Point(1094, 1423);
            lblTelefone2.Margin = new Padding(6, 0, 6, 0);
            lblTelefone2.Name = "lblTelefone2";
            lblTelefone2.Size = new Size(114, 30);
            lblTelefone2.TabIndex = 283;
            lblTelefone2.Text = "Telefone 2";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlDarkDark;
            lblEmail.Location = new Point(524, 1531);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 30);
            lblEmail.TabIndex = 282;
            lblEmail.Text = "Email";
            // 
            // lblTelefone1
            // 
            lblTelefone1.Anchor = AnchorStyles.Top;
            lblTelefone1.AutoSize = true;
            lblTelefone1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone1.ForeColor = SystemColors.ControlDarkDark;
            lblTelefone1.Location = new Point(524, 1423);
            lblTelefone1.Margin = new Padding(6, 0, 6, 0);
            lblTelefone1.Name = "lblTelefone1";
            lblTelefone1.Size = new Size(114, 30);
            lblTelefone1.TabIndex = 281;
            lblTelefone1.Text = "Telefone 1";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.White;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(780, 1521);
            txtEmail.Margin = new Padding(6, 7, 6, 7);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(712, 39);
            txtEmail.TabIndex = 11;
            // 
            // lblCPF
            // 
            lblCPF.Anchor = AnchorStyles.Top;
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCPF.ForeColor = SystemColors.ControlDarkDark;
            lblCPF.Location = new Point(524, 650);
            lblCPF.Margin = new Padding(6, 0, 6, 0);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(50, 30);
            lblCPF.TabIndex = 280;
            lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top;
            txtNome.BackColor = Color.White;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(780, 544);
            txtNome.Margin = new Padding(6, 7, 6, 7);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(712, 39);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlDarkDark;
            lblNome.Location = new Point(524, 554);
            lblNome.Margin = new Padding(6, 0, 6, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(88, 30);
            lblNome.TabIndex = 279;
            lblNome.Text = "* Nome";
            // 
            // lblCarteiraProfissional
            // 
            lblCarteiraProfissional.Anchor = AnchorStyles.Top;
            lblCarteiraProfissional.AutoSize = true;
            lblCarteiraProfissional.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarteiraProfissional.ForeColor = SystemColors.ControlDarkDark;
            lblCarteiraProfissional.Location = new Point(524, 1046);
            lblCarteiraProfissional.Margin = new Padding(6, 0, 6, 0);
            lblCarteiraProfissional.Name = "lblCarteiraProfissional";
            lblCarteiraProfissional.Size = new Size(204, 30);
            lblCarteiraProfissional.TabIndex = 278;
            lblCarteiraProfissional.Text = "Carteira Profissional";
            // 
            // txtCarteira
            // 
            txtCarteira.Anchor = AnchorStyles.Top;
            txtCarteira.BackColor = Color.White;
            txtCarteira.CharacterCasing = CharacterCasing.Upper;
            txtCarteira.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarteira.ForeColor = Color.Black;
            txtCarteira.Location = new Point(780, 1036);
            txtCarteira.Margin = new Padding(6, 7, 6, 7);
            txtCarteira.MaxLength = 100;
            txtCarteira.Name = "txtCarteira";
            txtCarteira.Size = new Size(712, 39);
            txtCarteira.TabIndex = 7;
            // 
            // lblEntidadedeClasse
            // 
            lblEntidadedeClasse.Anchor = AnchorStyles.Top;
            lblEntidadedeClasse.AutoSize = true;
            lblEntidadedeClasse.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEntidadedeClasse.ForeColor = SystemColors.ControlDarkDark;
            lblEntidadedeClasse.Location = new Point(524, 1142);
            lblEntidadedeClasse.Margin = new Padding(6, 0, 6, 0);
            lblEntidadedeClasse.Name = "lblEntidadedeClasse";
            lblEntidadedeClasse.Size = new Size(194, 30);
            lblEntidadedeClasse.TabIndex = 277;
            lblEntidadedeClasse.Text = "Entidade de Classe";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Top;
            txtCodigo.BackColor = Color.White;
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Location = new Point(780, 185);
            txtCodigo.Margin = new Padding(6, 7, 6, 7);
            txtCodigo.MaxLength = 3;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(266, 39);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.Top;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.ForeColor = SystemColors.ControlDarkDark;
            lblCodigo.Location = new Point(524, 194);
            lblCodigo.Margin = new Padding(6, 0, 6, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(99, 30);
            lblCodigo.TabIndex = 275;
            lblCodigo.Text = "* Código";
            // 
            // txtProfissao
            // 
            txtProfissao.Anchor = AnchorStyles.Top;
            txtProfissao.BackColor = Color.White;
            txtProfissao.CharacterCasing = CharacterCasing.Upper;
            txtProfissao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProfissao.ForeColor = Color.Black;
            txtProfissao.Location = new Point(780, 940);
            txtProfissao.Margin = new Padding(6, 7, 6, 7);
            txtProfissao.MaxLength = 100;
            txtProfissao.Name = "txtProfissao";
            txtProfissao.Size = new Size(712, 39);
            txtProfissao.TabIndex = 6;
            // 
            // lblProfissao
            // 
            lblProfissao.Anchor = AnchorStyles.Top;
            lblProfissao.AutoSize = true;
            lblProfissao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfissao.ForeColor = SystemColors.ControlDarkDark;
            lblProfissao.Location = new Point(524, 950);
            lblProfissao.Margin = new Padding(6, 0, 6, 0);
            lblProfissao.Name = "lblProfissao";
            lblProfissao.Size = new Size(100, 30);
            lblProfissao.TabIndex = 274;
            lblProfissao.Text = "Profissão";
            // 
            // pnlLinha2
            // 
            pnlLinha2.BackColor = Color.LightBlue;
            pnlLinha2.Controls.Add(btnAddSave);
            pnlLinha2.Controls.Add(btnCancelar);
            pnlLinha2.Dock = DockStyle.Bottom;
            pnlLinha2.Location = new Point(0, 1305);
            pnlLinha2.Margin = new Padding(6, 7, 6, 7);
            pnlLinha2.Name = "pnlLinha2";
            pnlLinha2.Size = new Size(1993, 123);
            pnlLinha2.TabIndex = 1;
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
            btnAddSave.Text = "&Adicionar";
            btnAddSave.UseVisualStyleBackColor = false;
            btnAddSave.Click += btnAddSave_Click;
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
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Location = new Point(453, 898);
            panel5.Margin = new Padding(6, 7, 6, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(1105, 2);
            panel5.TabIndex = 280;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(453, 832);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 32);
            label2.TabIndex = 279;
            label2.Text = "Dados Profissionais";
            // 
            // pnlTitLinhaContato
            // 
            pnlTitLinhaContato.Anchor = AnchorStyles.Top;
            pnlTitLinhaContato.BackColor = SystemColors.ControlDark;
            pnlTitLinhaContato.Location = new Point(453, 1371);
            pnlTitLinhaContato.Margin = new Padding(6, 7, 6, 7);
            pnlTitLinhaContato.Name = "pnlTitLinhaContato";
            pnlTitLinhaContato.Size = new Size(1105, 2);
            pnlTitLinhaContato.TabIndex = 157;
            // 
            // lblTitContato
            // 
            lblTitContato.Anchor = AnchorStyles.Top;
            lblTitContato.AutoSize = true;
            lblTitContato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitContato.ForeColor = Color.DimGray;
            lblTitContato.Location = new Point(453, 1305);
            lblTitContato.Margin = new Padding(6, 0, 6, 0);
            lblTitContato.Name = "lblTitContato";
            lblTitContato.Size = new Size(105, 32);
            lblTitContato.TabIndex = 156;
            lblTitContato.Text = "Contato";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Location = new Point(453, 502);
            panel4.Margin = new Padding(6, 7, 6, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(1105, 2);
            panel4.TabIndex = 157;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(453, 436);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 156;
            label1.Text = "Dados Pessoais";
            // 
            // chkRT
            // 
            chkRT.Anchor = AnchorStyles.Top;
            chkRT.AutoSize = true;
            chkRT.Location = new Point(780, 293);
            chkRT.Margin = new Padding(6, 7, 6, 7);
            chkRT.Name = "chkRT";
            chkRT.Size = new Size(28, 27);
            chkRT.TabIndex = 1;
            chkRT.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(524, 293);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(210, 30);
            label3.TabIndex = 275;
            label3.Text = "Responsável Técnico";
            // 
            // pnlMainAddProfissional
            // 
            pnlMainAddProfissional.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMainAddProfissional.AutoScroll = true;
            pnlMainAddProfissional.BackColor = Color.White;
            pnlMainAddProfissional.Controls.Add(dtpBirthday);
            pnlMainAddProfissional.Controls.Add(cboEntidade);
            pnlMainAddProfissional.Controls.Add(imgShowPwd);
            pnlMainAddProfissional.Controls.Add(imgHidePwd);
            pnlMainAddProfissional.Controls.Add(txtUsrSenha2);
            pnlMainAddProfissional.Controls.Add(txtUsrSenha);
            pnlMainAddProfissional.Controls.Add(label10);
            pnlMainAddProfissional.Controls.Add(chkUsrAtivo);
            pnlMainAddProfissional.Controls.Add(panel3);
            pnlMainAddProfissional.Controls.Add(label6);
            pnlMainAddProfissional.Controls.Add(txtUsrNome);
            pnlMainAddProfissional.Controls.Add(label7);
            pnlMainAddProfissional.Controls.Add(label8);
            pnlMainAddProfissional.Controls.Add(label9);
            pnlMainAddProfissional.Controls.Add(label5);
            pnlMainAddProfissional.Controls.Add(panel2);
            pnlMainAddProfissional.Controls.Add(label4);
            pnlMainAddProfissional.Controls.Add(chkRL);
            pnlMainAddProfissional.Controls.Add(panel1);
            pnlMainAddProfissional.Controls.Add(pnlTitLinhaContato);
            pnlMainAddProfissional.Controls.Add(panel5);
            pnlMainAddProfissional.Controls.Add(label1);
            pnlMainAddProfissional.Controls.Add(lblTitContato);
            pnlMainAddProfissional.Controls.Add(lblCPF);
            pnlMainAddProfissional.Controls.Add(txtEmail);
            pnlMainAddProfissional.Controls.Add(lblNome);
            pnlMainAddProfissional.Controls.Add(chkRT);
            pnlMainAddProfissional.Controls.Add(txtCodigo);
            pnlMainAddProfissional.Controls.Add(lblTelefone1);
            pnlMainAddProfissional.Controls.Add(lblDataNascimento);
            pnlMainAddProfissional.Controls.Add(label2);
            pnlMainAddProfissional.Controls.Add(panel4);
            pnlMainAddProfissional.Controls.Add(lblEmail);
            pnlMainAddProfissional.Controls.Add(lblCarteiraProfissional);
            pnlMainAddProfissional.Controls.Add(lblProfissao);
            pnlMainAddProfissional.Controls.Add(txtCPF);
            pnlMainAddProfissional.Controls.Add(txtTelefone1);
            pnlMainAddProfissional.Controls.Add(txtCarteira);
            pnlMainAddProfissional.Controls.Add(txtNome);
            pnlMainAddProfissional.Controls.Add(lblTelefone2);
            pnlMainAddProfissional.Controls.Add(txtProfissao);
            pnlMainAddProfissional.Controls.Add(lblCodigo);
            pnlMainAddProfissional.Controls.Add(txtTelefone2);
            pnlMainAddProfissional.Controls.Add(lblEntidadedeClasse);
            pnlMainAddProfissional.Controls.Add(label3);
            pnlMainAddProfissional.Location = new Point(0, 0);
            pnlMainAddProfissional.Margin = new Padding(6, 7, 6, 7);
            pnlMainAddProfissional.Name = "pnlMainAddProfissional";
            pnlMainAddProfissional.Size = new Size(1993, 1305);
            pnlMainAddProfissional.TabIndex = 0;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Anchor = AnchorStyles.Top;
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(1280, 640);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(212, 39);
            dtpBirthday.TabIndex = 5;
            // 
            // cboEntidade
            // 
            cboEntidade.Anchor = AnchorStyles.Top;
            cboEntidade.BackColor = Color.White;
            cboEntidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEntidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboEntidade.ForeColor = Color.Black;
            cboEntidade.FormattingEnabled = true;
            cboEntidade.Items.AddRange(new object[] { "C.A.U. - CONSELHO DE ARQUITETURA E URBANISMO", "C.R.E.A. - CONSELHO DE ENGENHARIA E AGRONOMIA", "OUTRO" });
            cboEntidade.Location = new Point(780, 1132);
            cboEntidade.Margin = new Padding(6, 7, 6, 7);
            cboEntidade.MaxLength = 100;
            cboEntidade.Name = "cboEntidade";
            cboEntidade.Size = new Size(712, 40);
            cboEntidade.TabIndex = 8;
            // 
            // imgShowPwd
            // 
            imgShowPwd.Anchor = AnchorStyles.Top;
            imgShowPwd.Cursor = Cursors.Hand;
            imgShowPwd.Image = (Image)resources.GetObject("imgShowPwd.Image");
            imgShowPwd.Location = new Point(995, 1986);
            imgShowPwd.Margin = new Padding(6, 7, 6, 7);
            imgShowPwd.Name = "imgShowPwd";
            imgShowPwd.Size = new Size(32, 37);
            imgShowPwd.SizeMode = PictureBoxSizeMode.Zoom;
            imgShowPwd.TabIndex = 234;
            imgShowPwd.TabStop = false;
            ttpAddProfissional.SetToolTip(imgShowPwd, "Mostrar senha");
            imgShowPwd.Click += imgShowPwd_Click;
            // 
            // imgHidePwd
            // 
            imgHidePwd.Anchor = AnchorStyles.Top;
            imgHidePwd.Cursor = Cursors.Hand;
            imgHidePwd.Image = (Image)resources.GetObject("imgHidePwd.Image");
            imgHidePwd.Location = new Point(995, 1986);
            imgHidePwd.Margin = new Padding(6, 7, 6, 7);
            imgHidePwd.Name = "imgHidePwd";
            imgHidePwd.Size = new Size(32, 37);
            imgHidePwd.SizeMode = PictureBoxSizeMode.Zoom;
            imgHidePwd.TabIndex = 235;
            imgHidePwd.TabStop = false;
            ttpAddProfissional.SetToolTip(imgHidePwd, "Ocultar senha");
            imgHidePwd.Click += imgHidePwd_Click;
            // 
            // txtUsrSenha2
            // 
            txtUsrSenha2.Anchor = AnchorStyles.Top;
            txtUsrSenha2.BackColor = Color.White;
            txtUsrSenha2.CharacterCasing = CharacterCasing.Lower;
            txtUsrSenha2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsrSenha2.ForeColor = Color.Black;
            txtUsrSenha2.Location = new Point(1231, 1986);
            txtUsrSenha2.Margin = new Padding(6, 7, 6, 7);
            txtUsrSenha2.MaxLength = 15;
            txtUsrSenha2.Name = "txtUsrSenha2";
            txtUsrSenha2.PasswordChar = '*';
            txtUsrSenha2.Size = new Size(255, 39);
            txtUsrSenha2.TabIndex = 15;
            // 
            // txtUsrSenha
            // 
            txtUsrSenha.Anchor = AnchorStyles.Top;
            txtUsrSenha.BackColor = Color.White;
            txtUsrSenha.CharacterCasing = CharacterCasing.Lower;
            txtUsrSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsrSenha.ForeColor = Color.Black;
            txtUsrSenha.Location = new Point(774, 1986);
            txtUsrSenha.Margin = new Padding(6, 7, 6, 7);
            txtUsrSenha.MaxLength = 15;
            txtUsrSenha.Name = "txtUsrSenha";
            txtUsrSenha.PasswordChar = '*';
            txtUsrSenha.Size = new Size(255, 39);
            txtUsrSenha.TabIndex = 14;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(518, 1792);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 30);
            label10.TabIndex = 299;
            label10.Text = "Usuário Ativo";
            // 
            // chkUsrAtivo
            // 
            chkUsrAtivo.Anchor = AnchorStyles.Top;
            chkUsrAtivo.AutoSize = true;
            chkUsrAtivo.Location = new Point(774, 1792);
            chkUsrAtivo.Margin = new Padding(6, 7, 6, 7);
            chkUsrAtivo.Name = "chkUsrAtivo";
            chkUsrAtivo.Size = new Size(28, 27);
            chkUsrAtivo.TabIndex = 12;
            chkUsrAtivo.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Location = new Point(446, 1740);
            panel3.Margin = new Padding(6, 7, 6, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(1105, 2);
            panel3.TabIndex = 294;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(446, 1674);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(232, 32);
            label6.TabIndex = 293;
            label6.Text = "Usuário do sistema";
            // 
            // txtUsrNome
            // 
            txtUsrNome.Anchor = AnchorStyles.Top;
            txtUsrNome.BackColor = Color.White;
            txtUsrNome.CharacterCasing = CharacterCasing.Lower;
            txtUsrNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsrNome.ForeColor = Color.Black;
            txtUsrNome.Location = new Point(774, 1878);
            txtUsrNome.Margin = new Padding(6, 7, 6, 7);
            txtUsrNome.MaxLength = 40;
            txtUsrNome.Name = "txtUsrNome";
            txtUsrNome.Size = new Size(712, 39);
            txtUsrNome.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(518, 1996);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 30);
            label7.TabIndex = 295;
            label7.Text = "Senha";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(518, 1888);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(195, 30);
            label8.TabIndex = 296;
            label8.Text = "* Nome de usuário";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(1062, 1996);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 30);
            label9.TabIndex = 297;
            label9.Text = "Confirmação";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(446, 64);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(235, 32);
            label5.TabIndex = 288;
            label5.Text = "Informações Gerais";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(453, 130);
            panel2.Margin = new Padding(6, 7, 6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 2);
            panel2.TabIndex = 289;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(921, 293);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 30);
            label4.TabIndex = 287;
            label4.Text = "Responsável Legal";
            // 
            // chkRL
            // 
            chkRL.Anchor = AnchorStyles.Top;
            chkRL.AutoSize = true;
            chkRL.Location = new Point(1153, 293);
            chkRL.Margin = new Padding(6, 7, 6, 7);
            chkRL.Name = "chkRL";
            chkRL.Size = new Size(28, 27);
            chkRL.TabIndex = 2;
            chkRL.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(520, 2171);
            panel1.Margin = new Padding(6, 7, 6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 2);
            panel1.TabIndex = 285;
            // 
            // frmAddProfessional
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1993, 1428);
            Controls.Add(pnlMainAddProfissional);
            Controls.Add(pnlLinha2);
            Margin = new Padding(6, 7, 6, 7);
            Name = "frmAddProfessional";
            Text = "Adicionar Profissional";
            Load += frmAddProfissional_Load;
            pnlLinha2.ResumeLayout(false);
            pnlMainAddProfissional.ResumeLayout(false);
            pnlMainAddProfissional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgShowPwd).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHidePwd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCarteiraProfissional;
        private System.Windows.Forms.TextBox txtCarteira;
        private System.Windows.Forms.Label lblEntidadedeClasse;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTitLinhaContato;
        private System.Windows.Forms.Label lblTitContato;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMainAddProfissional;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkRL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsrSenha2;
        private System.Windows.Forms.TextBox txtUsrSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkUsrAtivo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsrNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imgShowPwd;
        private System.Windows.Forms.PictureBox imgHidePwd;
        private System.Windows.Forms.ToolTip ttpAddProfissional;
        private System.Windows.Forms.ComboBox cboEntidade;
        private DateTimePicker dtpBirthday;
    }
}