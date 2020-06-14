namespace Arqueng.VIEW
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
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
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
            this.txtEntidade = new System.Windows.Forms.TextBox();
            this.lblEntidadedeClasse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCPF.Location = new System.Drawing.Point(307, 152);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(150, 23);
            this.txtCPF.TabIndex = 2;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNascimento.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(307, 200);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(150, 23);
            this.dtpNascimento.TabIndex = 3;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDataNascimento.Location = new System.Drawing.Point(304, 184);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(94, 13);
            this.lblDataNascimento.TabIndex = 284;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone2.Location = new System.Drawing.Point(467, 389);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(150, 23);
            this.txtTelefone2.TabIndex = 8;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefone1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefone1.Location = new System.Drawing.Point(307, 389);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(150, 23);
            this.txtTelefone1.TabIndex = 7;
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone2.Location = new System.Drawing.Point(464, 373);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone2.TabIndex = 283;
            this.lblTelefone2.Text = "Telefone 2";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(304, 420);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 282;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefone1.Location = new System.Drawing.Point(304, 372);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone1.TabIndex = 281;
            this.lblTelefone1.Text = "Telefone 1";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(307, 435);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCPF.Location = new System.Drawing.Point(304, 136);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(26, 13);
            this.lblCPF.TabIndex = 280;
            this.lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(307, 105);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(304, 89);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(37, 13);
            this.lblNome.TabIndex = 279;
            this.lblNome.Text = "Nome";
            // 
            // lblCarteiraProfissional
            // 
            this.lblCarteiraProfissional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCarteiraProfissional.AutoSize = true;
            this.lblCarteiraProfissional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteiraProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCarteiraProfissional.Location = new System.Drawing.Point(302, 278);
            this.lblCarteiraProfissional.Name = "lblCarteiraProfissional";
            this.lblCarteiraProfissional.Size = new System.Drawing.Size(110, 13);
            this.lblCarteiraProfissional.TabIndex = 278;
            this.lblCarteiraProfissional.Text = "Carteira Profissional";
            // 
            // txtCarteira
            // 
            this.txtCarteira.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarteira.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCarteira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCarteira.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarteira.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCarteira.Location = new System.Drawing.Point(307, 294);
            this.txtCarteira.MaxLength = 100;
            this.txtCarteira.Name = "txtCarteira";
            this.txtCarteira.Size = new System.Drawing.Size(310, 23);
            this.txtCarteira.TabIndex = 5;
            // 
            // txtEntidade
            // 
            this.txtEntidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEntidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEntidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEntidade.Location = new System.Drawing.Point(307, 341);
            this.txtEntidade.MaxLength = 100;
            this.txtEntidade.Name = "txtEntidade";
            this.txtEntidade.Size = new System.Drawing.Size(310, 23);
            this.txtEntidade.TabIndex = 6;
            // 
            // lblEntidadedeClasse
            // 
            this.lblEntidadedeClasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEntidadedeClasse.AutoSize = true;
            this.lblEntidadedeClasse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadedeClasse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEntidadedeClasse.Location = new System.Drawing.Point(304, 325);
            this.lblEntidadedeClasse.Name = "lblEntidadedeClasse";
            this.lblEntidadedeClasse.Size = new System.Drawing.Size(104, 13);
            this.lblEntidadedeClasse.TabIndex = 277;
            this.lblEntidadedeClasse.Text = "Entidade de Classe";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(347, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 276;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo.Location = new System.Drawing.Point(307, 58);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigo.Location = new System.Drawing.Point(304, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 13);
            this.lblCodigo.TabIndex = 275;
            this.lblCodigo.Text = "* Código";
            // 
            // txtProfissao
            // 
            this.txtProfissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProfissao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfissao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProfissao.Location = new System.Drawing.Point(307, 247);
            this.txtProfissao.MaxLength = 100;
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(310, 23);
            this.txtProfissao.TabIndex = 4;
            // 
            // lblProfissao
            // 
            this.lblProfissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProfissao.Location = new System.Drawing.Point(304, 231);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(54, 13);
            this.lblProfissao.TabIndex = 274;
            this.lblProfissao.Text = "Profissão";
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLinha2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha2.Location = new System.Drawing.Point(305, 489);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(310, 1);
            this.pnlLinha2.TabIndex = 288;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(361, 521);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 25);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSave.Location = new System.Drawing.Point(492, 521);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(125, 25);
            this.btnAddSave.TabIndex = 10;
            this.btnAddSave.Text = "&Adicionar";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // frmAddProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.pnlLinha2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCarteiraProfissional);
            this.Controls.Add(this.txtCarteira);
            this.Controls.Add(this.txtEntidade);
            this.Controls.Add(this.lblEntidadedeClasse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.lblProfissao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Profissional";
            this.Load += new System.EventHandler(this.frmAddProfissional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
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
        private System.Windows.Forms.TextBox txtEntidade;
        private System.Windows.Forms.Label lblEntidadedeClasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddSave;
    }
}