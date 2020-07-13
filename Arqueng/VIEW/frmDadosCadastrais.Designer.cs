namespace Arqueng.VIEW
{
    partial class frmDadosCadastrais
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
            this.btnCadastrarSalvar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRepresentanteLegal = new System.Windows.Forms.TextBox();
            this.lblRepresentanteLegal = new System.Windows.Forms.Label();
            this.lblDataConstituinte = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtInscricaoMunicipal = new System.Windows.Forms.TextBox();
            this.txtInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.lblInscricaoMunicipal = new System.Windows.Forms.Label();
            this.lblInscricaoEstadual = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblTipoDeConta = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cboTipoDeConta = new System.Windows.Forms.ComboBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtConstituicao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarSalvar
            // 
            this.btnCadastrarSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrarSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrarSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(437, 895);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(200, 25);
            this.btnCadastrarSalvar.TabIndex = 21;
            this.btnCadastrarSalvar.Text = "&Cadastrar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            this.btnCadastrarSalvar.Click += new System.EventHandler(this.btnCadastrarSalvar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(230, 554);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 146;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone.Location = new System.Drawing.Point(230, 502);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(51, 13);
            this.lblTelefone.TabIndex = 145;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(232, 570);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(405, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // txtRepresentanteLegal
            // 
            this.txtRepresentanteLegal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRepresentanteLegal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRepresentanteLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRepresentanteLegal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepresentanteLegal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRepresentanteLegal.Location = new System.Drawing.Point(232, 466);
            this.txtRepresentanteLegal.MaxLength = 50;
            this.txtRepresentanteLegal.Name = "txtRepresentanteLegal";
            this.txtRepresentanteLegal.Size = new System.Drawing.Size(199, 23);
            this.txtRepresentanteLegal.TabIndex = 12;
            // 
            // lblRepresentanteLegal
            // 
            this.lblRepresentanteLegal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRepresentanteLegal.AutoSize = true;
            this.lblRepresentanteLegal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepresentanteLegal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRepresentanteLegal.Location = new System.Drawing.Point(230, 450);
            this.lblRepresentanteLegal.Name = "lblRepresentanteLegal";
            this.lblRepresentanteLegal.Size = new System.Drawing.Size(112, 13);
            this.lblRepresentanteLegal.TabIndex = 141;
            this.lblRepresentanteLegal.Text = "Representante Legal";
            // 
            // lblDataConstituinte
            // 
            this.lblDataConstituinte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataConstituinte.AutoSize = true;
            this.lblDataConstituinte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConstituinte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDataConstituinte.Location = new System.Drawing.Point(434, 138);
            this.lblDataConstituinte.Name = "lblDataConstituinte";
            this.lblDataConstituinte.Size = new System.Drawing.Size(98, 13);
            this.lblDataConstituinte.TabIndex = 133;
            this.lblDataConstituinte.Text = "Data Constituinte";
            // 
            // lblUF
            // 
            this.lblUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUF.Location = new System.Drawing.Point(434, 398);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 132;
            this.lblUF.Text = "UF";
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCEP.Location = new System.Drawing.Point(229, 398);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(26, 13);
            this.lblCEP.TabIndex = 131;
            this.lblCEP.Text = "CEP";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCidade.Location = new System.Drawing.Point(434, 346);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 130;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBairro.Location = new System.Drawing.Point(229, 346);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 129;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCidade.Location = new System.Drawing.Point(437, 362);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 23);
            this.txtCidade.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBairro.Location = new System.Drawing.Point(231, 362);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 23);
            this.txtBairro.TabIndex = 8;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtComplemento.Location = new System.Drawing.Point(231, 310);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(405, 23);
            this.txtComplemento.TabIndex = 7;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndereco.Location = new System.Drawing.Point(231, 258);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(405, 23);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplemento.Location = new System.Drawing.Point(229, 294);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(79, 13);
            this.lblComplemento.TabIndex = 122;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEndereco.Location = new System.Drawing.Point(229, 242);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(55, 13);
            this.lblEndereco.TabIndex = 121;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtInscricaoMunicipal
            // 
            this.txtInscricaoMunicipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInscricaoMunicipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInscricaoMunicipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscricaoMunicipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricaoMunicipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInscricaoMunicipal.Location = new System.Drawing.Point(437, 206);
            this.txtInscricaoMunicipal.MaxLength = 50;
            this.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            this.txtInscricaoMunicipal.Size = new System.Drawing.Size(200, 23);
            this.txtInscricaoMunicipal.TabIndex = 5;
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInscricaoEstadual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInscricaoEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscricaoEstadual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricaoEstadual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(231, 206);
            this.txtInscricaoEstadual.MaxLength = 50;
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(200, 23);
            this.txtInscricaoEstadual.TabIndex = 4;
            // 
            // lblInscricaoMunicipal
            // 
            this.lblInscricaoMunicipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInscricaoMunicipal.AutoSize = true;
            this.lblInscricaoMunicipal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricaoMunicipal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInscricaoMunicipal.Location = new System.Drawing.Point(434, 190);
            this.lblInscricaoMunicipal.Name = "lblInscricaoMunicipal";
            this.lblInscricaoMunicipal.Size = new System.Drawing.Size(106, 13);
            this.lblInscricaoMunicipal.TabIndex = 117;
            this.lblInscricaoMunicipal.Text = "Inscrição Municipal";
            // 
            // lblInscricaoEstadual
            // 
            this.lblInscricaoEstadual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInscricaoEstadual.AutoSize = true;
            this.lblInscricaoEstadual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricaoEstadual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInscricaoEstadual.Location = new System.Drawing.Point(229, 190);
            this.lblInscricaoEstadual.Name = "lblInscricaoEstadual";
            this.lblInscricaoEstadual.Size = new System.Drawing.Size(99, 13);
            this.lblInscricaoEstadual.TabIndex = 116;
            this.lblInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCNPJ.Location = new System.Drawing.Point(230, 34);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(39, 13);
            this.lblCNPJ.TabIndex = 115;
            this.lblCNPJ.Text = "* CNPJ";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRazaoSocial.Location = new System.Drawing.Point(230, 86);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(79, 13);
            this.lblRazaoSocial.TabIndex = 114;
            this.lblRazaoSocial.Text = "* Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRazaoSocial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRazaoSocial.Location = new System.Drawing.Point(232, 102);
            this.txtRazaoSocial.MaxLength = 100;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(405, 23);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeFantasia.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeFantasia.Location = new System.Drawing.Point(232, 154);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(200, 23);
            this.txtNomeFantasia.TabIndex = 2;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeFantasia.Location = new System.Drawing.Point(230, 138);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(91, 13);
            this.lblNomeFantasia.TabIndex = 111;
            this.lblNomeFantasia.Text = "* Nome Fantasia";
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlLinha2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha2.Location = new System.Drawing.Point(231, 667);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(405, 1);
            this.pnlLinha2.TabIndex = 148;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo2.Location = new System.Drawing.Point(229, 636);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(111, 13);
            this.lblTitulo2.TabIndex = 147;
            this.lblTitulo2.Text = "DADOS BANCÁRIOS";
            // 
            // txtConta
            // 
            this.txtConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConta.Location = new System.Drawing.Point(487, 769);
            this.txtConta.MaxLength = 20;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(150, 23);
            this.txtConta.TabIndex = 20;
            // 
            // txtOperador
            // 
            this.txtOperador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOperador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOperador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOperador.Location = new System.Drawing.Point(388, 769);
            this.txtOperador.MaxLength = 3;
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(93, 23);
            this.txtOperador.TabIndex = 19;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAgencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgencia.Location = new System.Drawing.Point(232, 769);
            this.txtAgencia.MaxLength = 6;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(150, 23);
            this.txtAgencia.TabIndex = 18;
            // 
            // txtBanco
            // 
            this.txtBanco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBanco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBanco.Location = new System.Drawing.Point(232, 717);
            this.txtBanco.MaxLength = 100;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(200, 23);
            this.txtBanco.TabIndex = 16;
            // 
            // lblConta
            // 
            this.lblConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConta.Location = new System.Drawing.Point(484, 753);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(38, 13);
            this.lblConta.TabIndex = 153;
            this.lblConta.Text = "Conta";
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOperador.Location = new System.Drawing.Point(385, 753);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(57, 13);
            this.lblOperador.TabIndex = 152;
            this.lblOperador.Text = "Operador";
            // 
            // lblAgencia
            // 
            this.lblAgencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAgencia.Location = new System.Drawing.Point(230, 753);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(48, 13);
            this.lblAgencia.TabIndex = 151;
            this.lblAgencia.Text = "Agência";
            // 
            // lblTipoDeConta
            // 
            this.lblTipoDeConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoDeConta.AutoSize = true;
            this.lblTipoDeConta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeConta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipoDeConta.Location = new System.Drawing.Point(434, 701);
            this.lblTipoDeConta.Name = "lblTipoDeConta";
            this.lblTipoDeConta.Size = new System.Drawing.Size(80, 13);
            this.lblTipoDeConta.TabIndex = 150;
            this.lblTipoDeConta.Text = "Tipo de Conta";
            // 
            // lblBanco
            // 
            this.lblBanco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBanco.Location = new System.Drawing.Point(230, 701);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 13);
            this.lblBanco.TabIndex = 149;
            this.lblBanco.Text = "Banco";
            // 
            // cboTipoDeConta
            // 
            this.cboTipoDeConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoDeConta.AutoCompleteCustomSource.AddRange(new string[] {
            "Conta Corrente de Pessoa Física",
            "Conta Simples de Pessoa Física",
            "Conta Corrente de Pessoa Jurídica",
            "Entidades Públicas",
            "Depósitos Instituições Financeiras",
            "Poupança de Pessoa Física",
            "Poupança de Pessoa Jurídica",
            "Conta Caixa Fácil",
            "Poupança de Crédito Imobiliário",
            "Conta Investimento Pessoa Física",
            "Conta Investimento Pessoa Jurídica",
            "Conta Salário",
            "Depósitos Lotéricos",
            "Poupança Integrada"});
            this.cboTipoDeConta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboTipoDeConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDeConta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboTipoDeConta.FormattingEnabled = true;
            this.cboTipoDeConta.Items.AddRange(new object[] {
            "Conta Corrente de Pessoa Física",
            "Conta Simples de Pessoa Física",
            "Conta Corrente de Pessoa Jurídica",
            "Entidades Públicas",
            "Depósitos Instituições Financeiras",
            "Poupança de Pessoa Física",
            "Poupança de Pessoa Jurídica",
            "Conta Caixa Fácil",
            "Poupança de Crédito Imobiliário",
            "Conta Investimento Pessoa Física",
            "Conta Investimento Pessoa Jurídica",
            "Conta Salário",
            "Depósitos Lotéricos",
            "Poupança Integrada"});
            this.cboTipoDeConta.Location = new System.Drawing.Point(437, 717);
            this.cboTipoDeConta.Name = "cboTipoDeConta";
            this.cboTipoDeConta.Size = new System.Drawing.Size(200, 23);
            this.cboTipoDeConta.TabIndex = 17;
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
            this.cboUF.Location = new System.Drawing.Point(437, 414);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(75, 23);
            this.cboUF.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone.Location = new System.Drawing.Point(232, 518);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 23);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Validated += new System.EventHandler(this.txtTelefone_Validated);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCNPJ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCNPJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCNPJ.Location = new System.Drawing.Point(232, 50);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(200, 23);
            this.txtCNPJ.TabIndex = 0;
            this.txtCNPJ.Enter += new System.EventHandler(this.txtCNPJ_Enter);
            this.txtCNPJ.Validated += new System.EventHandler(this.txtCNPJ_Validated);
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone2.Location = new System.Drawing.Point(437, 518);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(200, 23);
            this.txtTelefone2.TabIndex = 14;
            this.txtTelefone2.Enter += new System.EventHandler(this.txtTelefone2_Enter);
            this.txtTelefone2.Validated += new System.EventHandler(this.txtTelefone2_Validated);
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone2.Location = new System.Drawing.Point(434, 502);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone2.TabIndex = 155;
            this.lblTelefone2.Text = "Telefone 2";
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCEP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCEP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCEP.Location = new System.Drawing.Point(231, 414);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(200, 23);
            this.txtCEP.TabIndex = 10;
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Enter);
            this.txtCEP.Validated += new System.EventHandler(this.txtCEP_Validated);
            // 
            // txtConstituicao
            // 
            this.txtConstituicao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConstituicao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtConstituicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstituicao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConstituicao.Location = new System.Drawing.Point(437, 154);
            this.txtConstituicao.Name = "txtConstituicao";
            this.txtConstituicao.Size = new System.Drawing.Size(200, 23);
            this.txtConstituicao.TabIndex = 3;
            this.txtConstituicao.ValidatingType = typeof(System.DateTime);
            this.txtConstituicao.Enter += new System.EventHandler(this.txtConstituicao_Enter);
            this.txtConstituicao.Validated += new System.EventHandler(this.txtConstituicao_Validated);
            // 
            // frmDadosCadastrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(937, 580);
            this.Controls.Add(this.txtConstituicao);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.cboTipoDeConta);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblTipoDeConta);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.pnlLinha2);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRepresentanteLegal);
            this.Controls.Add(this.lblRepresentanteLegal);
            this.Controls.Add(this.lblDataConstituinte);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtInscricaoMunicipal);
            this.Controls.Add(this.txtInscricaoEstadual);
            this.Controls.Add(this.lblInscricaoMunicipal);
            this.Controls.Add(this.lblInscricaoEstadual);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDadosCadastrais";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Cadastrais";
            this.Load += new System.EventHandler(this.frmDadosCadastrais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarSalvar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRepresentanteLegal;
        private System.Windows.Forms.Label lblRepresentanteLegal;
        private System.Windows.Forms.Label lblDataConstituinte;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtInscricaoMunicipal;
        private System.Windows.Forms.TextBox txtInscricaoEstadual;
        private System.Windows.Forms.Label lblInscricaoMunicipal;
        private System.Windows.Forms.Label lblInscricaoEstadual;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblTipoDeConta;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cboTipoDeConta;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtConstituicao;
    }
}