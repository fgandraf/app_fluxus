namespace Fluxus.WinUI.View
{
    partial class frmOSLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOSLista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.pctLupa = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surveyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiced = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTitTotal = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.ttpOS = new System.Windows.Forms.ToolTip(this.components);
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFaturadas = new System.Windows.Forms.ComboBox();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAtividade = new System.Windows.Forms.ComboBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.salvar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLinha2.Location = new System.Drawing.Point(1283, 107);
            this.pnlLinha2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(607, 2);
            this.pnlLinha2.TabIndex = 224;
            // 
            // pctLupa
            // 
            this.pctLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctLupa.Image = ((System.Drawing.Image)(resources.GetObject("pctLupa.Image")));
            this.pctLupa.Location = new System.Drawing.Point(1283, 51);
            this.pctLupa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pctLupa.Name = "pctLupa";
            this.pctLupa.Size = new System.Drawing.Size(43, 49);
            this.pctLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLupa.TabIndex = 223;
            this.pctLupa.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.Location = new System.Drawing.Point(1333, 53);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(557, 35);
            this.txtPesquisar.TabIndex = 222;
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(126, 34);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 85);
            this.btnEditar.TabIndex = 219;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpOS.SetToolTip(this.btnEditar, "Editar Ordem de Serviço");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(214, 34);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 85);
            this.btnExcluir.TabIndex = 220;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpOS.SetToolTip(this.btnExcluir, "Excluir Ordem de Serviço");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOS.ColumnHeadersHeight = 35;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.status,
            this.professional,
            this.orderDate,
            this.referenceCode,
            this.service,
            this.city,
            this.customerName,
            this.surveyDate,
            this.doneDate,
            this.invoiced});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOS.Location = new System.Drawing.Point(43, 160);
            this.dgvOS.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.RowHeadersWidth = 82;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOS.RowTemplate.Height = 30;
            this.dgvOS.RowTemplate.ReadOnly = true;
            this.dgvOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.ShowEditingIcon = false;
            this.dgvOS.Size = new System.Drawing.Size(1846, 890);
            this.dgvOS.StandardTab = true;
            this.dgvOS.TabIndex = 221;
            this.dgvOS.DoubleClick += new System.EventHandler(this.dgvOS_DoubleClick);
            this.dgvOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOS_KeyDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 90;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.Width = 118;
            // 
            // professional
            // 
            this.professional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.professional.DataPropertyName = "Professional";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.professional.DefaultCellStyle = dataGridViewCellStyle2;
            this.professional.HeaderText = "Pro.";
            this.professional.MinimumWidth = 40;
            this.professional.Name = "professional";
            this.professional.ReadOnly = true;
            this.professional.Width = 97;
            // 
            // orderDate
            // 
            this.orderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.orderDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderDate.HeaderText = "Data Ordem";
            this.orderDate.MinimumWidth = 80;
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            this.orderDate.Width = 179;
            // 
            // referenceCode
            // 
            this.referenceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.referenceCode.DataPropertyName = "ReferenceCode";
            this.referenceCode.HeaderText = "Referência";
            this.referenceCode.MinimumWidth = 10;
            this.referenceCode.Name = "referenceCode";
            this.referenceCode.ReadOnly = true;
            this.referenceCode.Width = 163;
            // 
            // service
            // 
            this.service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.service.DataPropertyName = "Service";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.service.DefaultCellStyle = dataGridViewCellStyle4;
            this.service.HeaderText = "Serviço";
            this.service.MinimumWidth = 45;
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Width = 131;
            // 
            // city
            // 
            this.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.city.DataPropertyName = "City";
            this.city.HeaderText = "Cidade";
            this.city.MinimumWidth = 60;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 127;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerName.DataPropertyName = "CustomerName";
            this.customerName.HeaderText = "Nome do Cliente";
            this.customerName.MinimumWidth = 10;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerName.Width = 228;
            // 
            // surveyDate
            // 
            this.surveyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surveyDate.DataPropertyName = "SurveyDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.surveyDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.surveyDate.HeaderText = "Data da Vistoria";
            this.surveyDate.MinimumWidth = 10;
            this.surveyDate.Name = "surveyDate";
            this.surveyDate.ReadOnly = true;
            this.surveyDate.Width = 215;
            // 
            // doneDate
            // 
            this.doneDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.doneDate.DataPropertyName = "DoneDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.doneDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.doneDate.HeaderText = "Dt. Conclusão";
            this.doneDate.MinimumWidth = 85;
            this.doneDate.Name = "doneDate";
            this.doneDate.ReadOnly = true;
            this.doneDate.Width = 195;
            // 
            // invoiced
            // 
            this.invoiced.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.invoiced.DataPropertyName = "Invoiced";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.invoiced.DefaultCellStyle = dataGridViewCellStyle7;
            this.invoiced.HeaderText = "Faturada";
            this.invoiced.MinimumWidth = 60;
            this.invoiced.Name = "invoiced";
            this.invoiced.ReadOnly = true;
            this.invoiced.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiced.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.invoiced.Width = 143;
            // 
            // lblTitTotal
            // 
            this.lblTitTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitTotal.AutoSize = true;
            this.lblTitTotal.Location = new System.Drawing.Point(1612, 1056);
            this.lblTitTotal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitTotal.Name = "lblTitTotal";
            this.lblTitTotal.Size = new System.Drawing.Size(207, 32);
            this.lblTitTotal.TabIndex = 227;
            this.lblTitTotal.Text = "Total de Registros:";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(1816, 1056);
            this.lblTotalRegistros.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(74, 32);
            this.lblTotalRegistros.TabIndex = 228;
            this.lblTotalRegistros.Text = "99";
            this.lblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(1755, 1173);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(48, 49);
            this.btnFiltrar.TabIndex = 233;
            this.ttpOS.SetToolTip(this.btnFiltrar, "Filtrar");
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Visible = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltro.FlatAppearance.BorderSize = 0;
            this.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparFiltro.Image")));
            this.btnLimparFiltro.Location = new System.Drawing.Point(1634, 1180);
            this.btnLimparFiltro.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(48, 49);
            this.btnLimparFiltro.TabIndex = 256;
            this.ttpOS.SetToolTip(this.btnLimparFiltro, "Limpar filtro");
            this.btnLimparFiltro.UseVisualStyleBackColor = true;
            this.btnLimparFiltro.Visible = false;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(1833, 1167);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(54, 62);
            this.btnExportar.TabIndex = 260;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpOS.SetToolTip(this.btnExportar, "Exportar para o Excel");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1356, 1141);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 237;
            this.label1.Text = "Faturadas";
            // 
            // cboFaturadas
            // 
            this.cboFaturadas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboFaturadas.AutoCompleteCustomSource.AddRange(new string[] {
            "Todas",
            "Sim",
            "Nâo"});
            this.cboFaturadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaturadas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFaturadas.FormattingEnabled = true;
            this.cboFaturadas.Items.AddRange(new object[] {
            "NÂO FATURADAS",
            "FATURADAS"});
            this.cboFaturadas.Location = new System.Drawing.Point(1359, 1178);
            this.cboFaturadas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboFaturadas.Name = "cboFaturadas";
            this.cboFaturadas.Size = new System.Drawing.Size(255, 38);
            this.cboFaturadas.TabIndex = 243;
            this.cboFaturadas.SelectionChangeCommitted += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboProfissional
            // 
            this.cboProfissional.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboProfissional.DisplayMember = "nameid";
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(230, 1178);
            this.cboProfissional.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(375, 38);
            this.cboProfissional.TabIndex = 247;
            this.cboProfissional.ValueMember = "tag";
            this.cboProfissional.SelectionChangeCommitted += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(225, 1141);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 246;
            this.label3.Text = "Profissional";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1174, 1141);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 249;
            this.label4.Text = "Atividade";
            // 
            // cboAtividade
            // 
            this.cboAtividade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboAtividade.DisplayMember = "tag";
            this.cboAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAtividade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAtividade.FormattingEnabled = true;
            this.cboAtividade.Location = new System.Drawing.Point(1177, 1178);
            this.cboAtividade.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboAtividade.Name = "cboAtividade";
            this.cboAtividade.Size = new System.Drawing.Size(164, 38);
            this.cboAtividade.TabIndex = 250;
            this.cboAtividade.ValueMember = "id";
            this.cboAtividade.SelectionChangeCommitted += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboCidade
            // 
            this.cboCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCidade.DisplayMember = "city";
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(851, 1178);
            this.cboCidade.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(307, 38);
            this.cboCidade.TabIndex = 253;
            this.cboCidade.ValueMember = "cidade";
            this.cboCidade.SelectionChangeCommitted += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(849, 1141);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 252;
            this.label6.Text = "Cidade";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Todas",
            "Sim",
            "Nâo"});
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "--TODAS--",
            "RECEBIDA",
            "PENDENTE",
            "VISTORIADA",
            "CONCLUÍDA"});
            this.cboStatus.Location = new System.Drawing.Point(622, 1178);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(212, 38);
            this.cboStatus.TabIndex = 255;
            this.cboStatus.SelectionChangeCommitted += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(620, 1141);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 254;
            this.label7.Text = "Status";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(43, 34);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(76, 85);
            this.btnAdicionar.TabIndex = 258;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(41, 1118);
            this.panel4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1846, 2);
            this.panel4.TabIndex = 259;
            // 
            // salvar
            // 
            this.salvar.FileName = "Relatorio de OS.xls";
            this.salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            this.salvar.Title = "Exportar para Excel";
            // 
            // frmOSLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1933, 1261);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cboProfissional);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.lblTitTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlLinha2);
            this.Controls.Add(this.cboFaturadas);
            this.Controls.Add(this.pctLupa);
            this.Controls.Add(this.cboAtividade);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOSLista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.PictureBox pctLupa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Label lblTitTotal;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.ToolTip ttpOS;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFaturadas;
        private System.Windows.Forms.ComboBox cboProfissional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAtividade;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.SaveFileDialog salvar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn professional;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn referenceCode;
        private DataGridViewTextBoxColumn service;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn surveyDate;
        private DataGridViewTextBoxColumn doneDate;
        private DataGridViewCheckBoxColumn invoiced;
    }
}