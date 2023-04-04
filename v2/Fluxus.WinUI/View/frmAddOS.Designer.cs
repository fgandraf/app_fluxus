namespace Fluxus.WinUI.View
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOS));
            btnCancelar = new Button();
            btnAddSave = new Button();
            rbtRecebida = new RadioButton();
            rbtPendente = new RadioButton();
            rbtConcluida = new RadioButton();
            rbtVistoriada = new RadioButton();
            ttpAddOS = new ToolTip(components);
            lblReferencia = new Label();
            lblDataExecucao = new Label();
            lblAtividade = new Label();
            cboAtividade = new ComboBox();
            chkSiopi = new CheckBox();
            lblProfissional = new Label();
            lblCliente = new Label();
            txtNomeCliente = new TextBox();
            lblCidade = new Label();
            lblNomeContato = new Label();
            txtNomeContato = new TextBox();
            lblTelefoneContato = new Label();
            txtTelefoneContato = new MaskedTextBox();
            txtAgenciaEmail = new TextBox();
            txtAgenciaTelefone = new TextBox();
            txtAgenciaNome = new TextBox();
            cboProfissional = new ComboBox();
            lblNomeProfissional = new Label();
            lblAtividadeDeslocamento = new Label();
            lblAtividadeValor = new Label();
            lblAtividadeNome = new Label();
            label3 = new Label();
            txtCodFatura = new TextBox();
            lblFaturada = new Label();
            txtOBS = new TextBox();
            pnlBotton = new Panel();
            pnlDados = new Panel();
            pnlStatus = new Panel();
            dtpDataConcluida = new DateTimePicker();
            dtpDataVistoria = new DateTimePicker();
            dtpDataPendente = new DateTimePicker();
            tabOS = new TabControl();
            tabPage1 = new TabPage();
            dtpDataOrdem = new DateTimePicker();
            pnlReferencia = new Panel();
            txtRef0 = new TextBox();
            lblPonto5Ref = new Label();
            txtRef1 = new TextBox();
            txtRef6 = new TextBox();
            lblPonto1Ref = new Label();
            lblPonto4Ref = new Label();
            txtRef2 = new TextBox();
            txtRef5 = new TextBox();
            lblPonto2Ref = new Label();
            lblPonto3Ref = new Label();
            lblBarraRef = new Label();
            txtRef4 = new TextBox();
            txtRef3 = new TextBox();
            cboCidade = new ComboBox();
            dtpPrazo = new DateTimePicker();
            btnAddAgencia = new Button();
            txtCoordenada = new TextBox();
            lblCoordenada = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            pnlBotton.SuspendLayout();
            pnlDados.SuspendLayout();
            pnlStatus.SuspendLayout();
            tabOS.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlReferencia.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(1224, 32);
            btnCancelar.Margin = new Padding(7, 6, 7, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(271, 62);
            btnCancelar.TabIndex = 1;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAddSave
            // 
            btnAddSave.Anchor = AnchorStyles.Right;
            btnAddSave.BackColor = Color.MediumBlue;
            btnAddSave.FlatAppearance.BorderColor = Color.MediumBlue;
            btnAddSave.FlatStyle = FlatStyle.Flat;
            btnAddSave.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSave.ForeColor = SystemColors.Control;
            btnAddSave.Location = new Point(1508, 32);
            btnAddSave.Margin = new Padding(7, 6, 7, 6);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(433, 62);
            btnAddSave.TabIndex = 0;
            btnAddSave.TabStop = false;
            btnAddSave.Text = "&Adicionar";
            btnAddSave.UseVisualStyleBackColor = false;
            btnAddSave.Click += btnAddSave_Click;
            // 
            // rbtRecebida
            // 
            rbtRecebida.Anchor = AnchorStyles.Top;
            rbtRecebida.AutoSize = true;
            rbtRecebida.Checked = true;
            rbtRecebida.FlatStyle = FlatStyle.Flat;
            rbtRecebida.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtRecebida.ForeColor = SystemColors.ControlDarkDark;
            rbtRecebida.Location = new Point(82, 6);
            rbtRecebida.Margin = new Padding(7, 6, 7, 6);
            rbtRecebida.Name = "rbtRecebida";
            rbtRecebida.Size = new Size(130, 34);
            rbtRecebida.TabIndex = 0;
            rbtRecebida.TabStop = true;
            rbtRecebida.Text = "Recebida";
            rbtRecebida.UseVisualStyleBackColor = true;
            rbtRecebida.CheckedChanged += rbtRecebida_CheckedChanged;
            // 
            // rbtPendente
            // 
            rbtPendente.Anchor = AnchorStyles.Top;
            rbtPendente.AutoSize = true;
            rbtPendente.FlatStyle = FlatStyle.Flat;
            rbtPendente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtPendente.ForeColor = SystemColors.ControlDarkDark;
            rbtPendente.Location = new Point(403, 6);
            rbtPendente.Margin = new Padding(7, 6, 7, 6);
            rbtPendente.Name = "rbtPendente";
            rbtPendente.Size = new Size(133, 34);
            rbtPendente.TabIndex = 1;
            rbtPendente.Text = "Pendente";
            rbtPendente.UseVisualStyleBackColor = true;
            rbtPendente.CheckedChanged += rbtPendente_CheckedChanged;
            // 
            // rbtConcluida
            // 
            rbtConcluida.Anchor = AnchorStyles.Top;
            rbtConcluida.AutoSize = true;
            rbtConcluida.FlatStyle = FlatStyle.Flat;
            rbtConcluida.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtConcluida.ForeColor = SystemColors.ControlDarkDark;
            rbtConcluida.Location = new Point(1047, 6);
            rbtConcluida.Margin = new Padding(7, 6, 7, 6);
            rbtConcluida.Name = "rbtConcluida";
            rbtConcluida.Size = new Size(137, 34);
            rbtConcluida.TabIndex = 3;
            rbtConcluida.Text = "Concluída";
            rbtConcluida.UseVisualStyleBackColor = true;
            rbtConcluida.CheckedChanged += rbtConcluida_CheckedChanged;
            // 
            // rbtVistoriada
            // 
            rbtVistoriada.Anchor = AnchorStyles.Top;
            rbtVistoriada.AutoSize = true;
            rbtVistoriada.FlatStyle = FlatStyle.Flat;
            rbtVistoriada.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtVistoriada.ForeColor = SystemColors.ControlDarkDark;
            rbtVistoriada.Location = new Point(724, 6);
            rbtVistoriada.Margin = new Padding(7, 6, 7, 6);
            rbtVistoriada.Name = "rbtVistoriada";
            rbtVistoriada.Size = new Size(138, 34);
            rbtVistoriada.TabIndex = 2;
            rbtVistoriada.Text = "Vistoriada";
            rbtVistoriada.UseVisualStyleBackColor = true;
            rbtVistoriada.CheckedChanged += rbtVistoriada_CheckedChanged;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblReferencia.ForeColor = SystemColors.ControlDarkDark;
            lblReferencia.Location = new Point(45, 75);
            lblReferencia.Margin = new Padding(7, 0, 7, 0);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(129, 30);
            lblReferencia.TabIndex = 0;
            lblReferencia.Text = "* Referência";
            // 
            // lblDataExecucao
            // 
            lblDataExecucao.AutoSize = true;
            lblDataExecucao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataExecucao.ForeColor = SystemColors.ControlDarkDark;
            lblDataExecucao.Location = new Point(527, 486);
            lblDataExecucao.Margin = new Padding(7, 0, 7, 0);
            lblDataExecucao.Name = "lblDataExecucao";
            lblDataExecucao.Size = new Size(162, 30);
            lblDataExecucao.TabIndex = 347;
            lblDataExecucao.Text = "Prazo Execução";
            // 
            // lblAtividade
            // 
            lblAtividade.AutoSize = true;
            lblAtividade.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtividade.ForeColor = SystemColors.ControlDarkDark;
            lblAtividade.Location = new Point(45, 358);
            lblAtividade.Margin = new Padding(7, 0, 7, 0);
            lblAtividade.Name = "lblAtividade";
            lblAtividade.Size = new Size(104, 30);
            lblAtividade.TabIndex = 350;
            lblAtividade.Text = "Atividade";
            // 
            // cboAtividade
            // 
            cboAtividade.BackColor = Color.White;
            cboAtividade.DisplayMember = "tag";
            cboAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAtividade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboAtividade.ForeColor = Color.Black;
            cboAtividade.FormattingEnabled = true;
            cboAtividade.Location = new Point(275, 346);
            cboAtividade.Margin = new Padding(7, 6, 7, 6);
            cboAtividade.MaxLength = 10;
            cboAtividade.Name = "cboAtividade";
            cboAtividade.Size = new Size(190, 40);
            cboAtividade.TabIndex = 3;
            cboAtividade.ValueMember = "id";
            cboAtividade.SelectionChangeCommitted += GetServiceName;
            // 
            // chkSiopi
            // 
            chkSiopi.AutoSize = true;
            chkSiopi.CheckAlign = ContentAlignment.BottomCenter;
            chkSiopi.Checked = true;
            chkSiopi.CheckState = CheckState.Checked;
            chkSiopi.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkSiopi.ForeColor = SystemColors.ControlDarkDark;
            chkSiopi.Location = new Point(1196, 70);
            chkSiopi.Margin = new Padding(7, 6, 7, 6);
            chkSiopi.Name = "chkSiopi";
            chkSiopi.Size = new Size(28, 27);
            chkSiopi.TabIndex = 1;
            chkSiopi.TextAlign = ContentAlignment.MiddleCenter;
            chkSiopi.UseCompatibleTextRendering = true;
            chkSiopi.UseVisualStyleBackColor = true;
            // 
            // lblProfissional
            // 
            lblProfissional.AutoSize = true;
            lblProfissional.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfissional.ForeColor = SystemColors.ControlDarkDark;
            lblProfissional.Location = new Point(45, 275);
            lblProfissional.Margin = new Padding(7, 0, 7, 0);
            lblProfissional.Name = "lblProfissional";
            lblProfissional.Size = new Size(122, 30);
            lblProfissional.TabIndex = 355;
            lblProfissional.Text = "Profissional";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = SystemColors.ControlDarkDark;
            lblCliente.Location = new Point(45, 634);
            lblCliente.Margin = new Padding(7, 0, 7, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(178, 30);
            lblCliente.TabIndex = 358;
            lblCliente.Text = "Nome do Cliente";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = Color.White;
            txtNomeCliente.CharacterCasing = CharacterCasing.Upper;
            txtNomeCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.ForeColor = Color.Black;
            txtNomeCliente.Location = new Point(275, 623);
            txtNomeCliente.Margin = new Padding(7, 6, 7, 6);
            txtNomeCliente.MaxLength = 100;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(953, 39);
            txtNomeCliente.TabIndex = 6;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCidade.ForeColor = SystemColors.ControlDarkDark;
            lblCidade.Location = new Point(45, 719);
            lblCidade.Margin = new Padding(7, 0, 7, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(81, 30);
            lblCidade.TabIndex = 360;
            lblCidade.Text = "Cidade";
            // 
            // lblNomeContato
            // 
            lblNomeContato.AutoSize = true;
            lblNomeContato.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeContato.ForeColor = SystemColors.ControlDarkDark;
            lblNomeContato.Location = new Point(45, 804);
            lblNomeContato.Margin = new Padding(7, 0, 7, 0);
            lblNomeContato.Name = "lblNomeContato";
            lblNomeContato.Size = new Size(188, 30);
            lblNomeContato.TabIndex = 362;
            lblNomeContato.Text = "Nome do Contato";
            // 
            // txtNomeContato
            // 
            txtNomeContato.BackColor = Color.White;
            txtNomeContato.CharacterCasing = CharacterCasing.Upper;
            txtNomeContato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeContato.ForeColor = Color.Black;
            txtNomeContato.Location = new Point(275, 796);
            txtNomeContato.Margin = new Padding(7, 6, 7, 6);
            txtNomeContato.MaxLength = 100;
            txtNomeContato.Name = "txtNomeContato";
            txtNomeContato.Size = new Size(429, 39);
            txtNomeContato.TabIndex = 8;
            // 
            // lblTelefoneContato
            // 
            lblTelefoneContato.AutoSize = true;
            lblTelefoneContato.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefoneContato.ForeColor = SystemColors.ControlDarkDark;
            lblTelefoneContato.Location = new Point(843, 798);
            lblTelefoneContato.Margin = new Padding(7, 0, 7, 0);
            lblTelefoneContato.Name = "lblTelefoneContato";
            lblTelefoneContato.Size = new Size(96, 30);
            lblTelefoneContato.TabIndex = 364;
            lblTelefoneContato.Text = "Telefone";
            // 
            // txtTelefoneContato
            // 
            txtTelefoneContato.BackColor = Color.White;
            txtTelefoneContato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefoneContato.ForeColor = Color.Black;
            txtTelefoneContato.Location = new Point(973, 796);
            txtTelefoneContato.Margin = new Padding(7, 6, 7, 6);
            txtTelefoneContato.Name = "txtTelefoneContato";
            txtTelefoneContato.Size = new Size(255, 39);
            txtTelefoneContato.TabIndex = 9;
            txtTelefoneContato.Tag = "telefone";
            txtTelefoneContato.Enter += OnEnter_MaskedTextBox;
            txtTelefoneContato.Validated += OnValidated_MaskedTextBox;
            // 
            // txtAgenciaEmail
            // 
            txtAgenciaEmail.BackColor = Color.LightGray;
            txtAgenciaEmail.BorderStyle = BorderStyle.None;
            txtAgenciaEmail.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgenciaEmail.ForeColor = SystemColors.ControlDarkDark;
            txtAgenciaEmail.Location = new Point(661, 160);
            txtAgenciaEmail.Margin = new Padding(7, 6, 7, 6);
            txtAgenciaEmail.MaxLength = 100;
            txtAgenciaEmail.Name = "txtAgenciaEmail";
            txtAgenciaEmail.ReadOnly = true;
            txtAgenciaEmail.Size = new Size(568, 29);
            txtAgenciaEmail.TabIndex = 402;
            txtAgenciaEmail.TabStop = false;
            txtAgenciaEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAgenciaTelefone
            // 
            txtAgenciaTelefone.BackColor = Color.LightGray;
            txtAgenciaTelefone.BorderStyle = BorderStyle.None;
            txtAgenciaTelefone.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgenciaTelefone.ForeColor = SystemColors.ControlDarkDark;
            txtAgenciaTelefone.Location = new Point(275, 160);
            txtAgenciaTelefone.Margin = new Padding(7, 6, 7, 6);
            txtAgenciaTelefone.MaxLength = 100;
            txtAgenciaTelefone.Name = "txtAgenciaTelefone";
            txtAgenciaTelefone.ReadOnly = true;
            txtAgenciaTelefone.Size = new Size(386, 29);
            txtAgenciaTelefone.TabIndex = 401;
            txtAgenciaTelefone.TabStop = false;
            txtAgenciaTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAgenciaNome
            // 
            txtAgenciaNome.BackColor = Color.LightGray;
            txtAgenciaNome.BorderStyle = BorderStyle.None;
            txtAgenciaNome.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAgenciaNome.ForeColor = SystemColors.ControlDarkDark;
            txtAgenciaNome.Location = new Point(275, 124);
            txtAgenciaNome.Margin = new Padding(7, 6, 7, 6);
            txtAgenciaNome.MaxLength = 100;
            txtAgenciaNome.Name = "txtAgenciaNome";
            txtAgenciaNome.ReadOnly = true;
            txtAgenciaNome.Size = new Size(953, 29);
            txtAgenciaNome.TabIndex = 400;
            txtAgenciaNome.TabStop = false;
            txtAgenciaNome.TextAlign = HorizontalAlignment.Center;
            // 
            // cboProfissional
            // 
            cboProfissional.BackColor = Color.White;
            cboProfissional.DisplayMember = "tag";
            cboProfissional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfissional.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboProfissional.ForeColor = Color.Black;
            cboProfissional.FormattingEnabled = true;
            cboProfissional.Location = new Point(275, 260);
            cboProfissional.Margin = new Padding(7, 6, 7, 6);
            cboProfissional.MaxLength = 3;
            cboProfissional.Name = "cboProfissional";
            cboProfissional.Size = new Size(190, 40);
            cboProfissional.TabIndex = 2;
            cboProfissional.ValueMember = "id";
            cboProfissional.SelectionChangeCommitted += GetProfessionalName;
            // 
            // lblNomeProfissional
            // 
            lblNomeProfissional.BackColor = Color.LightGray;
            lblNomeProfissional.Enabled = false;
            lblNomeProfissional.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeProfissional.ForeColor = SystemColors.ControlDarkDark;
            lblNomeProfissional.Location = new Point(472, 262);
            lblNomeProfissional.Margin = new Padding(7, 0, 7, 0);
            lblNomeProfissional.Name = "lblNomeProfissional";
            lblNomeProfissional.Size = new Size(756, 58);
            lblNomeProfissional.TabIndex = 403;
            lblNomeProfissional.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeDeslocamento
            // 
            lblAtividadeDeslocamento.BackColor = Color.LightGray;
            lblAtividadeDeslocamento.Enabled = false;
            lblAtividadeDeslocamento.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtividadeDeslocamento.ForeColor = SystemColors.ControlDarkDark;
            lblAtividadeDeslocamento.Location = new Point(849, 371);
            lblAtividadeDeslocamento.Margin = new Padding(7, 0, 7, 0);
            lblAtividadeDeslocamento.Name = "lblAtividadeDeslocamento";
            lblAtividadeDeslocamento.Size = new Size(379, 32);
            lblAtividadeDeslocamento.TabIndex = 406;
            lblAtividadeDeslocamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeValor
            // 
            lblAtividadeValor.BackColor = Color.LightGray;
            lblAtividadeValor.Enabled = false;
            lblAtividadeValor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtividadeValor.ForeColor = SystemColors.ControlDarkDark;
            lblAtividadeValor.Location = new Point(472, 371);
            lblAtividadeValor.Margin = new Padding(7, 0, 7, 0);
            lblAtividadeValor.Name = "lblAtividadeValor";
            lblAtividadeValor.Size = new Size(377, 32);
            lblAtividadeValor.TabIndex = 405;
            lblAtividadeValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeNome
            // 
            lblAtividadeNome.BackColor = Color.LightGray;
            lblAtividadeNome.Enabled = false;
            lblAtividadeNome.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtividadeNome.ForeColor = SystemColors.ControlDarkDark;
            lblAtividadeNome.Location = new Point(472, 346);
            lblAtividadeNome.Margin = new Padding(7, 0, 7, 0);
            lblAtividadeNome.Name = "lblAtividadeNome";
            lblAtividadeNome.Size = new Size(756, 32);
            lblAtividadeNome.TabIndex = 404;
            lblAtividadeNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(1094, 70);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 416;
            label3.Text = "SIOPI";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCodFatura
            // 
            txtCodFatura.Anchor = AnchorStyles.Top;
            txtCodFatura.BackColor = Color.LightBlue;
            txtCodFatura.BorderStyle = BorderStyle.None;
            txtCodFatura.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodFatura.ForeColor = Color.Black;
            txtCodFatura.Location = new Point(35, 64);
            txtCodFatura.Margin = new Padding(7, 6, 7, 6);
            txtCodFatura.MaxLength = 100;
            txtCodFatura.Name = "txtCodFatura";
            txtCodFatura.ReadOnly = true;
            txtCodFatura.Size = new Size(316, 32);
            txtCodFatura.TabIndex = 414;
            txtCodFatura.TextAlign = HorizontalAlignment.Center;
            txtCodFatura.Visible = false;
            // 
            // lblFaturada
            // 
            lblFaturada.Anchor = AnchorStyles.Top;
            lblFaturada.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFaturada.ForeColor = Color.Red;
            lblFaturada.Location = new Point(26, 17);
            lblFaturada.Margin = new Padding(7, 0, 7, 0);
            lblFaturada.Name = "lblFaturada";
            lblFaturada.Size = new Size(325, 49);
            lblFaturada.TabIndex = 412;
            lblFaturada.Text = "OS FATURADA";
            lblFaturada.TextAlign = ContentAlignment.TopCenter;
            lblFaturada.Visible = false;
            // 
            // txtOBS
            // 
            txtOBS.AcceptsReturn = true;
            txtOBS.BackColor = Color.White;
            txtOBS.BorderStyle = BorderStyle.FixedSingle;
            txtOBS.Dock = DockStyle.Fill;
            txtOBS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOBS.Location = new Point(22, 26);
            txtOBS.Margin = new Padding(7, 6, 7, 6);
            txtOBS.MaxLength = 250;
            txtOBS.Multiline = true;
            txtOBS.Name = "txtOBS";
            txtOBS.Size = new Size(1240, 981);
            txtOBS.TabIndex = 0;
            // 
            // pnlBotton
            // 
            pnlBotton.BackColor = Color.LightBlue;
            pnlBotton.Controls.Add(btnAddSave);
            pnlBotton.Controls.Add(btnCancelar);
            pnlBotton.Controls.Add(txtCodFatura);
            pnlBotton.Controls.Add(lblFaturada);
            pnlBotton.Dock = DockStyle.Bottom;
            pnlBotton.Location = new Point(0, 1303);
            pnlBotton.Margin = new Padding(7, 6, 7, 6);
            pnlBotton.Name = "pnlBotton";
            pnlBotton.Size = new Size(1993, 124);
            pnlBotton.TabIndex = 8;
            // 
            // pnlDados
            // 
            pnlDados.AutoScroll = true;
            pnlDados.BackColor = Color.Gainsboro;
            pnlDados.Controls.Add(pnlStatus);
            pnlDados.Controls.Add(tabOS);
            pnlDados.Dock = DockStyle.Fill;
            pnlDados.Location = new Point(0, 0);
            pnlDados.Margin = new Padding(7, 6, 7, 6);
            pnlDados.Name = "pnlDados";
            pnlDados.Size = new Size(1993, 1427);
            pnlDados.TabIndex = 1;
            // 
            // pnlStatus
            // 
            pnlStatus.Anchor = AnchorStyles.Top;
            pnlStatus.BackColor = Color.White;
            pnlStatus.Controls.Add(dtpDataConcluida);
            pnlStatus.Controls.Add(dtpDataVistoria);
            pnlStatus.Controls.Add(dtpDataPendente);
            pnlStatus.Controls.Add(rbtRecebida);
            pnlStatus.Controls.Add(rbtConcluida);
            pnlStatus.Controls.Add(rbtPendente);
            pnlStatus.Controls.Add(rbtVistoriada);
            pnlStatus.Location = new Point(349, 1133);
            pnlStatus.Margin = new Padding(7, 6, 7, 6);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(1298, 134);
            pnlStatus.TabIndex = 1;
            pnlStatus.TabStop = true;
            // 
            // dtpDataConcluida
            // 
            dtpDataConcluida.CustomFormat = "";
            dtpDataConcluida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataConcluida.Format = DateTimePickerFormat.Short;
            dtpDataConcluida.Location = new Point(1079, 62);
            dtpDataConcluida.Margin = new Padding(7, 6, 7, 6);
            dtpDataConcluida.Name = "dtpDataConcluida";
            dtpDataConcluida.Size = new Size(190, 39);
            dtpDataConcluida.TabIndex = 432;
            dtpDataConcluida.Visible = false;
            // 
            // dtpDataVistoria
            // 
            dtpDataVistoria.CustomFormat = "";
            dtpDataVistoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataVistoria.Format = DateTimePickerFormat.Short;
            dtpDataVistoria.Location = new Point(756, 62);
            dtpDataVistoria.Margin = new Padding(7, 6, 7, 6);
            dtpDataVistoria.Name = "dtpDataVistoria";
            dtpDataVistoria.Size = new Size(190, 39);
            dtpDataVistoria.TabIndex = 431;
            dtpDataVistoria.Visible = false;
            // 
            // dtpDataPendente
            // 
            dtpDataPendente.CustomFormat = "";
            dtpDataPendente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataPendente.Format = DateTimePickerFormat.Short;
            dtpDataPendente.Location = new Point(433, 62);
            dtpDataPendente.Margin = new Padding(7, 6, 7, 6);
            dtpDataPendente.Name = "dtpDataPendente";
            dtpDataPendente.Size = new Size(190, 39);
            dtpDataPendente.TabIndex = 430;
            dtpDataPendente.Visible = false;
            // 
            // tabOS
            // 
            tabOS.Anchor = AnchorStyles.Top;
            tabOS.Controls.Add(tabPage1);
            tabOS.Controls.Add(tabPage3);
            tabOS.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabOS.HotTrack = true;
            tabOS.ItemSize = new Size(160, 35);
            tabOS.Location = new Point(347, 38);
            tabOS.Margin = new Padding(0);
            tabOS.Multiline = true;
            tabOS.Name = "tabOS";
            tabOS.Padding = new Point(0, 0);
            tabOS.SelectedIndex = 0;
            tabOS.Size = new Size(1300, 1084);
            tabOS.SizeMode = TabSizeMode.Fixed;
            tabOS.TabIndex = 0;
            tabOS.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtpDataOrdem);
            tabPage1.Controls.Add(pnlReferencia);
            tabPage1.Controls.Add(cboAtividade);
            tabPage1.Controls.Add(cboProfissional);
            tabPage1.Controls.Add(cboCidade);
            tabPage1.Controls.Add(dtpPrazo);
            tabPage1.Controls.Add(btnAddAgencia);
            tabPage1.Controls.Add(txtCoordenada);
            tabPage1.Controls.Add(lblCoordenada);
            tabPage1.Controls.Add(lblReferencia);
            tabPage1.Controls.Add(txtNomeCliente);
            tabPage1.Controls.Add(txtAgenciaTelefone);
            tabPage1.Controls.Add(lblNomeProfissional);
            tabPage1.Controls.Add(lblAtividadeDeslocamento);
            tabPage1.Controls.Add(lblCliente);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(lblAtividadeValor);
            tabPage1.Controls.Add(lblAtividade);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lblProfissional);
            tabPage1.Controls.Add(lblCidade);
            tabPage1.Controls.Add(lblAtividadeNome);
            tabPage1.Controls.Add(txtNomeContato);
            tabPage1.Controls.Add(txtAgenciaNome);
            tabPage1.Controls.Add(txtTelefoneContato);
            tabPage1.Controls.Add(lblNomeContato);
            tabPage1.Controls.Add(chkSiopi);
            tabPage1.Controls.Add(lblDataExecucao);
            tabPage1.Controls.Add(lblTelefoneContato);
            tabPage1.Controls.Add(txtAgenciaEmail);
            tabPage1.Location = new Point(8, 43);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1284, 1033);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados da Ordem";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpDataOrdem
            // 
            dtpDataOrdem.CustomFormat = "";
            dtpDataOrdem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataOrdem.Format = DateTimePickerFormat.Short;
            dtpDataOrdem.Location = new Point(275, 478);
            dtpDataOrdem.Margin = new Padding(7, 6, 7, 6);
            dtpDataOrdem.Name = "dtpDataOrdem";
            dtpDataOrdem.Size = new Size(190, 39);
            dtpDataOrdem.TabIndex = 429;
            dtpDataOrdem.Validated += dtpDataOrdem_Validated;
            // 
            // pnlReferencia
            // 
            pnlReferencia.BackColor = Color.Transparent;
            pnlReferencia.BorderStyle = BorderStyle.FixedSingle;
            pnlReferencia.Controls.Add(txtRef0);
            pnlReferencia.Controls.Add(lblPonto5Ref);
            pnlReferencia.Controls.Add(txtRef1);
            pnlReferencia.Controls.Add(txtRef6);
            pnlReferencia.Controls.Add(lblPonto1Ref);
            pnlReferencia.Controls.Add(lblPonto4Ref);
            pnlReferencia.Controls.Add(txtRef2);
            pnlReferencia.Controls.Add(txtRef5);
            pnlReferencia.Controls.Add(lblPonto2Ref);
            pnlReferencia.Controls.Add(lblPonto3Ref);
            pnlReferencia.Controls.Add(lblBarraRef);
            pnlReferencia.Controls.Add(txtRef4);
            pnlReferencia.Controls.Add(txtRef3);
            pnlReferencia.ForeColor = Color.Black;
            pnlReferencia.Location = new Point(275, 62);
            pnlReferencia.Margin = new Padding(7, 6, 7, 6);
            pnlReferencia.Name = "pnlReferencia";
            pnlReferencia.Size = new Size(782, 53);
            pnlReferencia.TabIndex = 0;
            // 
            // txtRef0
            // 
            txtRef0.BackColor = Color.White;
            txtRef0.BorderStyle = BorderStyle.None;
            txtRef0.CharacterCasing = CharacterCasing.Upper;
            txtRef0.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRef0.ForeColor = Color.Black;
            txtRef0.Location = new Point(7, 4);
            txtRef0.Margin = new Padding(7, 6, 7, 6);
            txtRef0.MaxLength = 4;
            txtRef0.Name = "txtRef0";
            txtRef0.Size = new Size(65, 32);
            txtRef0.TabIndex = 0;
            txtRef0.TextAlign = HorizontalAlignment.Center;
            txtRef0.TextChanged += NextControl;
            // 
            // lblPonto5Ref
            // 
            lblPonto5Ref.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPonto5Ref.ForeColor = Color.Black;
            lblPonto5Ref.Location = new Point(461, 6);
            lblPonto5Ref.Margin = new Padding(0);
            lblPonto5Ref.Name = "lblPonto5Ref";
            lblPonto5Ref.Size = new Size(22, 32);
            lblPonto5Ref.TabIndex = 442;
            lblPonto5Ref.Text = ".";
            // 
            // txtRef1
            // 
            txtRef1.BackColor = Color.White;
            txtRef1.BorderStyle = BorderStyle.None;
            txtRef1.CharacterCasing = CharacterCasing.Upper;
            txtRef1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRef1.ForeColor = Color.Black;
            txtRef1.Location = new Point(78, 4);
            txtRef1.Margin = new Padding(7, 6, 7, 6);
            txtRef1.MaxLength = 4;
            txtRef1.Name = "txtRef1";
            txtRef1.Size = new Size(65, 32);
            txtRef1.TabIndex = 1;
            txtRef1.TextAlign = HorizontalAlignment.Center;
            txtRef1.TextChanged += NextControl;
            txtRef1.Validated += txtRef1_Validated;
            // 
            // txtRef6
            // 
            txtRef6.BackColor = Color.White;
            txtRef6.BorderStyle = BorderStyle.None;
            txtRef6.CharacterCasing = CharacterCasing.Upper;
            txtRef6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRef6.ForeColor = Color.Black;
            txtRef6.Location = new Point(474, 4);
            txtRef6.Margin = new Padding(7, 6, 7, 6);
            txtRef6.MaxLength = 2;
            txtRef6.Name = "txtRef6";
            txtRef6.Size = new Size(43, 32);
            txtRef6.TabIndex = 6;
            txtRef6.TextAlign = HorizontalAlignment.Center;
            txtRef6.TextChanged += NextControl;
            // 
            // lblPonto1Ref
            // 
            lblPonto1Ref.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPonto1Ref.ForeColor = Color.Black;
            lblPonto1Ref.Location = new Point(65, 11);
            lblPonto1Ref.Margin = new Padding(0);
            lblPonto1Ref.Name = "lblPonto1Ref";
            lblPonto1Ref.Size = new Size(22, 32);
            lblPonto1Ref.TabIndex = 431;
            lblPonto1Ref.Text = ".";
            // 
            // lblPonto4Ref
            // 
            lblPonto4Ref.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPonto4Ref.ForeColor = Color.Black;
            lblPonto4Ref.Location = new Point(414, 6);
            lblPonto4Ref.Margin = new Padding(0);
            lblPonto4Ref.Name = "lblPonto4Ref";
            lblPonto4Ref.Size = new Size(22, 32);
            lblPonto4Ref.TabIndex = 440;
            lblPonto4Ref.Text = ".";
            // 
            // txtRef2
            // 
            txtRef2.BackColor = Color.White;
            txtRef2.BorderStyle = BorderStyle.None;
            txtRef2.CharacterCasing = CharacterCasing.Upper;
            txtRef2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRef2.ForeColor = Color.Black;
            txtRef2.Location = new Point(149, 4);
            txtRef2.Margin = new Padding(0);
            txtRef2.MaxLength = 9;
            txtRef2.Name = "txtRef2";
            txtRef2.Size = new Size(141, 32);
            txtRef2.TabIndex = 2;
            txtRef2.TextAlign = HorizontalAlignment.Center;
            txtRef2.Validated += txtRef2_Validated;
            // 
            // txtRef5
            // 
            txtRef5.BackColor = Color.White;
            txtRef5.BorderStyle = BorderStyle.None;
            txtRef5.CharacterCasing = CharacterCasing.Upper;
            txtRef5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRef5.ForeColor = Color.Black;
            txtRef5.Location = new Point(427, 4);
            txtRef5.Margin = new Padding(7, 6, 7, 6);
            txtRef5.MaxLength = 2;
            txtRef5.Name = "txtRef5";
            txtRef5.Size = new Size(43, 32);
            txtRef5.TabIndex = 5;
            txtRef5.TextAlign = HorizontalAlignment.Center;
            txtRef5.TextChanged += NextControl;
            // 
            // lblPonto2Ref
            // 
            lblPonto2Ref.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPonto2Ref.ForeColor = Color.Black;
            lblPonto2Ref.Location = new Point(137, 6);
            lblPonto2Ref.Margin = new Padding(0);
            lblPonto2Ref.Name = "lblPonto2Ref";
            lblPonto2Ref.Size = new Size(22, 32);
            lblPonto2Ref.TabIndex = 434;
            lblPonto2Ref.Text = ".";
            // 
            // lblPonto3Ref
            // 
            lblPonto3Ref.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPonto3Ref.ForeColor = Color.Black;
            lblPonto3Ref.Location = new Point(366, 6);
            lblPonto3Ref.Margin = new Padding(0);
            lblPonto3Ref.Name = "lblPonto3Ref";
            lblPonto3Ref.Size = new Size(22, 32);
            lblPonto3Ref.TabIndex = 438;
            lblPonto3Ref.Text = ".";
            // 
            // lblBarraRef
            // 
            lblBarraRef.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarraRef.ForeColor = Color.Black;
            lblBarraRef.Location = new Point(284, 6);
            lblBarraRef.Margin = new Padding(0);
            lblBarraRef.Name = "lblBarraRef";
            lblBarraRef.Size = new Size(22, 32);
            lblBarraRef.TabIndex = 435;
            lblBarraRef.Text = "/";
            // 
            // txtRef4
            // 
            txtRef4.BackColor = Color.White;
            txtRef4.BorderStyle = BorderStyle.None;
            txtRef4.CharacterCasing = CharacterCasing.Upper;
            txtRef4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRef4.ForeColor = Color.Black;
            txtRef4.Location = new Point(379, 4);
            txtRef4.Margin = new Padding(7, 6, 7, 6);
            txtRef4.MaxLength = 2;
            txtRef4.Name = "txtRef4";
            txtRef4.Size = new Size(43, 32);
            txtRef4.TabIndex = 4;
            txtRef4.TextAlign = HorizontalAlignment.Center;
            txtRef4.TextChanged += NextControl;
            // 
            // txtRef3
            // 
            txtRef3.BackColor = Color.White;
            txtRef3.BorderStyle = BorderStyle.None;
            txtRef3.CharacterCasing = CharacterCasing.Upper;
            txtRef3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRef3.ForeColor = Color.Black;
            txtRef3.Location = new Point(301, 4);
            txtRef3.Margin = new Padding(7, 6, 7, 6);
            txtRef3.MaxLength = 4;
            txtRef3.Name = "txtRef3";
            txtRef3.Size = new Size(76, 32);
            txtRef3.TabIndex = 3;
            txtRef3.TextAlign = HorizontalAlignment.Center;
            txtRef3.TextChanged += NextControl;
            // 
            // cboCidade
            // 
            cboCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCidade.DisplayMember = "city";
            cboCidade.FormattingEnabled = true;
            cboCidade.Location = new Point(275, 710);
            cboCidade.Margin = new Padding(7, 6, 7, 6);
            cboCidade.Name = "cboCidade";
            cboCidade.Size = new Size(953, 38);
            cboCidade.TabIndex = 7;
            cboCidade.ValueMember = "city";
            cboCidade.KeyPress += cboCidade_KeyPress;
            // 
            // dtpPrazo
            // 
            dtpPrazo.CustomFormat = "";
            dtpPrazo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPrazo.Location = new Point(724, 478);
            dtpPrazo.Margin = new Padding(7, 6, 7, 6);
            dtpPrazo.Name = "dtpPrazo";
            dtpPrazo.Size = new Size(505, 39);
            dtpPrazo.TabIndex = 5;
            // 
            // btnAddAgencia
            // 
            btnAddAgencia.FlatStyle = FlatStyle.Flat;
            btnAddAgencia.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAgencia.Image = (Image)resources.GetObject("btnAddAgencia.Image");
            btnAddAgencia.Location = new Point(275, 160);
            btnAddAgencia.Margin = new Padding(0);
            btnAddAgencia.Name = "btnAddAgencia";
            btnAddAgencia.Size = new Size(953, 36);
            btnAddAgencia.TabIndex = 417;
            btnAddAgencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAgencia.UseVisualStyleBackColor = true;
            btnAddAgencia.Visible = false;
            btnAddAgencia.Click += btnAddAgencia_Click;
            // 
            // txtCoordenada
            // 
            txtCoordenada.BackColor = Color.White;
            txtCoordenada.CharacterCasing = CharacterCasing.Upper;
            txtCoordenada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoordenada.ForeColor = Color.Black;
            txtCoordenada.Location = new Point(275, 883);
            txtCoordenada.Margin = new Padding(7, 6, 7, 6);
            txtCoordenada.MaxLength = 40;
            txtCoordenada.Name = "txtCoordenada";
            txtCoordenada.Size = new Size(953, 39);
            txtCoordenada.TabIndex = 10;
            // 
            // lblCoordenada
            // 
            lblCoordenada.AutoSize = true;
            lblCoordenada.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoordenada.ForeColor = SystemColors.ControlDarkDark;
            lblCoordenada.Location = new Point(45, 894);
            lblCoordenada.Margin = new Padding(0);
            lblCoordenada.Name = "lblCoordenada";
            lblCoordenada.Size = new Size(133, 30);
            lblCoordenada.TabIndex = 428;
            lblCoordenada.Text = "Coordenada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(41, 486);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 355;
            label1.Text = "Data da Ordem";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtOBS);
            tabPage3.Location = new Point(8, 43);
            tabPage3.Margin = new Padding(7, 6, 7, 6);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(22, 26, 22, 26);
            tabPage3.Size = new Size(1284, 1033);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Observações";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmAddOS
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(pnlBotton);
            Controls.Add(pnlDados);
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmAddOS";
            Size = new Size(1993, 1427);
            Load += frmAddOS_Load;
            pnlBotton.ResumeLayout(false);
            pnlBotton.PerformLayout();
            pnlDados.ResumeLayout(false);
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            tabOS.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            pnlReferencia.ResumeLayout(false);
            pnlReferencia.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
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
        private DateTimePicker dtpDataOrdem;
        private DateTimePicker dtpDataConcluida;
        private DateTimePicker dtpDataVistoria;
        private DateTimePicker dtpDataPendente;
    }
}