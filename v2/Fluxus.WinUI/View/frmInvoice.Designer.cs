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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            tblFaturas = new TableLayoutPanel();
            panel1 = new Panel();
            pnlFaturaMain = new Panel();
            btnExcluir = new Button();
            btnRemoverOs = new Button();
            dgvOS = new DataGridView();
            id_os = new DataGridViewTextBoxColumn();
            data_ordem = new DataGridViewTextBoxColumn();
            referenceCode = new DataGridViewTextBoxColumn();
            service = new DataGridViewTextBoxColumn();
            professionalTag = new DataGridViewTextBoxColumn();
            professionalId = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            data_vistoria = new DataGridViewTextBoxColumn();
            data_concluida = new DataGridViewTextBoxColumn();
            serviceAmount = new DataGridViewTextBoxColumn();
            mileageAllowance = new DataGridViewTextBoxColumn();
            invoiceId = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            pnlLinha2 = new Panel();
            txtValorDeslocamento = new TextBox();
            txtValorOS = new TextBox();
            txtValorTotal = new TextBox();
            lblSubtotal = new Label();
            lblTotal = new Label();
            dgvFaturas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            subtotalService = new DataGridViewTextBoxColumn();
            subtotalMileageAllowance = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnImprimir = new Button();
            lbData = new Label();
            txtData = new TextBox();
            lblNenhuma = new Label();
            saveFileDialog = new SaveFileDialog();
            ttpFatura = new ToolTip(components);
            tblFaturas.SuspendLayout();
            pnlFaturaMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFaturas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tblFaturas
            // 
            tblFaturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblFaturas.ColumnCount = 3;
            tblFaturas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 390F));
            tblFaturas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblFaturas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFaturas.Controls.Add(panel1, 1, 0);
            tblFaturas.Controls.Add(pnlFaturaMain, 2, 2);
            tblFaturas.Controls.Add(dgvFaturas, 0, 0);
            tblFaturas.Controls.Add(panel2, 2, 0);
            tblFaturas.Location = new Point(33, 61);
            tblFaturas.Margin = new Padding(0);
            tblFaturas.Name = "tblFaturas";
            tblFaturas.RowCount = 3;
            tblFaturas.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tblFaturas.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tblFaturas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFaturas.Size = new Size(1878, 1272);
            tblFaturas.TabIndex = 424;
            tblFaturas.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(397, 6);
            panel1.Margin = new Padding(7, 6, 7, 6);
            panel1.Name = "panel1";
            tblFaturas.SetRowSpan(panel1, 3);
            panel1.Size = new Size(2, 1260);
            panel1.TabIndex = 433;
            // 
            // pnlFaturaMain
            // 
            pnlFaturaMain.Controls.Add(btnExcluir);
            pnlFaturaMain.Controls.Add(btnRemoverOs);
            pnlFaturaMain.Controls.Add(dgvOS);
            pnlFaturaMain.Controls.Add(pnlLinha2);
            pnlFaturaMain.Controls.Add(txtValorDeslocamento);
            pnlFaturaMain.Controls.Add(txtValorOS);
            pnlFaturaMain.Controls.Add(txtValorTotal);
            pnlFaturaMain.Controls.Add(lblSubtotal);
            pnlFaturaMain.Controls.Add(lblTotal);
            pnlFaturaMain.Dock = DockStyle.Fill;
            pnlFaturaMain.Location = new Point(410, 136);
            pnlFaturaMain.Margin = new Padding(0);
            pnlFaturaMain.Name = "pnlFaturaMain";
            pnlFaturaMain.Size = new Size(1468, 1136);
            pnlFaturaMain.TabIndex = 432;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.BackColor = Color.White;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderColor = Color.White;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Image = Properties.Resources.deleteIcon;
            btnExcluir.Location = new Point(115, 981);
            btnExcluir.Margin = new Padding(7, 6, 7, 6);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(65, 75);
            btnExcluir.TabIndex = 432;
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpFatura.SetToolTip(btnExcluir, "Excluir Fatura");
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnRemoverOs
            // 
            btnRemoverOs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoverOs.Cursor = Cursors.Hand;
            btnRemoverOs.FlatAppearance.BorderColor = Color.White;
            btnRemoverOs.FlatAppearance.BorderSize = 0;
            btnRemoverOs.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnRemoverOs.FlatStyle = FlatStyle.Flat;
            btnRemoverOs.Image = Properties.Resources.removeIcon;
            btnRemoverOs.Location = new Point(43, 981);
            btnRemoverOs.Margin = new Padding(0);
            btnRemoverOs.Name = "btnRemoverOs";
            btnRemoverOs.Size = new Size(65, 75);
            btnRemoverOs.TabIndex = 431;
            btnRemoverOs.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpFatura.SetToolTip(btnRemoverOs, "Remover Ordem de Serviço da Fatura");
            btnRemoverOs.UseVisualStyleBackColor = true;
            btnRemoverOs.Visible = false;
            btnRemoverOs.Click += btnRemover_Click;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOS.ColumnHeadersHeight = 35;
            dgvOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOS.Columns.AddRange(new DataGridViewColumn[] { id_os, data_ordem, referenceCode, service, professionalTag, professionalId, cidade, customerName, data_vistoria, data_concluida, serviceAmount, mileageAllowance, invoiceId, status });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvOS.DefaultCellStyle = dataGridViewCellStyle7;
            dgvOS.GridColor = SystemColors.InactiveCaption;
            dgvOS.Location = new Point(43, 25);
            dgvOS.Margin = new Padding(7, 6, 7, 6);
            dgvOS.MultiSelect = false;
            dgvOS.Name = "dgvOS";
            dgvOS.ReadOnly = true;
            dgvOS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvOS.RowHeadersVisible = false;
            dgvOS.RowHeadersWidth = 82;
            dgvOS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvOS.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvOS.RowTemplate.Height = 60;
            dgvOS.RowTemplate.ReadOnly = true;
            dgvOS.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvOS.ScrollBars = ScrollBars.Vertical;
            dgvOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOS.ShowEditingIcon = false;
            dgvOS.Size = new Size(1382, 950);
            dgvOS.TabIndex = 224;
            // 
            // id_os
            // 
            id_os.DataPropertyName = "id";
            id_os.HeaderText = "id_os";
            id_os.MinimumWidth = 10;
            id_os.Name = "id_os";
            id_os.ReadOnly = true;
            id_os.Visible = false;
            id_os.Width = 200;
            // 
            // data_ordem
            // 
            data_ordem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            data_ordem.DataPropertyName = "orderDate";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_ordem.DefaultCellStyle = dataGridViewCellStyle2;
            data_ordem.HeaderText = "Data da Ordem";
            data_ordem.MinimumWidth = 75;
            data_ordem.Name = "data_ordem";
            data_ordem.ReadOnly = true;
            data_ordem.Width = 75;
            // 
            // referenceCode
            // 
            referenceCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            referenceCode.DataPropertyName = "referenceCode";
            referenceCode.HeaderText = "Referência";
            referenceCode.MinimumWidth = 70;
            referenceCode.Name = "referenceCode";
            referenceCode.ReadOnly = true;
            // 
            // service
            // 
            service.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            service.DataPropertyName = "service";
            service.HeaderText = "Tipo";
            service.MinimumWidth = 45;
            service.Name = "service";
            service.ReadOnly = true;
            service.Width = 45;
            // 
            // professionalTag
            // 
            professionalTag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            professionalTag.DataPropertyName = "professional";
            professionalTag.HeaderText = "Pro.";
            professionalTag.MinimumWidth = 45;
            professionalTag.Name = "professionalTag";
            professionalTag.ReadOnly = true;
            professionalTag.Width = 45;
            // 
            // professionalId
            // 
            professionalId.DataPropertyName = "professionalId";
            professionalId.HeaderText = "professionalId";
            professionalId.MinimumWidth = 10;
            professionalId.Name = "professionalId";
            professionalId.ReadOnly = true;
            professionalId.Visible = false;
            professionalId.Width = 200;
            // 
            // cidade
            // 
            cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            cidade.DataPropertyName = "city";
            cidade.HeaderText = "Cidade";
            cidade.MinimumWidth = 60;
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            cidade.Width = 60;
            // 
            // customerName
            // 
            customerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerName.DataPropertyName = "customerName";
            customerName.HeaderText = "Nome do Cliente";
            customerName.MinimumWidth = 100;
            customerName.Name = "customerName";
            customerName.ReadOnly = true;
            // 
            // data_vistoria
            // 
            data_vistoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            data_vistoria.DataPropertyName = "surveyDate";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_vistoria.DefaultCellStyle = dataGridViewCellStyle3;
            data_vistoria.HeaderText = "Data da Vistoria";
            data_vistoria.MinimumWidth = 75;
            data_vistoria.Name = "data_vistoria";
            data_vistoria.ReadOnly = true;
            data_vistoria.Width = 75;
            // 
            // data_concluida
            // 
            data_concluida.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            data_concluida.DataPropertyName = "doneDate";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_concluida.DefaultCellStyle = dataGridViewCellStyle4;
            data_concluida.HeaderText = "Data da Conclusão";
            data_concluida.MinimumWidth = 75;
            data_concluida.Name = "data_concluida";
            data_concluida.ReadOnly = true;
            data_concluida.Width = 75;
            // 
            // serviceAmount
            // 
            serviceAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            serviceAmount.DataPropertyName = "serviceAmount";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 5, 0);
            serviceAmount.DefaultCellStyle = dataGridViewCellStyle5;
            serviceAmount.HeaderText = "Valor OS";
            serviceAmount.MinimumWidth = 55;
            serviceAmount.Name = "serviceAmount";
            serviceAmount.ReadOnly = true;
            serviceAmount.Width = 55;
            // 
            // mileageAllowance
            // 
            mileageAllowance.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            mileageAllowance.DataPropertyName = "mileageAllowance";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 5, 0);
            mileageAllowance.DefaultCellStyle = dataGridViewCellStyle6;
            mileageAllowance.HeaderText = "Desloca.";
            mileageAllowance.MinimumWidth = 55;
            mileageAllowance.Name = "mileageAllowance";
            mileageAllowance.ReadOnly = true;
            mileageAllowance.Width = 55;
            // 
            // invoiceId
            // 
            invoiceId.DataPropertyName = "invoiceId";
            invoiceId.HeaderText = "invoiceId";
            invoiceId.MinimumWidth = 10;
            invoiceId.Name = "invoiceId";
            invoiceId.ReadOnly = true;
            invoiceId.Visible = false;
            invoiceId.Width = 200;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "status";
            status.MinimumWidth = 10;
            status.Name = "status";
            status.ReadOnly = true;
            status.Visible = false;
            status.Width = 200;
            // 
            // pnlLinha2
            // 
            pnlLinha2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlLinha2.BackColor = SystemColors.ControlDark;
            pnlLinha2.Location = new Point(1015, 1064);
            pnlLinha2.Margin = new Padding(7, 6, 7, 6);
            pnlLinha2.Name = "pnlLinha2";
            pnlLinha2.Size = new Size(412, 2);
            pnlLinha2.TabIndex = 430;
            // 
            // txtValorDeslocamento
            // 
            txtValorDeslocamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtValorDeslocamento.BackColor = Color.White;
            txtValorDeslocamento.BorderStyle = BorderStyle.None;
            txtValorDeslocamento.CharacterCasing = CharacterCasing.Upper;
            txtValorDeslocamento.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeslocamento.ForeColor = Color.Black;
            txtValorDeslocamento.Location = new Point(1306, 1013);
            txtValorDeslocamento.Margin = new Padding(7, 6, 7, 6);
            txtValorDeslocamento.MaxLength = 100;
            txtValorDeslocamento.Name = "txtValorDeslocamento";
            txtValorDeslocamento.ReadOnly = true;
            txtValorDeslocamento.Size = new Size(119, 30);
            txtValorDeslocamento.TabIndex = 429;
            txtValorDeslocamento.Text = "00.000,00";
            txtValorDeslocamento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorOS
            // 
            txtValorOS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtValorOS.BackColor = Color.White;
            txtValorOS.BorderStyle = BorderStyle.None;
            txtValorOS.CharacterCasing = CharacterCasing.Upper;
            txtValorOS.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorOS.ForeColor = Color.Black;
            txtValorOS.Location = new Point(1174, 1013);
            txtValorOS.Margin = new Padding(7, 6, 7, 6);
            txtValorOS.MaxLength = 100;
            txtValorOS.Name = "txtValorOS";
            txtValorOS.ReadOnly = true;
            txtValorOS.Size = new Size(119, 30);
            txtValorOS.TabIndex = 428;
            txtValorOS.Text = "00.000,00";
            txtValorOS.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtValorTotal.BackColor = Color.White;
            txtValorTotal.BorderStyle = BorderStyle.None;
            txtValorTotal.CharacterCasing = CharacterCasing.Upper;
            txtValorTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtValorTotal.ForeColor = Color.Black;
            txtValorTotal.Location = new Point(1174, 1075);
            txtValorTotal.Margin = new Padding(7, 6, 7, 6);
            txtValorTotal.MaxLength = 100;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(251, 40);
            txtValorTotal.TabIndex = 427;
            txtValorTotal.Text = "R$00.000,00";
            txtValorTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.ForeColor = SystemColors.MenuText;
            lblSubtotal.Location = new Point(1044, 1013);
            lblSubtotal.Margin = new Padding(7, 0, 7, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(98, 30);
            lblSubtotal.TabIndex = 425;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(1037, 1075);
            lblTotal.Margin = new Padding(7, 0, 7, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 41);
            lblTotal.TabIndex = 426;
            lblTotal.Text = "TOTAL:";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvFaturas
            // 
            dgvFaturas.AllowUserToAddRows = false;
            dgvFaturas.AllowUserToDeleteRows = false;
            dgvFaturas.AllowUserToResizeColumns = false;
            dgvFaturas.AllowUserToResizeRows = false;
            dgvFaturas.BackgroundColor = Color.White;
            dgvFaturas.BorderStyle = BorderStyle.None;
            dgvFaturas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFaturas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvFaturas.ColumnHeadersHeight = 35;
            dgvFaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFaturas.ColumnHeadersVisible = false;
            dgvFaturas.Columns.AddRange(new DataGridViewColumn[] { id, descricao, data, subtotalService, subtotalMileageAllowance, total });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.Padding = new Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvFaturas.DefaultCellStyle = dataGridViewCellStyle11;
            dgvFaturas.Dock = DockStyle.Fill;
            dgvFaturas.EnableHeadersVisualStyles = false;
            dgvFaturas.GridColor = Color.White;
            dgvFaturas.Location = new Point(7, 49);
            dgvFaturas.Margin = new Padding(7, 49, 0, 49);
            dgvFaturas.MultiSelect = false;
            dgvFaturas.Name = "dgvFaturas";
            dgvFaturas.ReadOnly = true;
            dgvFaturas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvFaturas.RowHeadersVisible = false;
            dgvFaturas.RowHeadersWidth = 82;
            dgvFaturas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dgvFaturas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            tblFaturas.SetRowSpan(dgvFaturas, 3);
            dgvFaturas.RowTemplate.Height = 60;
            dgvFaturas.RowTemplate.ReadOnly = true;
            dgvFaturas.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvFaturas.ScrollBars = ScrollBars.Vertical;
            dgvFaturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFaturas.ShowEditingIcon = false;
            dgvFaturas.Size = new Size(383, 1174);
            dgvFaturas.TabIndex = 223;
            dgvFaturas.MouseClick += dgvFaturas_MouseClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 200;
            // 
            // descricao
            // 
            descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descricao.DataPropertyName = "description";
            descricao.HeaderText = "descricao";
            descricao.MinimumWidth = 10;
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // data
            // 
            data.DataPropertyName = "issueDate";
            data.HeaderText = "data";
            data.MinimumWidth = 10;
            data.Name = "data";
            data.ReadOnly = true;
            data.Visible = false;
            data.Width = 200;
            // 
            // subtotalService
            // 
            subtotalService.DataPropertyName = "subtotalService";
            subtotalService.HeaderText = "Subtotal Os";
            subtotalService.MinimumWidth = 10;
            subtotalService.Name = "subtotalService";
            subtotalService.ReadOnly = true;
            subtotalService.Visible = false;
            subtotalService.Width = 200;
            // 
            // subtotalMileageAllowance
            // 
            subtotalMileageAllowance.DataPropertyName = "subtotalMileageAllowance";
            subtotalMileageAllowance.HeaderText = "subtotaldesloca";
            subtotalMileageAllowance.MinimumWidth = 10;
            subtotalMileageAllowance.Name = "subtotalMileageAllowance";
            subtotalMileageAllowance.ReadOnly = true;
            subtotalMileageAllowance.Visible = false;
            subtotalMileageAllowance.Width = 200;
            // 
            // total
            // 
            total.DataPropertyName = "total";
            total.HeaderText = "totalsas";
            total.MinimumWidth = 10;
            total.Name = "total";
            total.ReadOnly = true;
            total.Visible = false;
            total.Width = 200;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnImprimir);
            panel2.Controls.Add(lbData);
            panel2.Controls.Add(txtData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(417, 49);
            panel2.Margin = new Padding(7, 49, 7, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1454, 79);
            panel2.TabIndex = 434;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimir.BackColor = Color.White;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.Location = new Point(1350, 2);
            btnImprimir.Margin = new Padding(0);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(65, 75);
            btnImprimir.TabIndex = 431;
            ttpFatura.SetToolTip(btnImprimir, "Imprimir relatório");
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbData.ForeColor = Color.Black;
            lbData.Location = new Point(17, 17);
            lbData.Margin = new Padding(7, 0, 7, 0);
            lbData.Name = "lbData";
            lbData.Size = new Size(92, 41);
            lbData.TabIndex = 420;
            lbData.Text = "Data:";
            lbData.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtData
            // 
            txtData.BackColor = Color.White;
            txtData.BorderStyle = BorderStyle.None;
            txtData.CharacterCasing = CharacterCasing.Upper;
            txtData.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtData.ForeColor = Color.Black;
            txtData.Location = new Point(111, 17);
            txtData.Margin = new Padding(7, 6, 7, 6);
            txtData.MaxLength = 100;
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(195, 40);
            txtData.TabIndex = 421;
            txtData.Text = "00/00/0000";
            txtData.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNenhuma
            // 
            lblNenhuma.Dock = DockStyle.Fill;
            lblNenhuma.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNenhuma.ForeColor = SystemColors.ControlDark;
            lblNenhuma.Location = new Point(0, 0);
            lblNenhuma.Margin = new Padding(0);
            lblNenhuma.Name = "lblNenhuma";
            lblNenhuma.Size = new Size(2000, 1400);
            lblNenhuma.TabIndex = 432;
            lblNenhuma.Text = "Nenhuma fatura gerada!";
            lblNenhuma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "Relacao_OS.pdf";
            saveFileDialog.Filter = "Arquivos PDF|*.pdf";
            // 
            // frmInvoice
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2000, 1400);
            Controls.Add(tblFaturas);
            Controls.Add(lblNenhuma);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmInvoice";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFaturas";
            Load += frmInvoice_Load;
            tblFaturas.ResumeLayout(false);
            pnlFaturaMain.ResumeLayout(false);
            pnlFaturaMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFaturas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel2;
    }
}