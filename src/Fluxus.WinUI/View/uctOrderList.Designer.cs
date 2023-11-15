using Fluxus.Domain.Entities;

namespace Fluxus.WinUI.View
{
    partial class uctOrderList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            pnlLinha2 = new Panel();
            pctLupa = new PictureBox();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvOS = new DataGridView();
            lblTitTotal = new Label();
            lblTotalRegistros = new Label();
            ttpOS = new ToolTip(components);
            btnExportar = new Button();
            label1 = new Label();
            cboFaturadas = new ComboBox();
            cboProfissional = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cboAtividade = new ComboBox();
            cboCidade = new ComboBox();
            label6 = new Label();
            cboStatus = new ComboBox();
            label7 = new Label();
            btnAdd = new Button();
            panel4 = new Panel();
            salvar = new SaveFileDialog();
            id = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            professional = new DataGridViewTextBoxColumn();
            ProfessionalId = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            referenceCode = new DataGridViewTextBoxColumn();
            service = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            surveyDate = new DataGridViewTextBoxColumn();
            doneDate = new DataGridViewTextBoxColumn();
            invoiced = new DataGridViewCheckBoxColumn();
            ServiceAmount = new DataGridViewTextBoxColumn();
            MileageAllowance = new DataGridViewTextBoxColumn();
            InvoiceId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pctLupa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOS).BeginInit();
            SuspendLayout();
            // 
            // pnlLinha2
            // 
            pnlLinha2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlLinha2.BackColor = Color.SteelBlue;
            pnlLinha2.Location = new Point(1280, 107);
            pnlLinha2.Margin = new Padding(7, 6, 7, 6);
            pnlLinha2.Name = "pnlLinha2";
            pnlLinha2.Size = new Size(607, 2);
            pnlLinha2.TabIndex = 224;
            // 
            // pctLupa
            // 
            pctLupa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pctLupa.Image = Properties.Resources.pesquisarIcon;
            pctLupa.Location = new Point(1280, 51);
            pctLupa.Margin = new Padding(7, 6, 7, 6);
            pctLupa.Name = "pctLupa";
            pctLupa.Size = new Size(43, 49);
            pctLupa.SizeMode = PictureBoxSizeMode.Zoom;
            pctLupa.TabIndex = 223;
            pctLupa.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.CharacterCasing = CharacterCasing.Upper;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(1330, 61);
            txtSearch.Margin = new Padding(0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pesquisar";
            txtSearch.Size = new Size(557, 35);
            txtSearch.TabIndex = 222;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Image = Properties.Resources.editIcon;
            btnUpdate.Location = new Point(126, 34);
            btnUpdate.Margin = new Padding(7, 6, 7, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(76, 85);
            btnUpdate.TabIndex = 219;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpOS.SetToolTip(btnUpdate, "Editar Ordem de Serviço");
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.deleteIcon;
            btnDelete.Location = new Point(216, 34);
            btnDelete.Margin = new Padding(7, 6, 7, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 85);
            btnDelete.TabIndex = 220;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpOS.SetToolTip(btnDelete, "Excluir Ordem de Serviço");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvOS
            // 
            dgvOS.AllowUserToAddRows = false;
            dgvOS.AllowUserToDeleteRows = false;
            dgvOS.AllowUserToOrderColumns = true;
            dgvOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOS.BackgroundColor = Color.White;
            dgvOS.BorderStyle = BorderStyle.Fixed3D;
            dgvOS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOS.ColumnHeadersHeight = 35;
            dgvOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOS.Columns.AddRange(new DataGridViewColumn[] { id, status, professional, ProfessionalId, orderDate, referenceCode, service, city, customerName, surveyDate, doneDate, invoiced, ServiceAmount, MileageAllowance, InvoiceId });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvOS.DefaultCellStyle = dataGridViewCellStyle8;
            dgvOS.GridColor = SystemColors.InactiveCaption;
            dgvOS.Location = new Point(43, 160);
            dgvOS.Margin = new Padding(7, 6, 7, 6);
            dgvOS.MultiSelect = false;
            dgvOS.Name = "dgvOS";
            dgvOS.ReadOnly = true;
            dgvOS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvOS.RowHeadersVisible = false;
            dgvOS.RowHeadersWidth = 82;
            dgvOS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvOS.RowTemplate.Height = 60;
            dgvOS.RowTemplate.ReadOnly = true;
            dgvOS.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOS.ShowEditingIcon = false;
            dgvOS.Size = new Size(1843, 929);
            dgvOS.TabIndex = 221;
            // 
            // lblTitTotal
            // 
            lblTitTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTitTotal.AutoSize = true;
            lblTitTotal.Location = new Point(1609, 1095);
            lblTitTotal.Margin = new Padding(7, 0, 7, 0);
            lblTitTotal.Name = "lblTitTotal";
            lblTitTotal.Size = new Size(207, 32);
            lblTitTotal.TabIndex = 227;
            lblTitTotal.Text = "Total de Registros:";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalRegistros.Location = new Point(1813, 1095);
            lblTotalRegistros.Margin = new Padding(7, 0, 7, 0);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(74, 32);
            lblTotalRegistros.TabIndex = 228;
            lblTotalRegistros.Text = "99";
            lblTotalRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportar.BackColor = Color.White;
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderColor = Color.White;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.ForeColor = Color.Black;
            btnExportar.Image = Properties.Resources.exportIcon;
            btnExportar.Location = new Point(1834, 1205);
            btnExportar.Margin = new Padding(7, 6, 7, 6);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(50, 50);
            btnExportar.TabIndex = 260;
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpOS.SetToolTip(btnExportar, "Exportar para o Excel");
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1355, 1180);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 237;
            label1.Text = "Faturadas";
            // 
            // cboFaturadas
            // 
            cboFaturadas.Anchor = AnchorStyles.Bottom;
            cboFaturadas.AutoCompleteCustomSource.AddRange(new string[] { "Todas", "Sim", "Nâo" });
            cboFaturadas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFaturadas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboFaturadas.FormattingEnabled = true;
            cboFaturadas.Items.AddRange(new object[] { "NÂO FATURADAS", "FATURADAS" });
            cboFaturadas.Location = new Point(1358, 1217);
            cboFaturadas.Margin = new Padding(7, 6, 7, 6);
            cboFaturadas.Name = "cboFaturadas";
            cboFaturadas.Size = new Size(255, 38);
            cboFaturadas.TabIndex = 243;
            cboFaturadas.SelectionChangeCommitted += GetFilteredChanges;
            // 
            // cboProfissional
            // 
            cboProfissional.Anchor = AnchorStyles.Bottom;
            cboProfissional.DisplayMember = "nameid";
            cboProfissional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfissional.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboProfissional.FormattingEnabled = true;
            cboProfissional.Location = new Point(229, 1217);
            cboProfissional.Margin = new Padding(7, 6, 7, 6);
            cboProfissional.Name = "cboProfissional";
            cboProfissional.Size = new Size(375, 38);
            cboProfissional.TabIndex = 247;
            cboProfissional.ValueMember = "tag";
            cboProfissional.SelectionChangeCommitted += GetFilteredChanges;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(224, 1180);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 246;
            label3.Text = "Profissional";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1173, 1180);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 249;
            label4.Text = "Atividade";
            // 
            // cboAtividade
            // 
            cboAtividade.Anchor = AnchorStyles.Bottom;
            cboAtividade.DisplayMember = "tag";
            cboAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAtividade.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboAtividade.FormattingEnabled = true;
            cboAtividade.Location = new Point(1176, 1217);
            cboAtividade.Margin = new Padding(7, 6, 7, 6);
            cboAtividade.Name = "cboAtividade";
            cboAtividade.Size = new Size(164, 38);
            cboAtividade.TabIndex = 250;
            cboAtividade.ValueMember = "id";
            cboAtividade.SelectionChangeCommitted += GetFilteredChanges;
            // 
            // cboCidade
            // 
            cboCidade.Anchor = AnchorStyles.Bottom;
            cboCidade.DisplayMember = "city";
            cboCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCidade.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboCidade.FormattingEnabled = true;
            cboCidade.Location = new Point(850, 1217);
            cboCidade.Margin = new Padding(7, 6, 7, 6);
            cboCidade.Name = "cboCidade";
            cboCidade.Size = new Size(307, 38);
            cboCidade.TabIndex = 253;
            cboCidade.ValueMember = "cidade";
            cboCidade.SelectionChangeCommitted += GetFilteredChanges;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(848, 1180);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 252;
            label6.Text = "Cidade";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Bottom;
            cboStatus.AutoCompleteCustomSource.AddRange(new string[] { "Todas", "Sim", "Nâo" });
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "--TODAS--", "RECEBIDA", "PENDENTE", "VISTORIADA", "CONCLUÍDA" });
            cboStatus.Location = new Point(621, 1217);
            cboStatus.Margin = new Padding(7, 6, 7, 6);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(212, 38);
            cboStatus.TabIndex = 255;
            cboStatus.SelectionChangeCommitted += GetFilteredChanges;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(619, 1180);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 254;
            label7.Text = "Status";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.addIcon;
            btnAdd.Location = new Point(43, 34);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 85);
            btnAdd.TabIndex = 258;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Location = new Point(41, 1157);
            panel4.Margin = new Padding(7, 6, 7, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(1843, 2);
            panel4.TabIndex = 259;
            // 
            // salvar
            // 
            salvar.FileName = "Relatorio de OS.xls";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.Title = "Exportar para Excel";
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 200;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            status.DataPropertyName = "Status";
            status.HeaderText = "Status";
            status.MinimumWidth = 90;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 118;
            // 
            // professional
            // 
            professional.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            professional.DataPropertyName = "Professional";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            professional.DefaultCellStyle = dataGridViewCellStyle2;
            professional.HeaderText = "Pro.";
            professional.MinimumWidth = 40;
            professional.Name = "professional";
            professional.ReadOnly = true;
            professional.Width = 97;
            // 
            // ProfessionalId
            // 
            ProfessionalId.DataPropertyName = "ProfessionalId";
            ProfessionalId.HeaderText = "ProfessionalId";
            ProfessionalId.MinimumWidth = 10;
            ProfessionalId.Name = "ProfessionalId";
            ProfessionalId.ReadOnly = true;
            ProfessionalId.Visible = false;
            ProfessionalId.Width = 200;
            // 
            // orderDate
            // 
            orderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            orderDate.DefaultCellStyle = dataGridViewCellStyle3;
            orderDate.HeaderText = "Data Ordem";
            orderDate.MinimumWidth = 80;
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 179;
            // 
            // referenceCode
            // 
            referenceCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            referenceCode.DataPropertyName = "ReferenceCode";
            referenceCode.HeaderText = "Referência";
            referenceCode.MinimumWidth = 10;
            referenceCode.Name = "referenceCode";
            referenceCode.ReadOnly = true;
            referenceCode.Width = 163;
            // 
            // service
            // 
            service.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            service.DataPropertyName = "Service";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            service.DefaultCellStyle = dataGridViewCellStyle4;
            service.HeaderText = "Serviço";
            service.MinimumWidth = 45;
            service.Name = "service";
            service.ReadOnly = true;
            service.Width = 131;
            // 
            // city
            // 
            city.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            city.DataPropertyName = "City";
            city.HeaderText = "Cidade";
            city.MinimumWidth = 60;
            city.Name = "city";
            city.ReadOnly = true;
            city.Width = 127;
            // 
            // customerName
            // 
            customerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customerName.DataPropertyName = "CustomerName";
            customerName.HeaderText = "Nome do Cliente";
            customerName.MinimumWidth = 10;
            customerName.Name = "customerName";
            customerName.ReadOnly = true;
            customerName.Width = 228;
            // 
            // surveyDate
            // 
            surveyDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            surveyDate.DataPropertyName = "SurveyDate";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            surveyDate.DefaultCellStyle = dataGridViewCellStyle5;
            surveyDate.HeaderText = "Data da Vistoria";
            surveyDate.MinimumWidth = 10;
            surveyDate.Name = "surveyDate";
            surveyDate.ReadOnly = true;
            surveyDate.Width = 215;
            // 
            // doneDate
            // 
            doneDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            doneDate.DataPropertyName = "DoneDate";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            doneDate.DefaultCellStyle = dataGridViewCellStyle6;
            doneDate.HeaderText = "Dt. Conclusão";
            doneDate.MinimumWidth = 85;
            doneDate.Name = "doneDate";
            doneDate.ReadOnly = true;
            doneDate.Width = 195;
            // 
            // invoiced
            // 
            invoiced.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            invoiced.DataPropertyName = "Invoiced";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiced.DefaultCellStyle = dataGridViewCellStyle7;
            invoiced.HeaderText = "Faturada";
            invoiced.MinimumWidth = 60;
            invoiced.Name = "invoiced";
            invoiced.ReadOnly = true;
            invoiced.SortMode = DataGridViewColumnSortMode.Automatic;
            invoiced.Width = 143;
            // 
            // ServiceAmount
            // 
            ServiceAmount.DataPropertyName = "ServiceAmount";
            ServiceAmount.HeaderText = "ServiceAmount";
            ServiceAmount.MinimumWidth = 10;
            ServiceAmount.Name = "ServiceAmount";
            ServiceAmount.ReadOnly = true;
            ServiceAmount.Visible = false;
            ServiceAmount.Width = 200;
            // 
            // MileageAllowance
            // 
            MileageAllowance.DataPropertyName = "MileageAllowance";
            MileageAllowance.HeaderText = "MileageAllowance";
            MileageAllowance.MinimumWidth = 10;
            MileageAllowance.Name = "MileageAllowance";
            MileageAllowance.ReadOnly = true;
            MileageAllowance.Visible = false;
            MileageAllowance.Width = 200;
            // 
            // InvoiceId
            // 
            InvoiceId.DataPropertyName = "InvoiceId";
            InvoiceId.HeaderText = "InvoiceId";
            InvoiceId.MinimumWidth = 10;
            InvoiceId.Name = "InvoiceId";
            InvoiceId.ReadOnly = true;
            InvoiceId.Visible = false;
            InvoiceId.Width = 200;
            // 
            // uctOrderList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnExportar);
            Controls.Add(cboProfissional);
            Controls.Add(panel4);
            Controls.Add(cboStatus);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(lblTotalRegistros);
            Controls.Add(cboCidade);
            Controls.Add(lblTitTotal);
            Controls.Add(label6);
            Controls.Add(pnlLinha2);
            Controls.Add(cboFaturadas);
            Controls.Add(pctLupa);
            Controls.Add(cboAtividade);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(dgvOS);
            Margin = new Padding(7, 6, 7, 6);
            Name = "uctOrderList";
            Size = new Size(1930, 1300);
            ((System.ComponentModel.ISupportInitialize)pctLupa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlLinha2;
        private PictureBox pctLupa;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvOS;
        private Label lblTitTotal;
        private Label lblTotalRegistros;
        private ToolTip ttpOS;
        private Label label1;
        private ComboBox cboFaturadas;
        private ComboBox cboProfissional;
        private Label label3;
        private Label label4;
        private ComboBox cboAtividade;
        private ComboBox cboCidade;
        private Label label6;
        private ComboBox cboStatus;
        private Label label7;
        private Button btnAdd;
        private Panel panel4;
        private Button btnExportar;
        private SaveFileDialog salvar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn professional;
        private DataGridViewTextBoxColumn ProfessionalId;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn referenceCode;
        private DataGridViewTextBoxColumn service;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn surveyDate;
        private DataGridViewTextBoxColumn doneDate;
        private DataGridViewCheckBoxColumn invoiced;
        private DataGridViewTextBoxColumn ServiceAmount;
        private DataGridViewTextBoxColumn MileageAllowance;
        private DataGridViewTextBoxColumn InvoiceId;
    }
}