namespace Fluxus.Application.View
{
    partial class frmAddOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOS));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.rbtRecebida = new System.Windows.Forms.RadioButton();
            this.rbtPendente = new System.Windows.Forms.RadioButton();
            this.rbtConcluida = new System.Windows.Forms.RadioButton();
            this.rbtVistoriada = new System.Windows.Forms.RadioButton();
            this.ttpAddOS = new System.Windows.Forms.ToolTip(this.components);
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblDataExecucao = new System.Windows.Forms.Label();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.cboAtividade = new System.Windows.Forms.ComboBox();
            this.chkSiopi = new System.Windows.Forms.CheckBox();
            this.lblProfissional = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNomeContato = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.lblTelefoneContato = new System.Windows.Forms.Label();
            this.txtTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.txtAgenciaEmail = new System.Windows.Forms.TextBox();
            this.txtAgenciaTelefone = new System.Windows.Forms.TextBox();
            this.txtAgenciaNome = new System.Windows.Forms.TextBox();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.lblNomeProfissional = new System.Windows.Forms.Label();
            this.lblAtividadeDeslocamento = new System.Windows.Forms.Label();
            this.lblAtividadeValor = new System.Windows.Forms.Label();
            this.lblAtividadeNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodFatura = new System.Windows.Forms.TextBox();
            this.lblFaturada = new System.Windows.Forms.Label();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.pnlBotton = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.txtDataConcluida = new System.Windows.Forms.MaskedTextBox();
            this.txtDataVistoria = new System.Windows.Forms.MaskedTextBox();
            this.txtDataPendente = new System.Windows.Forms.MaskedTextBox();
            this.tabOS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlReferencia = new System.Windows.Forms.Panel();
            this.txtRef0 = new System.Windows.Forms.TextBox();
            this.lblPonto5Ref = new System.Windows.Forms.Label();
            this.txtRef1 = new System.Windows.Forms.TextBox();
            this.txtRef6 = new System.Windows.Forms.TextBox();
            this.lblPonto1Ref = new System.Windows.Forms.Label();
            this.lblPonto4Ref = new System.Windows.Forms.Label();
            this.txtRef2 = new System.Windows.Forms.TextBox();
            this.txtRef5 = new System.Windows.Forms.TextBox();
            this.lblPonto2Ref = new System.Windows.Forms.Label();
            this.lblPonto3Ref = new System.Windows.Forms.Label();
            this.lblBarraRef = new System.Windows.Forms.Label();
            this.txtRef4 = new System.Windows.Forms.TextBox();
            this.txtRef3 = new System.Windows.Forms.TextBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.btnAddAgencia = new System.Windows.Forms.Button();
            this.txtCoordenada = new System.Windows.Forms.TextBox();
            this.txtDataOrdem = new System.Windows.Forms.MaskedTextBox();
            this.lblCoordenada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlBotton.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.tabOS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlReferencia.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(565, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSave.Location = new System.Drawing.Point(696, 13);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(200, 25);
            this.btnAddSave.TabIndex = 0;
            this.btnAddSave.TabStop = false;
            this.btnAddSave.Text = "&Adicionar";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // rbtRecebida
            // 
            this.rbtRecebida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtRecebida.AutoSize = true;
            this.rbtRecebida.Checked = true;
            this.rbtRecebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtRecebida.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtRecebida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtRecebida.Location = new System.Drawing.Point(38, 3);
            this.rbtRecebida.Name = "rbtRecebida";
            this.rbtRecebida.Size = new System.Drawing.Size(71, 17);
            this.rbtRecebida.TabIndex = 0;
            this.rbtRecebida.TabStop = true;
            this.rbtRecebida.Text = "Recebida";
            this.rbtRecebida.UseVisualStyleBackColor = true;
            this.rbtRecebida.CheckedChanged += new System.EventHandler(this.rbtRecebida_CheckedChanged);
            // 
            // rbtPendente
            // 
            this.rbtPendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtPendente.AutoSize = true;
            this.rbtPendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtPendente.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtPendente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtPendente.Location = new System.Drawing.Point(186, 3);
            this.rbtPendente.Name = "rbtPendente";
            this.rbtPendente.Size = new System.Drawing.Size(73, 17);
            this.rbtPendente.TabIndex = 1;
            this.rbtPendente.Text = "Pendente";
            this.rbtPendente.UseVisualStyleBackColor = true;
            this.rbtPendente.CheckedChanged += new System.EventHandler(this.rbtPendente_CheckedChanged);
            // 
            // rbtConcluida
            // 
            this.rbtConcluida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtConcluida.AutoSize = true;
            this.rbtConcluida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtConcluida.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtConcluida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtConcluida.Location = new System.Drawing.Point(483, 3);
            this.rbtConcluida.Name = "rbtConcluida";
            this.rbtConcluida.Size = new System.Drawing.Size(76, 17);
            this.rbtConcluida.TabIndex = 3;
            this.rbtConcluida.Text = "Concluída";
            this.rbtConcluida.UseVisualStyleBackColor = true;
            this.rbtConcluida.CheckedChanged += new System.EventHandler(this.rbtConcluida_CheckedChanged);
            // 
            // rbtVistoriada
            // 
            this.rbtVistoriada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtVistoriada.AutoSize = true;
            this.rbtVistoriada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtVistoriada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtVistoriada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtVistoriada.Location = new System.Drawing.Point(334, 3);
            this.rbtVistoriada.Name = "rbtVistoriada";
            this.rbtVistoriada.Size = new System.Drawing.Size(76, 17);
            this.rbtVistoriada.TabIndex = 2;
            this.rbtVistoriada.Text = "Vistoriada";
            this.rbtVistoriada.UseVisualStyleBackColor = true;
            this.rbtVistoriada.CheckedChanged += new System.EventHandler(this.rbtVistoriada_CheckedChanged);
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReferencia.Location = new System.Drawing.Point(21, 30);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(69, 13);
            this.lblReferencia.TabIndex = 0;
            this.lblReferencia.Text = "* Referência";
            // 
            // lblDataExecucao
            // 
            this.lblDataExecucao.AutoSize = true;
            this.lblDataExecucao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataExecucao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDataExecucao.Location = new System.Drawing.Point(243, 198);
            this.lblDataExecucao.Name = "lblDataExecucao";
            this.lblDataExecucao.Size = new System.Drawing.Size(85, 13);
            this.lblDataExecucao.TabIndex = 347;
            this.lblDataExecucao.Text = "Prazo Execução";
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividade.Location = new System.Drawing.Point(21, 146);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(55, 13);
            this.lblAtividade.TabIndex = 350;
            this.lblAtividade.Text = "Atividade";
            // 
            // cboAtividade
            // 
            this.cboAtividade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboAtividade.DisplayMember = "codigo";
            this.cboAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAtividade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAtividade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboAtividade.FormattingEnabled = true;
            this.cboAtividade.Location = new System.Drawing.Point(127, 140);
            this.cboAtividade.MaxLength = 10;
            this.cboAtividade.Name = "cboAtividade";
            this.cboAtividade.Size = new System.Drawing.Size(90, 23);
            this.cboAtividade.TabIndex = 3;
            this.cboAtividade.ValueMember = "codigo";
            this.cboAtividade.SelectionChangeCommitted += new System.EventHandler(this.cboAtividade_SelectionChangeCommitted);
            // 
            // chkSiopi
            // 
            this.chkSiopi.AutoSize = true;
            this.chkSiopi.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkSiopi.Checked = true;
            this.chkSiopi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSiopi.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkSiopi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkSiopi.Location = new System.Drawing.Point(552, 29);
            this.chkSiopi.Name = "chkSiopi";
            this.chkSiopi.Size = new System.Drawing.Size(15, 14);
            this.chkSiopi.TabIndex = 1;
            this.chkSiopi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSiopi.UseCompatibleTextRendering = true;
            this.chkSiopi.UseVisualStyleBackColor = true;
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProfissional.Location = new System.Drawing.Point(21, 112);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(67, 13);
            this.lblProfissional.TabIndex = 355;
            this.lblProfissional.Text = "Profissional";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCliente.Location = new System.Drawing.Point(21, 257);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(93, 13);
            this.lblCliente.TabIndex = 358;
            this.lblCliente.Text = "Nome do Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeCliente.Location = new System.Drawing.Point(127, 253);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(442, 23);
            this.txtNomeCliente.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCidade.Location = new System.Drawing.Point(21, 292);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 360;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNomeContato
            // 
            this.lblNomeContato.AutoSize = true;
            this.lblNomeContato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeContato.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeContato.Location = new System.Drawing.Point(21, 327);
            this.lblNomeContato.Name = "lblNomeContato";
            this.lblNomeContato.Size = new System.Drawing.Size(99, 13);
            this.lblNomeContato.TabIndex = 362;
            this.lblNomeContato.Text = "Nome do Contato";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeContato.Location = new System.Drawing.Point(127, 323);
            this.txtNomeContato.MaxLength = 100;
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(200, 23);
            this.txtNomeContato.TabIndex = 8;
            // 
            // lblTelefoneContato
            // 
            this.lblTelefoneContato.AutoSize = true;
            this.lblTelefoneContato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneContato.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefoneContato.Location = new System.Drawing.Point(389, 324);
            this.lblTelefoneContato.Name = "lblTelefoneContato";
            this.lblTelefoneContato.Size = new System.Drawing.Size(51, 13);
            this.lblTelefoneContato.TabIndex = 364;
            this.lblTelefoneContato.Text = "Telefone";
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefoneContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefoneContato.Location = new System.Drawing.Point(449, 323);
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(120, 23);
            this.txtTelefoneContato.TabIndex = 9;
            this.txtTelefoneContato.Tag = "telefone";
            this.txtTelefoneContato.Enter += new System.EventHandler(this.OnEnter_MaskedTextBox);
            this.txtTelefoneContato.Validated += new System.EventHandler(this.OnValidated_MaskedTextBox);
            // 
            // txtAgenciaEmail
            // 
            this.txtAgenciaEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtAgenciaEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaEmail.Location = new System.Drawing.Point(305, 65);
            this.txtAgenciaEmail.MaxLength = 100;
            this.txtAgenciaEmail.Name = "txtAgenciaEmail";
            this.txtAgenciaEmail.ReadOnly = true;
            this.txtAgenciaEmail.Size = new System.Drawing.Size(262, 15);
            this.txtAgenciaEmail.TabIndex = 402;
            this.txtAgenciaEmail.TabStop = false;
            this.txtAgenciaEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAgenciaTelefone
            // 
            this.txtAgenciaTelefone.BackColor = System.Drawing.Color.LightGray;
            this.txtAgenciaTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaTelefone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaTelefone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaTelefone.Location = new System.Drawing.Point(127, 65);
            this.txtAgenciaTelefone.MaxLength = 100;
            this.txtAgenciaTelefone.Name = "txtAgenciaTelefone";
            this.txtAgenciaTelefone.ReadOnly = true;
            this.txtAgenciaTelefone.Size = new System.Drawing.Size(178, 15);
            this.txtAgenciaTelefone.TabIndex = 401;
            this.txtAgenciaTelefone.TabStop = false;
            this.txtAgenciaTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAgenciaNome
            // 
            this.txtAgenciaNome.BackColor = System.Drawing.Color.LightGray;
            this.txtAgenciaNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaNome.Location = new System.Drawing.Point(127, 50);
            this.txtAgenciaNome.MaxLength = 100;
            this.txtAgenciaNome.Name = "txtAgenciaNome";
            this.txtAgenciaNome.ReadOnly = true;
            this.txtAgenciaNome.Size = new System.Drawing.Size(440, 15);
            this.txtAgenciaNome.TabIndex = 400;
            this.txtAgenciaNome.TabStop = false;
            this.txtAgenciaNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboProfissional
            // 
            this.cboProfissional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboProfissional.DisplayMember = "codigo";
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfissional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(127, 106);
            this.cboProfissional.MaxLength = 3;
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(90, 23);
            this.cboProfissional.TabIndex = 2;
            this.cboProfissional.ValueMember = "codigo";
            this.cboProfissional.SelectionChangeCommitted += new System.EventHandler(this.cboProfissional_SelectionChangeCommitted);
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.BackColor = System.Drawing.Color.LightGray;
            this.lblNomeProfissional.Enabled = false;
            this.lblNomeProfissional.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeProfissional.Location = new System.Drawing.Point(218, 107);
            this.lblNomeProfissional.Name = "lblNomeProfissional";
            this.lblNomeProfissional.Size = new System.Drawing.Size(349, 23);
            this.lblNomeProfissional.TabIndex = 403;
            this.lblNomeProfissional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeDeslocamento
            // 
            this.lblAtividadeDeslocamento.BackColor = System.Drawing.Color.LightGray;
            this.lblAtividadeDeslocamento.Enabled = false;
            this.lblAtividadeDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeDeslocamento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeDeslocamento.Location = new System.Drawing.Point(392, 151);
            this.lblAtividadeDeslocamento.Name = "lblAtividadeDeslocamento";
            this.lblAtividadeDeslocamento.Size = new System.Drawing.Size(175, 13);
            this.lblAtividadeDeslocamento.TabIndex = 406;
            this.lblAtividadeDeslocamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeValor
            // 
            this.lblAtividadeValor.BackColor = System.Drawing.Color.LightGray;
            this.lblAtividadeValor.Enabled = false;
            this.lblAtividadeValor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeValor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeValor.Location = new System.Drawing.Point(218, 151);
            this.lblAtividadeValor.Name = "lblAtividadeValor";
            this.lblAtividadeValor.Size = new System.Drawing.Size(174, 13);
            this.lblAtividadeValor.TabIndex = 405;
            this.lblAtividadeValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeNome
            // 
            this.lblAtividadeNome.BackColor = System.Drawing.Color.LightGray;
            this.lblAtividadeNome.Enabled = false;
            this.lblAtividadeNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeNome.Location = new System.Drawing.Point(218, 140);
            this.lblAtividadeNome.Name = "lblAtividadeNome";
            this.lblAtividadeNome.Size = new System.Drawing.Size(349, 13);
            this.lblAtividadeNome.TabIndex = 404;
            this.lblAtividadeNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(505, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 416;
            this.label3.Text = "SIOPI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodFatura
            // 
            this.txtCodFatura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodFatura.BackColor = System.Drawing.Color.LightBlue;
            this.txtCodFatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodFatura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFatura.ForeColor = System.Drawing.Color.Black;
            this.txtCodFatura.Location = new System.Drawing.Point(16, 26);
            this.txtCodFatura.MaxLength = 100;
            this.txtCodFatura.Name = "txtCodFatura";
            this.txtCodFatura.ReadOnly = true;
            this.txtCodFatura.Size = new System.Drawing.Size(146, 16);
            this.txtCodFatura.TabIndex = 414;
            this.txtCodFatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodFatura.Visible = false;
            // 
            // lblFaturada
            // 
            this.lblFaturada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFaturada.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturada.ForeColor = System.Drawing.Color.Red;
            this.lblFaturada.Location = new System.Drawing.Point(12, 7);
            this.lblFaturada.Name = "lblFaturada";
            this.lblFaturada.Size = new System.Drawing.Size(150, 20);
            this.lblFaturada.TabIndex = 412;
            this.lblFaturada.Text = "OS FATURADA";
            this.lblFaturada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFaturada.Visible = false;
            // 
            // txtOBS
            // 
            this.txtOBS.AcceptsReturn = true;
            this.txtOBS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOBS.Location = new System.Drawing.Point(10, 10);
            this.txtOBS.MaxLength = 250;
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(572, 377);
            this.txtOBS.TabIndex = 0;
            // 
            // pnlBotton
            // 
            this.pnlBotton.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBotton.Controls.Add(this.btnAddSave);
            this.pnlBotton.Controls.Add(this.btnCancelar);
            this.pnlBotton.Controls.Add(this.txtCodFatura);
            this.pnlBotton.Controls.Add(this.lblFaturada);
            this.pnlBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotton.Location = new System.Drawing.Point(0, 530);
            this.pnlBotton.Name = "pnlBotton";
            this.pnlBotton.Size = new System.Drawing.Size(920, 50);
            this.pnlBotton.TabIndex = 8;
            // 
            // pnlDados
            // 
            this.pnlDados.AutoScroll = true;
            this.pnlDados.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDados.Controls.Add(this.pnlStatus);
            this.pnlDados.Controls.Add(this.tabOS);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(920, 580);
            this.pnlDados.TabIndex = 1;
            // 
            // txtDataConcluida
            // 
            this.txtDataConcluida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataConcluida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataConcluida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataConcluida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataConcluida.Location = new System.Drawing.Point(498, 25);
            this.txtDataConcluida.Mask = "00/00/0000";
            this.txtDataConcluida.Name = "txtDataConcluida";
            this.txtDataConcluida.Size = new System.Drawing.Size(90, 23);
            this.txtDataConcluida.TabIndex = 6;
            this.txtDataConcluida.TabStop = false;
            this.txtDataConcluida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtDataConcluida.ValidatingType = typeof(System.DateTime);
            this.txtDataConcluida.Visible = false;
            // 
            // txtDataVistoria
            // 
            this.txtDataVistoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataVistoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataVistoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVistoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataVistoria.Location = new System.Drawing.Point(349, 25);
            this.txtDataVistoria.Mask = "00/00/0000";
            this.txtDataVistoria.Name = "txtDataVistoria";
            this.txtDataVistoria.Size = new System.Drawing.Size(90, 23);
            this.txtDataVistoria.TabIndex = 4;
            this.txtDataVistoria.TabStop = false;
            this.txtDataVistoria.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtDataVistoria.ValidatingType = typeof(System.DateTime);
            this.txtDataVistoria.Visible = false;
            // 
            // txtDataPendente
            // 
            this.txtDataPendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataPendente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataPendente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPendente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataPendente.Location = new System.Drawing.Point(200, 25);
            this.txtDataPendente.Mask = "00/00/0000";
            this.txtDataPendente.Name = "txtDataPendente";
            this.txtDataPendente.Size = new System.Drawing.Size(90, 23);
            this.txtDataPendente.TabIndex = 2;
            this.txtDataPendente.TabStop = false;
            this.txtDataPendente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtDataPendente.ValidatingType = typeof(System.DateTime);
            this.txtDataPendente.Visible = false;
            // 
            // tabOS
            // 
            this.tabOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabOS.Controls.Add(this.tabPage1);
            this.tabOS.Controls.Add(this.tabPage3);
            this.tabOS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOS.HotTrack = true;
            this.tabOS.ItemSize = new System.Drawing.Size(160, 35);
            this.tabOS.Location = new System.Drawing.Point(160, 16);
            this.tabOS.Margin = new System.Windows.Forms.Padding(0);
            this.tabOS.Multiline = true;
            this.tabOS.Name = "tabOS";
            this.tabOS.Padding = new System.Drawing.Point(0, 0);
            this.tabOS.SelectedIndex = 0;
            this.tabOS.Size = new System.Drawing.Size(600, 440);
            this.tabOS.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabOS.TabIndex = 0;
            this.tabOS.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlReferencia);
            this.tabPage1.Controls.Add(this.cboAtividade);
            this.tabPage1.Controls.Add(this.cboProfissional);
            this.tabPage1.Controls.Add(this.cboCidade);
            this.tabPage1.Controls.Add(this.dtpPrazo);
            this.tabPage1.Controls.Add(this.btnAddAgencia);
            this.tabPage1.Controls.Add(this.txtCoordenada);
            this.tabPage1.Controls.Add(this.txtDataOrdem);
            this.tabPage1.Controls.Add(this.lblCoordenada);
            this.tabPage1.Controls.Add(this.lblReferencia);
            this.tabPage1.Controls.Add(this.txtNomeCliente);
            this.tabPage1.Controls.Add(this.txtAgenciaTelefone);
            this.tabPage1.Controls.Add(this.lblNomeProfissional);
            this.tabPage1.Controls.Add(this.lblAtividadeDeslocamento);
            this.tabPage1.Controls.Add(this.lblCliente);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblAtividadeValor);
            this.tabPage1.Controls.Add(this.lblAtividade);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblProfissional);
            this.tabPage1.Controls.Add(this.lblCidade);
            this.tabPage1.Controls.Add(this.lblAtividadeNome);
            this.tabPage1.Controls.Add(this.txtNomeContato);
            this.tabPage1.Controls.Add(this.txtAgenciaNome);
            this.tabPage1.Controls.Add(this.txtTelefoneContato);
            this.tabPage1.Controls.Add(this.lblNomeContato);
            this.tabPage1.Controls.Add(this.chkSiopi);
            this.tabPage1.Controls.Add(this.lblDataExecucao);
            this.tabPage1.Controls.Add(this.lblTelefoneContato);
            this.tabPage1.Controls.Add(this.txtAgenciaEmail);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(592, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da Ordem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlReferencia
            // 
            this.pnlReferencia.BackColor = System.Drawing.Color.Transparent;
            this.pnlReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReferencia.Controls.Add(this.txtRef0);
            this.pnlReferencia.Controls.Add(this.lblPonto5Ref);
            this.pnlReferencia.Controls.Add(this.txtRef1);
            this.pnlReferencia.Controls.Add(this.txtRef6);
            this.pnlReferencia.Controls.Add(this.lblPonto1Ref);
            this.pnlReferencia.Controls.Add(this.lblPonto4Ref);
            this.pnlReferencia.Controls.Add(this.txtRef2);
            this.pnlReferencia.Controls.Add(this.txtRef5);
            this.pnlReferencia.Controls.Add(this.lblPonto2Ref);
            this.pnlReferencia.Controls.Add(this.lblPonto3Ref);
            this.pnlReferencia.Controls.Add(this.lblBarraRef);
            this.pnlReferencia.Controls.Add(this.txtRef4);
            this.pnlReferencia.Controls.Add(this.txtRef3);
            this.pnlReferencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlReferencia.Location = new System.Drawing.Point(127, 25);
            this.pnlReferencia.Name = "pnlReferencia";
            this.pnlReferencia.Size = new System.Drawing.Size(362, 23);
            this.pnlReferencia.TabIndex = 0;
            this.pnlReferencia.Validated += new System.EventHandler(this.pnlReferencia_Validated);
            // 
            // txtRef0
            // 
            this.txtRef0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRef0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRef0.Location = new System.Drawing.Point(3, 2);
            this.txtRef0.MaxLength = 4;
            this.txtRef0.Name = "txtRef0";
            this.txtRef0.Size = new System.Drawing.Size(30, 16);
            this.txtRef0.TabIndex = 0;
            this.txtRef0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRef0.TextChanged += new System.EventHandler(this.NextControl);
            // 
            // lblPonto5Ref
            // 
            this.lblPonto5Ref.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto5Ref.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPonto5Ref.Location = new System.Drawing.Point(213, 3);
            this.lblPonto5Ref.Margin = new System.Windows.Forms.Padding(0);
            this.lblPonto5Ref.Name = "lblPonto5Ref";
            this.lblPonto5Ref.Size = new System.Drawing.Size(10, 13);
            this.lblPonto5Ref.TabIndex = 442;
            this.lblPonto5Ref.Text = ".";
            // 
            // txtRef1
            // 
            this.txtRef1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRef1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRef1.Location = new System.Drawing.Point(36, 2);
            this.txtRef1.MaxLength = 4;
            this.txtRef1.Name = "txtRef1";
            this.txtRef1.Size = new System.Drawing.Size(30, 16);
            this.txtRef1.TabIndex = 1;
            this.txtRef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRef1.TextChanged += new System.EventHandler(this.NextControl);
            this.txtRef1.Validated += new System.EventHandler(this.txtRef1_Validated);
            // 
            // txtRef6
            // 
            this.txtRef6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRef6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRef6.Location = new System.Drawing.Point(219, 2);
            this.txtRef6.MaxLength = 2;
            this.txtRef6.Name = "txtRef6";
            this.txtRef6.Size = new System.Drawing.Size(20, 16);
            this.txtRef6.TabIndex = 6;
            this.txtRef6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRef6.TextChanged += new System.EventHandler(this.NextControl);
            // 
            // lblPonto1Ref
            // 
            this.lblPonto1Ref.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto1Ref.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPonto1Ref.Location = new System.Drawing.Point(30, 4);
            this.lblPonto1Ref.Margin = new System.Windows.Forms.Padding(0);
            this.lblPonto1Ref.Name = "lblPonto1Ref";
            this.lblPonto1Ref.Size = new System.Drawing.Size(10, 13);
            this.lblPonto1Ref.TabIndex = 431;
            this.lblPonto1Ref.Text = ".";
            // 
            // lblPonto4Ref
            // 
            this.lblPonto4Ref.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto4Ref.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPonto4Ref.Location = new System.Drawing.Point(191, 3);
            this.lblPonto4Ref.Margin = new System.Windows.Forms.Padding(0);
            this.lblPonto4Ref.Name = "lblPonto4Ref";
            this.lblPonto4Ref.Size = new System.Drawing.Size(10, 13);
            this.lblPonto4Ref.TabIndex = 440;
            this.lblPonto4Ref.Text = ".";
            // 
            // txtRef2
            // 
            this.txtRef2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRef2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRef2.Location = new System.Drawing.Point(69, 2);
            this.txtRef2.Margin = new System.Windows.Forms.Padding(0);
            this.txtRef2.MaxLength = 9;
            this.txtRef2.Name = "txtRef2";
            this.txtRef2.Size = new System.Drawing.Size(65, 16);
            this.txtRef2.TabIndex = 2;
            this.txtRef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRef2.Validated += new System.EventHandler(this.txtRef2_Validated);
            // 
            // txtRef5
            // 
            this.txtRef5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRef5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRef5.Location = new System.Drawing.Point(197, 2);
            this.txtRef5.MaxLength = 2;
            this.txtRef5.Name = "txtRef5";
            this.txtRef5.Size = new System.Drawing.Size(20, 16);
            this.txtRef5.TabIndex = 5;
            this.txtRef5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRef5.TextChanged += new System.EventHandler(this.NextControl);
            // 
            // lblPonto2Ref
            // 
            this.lblPonto2Ref.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto2Ref.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPonto2Ref.Location = new System.Drawing.Point(63, 3);
            this.lblPonto2Ref.Margin = new System.Windows.Forms.Padding(0);
            this.lblPonto2Ref.Name = "lblPonto2Ref";
            this.lblPonto2Ref.Size = new System.Drawing.Size(10, 13);
            this.lblPonto2Ref.TabIndex = 434;
            this.lblPonto2Ref.Text = ".";
            // 
            // lblPonto3Ref
            // 
            this.lblPonto3Ref.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto3Ref.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPonto3Ref.Location = new System.Drawing.Point(169, 3);
            this.lblPonto3Ref.Margin = new System.Windows.Forms.Padding(0);
            this.lblPonto3Ref.Name = "lblPonto3Ref";
            this.lblPonto3Ref.Size = new System.Drawing.Size(10, 13);
            this.lblPonto3Ref.TabIndex = 438;
            this.lblPonto3Ref.Text = ".";
            // 
            // lblBarraRef
            // 
            this.lblBarraRef.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraRef.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBarraRef.Location = new System.Drawing.Point(131, 3);
            this.lblBarraRef.Margin = new System.Windows.Forms.Padding(0);
            this.lblBarraRef.Name = "lblBarraRef";
            this.lblBarraRef.Size = new System.Drawing.Size(10, 13);
            this.lblBarraRef.TabIndex = 435;
            this.lblBarraRef.Text = "/";
            // 
            // txtRef4
            // 
            this.txtRef4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRef4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRef4.Location = new System.Drawing.Point(175, 2);
            this.txtRef4.MaxLength = 2;
            this.txtRef4.Name = "txtRef4";
            this.txtRef4.Size = new System.Drawing.Size(20, 16);
            this.txtRef4.TabIndex = 4;
            this.txtRef4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRef4.TextChanged += new System.EventHandler(this.NextControl);
            // 
            // txtRef3
            // 
            this.txtRef3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRef3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRef3.Location = new System.Drawing.Point(139, 2);
            this.txtRef3.MaxLength = 4;
            this.txtRef3.Name = "txtRef3";
            this.txtRef3.Size = new System.Drawing.Size(35, 16);
            this.txtRef3.TabIndex = 3;
            this.txtRef3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRef3.TextChanged += new System.EventHandler(this.NextControl);
            // 
            // cboCidade
            // 
            this.cboCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCidade.DisplayMember = "cidade";
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(127, 289);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(442, 21);
            this.cboCidade.TabIndex = 7;
            this.cboCidade.ValueMember = "cidade";
            this.cboCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCidade_KeyPress);
            // 
            // dtpPrazo
            // 
            this.dtpPrazo.CustomFormat = "";
            this.dtpPrazo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrazo.Location = new System.Drawing.Point(334, 194);
            this.dtpPrazo.Name = "dtpPrazo";
            this.dtpPrazo.Size = new System.Drawing.Size(235, 23);
            this.dtpPrazo.TabIndex = 5;
            // 
            // btnAddAgencia
            // 
            this.btnAddAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAgencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAgencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAgencia.Image")));
            this.btnAddAgencia.Location = new System.Drawing.Point(127, 65);
            this.btnAddAgencia.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAgencia.Name = "btnAddAgencia";
            this.btnAddAgencia.Size = new System.Drawing.Size(440, 15);
            this.btnAddAgencia.TabIndex = 417;
            this.btnAddAgencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAgencia.UseVisualStyleBackColor = true;
            this.btnAddAgencia.Visible = false;
            this.btnAddAgencia.Click += new System.EventHandler(this.btnAddAgencia_Click);
            // 
            // txtCoordenada
            // 
            this.txtCoordenada.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCoordenada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCoordenada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoordenada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCoordenada.Location = new System.Drawing.Point(127, 359);
            this.txtCoordenada.MaxLength = 40;
            this.txtCoordenada.Name = "txtCoordenada";
            this.txtCoordenada.Size = new System.Drawing.Size(442, 23);
            this.txtCoordenada.TabIndex = 10;
            // 
            // txtDataOrdem
            // 
            this.txtDataOrdem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataOrdem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataOrdem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataOrdem.Location = new System.Drawing.Point(127, 194);
            this.txtDataOrdem.Mask = "00/00/0000";
            this.txtDataOrdem.Name = "txtDataOrdem";
            this.txtDataOrdem.Size = new System.Drawing.Size(90, 23);
            this.txtDataOrdem.TabIndex = 4;
            this.txtDataOrdem.ValidatingType = typeof(System.DateTime);
            this.txtDataOrdem.Enter += new System.EventHandler(this.txtDataOrdem_Enter);
            this.txtDataOrdem.Validated += new System.EventHandler(this.txtDataOrdem_Validated);
            // 
            // lblCoordenada
            // 
            this.lblCoordenada.AutoSize = true;
            this.lblCoordenada.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCoordenada.Location = new System.Drawing.Point(21, 363);
            this.lblCoordenada.Margin = new System.Windows.Forms.Padding(0);
            this.lblCoordenada.Name = "lblCoordenada";
            this.lblCoordenada.Size = new System.Drawing.Size(71, 13);
            this.lblCoordenada.TabIndex = 428;
            this.lblCoordenada.Text = "Coordenada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(19, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 355;
            this.label1.Text = "Data da Ordem";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtOBS);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage3.Size = new System.Drawing.Size(592, 397);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Observações";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.White;
            this.pnlStatus.Controls.Add(this.txtDataConcluida);
            this.pnlStatus.Controls.Add(this.rbtRecebida);
            this.pnlStatus.Controls.Add(this.txtDataVistoria);
            this.pnlStatus.Controls.Add(this.rbtConcluida);
            this.pnlStatus.Controls.Add(this.txtDataPendente);
            this.pnlStatus.Controls.Add(this.rbtPendente);
            this.pnlStatus.Controls.Add(this.rbtVistoriada);
            this.pnlStatus.Location = new System.Drawing.Point(161, 460);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(599, 55);
            this.pnlStatus.TabIndex = 1;
            this.pnlStatus.TabStop = true;
            // 
            // frmAddOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.pnlBotton);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.frmAddOS_Load);
            this.pnlBotton.ResumeLayout(false);
            this.pnlBotton.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.tabOS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlReferencia.ResumeLayout(false);
            this.pnlReferencia.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.RadioButton rbtRecebida;
        private System.Windows.Forms.RadioButton rbtPendente;
        private System.Windows.Forms.RadioButton rbtConcluida;
        private System.Windows.Forms.RadioButton rbtVistoriada;
        private System.Windows.Forms.ToolTip ttpAddOS;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblDataExecucao;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.ComboBox cboAtividade;
        private System.Windows.Forms.CheckBox chkSiopi;
        private System.Windows.Forms.Label lblProfissional;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNomeContato;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label lblTelefoneContato;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContato;
        private System.Windows.Forms.TextBox txtAgenciaEmail;
        private System.Windows.Forms.TextBox txtAgenciaTelefone;
        private System.Windows.Forms.TextBox txtAgenciaNome;
        private System.Windows.Forms.ComboBox cboProfissional;
        private System.Windows.Forms.Label lblAtividadeNome;
        private System.Windows.Forms.Label lblAtividadeDeslocamento;
        private System.Windows.Forms.Label lblAtividadeValor;
        private System.Windows.Forms.Label lblNomeProfissional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOBS;
        private System.Windows.Forms.Panel pnlBotton;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label lblFaturada;
        private System.Windows.Forms.TextBox txtCodFatura;
        private System.Windows.Forms.Button btnAddAgencia;
        private System.Windows.Forms.TabControl tabOS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox txtDataConcluida;
        private System.Windows.Forms.MaskedTextBox txtDataVistoria;
        private System.Windows.Forms.MaskedTextBox txtDataPendente;
        private System.Windows.Forms.MaskedTextBox txtDataOrdem;
        private System.Windows.Forms.TextBox txtCoordenada;
        private System.Windows.Forms.Label lblCoordenada;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Panel pnlReferencia;
        private System.Windows.Forms.Label lblPonto1Ref;
        private System.Windows.Forms.TextBox txtRef1;
        private System.Windows.Forms.TextBox txtRef0;
        private System.Windows.Forms.Label lblBarraRef;
        private System.Windows.Forms.Label lblPonto2Ref;
        private System.Windows.Forms.TextBox txtRef2;
        private System.Windows.Forms.Label lblPonto5Ref;
        private System.Windows.Forms.TextBox txtRef6;
        private System.Windows.Forms.Label lblPonto4Ref;
        private System.Windows.Forms.TextBox txtRef5;
        private System.Windows.Forms.Label lblPonto3Ref;
        private System.Windows.Forms.TextBox txtRef4;
        private System.Windows.Forms.TextBox txtRef3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStatus;
    }
}