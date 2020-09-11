namespace Arqueng.VIEW
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
            this.txtReferencia = new System.Windows.Forms.MaskedTextBox();
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
            this.pnlMolduraProfissional = new System.Windows.Forms.Panel();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.pnlMolduraAtividade = new System.Windows.Forms.Panel();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDataConcluida = new System.Windows.Forms.MaskedTextBox();
            this.txtDataVistoria = new System.Windows.Forms.MaskedTextBox();
            this.txtDataPendente = new System.Windows.Forms.MaskedTextBox();
            this.txtDataOrdem = new System.Windows.Forms.MaskedTextBox();
            this.tabOS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.btnAddAgencia = new System.Windows.Forms.Button();
            this.txtCoordenada = new System.Windows.Forms.TextBox();
            this.lblCoordenada = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.pnlMolduraProfissional.SuspendLayout();
            this.pnlMolduraAtividade.SuspendLayout();
            this.pnlBotton.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabOS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.btnAddSave.Text = "&Adicionar";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // rbtRecebida
            // 
            this.rbtRecebida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtRecebida.AutoSize = true;
            this.rbtRecebida.Checked = true;
            this.rbtRecebida.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtRecebida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtRecebida.Location = new System.Drawing.Point(38, 3);
            this.rbtRecebida.Name = "rbtRecebida";
            this.rbtRecebida.Size = new System.Drawing.Size(72, 17);
            this.rbtRecebida.TabIndex = 7;
            this.rbtRecebida.TabStop = true;
            this.rbtRecebida.Text = "Recebida";
            this.rbtRecebida.UseVisualStyleBackColor = true;
            this.rbtRecebida.CheckedChanged += new System.EventHandler(this.rbtRecebida_CheckedChanged);
            // 
            // rbtPendente
            // 
            this.rbtPendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtPendente.AutoSize = true;
            this.rbtPendente.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtPendente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtPendente.Location = new System.Drawing.Point(186, 3);
            this.rbtPendente.Name = "rbtPendente";
            this.rbtPendente.Size = new System.Drawing.Size(74, 17);
            this.rbtPendente.TabIndex = 1;
            this.rbtPendente.Text = "Pendente";
            this.rbtPendente.UseVisualStyleBackColor = true;
            this.rbtPendente.CheckedChanged += new System.EventHandler(this.rbtPendente_CheckedChanged);
            // 
            // rbtConcluida
            // 
            this.rbtConcluida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtConcluida.AutoSize = true;
            this.rbtConcluida.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtConcluida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtConcluida.Location = new System.Drawing.Point(483, 3);
            this.rbtConcluida.Name = "rbtConcluida";
            this.rbtConcluida.Size = new System.Drawing.Size(77, 17);
            this.rbtConcluida.TabIndex = 5;
            this.rbtConcluida.Text = "Concluída";
            this.rbtConcluida.UseVisualStyleBackColor = true;
            this.rbtConcluida.CheckedChanged += new System.EventHandler(this.rbtConcluida_CheckedChanged);
            // 
            // rbtVistoriada
            // 
            this.rbtVistoriada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtVistoriada.AutoSize = true;
            this.rbtVistoriada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbtVistoriada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtVistoriada.Location = new System.Drawing.Point(334, 3);
            this.rbtVistoriada.Name = "rbtVistoriada";
            this.rbtVistoriada.Size = new System.Drawing.Size(77, 17);
            this.rbtVistoriada.TabIndex = 3;
            this.rbtVistoriada.Text = "Vistoriada";
            this.rbtVistoriada.UseVisualStyleBackColor = true;
            this.rbtVistoriada.CheckedChanged += new System.EventHandler(this.rbtVistoriada_CheckedChanged);
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReferencia.Location = new System.Drawing.Point(62, 123);
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
            this.lblDataExecucao.Location = new System.Drawing.Point(62, 267);
            this.lblDataExecucao.Name = "lblDataExecucao";
            this.lblDataExecucao.Size = new System.Drawing.Size(85, 13);
            this.lblDataExecucao.TabIndex = 347;
            this.lblDataExecucao.Text = "Prazo Execução";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReferencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReferencia.Location = new System.Drawing.Point(170, 122);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(297, 23);
            this.txtReferencia.TabIndex = 2;
            this.txtReferencia.Enter += new System.EventHandler(this.txtReferencia_Enter);
            this.txtReferencia.Validated += new System.EventHandler(this.txtReferencia_Validated);
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividade.Location = new System.Drawing.Point(22, 69);
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
            this.cboAtividade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAtividade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboAtividade.FormattingEnabled = true;
            this.cboAtividade.Location = new System.Drawing.Point(0, 1);
            this.cboAtividade.MaxLength = 10;
            this.cboAtividade.Name = "cboAtividade";
            this.cboAtividade.Size = new System.Drawing.Size(90, 23);
            this.cboAtividade.TabIndex = 0;
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
            this.chkSiopi.Location = new System.Drawing.Point(552, 122);
            this.chkSiopi.Name = "chkSiopi";
            this.chkSiopi.Size = new System.Drawing.Size(15, 14);
            this.chkSiopi.TabIndex = 3;
            this.chkSiopi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSiopi.UseCompatibleTextRendering = true;
            this.chkSiopi.UseVisualStyleBackColor = true;
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProfissional.Location = new System.Drawing.Point(22, 28);
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
            this.lblCliente.Location = new System.Drawing.Point(62, 190);
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
            this.txtNomeCliente.Location = new System.Drawing.Point(170, 189);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(400, 23);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCidade.Location = new System.Drawing.Point(62, 232);
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
            this.lblNomeContato.Location = new System.Drawing.Point(62, 306);
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
            this.txtNomeContato.Location = new System.Drawing.Point(170, 305);
            this.txtNomeContato.MaxLength = 100;
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(200, 23);
            this.txtNomeContato.TabIndex = 7;
            // 
            // lblTelefoneContato
            // 
            this.lblTelefoneContato.AutoSize = true;
            this.lblTelefoneContato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneContato.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefoneContato.Location = new System.Drawing.Point(390, 306);
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
            this.txtTelefoneContato.Location = new System.Drawing.Point(450, 305);
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(120, 23);
            this.txtTelefoneContato.TabIndex = 8;
            this.txtTelefoneContato.Enter += new System.EventHandler(this.txtTelefoneContato_Enter);
            this.txtTelefoneContato.Validated += new System.EventHandler(this.txtTelefoneContato_Validated);
            // 
            // txtAgenciaEmail
            // 
            this.txtAgenciaEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAgenciaEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaEmail.Location = new System.Drawing.Point(330, 161);
            this.txtAgenciaEmail.MaxLength = 100;
            this.txtAgenciaEmail.Name = "txtAgenciaEmail";
            this.txtAgenciaEmail.ReadOnly = true;
            this.txtAgenciaEmail.Size = new System.Drawing.Size(240, 15);
            this.txtAgenciaEmail.TabIndex = 402;
            this.txtAgenciaEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAgenciaTelefone
            // 
            this.txtAgenciaTelefone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAgenciaTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaTelefone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaTelefone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaTelefone.Location = new System.Drawing.Point(170, 161);
            this.txtAgenciaTelefone.MaxLength = 100;
            this.txtAgenciaTelefone.Name = "txtAgenciaTelefone";
            this.txtAgenciaTelefone.ReadOnly = true;
            this.txtAgenciaTelefone.Size = new System.Drawing.Size(160, 15);
            this.txtAgenciaTelefone.TabIndex = 401;
            this.txtAgenciaTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAgenciaNome
            // 
            this.txtAgenciaNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAgenciaNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgenciaNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgenciaNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAgenciaNome.Location = new System.Drawing.Point(170, 146);
            this.txtAgenciaNome.MaxLength = 100;
            this.txtAgenciaNome.Name = "txtAgenciaNome";
            this.txtAgenciaNome.ReadOnly = true;
            this.txtAgenciaNome.Size = new System.Drawing.Size(400, 15);
            this.txtAgenciaNome.TabIndex = 400;
            this.txtAgenciaNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlMolduraProfissional
            // 
            this.pnlMolduraProfissional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMolduraProfissional.Controls.Add(this.cboProfissional);
            this.pnlMolduraProfissional.Location = new System.Drawing.Point(102, 22);
            this.pnlMolduraProfissional.Name = "pnlMolduraProfissional";
            this.pnlMolduraProfissional.Size = new System.Drawing.Size(92, 26);
            this.pnlMolduraProfissional.TabIndex = 0;
            // 
            // cboProfissional
            // 
            this.cboProfissional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboProfissional.DisplayMember = "codigo";
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboProfissional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfissional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(0, 1);
            this.cboProfissional.MaxLength = 3;
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(90, 23);
            this.cboProfissional.TabIndex = 0;
            this.cboProfissional.ValueMember = "codigo";
            this.cboProfissional.SelectionChangeCommitted += new System.EventHandler(this.cboProfissional_SelectionChangeCommitted);
            // 
            // pnlMolduraAtividade
            // 
            this.pnlMolduraAtividade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMolduraAtividade.Controls.Add(this.cboAtividade);
            this.pnlMolduraAtividade.Location = new System.Drawing.Point(102, 64);
            this.pnlMolduraAtividade.Name = "pnlMolduraAtividade";
            this.pnlMolduraAtividade.Size = new System.Drawing.Size(92, 26);
            this.pnlMolduraAtividade.TabIndex = 1;
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeProfissional.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfissional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeProfissional.Location = new System.Drawing.Point(200, 22);
            this.lblNomeProfissional.Name = "lblNomeProfissional";
            this.lblNomeProfissional.Size = new System.Drawing.Size(370, 28);
            this.lblNomeProfissional.TabIndex = 403;
            this.lblNomeProfissional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeDeslocamento
            // 
            this.lblAtividadeDeslocamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAtividadeDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeDeslocamento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeDeslocamento.Location = new System.Drawing.Point(385, 77);
            this.lblAtividadeDeslocamento.Name = "lblAtividadeDeslocamento";
            this.lblAtividadeDeslocamento.Size = new System.Drawing.Size(185, 13);
            this.lblAtividadeDeslocamento.TabIndex = 406;
            this.lblAtividadeDeslocamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeValor
            // 
            this.lblAtividadeValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAtividadeValor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeValor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeValor.Location = new System.Drawing.Point(200, 77);
            this.lblAtividadeValor.Name = "lblAtividadeValor";
            this.lblAtividadeValor.Size = new System.Drawing.Size(185, 13);
            this.lblAtividadeValor.TabIndex = 405;
            this.lblAtividadeValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtividadeNome
            // 
            this.lblAtividadeNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAtividadeNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAtividadeNome.Location = new System.Drawing.Point(200, 64);
            this.lblAtividadeNome.Name = "lblAtividadeNome";
            this.lblAtividadeNome.Size = new System.Drawing.Size(370, 13);
            this.lblAtividadeNome.TabIndex = 404;
            this.lblAtividadeNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(505, 125);
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
            this.pnlBotton.TabIndex = 3;
            // 
            // pnlDados
            // 
            this.pnlDados.AutoScroll = true;
            this.pnlDados.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDados.Controls.Add(this.tableLayoutPanel1);
            this.pnlDados.Controls.Add(this.tabOS);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(920, 580);
            this.pnlDados.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.rbtRecebida, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDataConcluida, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtPendente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtConcluida, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDataVistoria, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDataPendente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtVistoriada, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDataOrdem, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(161, 464);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDataConcluida
            // 
            this.txtDataConcluida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDataConcluida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataConcluida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataConcluida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataConcluida.Location = new System.Drawing.Point(503, 31);
            this.txtDataConcluida.Mask = "00/00/0000";
            this.txtDataConcluida.Name = "txtDataConcluida";
            this.txtDataConcluida.Size = new System.Drawing.Size(90, 23);
            this.txtDataConcluida.TabIndex = 6;
            this.txtDataConcluida.ValidatingType = typeof(System.DateTime);
            this.txtDataConcluida.Visible = false;
            // 
            // txtDataVistoria
            // 
            this.txtDataVistoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDataVistoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataVistoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVistoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataVistoria.Location = new System.Drawing.Point(354, 31);
            this.txtDataVistoria.Mask = "00/00/0000";
            this.txtDataVistoria.Name = "txtDataVistoria";
            this.txtDataVistoria.Size = new System.Drawing.Size(90, 23);
            this.txtDataVistoria.TabIndex = 4;
            this.txtDataVistoria.ValidatingType = typeof(System.DateTime);
            this.txtDataVistoria.Visible = false;
            // 
            // txtDataPendente
            // 
            this.txtDataPendente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDataPendente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataPendente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPendente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataPendente.Location = new System.Drawing.Point(205, 31);
            this.txtDataPendente.Mask = "00/00/0000";
            this.txtDataPendente.Name = "txtDataPendente";
            this.txtDataPendente.Size = new System.Drawing.Size(90, 23);
            this.txtDataPendente.TabIndex = 2;
            this.txtDataPendente.ValidatingType = typeof(System.DateTime);
            this.txtDataPendente.Visible = false;
            // 
            // txtDataOrdem
            // 
            this.txtDataOrdem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDataOrdem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDataOrdem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataOrdem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataOrdem.Location = new System.Drawing.Point(56, 31);
            this.txtDataOrdem.Mask = "00/00/0000";
            this.txtDataOrdem.Name = "txtDataOrdem";
            this.txtDataOrdem.Size = new System.Drawing.Size(90, 23);
            this.txtDataOrdem.TabIndex = 0;
            this.txtDataOrdem.ValidatingType = typeof(System.DateTime);
            this.txtDataOrdem.Validated += new System.EventHandler(this.txtDataOrdem_Validated);
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
            this.tabOS.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboCidade);
            this.tabPage1.Controls.Add(this.dtpPrazo);
            this.tabPage1.Controls.Add(this.btnAddAgencia);
            this.tabPage1.Controls.Add(this.txtCoordenada);
            this.tabPage1.Controls.Add(this.lblCoordenada);
            this.tabPage1.Controls.Add(this.lblReferencia);
            this.tabPage1.Controls.Add(this.pnlMolduraAtividade);
            this.tabPage1.Controls.Add(this.txtNomeCliente);
            this.tabPage1.Controls.Add(this.pnlMolduraProfissional);
            this.tabPage1.Controls.Add(this.txtAgenciaTelefone);
            this.tabPage1.Controls.Add(this.lblNomeProfissional);
            this.tabPage1.Controls.Add(this.lblAtividadeDeslocamento);
            this.tabPage1.Controls.Add(this.lblCliente);
            this.tabPage1.Controls.Add(this.txtReferencia);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblAtividadeValor);
            this.tabPage1.Controls.Add(this.lblAtividade);
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
            // dtpPrazo
            // 
            this.dtpPrazo.CustomFormat = "";
            this.dtpPrazo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrazo.Location = new System.Drawing.Point(170, 266);
            this.dtpPrazo.Name = "dtpPrazo";
            this.dtpPrazo.Size = new System.Drawing.Size(400, 23);
            this.dtpPrazo.TabIndex = 6;
            // 
            // btnAddAgencia
            // 
            this.btnAddAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAgencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAgencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAgencia.Image")));
            this.btnAddAgencia.Location = new System.Drawing.Point(170, 161);
            this.btnAddAgencia.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAgencia.Name = "btnAddAgencia";
            this.btnAddAgencia.Size = new System.Drawing.Size(400, 15);
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
            this.txtCoordenada.Location = new System.Drawing.Point(102, 359);
            this.txtCoordenada.MaxLength = 40;
            this.txtCoordenada.Name = "txtCoordenada";
            this.txtCoordenada.Size = new System.Drawing.Size(468, 23);
            this.txtCoordenada.TabIndex = 9;
            // 
            // lblCoordenada
            // 
            this.lblCoordenada.AutoSize = true;
            this.lblCoordenada.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCoordenada.Location = new System.Drawing.Point(22, 360);
            this.lblCoordenada.Name = "lblCoordenada";
            this.lblCoordenada.Size = new System.Drawing.Size(71, 13);
            this.lblCoordenada.TabIndex = 428;
            this.lblCoordenada.Text = "Coordenada";
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
            // cboCidade
            // 
            this.cboCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCidade.DisplayMember = "cidade";
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(170, 228);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(400, 21);
            this.cboCidade.TabIndex = 5;
            this.cboCidade.ValueMember = "cidade";
            this.cboCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCidade_KeyPress);
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
            this.pnlMolduraProfissional.ResumeLayout(false);
            this.pnlMolduraAtividade.ResumeLayout(false);
            this.pnlBotton.ResumeLayout(false);
            this.pnlBotton.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabOS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox txtReferencia;
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
        private System.Windows.Forms.Panel pnlMolduraProfissional;
        private System.Windows.Forms.ComboBox cboProfissional;
        private System.Windows.Forms.Label lblAtividadeNome;
        private System.Windows.Forms.Label lblAtividadeDeslocamento;
        private System.Windows.Forms.Label lblAtividadeValor;
        private System.Windows.Forms.Label lblNomeProfissional;
        private System.Windows.Forms.Panel pnlMolduraAtividade;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCoordenada;
        private System.Windows.Forms.Label lblCoordenada;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.ComboBox cboCidade;
    }
}