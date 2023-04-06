namespace Fluxus.WinUI.View
{
    partial class uctAddServiceOrder
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
            btnCancelar = new Button();
            btnAddSave = new Button();
            rbtRecebida = new RadioButton();
            rbtPendente = new RadioButton();
            rbtConcluida = new RadioButton();
            rbtVistoriada = new RadioButton();
            ttpAddOS = new ToolTip(components);
            txtCodFatura = new TextBox();
            lblFaturada = new Label();
            pnlBotton = new Panel();
            pnlMain = new Panel();
            groupBox2 = new GroupBox();
            txtBranchName = new TextBox();
            txtBranchPhone = new TextBox();
            txtBranchEmail = new TextBox();
            grpAtividade = new GroupBox();
            cboAtividade = new ComboBox();
            lblAtividadeNome = new Label();
            lblAtividadeValor = new Label();
            lblAtividadeDeslocamento = new Label();
            panel1 = new Panel();
            dtpDataConcluida = new DateTimePicker();
            pnlLinha5 = new Panel();
            dtpDataVistoria = new DateTimePicker();
            label9 = new Label();
            dtpDataPendente = new DateTimePicker();
            cboCidade = new ComboBox();
            pnlLinha3 = new Panel();
            txtCoordenada = new TextBox();
            label7 = new Label();
            lblCoordenada = new Label();
            cboProfissional = new ComboBox();
            txtNomeCliente = new TextBox();
            lblCliente = new Label();
            lblNomeProfissional = new Label();
            lblCidade = new Label();
            lblProfissional = new Label();
            txtNomeContato = new TextBox();
            txtTelefoneContato = new MaskedTextBox();
            lblNomeContato = new Label();
            lblTelefoneContato = new Label();
            dtpDataOrdem = new DateTimePicker();
            dtpPrazo = new DateTimePicker();
            label1 = new Label();
            lblDataExecucao = new Label();
            label5 = new Label();
            chkSiopi = new CheckBox();
            label4 = new Label();
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
            pnlLinha1 = new Panel();
            label2 = new Label();
            pnlBotton.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox2.SuspendLayout();
            grpAtividade.SuspendLayout();
            pnlReferencia.SuspendLayout();
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
            btnCancelar.Location = new Point(1231, 32);
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
            btnAddSave.Location = new Point(1515, 32);
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
            rbtRecebida.Location = new Point(494, 1513);
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
            rbtPendente.Location = new Point(731, 1513);
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
            rbtConcluida.Location = new Point(1339, 1513);
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
            rbtVistoriada.Location = new Point(1035, 1513);
            rbtVistoriada.Margin = new Padding(7, 6, 7, 6);
            rbtVistoriada.Name = "rbtVistoriada";
            rbtVistoriada.Size = new Size(138, 34);
            rbtVistoriada.TabIndex = 2;
            rbtVistoriada.Text = "Vistoriada";
            rbtVistoriada.UseVisualStyleBackColor = true;
            rbtVistoriada.CheckedChanged += rbtVistoriada_CheckedChanged;
            // 
            // txtCodFatura
            // 
            txtCodFatura.Anchor = AnchorStyles.Top;
            txtCodFatura.BackColor = Color.LightBlue;
            txtCodFatura.BorderStyle = BorderStyle.None;
            txtCodFatura.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodFatura.ForeColor = Color.Black;
            txtCodFatura.Location = new Point(39, 64);
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
            lblFaturada.Location = new Point(30, 17);
            lblFaturada.Margin = new Padding(7, 0, 7, 0);
            lblFaturada.Name = "lblFaturada";
            lblFaturada.Size = new Size(325, 49);
            lblFaturada.TabIndex = 412;
            lblFaturada.Text = "OS FATURADA";
            lblFaturada.TextAlign = ContentAlignment.TopCenter;
            lblFaturada.Visible = false;
            // 
            // pnlBotton
            // 
            pnlBotton.BackColor = Color.LightBlue;
            pnlBotton.Controls.Add(btnAddSave);
            pnlBotton.Controls.Add(btnCancelar);
            pnlBotton.Controls.Add(txtCodFatura);
            pnlBotton.Controls.Add(lblFaturada);
            pnlBotton.Dock = DockStyle.Bottom;
            pnlBotton.Location = new Point(0, 1276);
            pnlBotton.Margin = new Padding(7, 6, 7, 6);
            pnlBotton.Name = "pnlBotton";
            pnlBotton.Size = new Size(2000, 124);
            pnlBotton.TabIndex = 8;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Controls.Add(grpAtividade);
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(dtpDataConcluida);
            pnlMain.Controls.Add(pnlLinha5);
            pnlMain.Controls.Add(dtpDataVistoria);
            pnlMain.Controls.Add(label9);
            pnlMain.Controls.Add(dtpDataPendente);
            pnlMain.Controls.Add(rbtConcluida);
            pnlMain.Controls.Add(rbtRecebida);
            pnlMain.Controls.Add(rbtPendente);
            pnlMain.Controls.Add(rbtVistoriada);
            pnlMain.Controls.Add(cboCidade);
            pnlMain.Controls.Add(pnlLinha3);
            pnlMain.Controls.Add(txtCoordenada);
            pnlMain.Controls.Add(label7);
            pnlMain.Controls.Add(lblCoordenada);
            pnlMain.Controls.Add(cboProfissional);
            pnlMain.Controls.Add(txtNomeCliente);
            pnlMain.Controls.Add(lblCliente);
            pnlMain.Controls.Add(lblNomeProfissional);
            pnlMain.Controls.Add(lblCidade);
            pnlMain.Controls.Add(lblProfissional);
            pnlMain.Controls.Add(txtNomeContato);
            pnlMain.Controls.Add(txtTelefoneContato);
            pnlMain.Controls.Add(lblNomeContato);
            pnlMain.Controls.Add(lblTelefoneContato);
            pnlMain.Controls.Add(dtpDataOrdem);
            pnlMain.Controls.Add(dtpPrazo);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(lblDataExecucao);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(chkSiopi);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(pnlReferencia);
            pnlMain.Controls.Add(pnlLinha1);
            pnlMain.Controls.Add(label2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(7, 6, 7, 6);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(2000, 1276);
            pnlMain.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(txtBranchName);
            groupBox2.Controls.Add(txtBranchPhone);
            groupBox2.Controls.Add(txtBranchEmail);
            groupBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Location = new Point(498, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1004, 127);
            groupBox2.TabIndex = 455;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agência";
            // 
            // txtBranchName
            // 
            txtBranchName.Anchor = AnchorStyles.Top;
            txtBranchName.BackColor = Color.LightGray;
            txtBranchName.BorderStyle = BorderStyle.None;
            txtBranchName.CharacterCasing = CharacterCasing.Upper;
            txtBranchName.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBranchName.ForeColor = SystemColors.ControlDarkDark;
            txtBranchName.Location = new Point(280, 40);
            txtBranchName.Margin = new Padding(7, 6, 7, 6);
            txtBranchName.MaxLength = 100;
            txtBranchName.Name = "txtBranchName";
            txtBranchName.ReadOnly = true;
            txtBranchName.Size = new Size(681, 29);
            txtBranchName.TabIndex = 458;
            txtBranchName.TabStop = false;
            txtBranchName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBranchPhone
            // 
            txtBranchPhone.Anchor = AnchorStyles.Top;
            txtBranchPhone.BackColor = Color.LightGray;
            txtBranchPhone.BorderStyle = BorderStyle.None;
            txtBranchPhone.CharacterCasing = CharacterCasing.Upper;
            txtBranchPhone.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBranchPhone.ForeColor = SystemColors.ControlDarkDark;
            txtBranchPhone.Location = new Point(280, 69);
            txtBranchPhone.Margin = new Padding(7, 6, 7, 6);
            txtBranchPhone.MaxLength = 100;
            txtBranchPhone.Name = "txtBranchPhone";
            txtBranchPhone.ReadOnly = true;
            txtBranchPhone.Size = new Size(274, 29);
            txtBranchPhone.TabIndex = 457;
            txtBranchPhone.TabStop = false;
            txtBranchPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBranchEmail
            // 
            txtBranchEmail.Anchor = AnchorStyles.Top;
            txtBranchEmail.BackColor = Color.LightGray;
            txtBranchEmail.BorderStyle = BorderStyle.None;
            txtBranchEmail.CharacterCasing = CharacterCasing.Lower;
            txtBranchEmail.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBranchEmail.ForeColor = SystemColors.ControlDarkDark;
            txtBranchEmail.Location = new Point(550, 69);
            txtBranchEmail.Margin = new Padding(7, 6, 7, 6);
            txtBranchEmail.MaxLength = 100;
            txtBranchEmail.Name = "txtBranchEmail";
            txtBranchEmail.ReadOnly = true;
            txtBranchEmail.Size = new Size(411, 29);
            txtBranchEmail.TabIndex = 456;
            txtBranchEmail.TabStop = false;
            txtBranchEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // grpAtividade
            // 
            grpAtividade.Anchor = AnchorStyles.Top;
            grpAtividade.Controls.Add(cboAtividade);
            grpAtividade.Controls.Add(lblAtividadeNome);
            grpAtividade.Controls.Add(lblAtividadeValor);
            grpAtividade.Controls.Add(lblAtividadeDeslocamento);
            grpAtividade.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpAtividade.ForeColor = SystemColors.ControlDarkDark;
            grpAtividade.Location = new Point(498, 607);
            grpAtividade.Name = "grpAtividade";
            grpAtividade.Size = new Size(1009, 121);
            grpAtividade.TabIndex = 454;
            grpAtividade.TabStop = false;
            grpAtividade.Text = "Atividade";
            // 
            // cboAtividade
            // 
            cboAtividade.Anchor = AnchorStyles.Top;
            cboAtividade.BackColor = Color.White;
            cboAtividade.DisplayMember = "Tag";
            cboAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAtividade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboAtividade.ForeColor = Color.Black;
            cboAtividade.FormattingEnabled = true;
            cboAtividade.Location = new Point(276, 30);
            cboAtividade.Margin = new Padding(7, 6, 7, 6);
            cboAtividade.MaxLength = 10;
            cboAtividade.Name = "cboAtividade";
            cboAtividade.Size = new Size(150, 40);
            cboAtividade.TabIndex = 436;
            cboAtividade.ValueMember = "Id";
            cboAtividade.SelectionChangeCommitted += GetServiceName;
            // 
            // lblAtividadeNome
            // 
            lblAtividadeNome.Anchor = AnchorStyles.Top;
            lblAtividadeNome.BackColor = Color.LightGray;
            lblAtividadeNome.Enabled = false;
            lblAtividadeNome.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtividadeNome.ForeColor = SystemColors.ControlDarkDark;
            lblAtividadeNome.Location = new Point(276, 70);
            lblAtividadeNome.Margin = new Padding(7, 0, 7, 0);
            lblAtividadeNome.Name = "lblAtividadeNome";
            lblAtividadeNome.Size = new Size(685, 32);
            lblAtividadeNome.TabIndex = 438;
            lblAtividadeNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeValor
            // 
            lblAtividadeValor.Anchor = AnchorStyles.Top;
            lblAtividadeValor.BackColor = Color.LightGray;
            lblAtividadeValor.Enabled = false;
            lblAtividadeValor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtividadeValor.ForeColor = SystemColors.ControlDarkDark;
            lblAtividadeValor.Location = new Point(426, 30);
            lblAtividadeValor.Margin = new Padding(7, 0, 7, 0);
            lblAtividadeValor.Name = "lblAtividadeValor";
            lblAtividadeValor.Size = new Size(268, 40);
            lblAtividadeValor.TabIndex = 439;
            lblAtividadeValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeDeslocamento
            // 
            lblAtividadeDeslocamento.Anchor = AnchorStyles.Top;
            lblAtividadeDeslocamento.BackColor = Color.LightGray;
            lblAtividadeDeslocamento.Enabled = false;
            lblAtividadeDeslocamento.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtividadeDeslocamento.ForeColor = SystemColors.ControlDarkDark;
            lblAtividadeDeslocamento.Location = new Point(694, 30);
            lblAtividadeDeslocamento.Margin = new Padding(7, 0, 7, 0);
            lblAtividadeDeslocamento.Name = "lblAtividadeDeslocamento";
            lblAtividadeDeslocamento.Size = new Size(267, 40);
            lblAtividadeDeslocamento.TabIndex = 440;
            lblAtividadeDeslocamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Location = new Point(414, 1650);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 2);
            panel1.TabIndex = 452;
            // 
            // dtpDataConcluida
            // 
            dtpDataConcluida.Anchor = AnchorStyles.Top;
            dtpDataConcluida.CustomFormat = "";
            dtpDataConcluida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataConcluida.Format = DateTimePickerFormat.Short;
            dtpDataConcluida.Location = new Point(1371, 1569);
            dtpDataConcluida.Margin = new Padding(7, 6, 7, 6);
            dtpDataConcluida.Name = "dtpDataConcluida";
            dtpDataConcluida.Size = new Size(190, 39);
            dtpDataConcluida.TabIndex = 432;
            dtpDataConcluida.Visible = false;
            // 
            // pnlLinha5
            // 
            pnlLinha5.Anchor = AnchorStyles.Top;
            pnlLinha5.BackColor = SystemColors.ControlDark;
            pnlLinha5.Location = new Point(414, 1469);
            pnlLinha5.Margin = new Padding(6, 7, 6, 7);
            pnlLinha5.Name = "pnlLinha5";
            pnlLinha5.Size = new Size(1174, 2);
            pnlLinha5.TabIndex = 451;
            // 
            // dtpDataVistoria
            // 
            dtpDataVistoria.Anchor = AnchorStyles.Top;
            dtpDataVistoria.CustomFormat = "";
            dtpDataVistoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataVistoria.Format = DateTimePickerFormat.Short;
            dtpDataVistoria.Location = new Point(1067, 1569);
            dtpDataVistoria.Margin = new Padding(7, 6, 7, 6);
            dtpDataVistoria.Name = "dtpDataVistoria";
            dtpDataVistoria.Size = new Size(190, 39);
            dtpDataVistoria.TabIndex = 431;
            dtpDataVistoria.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(414, 1420);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 30);
            label9.TabIndex = 450;
            label9.Text = "Status";
            // 
            // dtpDataPendente
            // 
            dtpDataPendente.Anchor = AnchorStyles.Top;
            dtpDataPendente.CustomFormat = "";
            dtpDataPendente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataPendente.Format = DateTimePickerFormat.Short;
            dtpDataPendente.Location = new Point(761, 1569);
            dtpDataPendente.Margin = new Padding(7, 6, 7, 6);
            dtpDataPendente.Name = "dtpDataPendente";
            dtpDataPendente.Size = new Size(190, 39);
            dtpDataPendente.TabIndex = 430;
            dtpDataPendente.Visible = false;
            // 
            // cboCidade
            // 
            cboCidade.Anchor = AnchorStyles.Top;
            cboCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCidade.DisplayMember = "city";
            cboCidade.FormattingEnabled = true;
            cboCidade.Location = new Point(774, 1110);
            cboCidade.Margin = new Padding(7, 6, 7, 6);
            cboCidade.Name = "cboCidade";
            cboCidade.Size = new Size(685, 40);
            cboCidade.TabIndex = 7;
            cboCidade.ValueMember = "city";
            cboCidade.KeyPress += cboCidade_KeyPress;
            // 
            // pnlLinha3
            // 
            pnlLinha3.Anchor = AnchorStyles.Top;
            pnlLinha3.BackColor = SystemColors.ControlDark;
            pnlLinha3.Location = new Point(414, 919);
            pnlLinha3.Margin = new Padding(6, 7, 6, 7);
            pnlLinha3.Name = "pnlLinha3";
            pnlLinha3.Size = new Size(1174, 2);
            pnlLinha3.TabIndex = 447;
            // 
            // txtCoordenada
            // 
            txtCoordenada.Anchor = AnchorStyles.Top;
            txtCoordenada.BackColor = Color.White;
            txtCoordenada.CharacterCasing = CharacterCasing.Upper;
            txtCoordenada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoordenada.ForeColor = Color.Black;
            txtCoordenada.Location = new Point(774, 1283);
            txtCoordenada.Margin = new Padding(7, 6, 7, 6);
            txtCoordenada.MaxLength = 40;
            txtCoordenada.Name = "txtCoordenada";
            txtCoordenada.Size = new Size(685, 39);
            txtCoordenada.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(414, 870);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 30);
            label7.TabIndex = 446;
            label7.Text = "Detalhes";
            // 
            // lblCoordenada
            // 
            lblCoordenada.Anchor = AnchorStyles.Top;
            lblCoordenada.AutoSize = true;
            lblCoordenada.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoordenada.ForeColor = SystemColors.ControlDarkDark;
            lblCoordenada.Location = new Point(494, 1288);
            lblCoordenada.Margin = new Padding(0);
            lblCoordenada.Name = "lblCoordenada";
            lblCoordenada.Size = new Size(133, 30);
            lblCoordenada.TabIndex = 428;
            lblCoordenada.Text = "Coordenada";
            // 
            // cboProfissional
            // 
            cboProfissional.Anchor = AnchorStyles.Top;
            cboProfissional.BackColor = Color.White;
            cboProfissional.DisplayMember = "Tag";
            cboProfissional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfissional.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboProfissional.ForeColor = Color.Black;
            cboProfissional.FormattingEnabled = true;
            cboProfissional.Location = new Point(774, 762);
            cboProfissional.Margin = new Padding(7, 6, 7, 6);
            cboProfissional.MaxLength = 3;
            cboProfissional.Name = "cboProfissional";
            cboProfissional.Size = new Size(150, 40);
            cboProfissional.TabIndex = 443;
            cboProfissional.ValueMember = "Id";
            cboProfissional.SelectionChangeCommitted += GetProfessionalName;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Anchor = AnchorStyles.Top;
            txtNomeCliente.BackColor = Color.White;
            txtNomeCliente.CharacterCasing = CharacterCasing.Upper;
            txtNomeCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.ForeColor = Color.Black;
            txtNomeCliente.Location = new Point(774, 1023);
            txtNomeCliente.Margin = new Padding(7, 6, 7, 6);
            txtNomeCliente.MaxLength = 100;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(685, 39);
            txtNomeCliente.TabIndex = 6;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Top;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = SystemColors.ControlDarkDark;
            lblCliente.Location = new Point(494, 1028);
            lblCliente.Margin = new Padding(7, 0, 7, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(178, 30);
            lblCliente.TabIndex = 358;
            lblCliente.Text = "Nome do Cliente";
            // 
            // lblNomeProfissional
            // 
            lblNomeProfissional.Anchor = AnchorStyles.Top;
            lblNomeProfissional.BackColor = Color.LightGray;
            lblNomeProfissional.Enabled = false;
            lblNomeProfissional.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeProfissional.ForeColor = SystemColors.ControlDarkDark;
            lblNomeProfissional.Location = new Point(957, 763);
            lblNomeProfissional.Margin = new Padding(7, 0, 7, 0);
            lblNomeProfissional.Name = "lblNomeProfissional";
            lblNomeProfissional.Size = new Size(502, 39);
            lblNomeProfissional.TabIndex = 445;
            lblNomeProfissional.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCidade
            // 
            lblCidade.Anchor = AnchorStyles.Top;
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCidade.ForeColor = SystemColors.ControlDarkDark;
            lblCidade.Location = new Point(494, 1113);
            lblCidade.Margin = new Padding(7, 0, 7, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(81, 30);
            lblCidade.TabIndex = 360;
            lblCidade.Text = "Cidade";
            // 
            // lblProfissional
            // 
            lblProfissional.Anchor = AnchorStyles.Top;
            lblProfissional.AutoSize = true;
            lblProfissional.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfissional.ForeColor = SystemColors.ControlDarkDark;
            lblProfissional.Location = new Point(498, 772);
            lblProfissional.Margin = new Padding(7, 0, 7, 0);
            lblProfissional.Name = "lblProfissional";
            lblProfissional.Size = new Size(122, 30);
            lblProfissional.TabIndex = 444;
            lblProfissional.Text = "Profissional";
            // 
            // txtNomeContato
            // 
            txtNomeContato.Anchor = AnchorStyles.Top;
            txtNomeContato.BackColor = Color.White;
            txtNomeContato.CharacterCasing = CharacterCasing.Upper;
            txtNomeContato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeContato.ForeColor = Color.Black;
            txtNomeContato.Location = new Point(774, 1196);
            txtNomeContato.Margin = new Padding(7, 6, 7, 6);
            txtNomeContato.MaxLength = 100;
            txtNomeContato.Name = "txtNomeContato";
            txtNomeContato.Size = new Size(307, 39);
            txtNomeContato.TabIndex = 8;
            // 
            // txtTelefoneContato
            // 
            txtTelefoneContato.Anchor = AnchorStyles.Top;
            txtTelefoneContato.BackColor = Color.White;
            txtTelefoneContato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefoneContato.ForeColor = Color.Black;
            txtTelefoneContato.Location = new Point(1238, 1196);
            txtTelefoneContato.Margin = new Padding(7, 6, 7, 6);
            txtTelefoneContato.Name = "txtTelefoneContato";
            txtTelefoneContato.Size = new Size(221, 39);
            txtTelefoneContato.TabIndex = 9;
            txtTelefoneContato.Tag = "telefone";
            txtTelefoneContato.Enter += OnEnter_MaskedTextBox;
            txtTelefoneContato.Validated += OnValidated_MaskedTextBox;
            // 
            // lblNomeContato
            // 
            lblNomeContato.Anchor = AnchorStyles.Top;
            lblNomeContato.AutoSize = true;
            lblNomeContato.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeContato.ForeColor = SystemColors.ControlDarkDark;
            lblNomeContato.Location = new Point(494, 1198);
            lblNomeContato.Margin = new Padding(7, 0, 7, 0);
            lblNomeContato.Name = "lblNomeContato";
            lblNomeContato.Size = new Size(188, 30);
            lblNomeContato.TabIndex = 362;
            lblNomeContato.Text = "Nome do Contato";
            // 
            // lblTelefoneContato
            // 
            lblTelefoneContato.Anchor = AnchorStyles.Top;
            lblTelefoneContato.AutoSize = true;
            lblTelefoneContato.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefoneContato.ForeColor = SystemColors.ControlDarkDark;
            lblTelefoneContato.Location = new Point(1108, 1198);
            lblTelefoneContato.Margin = new Padding(7, 0, 7, 0);
            lblTelefoneContato.Name = "lblTelefoneContato";
            lblTelefoneContato.Size = new Size(96, 30);
            lblTelefoneContato.TabIndex = 364;
            lblTelefoneContato.Text = "Telefone";
            // 
            // dtpDataOrdem
            // 
            dtpDataOrdem.Anchor = AnchorStyles.Top;
            dtpDataOrdem.CustomFormat = "";
            dtpDataOrdem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataOrdem.Format = DateTimePickerFormat.Short;
            dtpDataOrdem.Location = new Point(774, 453);
            dtpDataOrdem.Margin = new Padding(7, 6, 7, 6);
            dtpDataOrdem.Name = "dtpDataOrdem";
            dtpDataOrdem.Size = new Size(190, 39);
            dtpDataOrdem.TabIndex = 433;
            dtpDataOrdem.Validated += dtpDataOrdem_Validated;
            // 
            // dtpPrazo
            // 
            dtpPrazo.Anchor = AnchorStyles.Top;
            dtpPrazo.CustomFormat = "";
            dtpPrazo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPrazo.Location = new Point(774, 530);
            dtpPrazo.Margin = new Padding(7, 6, 7, 6);
            dtpPrazo.Name = "dtpPrazo";
            dtpPrazo.Size = new Size(505, 39);
            dtpPrazo.TabIndex = 430;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(494, 462);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 432;
            label1.Text = "Data da Ordem";
            // 
            // lblDataExecucao
            // 
            lblDataExecucao.Anchor = AnchorStyles.Top;
            lblDataExecucao.AutoSize = true;
            lblDataExecucao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataExecucao.ForeColor = SystemColors.ControlDarkDark;
            lblDataExecucao.Location = new Point(494, 541);
            lblDataExecucao.Margin = new Padding(7, 0, 7, 0);
            lblDataExecucao.Name = "lblDataExecucao";
            lblDataExecucao.Size = new Size(162, 30);
            lblDataExecucao.TabIndex = 431;
            lblDataExecucao.Text = "Prazo Execução";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(1384, 106);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 339;
            label5.Text = "SIOPI:";
            // 
            // chkSiopi
            // 
            chkSiopi.Anchor = AnchorStyles.Top;
            chkSiopi.AutoSize = true;
            chkSiopi.CheckAlign = ContentAlignment.BottomCenter;
            chkSiopi.Checked = true;
            chkSiopi.CheckState = CheckState.Checked;
            chkSiopi.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkSiopi.ForeColor = SystemColors.ControlDarkDark;
            chkSiopi.Location = new Point(1479, 109);
            chkSiopi.Margin = new Padding(7, 6, 7, 6);
            chkSiopi.Name = "chkSiopi";
            chkSiopi.Size = new Size(28, 27);
            chkSiopi.TabIndex = 338;
            chkSiopi.TextAlign = ContentAlignment.MiddleCenter;
            chkSiopi.UseCompatibleTextRendering = true;
            chkSiopi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(512, 101);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 30);
            label4.TabIndex = 337;
            label4.Text = "* Referência";
            // 
            // pnlReferencia
            // 
            pnlReferencia.Anchor = AnchorStyles.Top;
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
            pnlReferencia.Location = new Point(774, 92);
            pnlReferencia.Margin = new Padding(7, 6, 7, 6);
            pnlReferencia.Name = "pnlReferencia";
            pnlReferencia.Size = new Size(556, 53);
            pnlReferencia.TabIndex = 336;
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
            txtRef0.KeyUp += NextControl;
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
            txtRef1.KeyUp += NextControl;
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
            txtRef6.KeyUp += NextControl;
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
            txtRef2.KeyUp += NextControl;
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
            txtRef5.KeyUp += NextControl;
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
            txtRef4.KeyUp += NextControl;
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
            txtRef3.KeyUp += NextControl;
            // 
            // pnlLinha1
            // 
            pnlLinha1.Anchor = AnchorStyles.Top;
            pnlLinha1.BackColor = SystemColors.ControlDark;
            pnlLinha1.Location = new Point(410, 263);
            pnlLinha1.Margin = new Padding(6, 7, 6, 7);
            pnlLinha1.Name = "pnlLinha1";
            pnlLinha1.Size = new Size(1174, 2);
            pnlLinha1.TabIndex = 335;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(410, 214);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 334;
            label2.Text = "Convocação";
            // 
            // uctAddServiceOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlMain);
            Controls.Add(pnlBotton);
            Margin = new Padding(7, 6, 7, 6);
            Name = "uctAddServiceOrder";
            Size = new Size(2000, 1400);
            Load += frmAddOS_Load;
            pnlBotton.ResumeLayout(false);
            pnlBotton.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpAtividade.ResumeLayout(false);
            pnlReferencia.ResumeLayout(false);
            pnlReferencia.PerformLayout();
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
        private System.Windows.Forms.Panel pnlBotton;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFaturada;
        private System.Windows.Forms.TextBox txtCodFatura;
        private DateTimePicker dtpDataConcluida;
        private DateTimePicker dtpDataVistoria;
        private DateTimePicker dtpDataPendente;
        private DateTimePicker dtpDataOrdem;
        private DateTimePicker dtpPrazo;
        private Label label1;
        private Label lblDataExecucao;
        private Label label5;
        private CheckBox chkSiopi;
        private Label label4;
        private Panel pnlReferencia;
        private TextBox txtRef0;
        private Label lblPonto5Ref;
        private TextBox txtRef1;
        private TextBox txtRef6;
        private Label lblPonto1Ref;
        private Label lblPonto4Ref;
        private TextBox txtRef2;
        private TextBox txtRef5;
        private Label lblPonto2Ref;
        private Label lblPonto3Ref;
        private Label lblBarraRef;
        private TextBox txtRef4;
        private TextBox txtRef3;
        private Panel pnlLinha1;
        private Label label2;
        private ComboBox cboAtividade;
        private Label lblAtividadeDeslocamento;
        private Label lblAtividadeValor;
        private Label lblAtividade;
        private Label lblAtividadeNome;
        private ComboBox cboProfissional;
        private Label lblNomeProfissional;
        private Label lblProfissional;
        private Panel pnlLinha5;
        private Label label9;
        private ComboBox cboCidade;
        private Panel pnlLinha3;
        private TextBox txtCoordenada;
        private Label label7;
        private Label lblCoordenada;
        private TextBox txtNomeCliente;
        private Label lblCliente;
        private Label lblCidade;
        private TextBox txtNomeContato;
        private MaskedTextBox txtTelefoneContato;
        private Label lblNomeContato;
        private Label lblTelefoneContato;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox grpAtividade;
        private GroupBox groupBox2;
        private TextBox txtBranchName;
        private TextBox txtBranchPhone;
        private TextBox txtBranchEmail;
    }
}