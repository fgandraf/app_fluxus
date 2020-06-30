namespace Arqueng.VIEW
{
    partial class frmAddFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFatura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValorDeslocamento = new System.Windows.Forms.TextBox();
            this.txtValorOS = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRRTART = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividade_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_concluída = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_atividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_deslocamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtValorDeslocamento);
            this.panel1.Controls.Add(this.txtValorOS);
            this.panel1.Controls.Add(this.txtValorTotal);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.pnlLinha2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRRTART);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.dgvOS);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 430);
            this.panel1.TabIndex = 295;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtValorDeslocamento
            // 
            this.txtValorDeslocamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDeslocamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorDeslocamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorDeslocamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDeslocamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorDeslocamento.Location = new System.Drawing.Point(897, 366);
            this.txtValorDeslocamento.MaxLength = 100;
            this.txtValorDeslocamento.Name = "txtValorDeslocamento";
            this.txtValorDeslocamento.ReadOnly = true;
            this.txtValorDeslocamento.Size = new System.Drawing.Size(65, 15);
            this.txtValorDeslocamento.TabIndex = 421;
            this.txtValorDeslocamento.Text = "00000";
            // 
            // txtValorOS
            // 
            this.txtValorOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorOS.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorOS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorOS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorOS.Location = new System.Drawing.Point(835, 366);
            this.txtValorOS.MaxLength = 100;
            this.txtValorOS.Name = "txtValorOS";
            this.txtValorOS.ReadOnly = true;
            this.txtValorOS.Size = new System.Drawing.Size(56, 15);
            this.txtValorOS.TabIndex = 420;
            this.txtValorOS.Text = "0000";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorTotal.Location = new System.Drawing.Point(835, 393);
            this.txtValorTotal.MaxLength = 100;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(127, 20);
            this.txtValorTotal.TabIndex = 419;
            this.txtValorTotal.Text = "4350,00";
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(30, 370);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(106, 34);
            this.btnRemover.TabIndex = 418;
            this.btnRemover.Text = "   Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha2.Location = new System.Drawing.Point(32, 98);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(930, 1);
            this.pnlLinha2.TabIndex = 310;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(29, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 309;
            this.label6.Text = "Data:";
            // 
            // txtRRTART
            // 
            this.txtRRTART.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRRTART.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRRTART.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRRTART.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRRTART.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRRTART.Location = new System.Drawing.Point(444, 50);
            this.txtRRTART.MaxLength = 100;
            this.txtRRTART.Name = "txtRRTART";
            this.txtRRTART.Size = new System.Drawing.Size(250, 23);
            this.txtRRTART.TabIndex = 307;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(441, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 308;
            this.label5.Text = "ART/RRT Nº:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescricao.Location = new System.Drawing.Point(188, 50);
            this.txtDescricao.MaxLength = 20;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(250, 23);
            this.txtDescricao.TabIndex = 305;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescricao.Location = new System.Drawing.Point(185, 34);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(59, 13);
            this.lblDescricao.TabIndex = 306;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpData.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dtpData.CustomFormat = "";
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(32, 50);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(150, 23);
            this.dtpData.TabIndex = 304;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(770, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 300;
            this.label1.Text = "TOTAL:";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblValor.Location = new System.Drawing.Point(774, 366);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 13);
            this.lblValor.TabIndex = 299;
            this.lblValor.Text = "Subtotal:";
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AllowUserToOrderColumns = true;
            this.dgvOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOS.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOS.ColumnHeadersHeight = 35;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data_ordem,
            this.referencia,
            this.atividade_cod,
            this.cidade,
            this.nome_cliente,
            this.data_vistoria,
            this.data_concluída,
            this.valor_atividade,
            this.valor_deslocamento});
            this.dgvOS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOS.Location = new System.Drawing.Point(30, 122);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.RowHeadersWidth = 40;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOS.RowTemplate.Height = 30;
            this.dgvOS.RowTemplate.ReadOnly = true;
            this.dgvOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.ShowEditingIcon = false;
            this.dgvOS.Size = new System.Drawing.Size(932, 238);
            this.dgvOS.TabIndex = 223;
            // 
            // btnFaturar
            // 
            this.btnFaturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaturar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFaturar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnFaturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFaturar.Location = new System.Drawing.Point(812, 460);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(150, 25);
            this.btnFaturar.TabIndex = 296;
            this.btnFaturar.Text = "&Faturar";
            this.btnFaturar.UseVisualStyleBackColor = false;
            this.btnFaturar.Click += new System.EventHandler(this.btnFaturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(681, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 25);
            this.btnCancelar.TabIndex = 297;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // data_ordem
            // 
            this.data_ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_ordem.DataPropertyName = "data_ordem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_ordem.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_ordem.HeaderText = "Dt. Ordem";
            this.data_ordem.MinimumWidth = 85;
            this.data_ordem.Name = "data_ordem";
            this.data_ordem.ReadOnly = true;
            this.data_ordem.Width = 85;
            // 
            // referencia
            // 
            this.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.referencia.DataPropertyName = "referencia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.referencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.referencia.HeaderText = "Referência";
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // atividade_cod
            // 
            this.atividade_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.atividade_cod.DataPropertyName = "atividade_cod";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.atividade_cod.DefaultCellStyle = dataGridViewCellStyle4;
            this.atividade_cod.HeaderText = "Tipo";
            this.atividade_cod.MinimumWidth = 45;
            this.atividade_cod.Name = "atividade_cod";
            this.atividade_cod.ReadOnly = true;
            this.atividade_cod.Width = 45;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cidade.DataPropertyName = "cidade";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cidade.DefaultCellStyle = dataGridViewCellStyle5;
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 60;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 60;
            // 
            // nome_cliente
            // 
            this.nome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nome_cliente.DataPropertyName = "nome_cliente";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.nome_cliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.nome_cliente.HeaderText = "Nome do Cliente";
            this.nome_cliente.MinimumWidth = 130;
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            this.nome_cliente.Width = 130;
            // 
            // data_vistoria
            // 
            this.data_vistoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_vistoria.DataPropertyName = "data_vistoria";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.data_vistoria.DefaultCellStyle = dataGridViewCellStyle7;
            this.data_vistoria.HeaderText = "Dt. Vistoria";
            this.data_vistoria.MinimumWidth = 100;
            this.data_vistoria.Name = "data_vistoria";
            this.data_vistoria.ReadOnly = true;
            // 
            // data_concluída
            // 
            this.data_concluída.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_concluída.DataPropertyName = "data_concluida";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.data_concluída.DefaultCellStyle = dataGridViewCellStyle8;
            this.data_concluída.HeaderText = "Dt. Conclusão";
            this.data_concluída.MinimumWidth = 100;
            this.data_concluída.Name = "data_concluída";
            this.data_concluída.ReadOnly = true;
            // 
            // valor_atividade
            // 
            this.valor_atividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_atividade.DataPropertyName = "valor_atividade";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.valor_atividade.DefaultCellStyle = dataGridViewCellStyle9;
            this.valor_atividade.HeaderText = "Valor OS";
            this.valor_atividade.MinimumWidth = 65;
            this.valor_atividade.Name = "valor_atividade";
            this.valor_atividade.ReadOnly = true;
            this.valor_atividade.Width = 65;
            // 
            // valor_deslocamento
            // 
            this.valor_deslocamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_deslocamento.DataPropertyName = "valor_deslocamento";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.valor_deslocamento.DefaultCellStyle = dataGridViewCellStyle10;
            this.valor_deslocamento.HeaderText = "Desloca.";
            this.valor_deslocamento.MinimumWidth = 65;
            this.valor_deslocamento.Name = "valor_deslocamento";
            this.valor_deslocamento.ReadOnly = true;
            this.valor_deslocamento.Width = 65;
            // 
            // frmAddFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 509);
            this.Controls.Add(this.btnFaturar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddFatura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturar";
            this.Load += new System.EventHandler(this.frmAddFatura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnFaturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRRTART;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorDeslocamento;
        private System.Windows.Forms.TextBox txtValorOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividade_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_vistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_concluída;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_atividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_deslocamento;
    }
}