namespace Fluxus.View
{
    partial class frmAddProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProfissional));
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCarteiraProfissional = new System.Windows.Forms.Label();
            this.txtCarteira = new System.Windows.Forms.TextBox();
            this.lblEntidadedeClasse = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitLinhaContato = new System.Windows.Forms.Panel();
            this.lblTitContato = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRT = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMainAddProfissional = new System.Windows.Forms.Panel();
            this.cboEntidade = new System.Windows.Forms.ComboBox();
            this.imgShowPwd = new System.Windows.Forms.PictureBox();
            this.imgHidePwd = new System.Windows.Forms.PictureBox();
            this.txtUsrSenha2 = new System.Windows.Forms.TextBox();
            this.txtUsrSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkUsrAtivo = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsrNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRL = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ttpAddProfissional = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLinha2.SuspendLayout();
            this.pnlMainAddProfissional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidePwd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCPF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCPF.Location = new System.Drawing.Point(360, 260);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(125, 23);
            this.txtCPF.TabIndex = 4;
            this.txtCPF.Tag = "cpf";
            this.txtCPF.Enter += new System.EventHandler(this.OnEnter_MaskedTextBox);
            this.txtCPF.Validated += new System.EventHandler(this.OnValidated_MaskedTextBox);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDataNascimento.Location = new System.Drawing.Point(491, 264);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(94, 13);
            this.lblDataNascimento.TabIndex = 284;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone2.Location = new System.Drawing.Point(571, 574);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(120, 23);
            this.txtTelefone2.TabIndex = 10;
            this.txtTelefone2.Tag = "telefone";
            this.txtTelefone2.Enter += new System.EventHandler(this.OnEnter_MaskedTextBox);
            this.txtTelefone2.Validated += new System.EventHandler(this.OnValidated_MaskedTextBox);
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone1.Location = new System.Drawing.Point(360, 574);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(120, 23);
            this.txtTelefone1.TabIndex = 9;
            this.txtTelefone1.Tag = "telefone";
            this.txtTelefone1.Enter += new System.EventHandler(this.OnEnter_MaskedTextBox);
            this.txtTelefone1.Validated += new System.EventHandler(this.OnValidated_MaskedTextBox);
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone2.Location = new System.Drawing.Point(505, 578);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone2.TabIndex = 283;
            this.lblTelefone2.Text = "Telefone 2";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(242, 622);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 282;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone1.Location = new System.Drawing.Point(242, 578);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone1.TabIndex = 281;
            this.lblTelefone1.Text = "Telefone 1";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(360, 618);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCPF.Location = new System.Drawing.Point(242, 264);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(26, 13);
            this.lblCPF.TabIndex = 280;
            this.lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(360, 221);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(242, 225);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 279;
            this.lblNome.Text = "* Nome";
            // 
            // lblCarteiraProfissional
            // 
            this.lblCarteiraProfissional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCarteiraProfissional.AutoSize = true;
            this.lblCarteiraProfissional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteiraProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCarteiraProfissional.Location = new System.Drawing.Point(242, 425);
            this.lblCarteiraProfissional.Name = "lblCarteiraProfissional";
            this.lblCarteiraProfissional.Size = new System.Drawing.Size(110, 13);
            this.lblCarteiraProfissional.TabIndex = 278;
            this.lblCarteiraProfissional.Text = "Carteira Profissional";
            // 
            // txtCarteira
            // 
            this.txtCarteira.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCarteira.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCarteira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCarteira.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarteira.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCarteira.Location = new System.Drawing.Point(360, 421);
            this.txtCarteira.MaxLength = 100;
            this.txtCarteira.Name = "txtCarteira";
            this.txtCarteira.Size = new System.Drawing.Size(331, 23);
            this.txtCarteira.TabIndex = 7;
            // 
            // lblEntidadedeClasse
            // 
            this.lblEntidadedeClasse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEntidadedeClasse.AutoSize = true;
            this.lblEntidadedeClasse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadedeClasse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEntidadedeClasse.Location = new System.Drawing.Point(242, 464);
            this.lblEntidadedeClasse.Name = "lblEntidadedeClasse";
            this.lblEntidadedeClasse.Size = new System.Drawing.Size(104, 13);
            this.lblEntidadedeClasse.TabIndex = 277;
            this.lblEntidadedeClasse.Text = "Entidade de Classe";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo.Location = new System.Drawing.Point(360, 75);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(125, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigo.Location = new System.Drawing.Point(242, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 13);
            this.lblCodigo.TabIndex = 275;
            this.lblCodigo.Text = "* Código";
            // 
            // txtProfissao
            // 
            this.txtProfissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProfissao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfissao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProfissao.Location = new System.Drawing.Point(360, 382);
            this.txtProfissao.MaxLength = 100;
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(331, 23);
            this.txtProfissao.TabIndex = 6;
            // 
            // lblProfissao
            // 
            this.lblProfissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProfissao.Location = new System.Drawing.Point(242, 386);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(54, 13);
            this.lblProfissao.TabIndex = 274;
            this.lblProfissao.Text = "Profissão";
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.BackColor = System.Drawing.Color.LightBlue;
            this.pnlLinha2.Controls.Add(this.btnAddSave);
            this.pnlLinha2.Controls.Add(this.btnCancelar);
            this.pnlLinha2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLinha2.Location = new System.Drawing.Point(0, 530);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(920, 50);
            this.pnlLinha2.TabIndex = 1;
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
            // txtNascimento
            // 
            this.txtNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNascimento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNascimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNascimento.Location = new System.Drawing.Point(591, 260);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(100, 23);
            this.txtNascimento.TabIndex = 5;
            this.txtNascimento.Tag = "data";
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            this.txtNascimento.Enter += new System.EventHandler(this.OnEnter_MaskedTextBox);
            this.txtNascimento.Validated += new System.EventHandler(this.OnValidated_MaskedTextBox);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(209, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(510, 1);
            this.panel5.TabIndex = 280;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(209, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 279;
            this.label2.Text = "Dados Profissionais";
            // 
            // pnlTitLinhaContato
            // 
            this.pnlTitLinhaContato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTitLinhaContato.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTitLinhaContato.Location = new System.Drawing.Point(209, 557);
            this.pnlTitLinhaContato.Name = "pnlTitLinhaContato";
            this.pnlTitLinhaContato.Size = new System.Drawing.Size(510, 1);
            this.pnlTitLinhaContato.TabIndex = 157;
            // 
            // lblTitContato
            // 
            this.lblTitContato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitContato.AutoSize = true;
            this.lblTitContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitContato.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitContato.Location = new System.Drawing.Point(209, 530);
            this.lblTitContato.Name = "lblTitContato";
            this.lblTitContato.Size = new System.Drawing.Size(51, 15);
            this.lblTitContato.TabIndex = 156;
            this.lblTitContato.Text = "Contato";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(209, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 1);
            this.panel4.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(209, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 156;
            this.label1.Text = "Dados Pessoais";
            // 
            // chkRT
            // 
            this.chkRT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkRT.AutoSize = true;
            this.chkRT.Location = new System.Drawing.Point(360, 119);
            this.chkRT.Name = "chkRT";
            this.chkRT.Size = new System.Drawing.Size(15, 14);
            this.chkRT.TabIndex = 1;
            this.chkRT.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(242, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 275;
            this.label3.Text = "Responsável Técnico";
            // 
            // pnlMainAddProfissional
            // 
            this.pnlMainAddProfissional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainAddProfissional.AutoScroll = true;
            this.pnlMainAddProfissional.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMainAddProfissional.Controls.Add(this.cboEntidade);
            this.pnlMainAddProfissional.Controls.Add(this.imgShowPwd);
            this.pnlMainAddProfissional.Controls.Add(this.imgHidePwd);
            this.pnlMainAddProfissional.Controls.Add(this.txtUsrSenha2);
            this.pnlMainAddProfissional.Controls.Add(this.txtUsrSenha);
            this.pnlMainAddProfissional.Controls.Add(this.label10);
            this.pnlMainAddProfissional.Controls.Add(this.chkUsrAtivo);
            this.pnlMainAddProfissional.Controls.Add(this.panel3);
            this.pnlMainAddProfissional.Controls.Add(this.label6);
            this.pnlMainAddProfissional.Controls.Add(this.txtUsrNome);
            this.pnlMainAddProfissional.Controls.Add(this.label7);
            this.pnlMainAddProfissional.Controls.Add(this.label8);
            this.pnlMainAddProfissional.Controls.Add(this.label9);
            this.pnlMainAddProfissional.Controls.Add(this.label5);
            this.pnlMainAddProfissional.Controls.Add(this.panel2);
            this.pnlMainAddProfissional.Controls.Add(this.label4);
            this.pnlMainAddProfissional.Controls.Add(this.chkRL);
            this.pnlMainAddProfissional.Controls.Add(this.panel1);
            this.pnlMainAddProfissional.Controls.Add(this.pnlTitLinhaContato);
            this.pnlMainAddProfissional.Controls.Add(this.panel5);
            this.pnlMainAddProfissional.Controls.Add(this.label1);
            this.pnlMainAddProfissional.Controls.Add(this.lblTitContato);
            this.pnlMainAddProfissional.Controls.Add(this.lblCPF);
            this.pnlMainAddProfissional.Controls.Add(this.txtEmail);
            this.pnlMainAddProfissional.Controls.Add(this.lblNome);
            this.pnlMainAddProfissional.Controls.Add(this.chkRT);
            this.pnlMainAddProfissional.Controls.Add(this.txtCodigo);
            this.pnlMainAddProfissional.Controls.Add(this.lblTelefone1);
            this.pnlMainAddProfissional.Controls.Add(this.lblDataNascimento);
            this.pnlMainAddProfissional.Controls.Add(this.label2);
            this.pnlMainAddProfissional.Controls.Add(this.panel4);
            this.pnlMainAddProfissional.Controls.Add(this.lblEmail);
            this.pnlMainAddProfissional.Controls.Add(this.lblCarteiraProfissional);
            this.pnlMainAddProfissional.Controls.Add(this.lblProfissao);
            this.pnlMainAddProfissional.Controls.Add(this.txtCPF);
            this.pnlMainAddProfissional.Controls.Add(this.txtTelefone1);
            this.pnlMainAddProfissional.Controls.Add(this.txtCarteira);
            this.pnlMainAddProfissional.Controls.Add(this.txtNascimento);
            this.pnlMainAddProfissional.Controls.Add(this.txtNome);
            this.pnlMainAddProfissional.Controls.Add(this.lblTelefone2);
            this.pnlMainAddProfissional.Controls.Add(this.txtProfissao);
            this.pnlMainAddProfissional.Controls.Add(this.lblCodigo);
            this.pnlMainAddProfissional.Controls.Add(this.txtTelefone2);
            this.pnlMainAddProfissional.Controls.Add(this.lblEntidadedeClasse);
            this.pnlMainAddProfissional.Controls.Add(this.label3);
            this.pnlMainAddProfissional.Location = new System.Drawing.Point(0, 0);
            this.pnlMainAddProfissional.Name = "pnlMainAddProfissional";
            this.pnlMainAddProfissional.Size = new System.Drawing.Size(920, 530);
            this.pnlMainAddProfissional.TabIndex = 0;
            // 
            // cboEntidade
            // 
            this.cboEntidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEntidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboEntidade.FormattingEnabled = true;
            this.cboEntidade.Items.AddRange(new object[] {
            "C.A.U. - CONSELHO DE ARQUITETURA E URBANISMO",
            "C.R.E.A. - CONSELHO DE ENGENHARIA E AGRONOMIA",
            "OUTRO"});
            this.cboEntidade.Location = new System.Drawing.Point(360, 460);
            this.cboEntidade.MaxLength = 100;
            this.cboEntidade.Name = "cboEntidade";
            this.cboEntidade.Size = new System.Drawing.Size(331, 23);
            this.cboEntidade.TabIndex = 8;
            // 
            // imgShowPwd
            // 
            this.imgShowPwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgShowPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgShowPwd.Image = ((System.Drawing.Image)(resources.GetObject("imgShowPwd.Image")));
            this.imgShowPwd.Location = new System.Drawing.Point(459, 811);
            this.imgShowPwd.Name = "imgShowPwd";
            this.imgShowPwd.Size = new System.Drawing.Size(15, 15);
            this.imgShowPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgShowPwd.TabIndex = 234;
            this.imgShowPwd.TabStop = false;
            this.ttpAddProfissional.SetToolTip(this.imgShowPwd, "Mostrar senha");
            this.imgShowPwd.Click += new System.EventHandler(this.imgShowPwd_Click);
            // 
            // imgHidePwd
            // 
            this.imgHidePwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgHidePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgHidePwd.Image = ((System.Drawing.Image)(resources.GetObject("imgHidePwd.Image")));
            this.imgHidePwd.Location = new System.Drawing.Point(459, 811);
            this.imgHidePwd.Name = "imgHidePwd";
            this.imgHidePwd.Size = new System.Drawing.Size(15, 15);
            this.imgHidePwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHidePwd.TabIndex = 235;
            this.imgHidePwd.TabStop = false;
            this.ttpAddProfissional.SetToolTip(this.imgHidePwd, "Ocultar senha");
            this.imgHidePwd.Click += new System.EventHandler(this.imgHidePwd_Click);
            // 
            // txtUsrSenha2
            // 
            this.txtUsrSenha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsrSenha2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsrSenha2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsrSenha2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrSenha2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsrSenha2.Location = new System.Drawing.Point(568, 807);
            this.txtUsrSenha2.MaxLength = 15;
            this.txtUsrSenha2.Name = "txtUsrSenha2";
            this.txtUsrSenha2.PasswordChar = '*';
            this.txtUsrSenha2.Size = new System.Drawing.Size(120, 23);
            this.txtUsrSenha2.TabIndex = 15;
            // 
            // txtUsrSenha
            // 
            this.txtUsrSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsrSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsrSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsrSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsrSenha.Location = new System.Drawing.Point(357, 807);
            this.txtUsrSenha.MaxLength = 15;
            this.txtUsrSenha.Name = "txtUsrSenha";
            this.txtUsrSenha.PasswordChar = '*';
            this.txtUsrSenha.Size = new System.Drawing.Size(120, 23);
            this.txtUsrSenha.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(239, 728);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 299;
            this.label10.Text = "Usuário Ativo";
            // 
            // chkUsrAtivo
            // 
            this.chkUsrAtivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkUsrAtivo.AutoSize = true;
            this.chkUsrAtivo.Location = new System.Drawing.Point(357, 728);
            this.chkUsrAtivo.Name = "chkUsrAtivo";
            this.chkUsrAtivo.Size = new System.Drawing.Size(15, 14);
            this.chkUsrAtivo.TabIndex = 12;
            this.chkUsrAtivo.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(206, 707);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 1);
            this.panel3.TabIndex = 294;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(206, 680);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 293;
            this.label6.Text = "Usuário do sistema";
            // 
            // txtUsrNome
            // 
            this.txtUsrNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsrNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsrNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsrNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsrNome.Location = new System.Drawing.Point(357, 763);
            this.txtUsrNome.MaxLength = 40;
            this.txtUsrNome.Name = "txtUsrNome";
            this.txtUsrNome.Size = new System.Drawing.Size(331, 23);
            this.txtUsrNome.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(239, 811);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 295;
            this.label7.Text = "Senha";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(239, 767);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 296;
            this.label8.Text = "Nome de usuário";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(490, 811);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 297;
            this.label9.Text = "Confirmação";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(206, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 288;
            this.label5.Text = "Informações Gerais";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(209, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 1);
            this.panel2.TabIndex = 289;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(425, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 287;
            this.label4.Text = "Responsável Legal";
            // 
            // chkRL
            // 
            this.chkRL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkRL.AutoSize = true;
            this.chkRL.Location = new System.Drawing.Point(532, 119);
            this.chkRL.Name = "chkRL";
            this.chkRL.Size = new System.Drawing.Size(15, 14);
            this.chkRL.TabIndex = 2;
            this.chkRL.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(240, 882);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 1);
            this.panel1.TabIndex = 285;
            // 
            // frmAddProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.pnlMainAddProfissional);
            this.Controls.Add(this.pnlLinha2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProfissional";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Profissional";
            this.Load += new System.EventHandler(this.frmAddProfissional_Load);
            this.pnlLinha2.ResumeLayout(false);
            this.pnlMainAddProfissional.ResumeLayout(false);
            this.pnlMainAddProfissional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidePwd)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.MaskedTextBox txtNascimento;
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
    }
}