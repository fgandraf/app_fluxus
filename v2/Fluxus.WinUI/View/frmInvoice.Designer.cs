namespace Fluxus.WinUI.View
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblFaturas = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFaturaMain = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRemoverOs = new System.Windows.Forms.Button();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.id_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionalTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.txtValorDeslocamento = new System.Windows.Forms.TextBox();
            this.txtValorOS = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvFaturas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalMileageAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblNenhuma = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ttpFatura = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tblFaturas.SuspendLayout();
            this.pnlFaturaMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFaturas
            // 
            this.tblFaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblFaturas.ColumnCount = 3;
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFaturas.Controls.Add(this.panel1, 1, 0);
            this.tblFaturas.Controls.Add(this.pnlFaturaMain, 2, 2);
            this.tblFaturas.Controls.Add(this.dgvFaturas, 0, 0);
            this.tblFaturas.Controls.Add(this.panel2, 2, 0);
            this.tblFaturas.Location = new System.Drawing.Point(65, 139);
            this.tblFaturas.Margin = new System.Windows.Forms.Padding(0);
            this.tblFaturas.Name = "tblFaturas";
            this.tblFaturas.RowCount = 3;
            this.tblFaturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblFaturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblFaturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFaturas.Size = new System.Drawing.Size(1878, 1194);
            this.tblFaturas.TabIndex = 424;
            this.tblFaturas.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(397, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.tblFaturas.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(1, 1182);
            this.panel1.TabIndex = 433;
            // 
            // pnlFaturaMain
            // 
            this.pnlFaturaMain.Controls.Add(this.btnExcluir);
            this.pnlFaturaMain.Controls.Add(this.btnRemoverOs);
            this.pnlFaturaMain.Controls.Add(this.dgvOS);
            this.pnlFaturaMain.Controls.Add(this.pnlLinha2);
            this.pnlFaturaMain.Controls.Add(this.txtValorDeslocamento);
            this.pnlFaturaMain.Controls.Add(this.txtValorOS);
            this.pnlFaturaMain.Controls.Add(this.txtValorTotal);
            this.pnlFaturaMain.Controls.Add(this.lblSubtotal);
            this.pnlFaturaMain.Controls.Add(this.lblTotal);
            this.pnlFaturaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFaturaMain.Location = new System.Drawing.Point(392, 136);
            this.pnlFaturaMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFaturaMain.Name = "pnlFaturaMain";
            this.pnlFaturaMain.Size = new System.Drawing.Size(1486, 1058);
            this.pnlFaturaMain.TabIndex = 432;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(104, 903);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 75);
            this.btnExcluir.TabIndex = 432;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpFatura.SetToolTip(this.btnExcluir, "Excluir Fatura");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRemoverOs
            // 
            this.btnRemoverOs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverOs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverOs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoverOs.FlatAppearance.BorderSize = 0;
            this.btnRemoverOs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnRemoverOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnRemoverOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverOs.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverOs.Image")));
            this.btnRemoverOs.Location = new System.Drawing.Point(43, 903);
            this.btnRemoverOs.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoverOs.Name = "btnRemoverOs";
            this.btnRemoverOs.Size = new System.Drawing.Size(54, 62);
            this.btnRemoverOs.TabIndex = 431;
            this.btnRemoverOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpFatura.SetToolTip(this.btnRemoverOs, "Remover Ordem de Serviço da Fatura");
            this.btnRemoverOs.UseVisualStyleBackColor = true;
            this.btnRemoverOs.Visible = false;
            this.btnRemoverOs.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AllowUserToOrderColumns = true;
            this.dgvOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOS.BackgroundColor = System.Drawing.Color.White;
            this.dgvOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOS.ColumnHeadersHeight = 35;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_os,
            this.data_ordem,
            this.referenceCode,
            this.service,
            this.professionalTag,
            this.professionalId,
            this.cidade,
            this.customerName,
            this.data_vistoria,
            this.data_concluida,
            this.serviceAmount,
            this.mileageAllowance,
            this.invoiceId,
            this.status});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvOS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOS.Location = new System.Drawing.Point(43, 25);
            this.dgvOS.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgvOS.MultiSelect = false;
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.RowHeadersWidth = 82;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvOS.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.RowTemplate.Height = 60;
            this.dgvOS.RowTemplate.ReadOnly = true;
            this.dgvOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.ShowEditingIcon = false;
            this.dgvOS.Size = new System.Drawing.Size(1400, 872);
            this.dgvOS.TabIndex = 224;
            // 
            // id_os
            // 
            this.id_os.DataPropertyName = "id";
            this.id_os.HeaderText = "id_os";
            this.id_os.MinimumWidth = 10;
            this.id_os.Name = "id_os";
            this.id_os.ReadOnly = true;
            this.id_os.Visible = false;
            this.id_os.Width = 200;
            // 
            // data_ordem
            // 
            this.data_ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_ordem.DataPropertyName = "orderDate";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_ordem.DefaultCellStyle = dataGridViewCellStyle14;
            this.data_ordem.HeaderText = "Data da Ordem";
            this.data_ordem.MinimumWidth = 75;
            this.data_ordem.Name = "data_ordem";
            this.data_ordem.ReadOnly = true;
            this.data_ordem.Width = 75;
            // 
            // referenceCode
            // 
            this.referenceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.referenceCode.DataPropertyName = "referenceCode";
            this.referenceCode.HeaderText = "Referência";
            this.referenceCode.MinimumWidth = 70;
            this.referenceCode.Name = "referenceCode";
            this.referenceCode.ReadOnly = true;
            // 
            // service
            // 
            this.service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.service.DataPropertyName = "service";
            this.service.HeaderText = "Tipo";
            this.service.MinimumWidth = 45;
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Width = 45;
            // 
            // professionalTag
            // 
            this.professionalTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.professionalTag.DataPropertyName = "professional";
            this.professionalTag.HeaderText = "Pro.";
            this.professionalTag.MinimumWidth = 45;
            this.professionalTag.Name = "professionalTag";
            this.professionalTag.ReadOnly = true;
            this.professionalTag.Width = 45;
            // 
            // professionalId
            // 
            this.professionalId.DataPropertyName = "professionalId";
            this.professionalId.HeaderText = "professionalId";
            this.professionalId.MinimumWidth = 10;
            this.professionalId.Name = "professionalId";
            this.professionalId.ReadOnly = true;
            this.professionalId.Visible = false;
            this.professionalId.Width = 200;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cidade.DataPropertyName = "city";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 60;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 60;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Nome do Cliente";
            this.customerName.MinimumWidth = 100;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // data_vistoria
            // 
            this.data_vistoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_vistoria.DataPropertyName = "surveyDate";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_vistoria.DefaultCellStyle = dataGridViewCellStyle15;
            this.data_vistoria.HeaderText = "Data da Vistoria";
            this.data_vistoria.MinimumWidth = 75;
            this.data_vistoria.Name = "data_vistoria";
            this.data_vistoria.ReadOnly = true;
            this.data_vistoria.Width = 75;
            // 
            // data_concluida
            // 
            this.data_concluida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_concluida.DataPropertyName = "doneDate";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_concluida.DefaultCellStyle = dataGridViewCellStyle16;
            this.data_concluida.HeaderText = "Data da Conclusão";
            this.data_concluida.MinimumWidth = 75;
            this.data_concluida.Name = "data_concluida";
            this.data_concluida.ReadOnly = true;
            this.data_concluida.Width = 75;
            // 
            // serviceAmount
            // 
            this.serviceAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.serviceAmount.DataPropertyName = "serviceAmount";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.serviceAmount.DefaultCellStyle = dataGridViewCellStyle17;
            this.serviceAmount.HeaderText = "Valor OS";
            this.serviceAmount.MinimumWidth = 55;
            this.serviceAmount.Name = "serviceAmount";
            this.serviceAmount.ReadOnly = true;
            this.serviceAmount.Width = 55;
            // 
            // mileageAllowance
            // 
            this.mileageAllowance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.mileageAllowance.DataPropertyName = "mileageAllowance";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.mileageAllowance.DefaultCellStyle = dataGridViewCellStyle18;
            this.mileageAllowance.HeaderText = "Desloca.";
            this.mileageAllowance.MinimumWidth = 55;
            this.mileageAllowance.Name = "mileageAllowance";
            this.mileageAllowance.ReadOnly = true;
            this.mileageAllowance.Width = 55;
            // 
            // invoiceId
            // 
            this.invoiceId.DataPropertyName = "invoiceId";
            this.invoiceId.HeaderText = "invoiceId";
            this.invoiceId.MinimumWidth = 10;
            this.invoiceId.Name = "invoiceId";
            this.invoiceId.ReadOnly = true;
            this.invoiceId.Visible = false;
            this.invoiceId.Width = 200;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.MinimumWidth = 10;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            this.status.Width = 200;
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha2.Location = new System.Drawing.Point(1033, 986);
            this.pnlLinha2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(412, 2);
            this.pnlLinha2.TabIndex = 430;
            // 
            // txtValorDeslocamento
            // 
            this.txtValorDeslocamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDeslocamento.BackColor = System.Drawing.Color.White;
            this.txtValorDeslocamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorDeslocamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorDeslocamento.ForeColor = System.Drawing.Color.Black;
            this.txtValorDeslocamento.Location = new System.Drawing.Point(1324, 935);
            this.txtValorDeslocamento.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtValorDeslocamento.MaxLength = 100;
            this.txtValorDeslocamento.Name = "txtValorDeslocamento";
            this.txtValorDeslocamento.ReadOnly = true;
            this.txtValorDeslocamento.Size = new System.Drawing.Size(119, 30);
            this.txtValorDeslocamento.TabIndex = 429;
            this.txtValorDeslocamento.Text = "00.000,00";
            this.txtValorDeslocamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorOS
            // 
            this.txtValorOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorOS.BackColor = System.Drawing.Color.White;
            this.txtValorOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorOS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorOS.ForeColor = System.Drawing.Color.Black;
            this.txtValorOS.Location = new System.Drawing.Point(1192, 935);
            this.txtValorOS.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtValorOS.MaxLength = 100;
            this.txtValorOS.Name = "txtValorOS";
            this.txtValorOS.ReadOnly = true;
            this.txtValorOS.Size = new System.Drawing.Size(119, 30);
            this.txtValorOS.TabIndex = 428;
            this.txtValorOS.Text = "00.000,00";
            this.txtValorOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.BackColor = System.Drawing.Color.White;
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValorTotal.ForeColor = System.Drawing.Color.Black;
            this.txtValorTotal.Location = new System.Drawing.Point(1192, 997);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtValorTotal.MaxLength = 100;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(251, 40);
            this.txtValorTotal.TabIndex = 427;
            this.txtValorTotal.Text = "R$00.000,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblSubtotal.Location = new System.Drawing.Point(1062, 935);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(98, 30);
            this.lblSubtotal.TabIndex = 425;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(1055, 997);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 41);
            this.lblTotal.TabIndex = 426;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvFaturas
            // 
            this.dgvFaturas.AllowUserToAddRows = false;
            this.dgvFaturas.AllowUserToDeleteRows = false;
            this.dgvFaturas.AllowUserToResizeColumns = false;
            this.dgvFaturas.AllowUserToResizeRows = false;
            this.dgvFaturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFaturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFaturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvFaturas.ColumnHeadersHeight = 35;
            this.dgvFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFaturas.ColumnHeadersVisible = false;
            this.dgvFaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.data,
            this.subtotalService,
            this.subtotalMileageAllowance,
            this.total});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturas.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvFaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaturas.EnableHeadersVisualStyles = false;
            this.dgvFaturas.GridColor = System.Drawing.Color.White;
            this.dgvFaturas.Location = new System.Drawing.Point(7, 49);
            this.dgvFaturas.Margin = new System.Windows.Forms.Padding(7, 49, 0, 49);
            this.dgvFaturas.MultiSelect = false;
            this.dgvFaturas.Name = "dgvFaturas";
            this.dgvFaturas.ReadOnly = true;
            this.dgvFaturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFaturas.RowHeadersVisible = false;
            this.dgvFaturas.RowHeadersWidth = 82;
            this.dgvFaturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFaturas.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.tblFaturas.SetRowSpan(this.dgvFaturas, 3);
            this.dgvFaturas.RowTemplate.Height = 60;
            this.dgvFaturas.RowTemplate.ReadOnly = true;
            this.dgvFaturas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaturas.ShowEditingIcon = false;
            this.dgvFaturas.Size = new System.Drawing.Size(383, 1096);
            this.dgvFaturas.TabIndex = 223;
            this.dgvFaturas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFaturas_MouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "description";
            this.descricao.HeaderText = "descricao";
            this.descricao.MinimumWidth = 10;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "issueDate";
            this.data.HeaderText = "data";
            this.data.MinimumWidth = 10;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Visible = false;
            this.data.Width = 200;
            // 
            // subtotalService
            // 
            this.subtotalService.DataPropertyName = "subtotalService";
            this.subtotalService.HeaderText = "Subtotal Os";
            this.subtotalService.MinimumWidth = 10;
            this.subtotalService.Name = "subtotalService";
            this.subtotalService.ReadOnly = true;
            this.subtotalService.Visible = false;
            this.subtotalService.Width = 200;
            // 
            // subtotalMileageAllowance
            // 
            this.subtotalMileageAllowance.DataPropertyName = "subtotalMileageAllowance";
            this.subtotalMileageAllowance.HeaderText = "subtotaldesloca";
            this.subtotalMileageAllowance.MinimumWidth = 10;
            this.subtotalMileageAllowance.Name = "subtotalMileageAllowance";
            this.subtotalMileageAllowance.ReadOnly = true;
            this.subtotalMileageAllowance.Visible = false;
            this.subtotalMileageAllowance.Width = 200;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "totalsas";
            this.total.MinimumWidth = 10;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Visible = false;
            this.total.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.lbData);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(399, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 49, 7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1472, 79);
            this.panel2.TabIndex = 434;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(1368, 2);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(65, 75);
            this.btnImprimir.TabIndex = 431;
            this.ttpFatura.SetToolTip(this.btnImprimir, "Imprimir relatório");
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbData.ForeColor = System.Drawing.Color.Black;
            this.lbData.Location = new System.Drawing.Point(17, 17);
            this.lbData.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(92, 41);
            this.lbData.TabIndex = 420;
            this.lbData.Text = "Data:";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.Black;
            this.txtData.Location = new System.Drawing.Point(111, 17);
            this.txtData.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtData.MaxLength = 100;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(195, 40);
            this.txtData.TabIndex = 421;
            this.txtData.Text = "00/00/0000";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNenhuma
            // 
            this.lblNenhuma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNenhuma.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNenhuma.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNenhuma.Location = new System.Drawing.Point(0, 0);
            this.lblNenhuma.Margin = new System.Windows.Forms.Padding(0);
            this.lblNenhuma.Name = "lblNenhuma";
            this.lblNenhuma.Size = new System.Drawing.Size(2000, 1400);
            this.lblNenhuma.TabIndex = 432;
            this.lblNenhuma.Text = "Nenhuma fatura gerada!";
            this.lblNenhuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Relacao_OS.pdf";
            this.saveFileDialog.Filter = "Arquivos PDF|*.pdf";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(65, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 75);
            this.lblTitulo.TabIndex = 433;
            this.lblTitulo.Text = "Faturas";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2000, 1400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tblFaturas);
            this.Controls.Add(this.lblNenhuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmInvoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFaturas";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.tblFaturas.ResumeLayout(false);
            this.pnlFaturaMain.ResumeLayout(false);
            this.pnlFaturaMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblFaturas;
        private System.Windows.Forms.Label lblNenhuma;
        private System.Windows.Forms.Panel pnlFaturaMain;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txtValorDeslocamento;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtValorOS;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnRemoverOs;
        private System.Windows.Forms.ToolTip ttpFatura;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvFaturas;
        private DataGridViewTextBoxColumn id_os;
        private DataGridViewTextBoxColumn data_ordem;
        private DataGridViewTextBoxColumn referenceCode;
        private DataGridViewTextBoxColumn service;
        private DataGridViewTextBoxColumn professionalTag;
        private DataGridViewTextBoxColumn professionalId;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn data_vistoria;
        private DataGridViewTextBoxColumn data_concluida;
        private DataGridViewTextBoxColumn serviceAmount;
        private DataGridViewTextBoxColumn mileageAllowance;
        private DataGridViewTextBoxColumn invoiceId;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn subtotalService;
        private DataGridViewTextBoxColumn subtotalMileageAllowance;
        private DataGridViewTextBoxColumn total;
        private Label lblTitulo;
        private Panel panel2;
    }
}