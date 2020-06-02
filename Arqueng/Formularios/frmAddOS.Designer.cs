namespace Arqueng.Formularios
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.rbtRecebida = new System.Windows.Forms.RadioButton();
            this.rbtPendente = new System.Windows.Forms.RadioButton();
            this.rbtConcluida = new System.Windows.Forms.RadioButton();
            this.dtpDataVistoria = new System.Windows.Forms.DateTimePicker();
            this.dtpDataConcluida = new System.Windows.Forms.DateTimePicker();
            this.rbtVistoriada = new System.Windows.Forms.RadioButton();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.ttpAddOS = new System.Windows.Forms.ToolTip(this.components);
            this.txtCodFatura = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.dtpDataOrdem = new System.Windows.Forms.DateTimePicker();
            this.lblDataExecucao = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.MaskedTextBox();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.cboAtividade = new System.Windows.Forms.ComboBox();
            this.chkSiopi = new System.Windows.Forms.CheckBox();
            this.lblProfissional = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNomeContato = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.lblTelefoneContato = new System.Windows.Forms.Label();
            this.txtTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.txtAgenciaEmail = new System.Windows.Forms.TextBox();
            this.txtAgenciaTelefone = new System.Windows.Forms.TextBox();
            this.txtAgenciaNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.dtpDataExecucao = new System.Windows.Forms.DateTimePicker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblNomeProfissional = new System.Windows.Forms.Label();
            this.lblAtividadeDeslocamento = new System.Windows.Forms.Label();
            this.lblAtividadeValor = new System.Windows.Forms.Label();
            this.lblAtividadeNome = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(465, 843);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 25);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSave.Location = new System.Drawing.Point(596, 843);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(125, 25);
            this.btnAddSave.TabIndex = 17;
            this.btnAddSave.Text = "&Adicionar";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // rbtRecebida
            // 
            this.rbtRecebida.AutoSize = true;
            this.rbtRecebida.Checked = true;
            this.rbtRecebida.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtRecebida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtRecebida.Location = new System.Drawing.Point(3, 3);
            this.rbtRecebida.Name = "rbtRecebida";
            this.rbtRecebida.Size = new System.Drawing.Size(72, 17);
            this.rbtRecebida.TabIndex = 10;
            this.rbtRecebida.TabStop = true;
            this.rbtRecebida.Text = "Recebida";
            this.rbtRecebida.UseVisualStyleBackColor = true;
            // 
            // rbtPendente
            // 
            this.rbtPendente.AutoSize = true;
            this.rbtPendente.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtPendente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtPendente.Location = new System.Drawing.Point(123, 3);
            this.rbtPendente.Name = "rbtPendente";
            this.rbtPendente.Size = new System.Drawing.Size(74, 17);
            this.rbtPendente.TabIndex = 11;
            this.rbtPendente.TabStop = true;
            this.rbtPendente.Text = "Pendente";
            this.rbtPendente.UseVisualStyleBackColor = true;
            // 
            // rbtConcluida
            // 
            this.rbtConcluida.AutoSize = true;
            this.rbtConcluida.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtConcluida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtConcluida.Location = new System.Drawing.Point(363, 3);
            this.rbtConcluida.Name = "rbtConcluida";
            this.rbtConcluida.Size = new System.Drawing.Size(77, 17);
            this.rbtConcluida.TabIndex = 14;
            this.rbtConcluida.TabStop = true;
            this.rbtConcluida.Text = "Concluída";
            this.rbtConcluida.UseVisualStyleBackColor = true;
            // 
            // dtpDataVistoria
            // 
            this.dtpDataVistoria.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDataVistoria.CustomFormat = "";
            this.dtpDataVistoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVistoria.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVistoria.Location = new System.Drawing.Point(243, 28);
            this.dtpDataVistoria.Name = "dtpDataVistoria";
            this.dtpDataVistoria.Size = new System.Drawing.Size(110, 23);
            this.dtpDataVistoria.TabIndex = 13;
            // 
            // dtpDataConcluida
            // 
            this.dtpDataConcluida.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDataConcluida.CustomFormat = "";
            this.dtpDataConcluida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataConcluida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConcluida.Location = new System.Drawing.Point(363, 28);
            this.dtpDataConcluida.Name = "dtpDataConcluida";
            this.dtpDataConcluida.Size = new System.Drawing.Size(110, 23);
            this.dtpDataConcluida.TabIndex = 15;
            // 
            // rbtVistoriada
            // 
            this.rbtVistoriada.AutoSize = true;
            this.rbtVistoriada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtVistoriada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtVistoriada.Location = new System.Drawing.Point(243, 3);
            this.rbtVistoriada.Name = "rbtVistoriada";
            this.rbtVistoriada.Size = new System.Drawing.Size(77, 17);
            this.rbtVistoriada.TabIndex = 12;
            this.rbtVistoriada.TabStop = true;
            this.rbtVistoriada.Text = "Vistoriada";
            this.rbtVistoriada.UseVisualStyleBackColor = true;
            // 
            // txtOBS
            // 
            this.txtOBS.AcceptsReturn = true;
            this.txtOBS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOBS.Location = new System.Drawing.Point(241, 727);
            this.txtOBS.MaxLength = 250;
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(480, 60);
            this.txtOBS.TabIndex = 16;
            // 
            // txtCodFatura
            // 
            this.txtCodFatura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodFatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFatura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFatura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodFatura.Location = new System.Drawing.Point(361, 843);
            this.txtCodFatura.Name = "txtCodFatura";
            this.txtCodFatura.Size = new System.Drawing.Size(88, 23);
            this.txtCodFatura.TabIndex = 405;
            this.txtCodFatura.Visible = false;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReferencia.Location = new System.Drawing.Point(282, 234);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(69, 13);
            this.lblReferencia.TabIndex = 0;
            this.lblReferencia.Text = "* Referência";
            // 
            // dtpDataOrdem
            // 
            this.dtpDataOrdem.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDataOrdem.CustomFormat = "";
            this.dtpDataOrdem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataOrdem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataOrdem.Location = new System.Drawing.Point(3, 28);
            this.dtpDataOrdem.Name = "dtpDataOrdem";
            this.dtpDataOrdem.Size = new System.Drawing.Size(110, 23);
            this.dtpDataOrdem.TabIndex = 1;
            // 
            // lblDataExecucao
            // 
            this.lblDataExecucao.AutoSize = true;
            this.lblDataExecucao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataExecucao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDataExecucao.Location = new System.Drawing.Point(554, 336);
            this.lblDataExecucao.Name = "lblDataExecucao";
            this.lblDataExecucao.Size = new System.Drawing.Size(85, 13);
            this.lblDataExecucao.TabIndex = 347;
            this.lblDataExecucao.Text = "Prazo Execução";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReferencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReferencia.Location = new System.Drawing.Point(282, 250);
            this.txtReferencia.Mask = "0000,0000,000000000/0000,00,00,00";
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(335, 23);
            this.txtReferencia.TabIndex = 0;
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividade.Location = new System.Drawing.Point(279, 450);
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
            this.cboAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAtividade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAtividade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboAtividade.FormattingEnabled = true;
            this.cboAtividade.Location = new System.Drawing.Point(-1, 2);
            this.cboAtividade.MaxLength = 10;
            this.cboAtividade.Name = "cboAtividade";
            this.cboAtividade.Size = new System.Drawing.Size(108, 23);
            this.cboAtividade.TabIndex = 4;
            this.cboAtividade.SelectionChangeCommitted += new System.EventHandler(this.cboAtividade_SelectionChangeCommitted);
            // 
            // chkSiopi
            // 
            this.chkSiopi.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkSiopi.Checked = true;
            this.chkSiopi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSiopi.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkSiopi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkSiopi.Location = new System.Drawing.Point(622, 254);
            this.chkSiopi.Name = "chkSiopi";
            this.chkSiopi.Size = new System.Drawing.Size(44, 15);
            this.chkSiopi.TabIndex = 5;
            this.chkSiopi.UseCompatibleTextRendering = true;
            this.chkSiopi.UseVisualStyleBackColor = true;
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProfissional.Location = new System.Drawing.Point(280, 393);
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
            this.lblCliente.Location = new System.Drawing.Point(279, 515);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(93, 13);
            this.lblCliente.TabIndex = 358;
            this.lblCliente.Text = "Nome do Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeCliente.Location = new System.Drawing.Point(282, 531);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(384, 23);
            this.txtNomeCliente.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCidade.Location = new System.Drawing.Point(280, 352);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(260, 23);
            this.txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCidade.Location = new System.Drawing.Point(277, 336);
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
            this.lblNomeContato.Location = new System.Drawing.Point(280, 577);
            this.lblNomeContato.Name = "lblNomeContato";
            this.lblNomeContato.Size = new System.Drawing.Size(99, 13);
            this.lblNomeContato.TabIndex = 362;
            this.lblNomeContato.Text = "Nome do Contato";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeContato.Location = new System.Drawing.Point(283, 593);
            this.txtNomeContato.MaxLength = 100;
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(256, 23);
            this.txtNomeContato.TabIndex = 8;
            // 
            // lblTelefoneContato
            // 
            this.lblTelefoneContato.AutoSize = true;
            this.lblTelefoneContato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneContato.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefoneContato.Location = new System.Drawing.Point(542, 576);
            this.lblTelefoneContato.Name = "lblTelefoneContato";
            this.lblTelefoneContato.Size = new System.Drawing.Size(113, 13);
            this.lblTelefoneContato.TabIndex = 364;
            this.lblTelefoneContato.Text = "Telefone do Contato";
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefoneContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefoneContato.Location = new System.Drawing.Point(545, 593);
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(120, 23);
            this.txtTelefoneContato.TabIndex = 9;
            // 
            // txtAgenciaEmail
            // 
            this.txtAgenciaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgenciaEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAgenciaEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaEmail.Location = new System.Drawing.Point(424, 294);
            this.txtAgenciaEmail.MaxLength = 100;
            this.txtAgenciaEmail.Name = "txtAgenciaEmail";
            this.txtAgenciaEmail.ReadOnly = true;
            this.txtAgenciaEmail.Size = new System.Drawing.Size(246, 15);
            this.txtAgenciaEmail.TabIndex = 373;
            // 
            // txtAgenciaTelefone
            // 
            this.txtAgenciaTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgenciaTelefone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAgenciaTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaTelefone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaTelefone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaTelefone.Location = new System.Drawing.Point(282, 294);
            this.txtAgenciaTelefone.MaxLength = 100;
            this.txtAgenciaTelefone.Name = "txtAgenciaTelefone";
            this.txtAgenciaTelefone.ReadOnly = true;
            this.txtAgenciaTelefone.Size = new System.Drawing.Size(139, 15);
            this.txtAgenciaTelefone.TabIndex = 372;
            // 
            // txtAgenciaNome
            // 
            this.txtAgenciaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgenciaNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAgenciaNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaNome.Location = new System.Drawing.Point(282, 276);
            this.txtAgenciaNome.MaxLength = 100;
            this.txtAgenciaNome.Name = "txtAgenciaNome";
            this.txtAgenciaNome.ReadOnly = true;
            this.txtAgenciaNome.Size = new System.Drawing.Size(388, 15);
            this.txtAgenciaNome.TabIndex = 371;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboProfissional);
            this.panel2.Location = new System.Drawing.Point(280, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 26);
            this.panel2.TabIndex = 3;
            // 
            // cboProfissional
            // 
            this.cboProfissional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboProfissional.DisplayMember = "codigo";
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboProfissional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfissional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(-1, 2);
            this.cboProfissional.MaxLength = 3;
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(110, 23);
            this.cboProfissional.TabIndex = 0;
            this.cboProfissional.SelectionChangeCommitted += new System.EventHandler(this.cboProfissional_SelectionChangeCommitted);
            // 
            // dtpDataExecucao
            // 
            this.dtpDataExecucao.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDataExecucao.CustomFormat = "";
            this.dtpDataExecucao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataExecucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataExecucao.Location = new System.Drawing.Point(556, 352);
            this.dtpDataExecucao.Name = "dtpDataExecucao";
            this.dtpDataExecucao.Size = new System.Drawing.Size(110, 23);
            this.dtpDataExecucao.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.cboAtividade);
            this.panel11.Location = new System.Drawing.Point(282, 466);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(108, 26);
            this.panel11.TabIndex = 382;
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomeProfissional.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeProfissional.Location = new System.Drawing.Point(396, 409);
            this.lblNomeProfissional.Name = "lblNomeProfissional";
            this.lblNomeProfissional.Size = new System.Drawing.Size(268, 26);
            this.lblNomeProfissional.TabIndex = 380;
            this.lblNomeProfissional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeDeslocamento
            // 
            this.lblAtividadeDeslocamento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAtividadeDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeDeslocamento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeDeslocamento.Location = new System.Drawing.Point(531, 479);
            this.lblAtividadeDeslocamento.Name = "lblAtividadeDeslocamento";
            this.lblAtividadeDeslocamento.Size = new System.Drawing.Size(135, 13);
            this.lblAtividadeDeslocamento.TabIndex = 379;
            this.lblAtividadeDeslocamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeValor
            // 
            this.lblAtividadeValor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAtividadeValor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeValor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeValor.Location = new System.Drawing.Point(396, 479);
            this.lblAtividadeValor.Name = "lblAtividadeValor";
            this.lblAtividadeValor.Size = new System.Drawing.Size(135, 13);
            this.lblAtividadeValor.TabIndex = 378;
            this.lblAtividadeValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeNome
            // 
            this.lblAtividadeNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAtividadeNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeNome.Location = new System.Drawing.Point(396, 466);
            this.lblAtividadeNome.Name = "lblAtividadeNome";
            this.lblAtividadeNome.Size = new System.Drawing.Size(270, 13);
            this.lblAtividadeNome.TabIndex = 377;
            this.lblAtividadeNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel13.Location = new System.Drawing.Point(39, 80);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(318, 1);
            this.panel13.TabIndex = 386;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel13);
            this.panel7.ForeColor = System.Drawing.SystemColors.Window;
            this.panel7.Location = new System.Drawing.Point(247, 920);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 1);
            this.panel7.TabIndex = 397;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(232, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 406;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(-146, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 1);
            this.panel4.TabIndex = 386;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.ForeColor = System.Drawing.SystemColors.Window;
            this.panel5.Location = new System.Drawing.Point(218, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 1);
            this.panel5.TabIndex = 407;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(114, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 1);
            this.panel6.TabIndex = 386;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.rbtRecebida, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtPendente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtVistoriada, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtConcluida, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataVistoria, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataConcluida, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataOrdem, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(238, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 55);
            this.tableLayoutPanel1.TabIndex = 410;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo2.Location = new System.Drawing.Point(215, 34);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(45, 13);
            this.lblTitulo2.TabIndex = 411;
            this.lblTitulo2.Text = "STATUS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(218, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 414;
            this.label2.Text = "DADOS DA ORDEM";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.ForeColor = System.Drawing.SystemColors.Window;
            this.panel8.Location = new System.Drawing.Point(221, 200);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(520, 1);
            this.panel8.TabIndex = 413;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel9.Location = new System.Drawing.Point(116, 80);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(318, 1);
            this.panel9.TabIndex = 386;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.panel14);
            this.panel12.ForeColor = System.Drawing.SystemColors.Window;
            this.panel12.Location = new System.Drawing.Point(255, 142);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 0);
            this.panel12.TabIndex = 412;
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel14.Location = new System.Drawing.Point(-144, 80);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(318, 1);
            this.panel14.TabIndex = 386;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(619, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 416;
            this.label3.Text = "SIOPI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(218, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 419;
            this.label4.Text = "OBSERVAÇÕES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel17);
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(221, 694);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 1);
            this.panel3.TabIndex = 418;
            // 
            // panel17
            // 
            this.panel17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel17.Location = new System.Drawing.Point(118, 80);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(318, 1);
            this.panel17.TabIndex = 386;
            // 
            // frmAddOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.txtOBS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtAgenciaEmail);
            this.Controls.Add(this.txtAgenciaTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgenciaNome);
            this.Controls.Add(this.lblDataExecucao);
            this.Controls.Add(this.chkSiopi);
            this.Controls.Add(this.lblReferencia);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.dtpDataExecucao);
            this.Controls.Add(this.lblNomeProfissional);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lblAtividadeDeslocamento);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.lblAtividadeValor);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblAtividadeNome);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCodFatura);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtTelefoneContato);
            this.Controls.Add(this.lblTelefoneContato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.lblNomeContato);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblAtividade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.frmAddOS_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddOS_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.RadioButton rbtRecebida;
        private System.Windows.Forms.RadioButton rbtPendente;
        private System.Windows.Forms.RadioButton rbtConcluida;
        private System.Windows.Forms.DateTimePicker dtpDataVistoria;
        private System.Windows.Forms.DateTimePicker dtpDataConcluida;
        private System.Windows.Forms.RadioButton rbtVistoriada;
        private System.Windows.Forms.TextBox txtOBS;
        private System.Windows.Forms.ToolTip ttpAddOS;
        private System.Windows.Forms.TextBox txtCodFatura;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.DateTimePicker dtpDataOrdem;
        private System.Windows.Forms.Label lblDataExecucao;
        private System.Windows.Forms.MaskedTextBox txtReferencia;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.ComboBox cboAtividade;
        private System.Windows.Forms.CheckBox chkSiopi;
        private System.Windows.Forms.Label lblProfissional;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNomeContato;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label lblTelefoneContato;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContato;
        private System.Windows.Forms.TextBox txtAgenciaEmail;
        private System.Windows.Forms.TextBox txtAgenciaTelefone;
        private System.Windows.Forms.TextBox txtAgenciaNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboProfissional;
        private System.Windows.Forms.DateTimePicker dtpDataExecucao;
        private System.Windows.Forms.Label lblAtividadeNome;
        private System.Windows.Forms.Label lblAtividadeDeslocamento;
        private System.Windows.Forms.Label lblAtividadeValor;
        private System.Windows.Forms.Label lblNomeProfissional;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel17;
    }
}