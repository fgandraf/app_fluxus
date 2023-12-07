namespace Fluxus.WinUI.View
{
    partial class uctAddInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pnlLinha2 = new Panel();
            txtValorDeslocamento = new TextBox();
            txtValorOS = new TextBox();
            txtValorTotal = new TextBox();
            btnRemover = new Button();
            label6 = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            dtpData = new DateTimePicker();
            lblTotal = new Label();
            lblSubtotal = new Label();
            dgvOS = new DataGridView();
            btnFaturar = new Button();
            btnCancelar = new Button();
            ttpFatura = new ToolTip(components);
            id = new DataGridViewTextBoxColumn();
            data_ordem = new DataGridViewTextBoxColumn();
            referencia = new DataGridViewTextBoxColumn();
            profissional_cod = new DataGridViewTextBoxColumn();
            atividade_cod = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            nome_cliente = new DataGridViewTextBoxColumn();
            data_vistoria = new DataGridViewTextBoxColumn();
            data_concluída = new DataGridViewTextBoxColumn();
            valor_atividade = new DataGridViewTextBoxColumn();
            valor_deslocamento = new DataGridViewTextBoxColumn();
            ProfessionalId = new DataGridViewTextBoxColumn();
            InvoiceId = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Invoiced = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 1256);
            panel1.Margin = new Padding(6, 7, 6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1998, 0);
            panel1.TabIndex = 295;
            // 
            // pnlLinha2
            // 
            pnlLinha2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlLinha2.BackColor = SystemColors.ControlDark;
            pnlLinha2.Location = new Point(1526, 1142);
            pnlLinha2.Margin = new Padding(6, 7, 6, 7);
            pnlLinha2.Name = "pnlLinha2";
            pnlLinha2.Size = new Size(412, 2);
            pnlLinha2.TabIndex = 422;
            // 
            // txtValorDeslocamento
            // 
            txtValorDeslocamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtValorDeslocamento.BackColor = Color.White;
            txtValorDeslocamento.BorderStyle = BorderStyle.None;
            txtValorDeslocamento.CharacterCasing = CharacterCasing.Upper;
            txtValorDeslocamento.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeslocamento.ForeColor = Color.Black;
            txtValorDeslocamento.Location = new Point(1818, 1091);
            txtValorDeslocamento.Margin = new Padding(6, 7, 6, 7);
            txtValorDeslocamento.MaxLength = 100;
            txtValorDeslocamento.Name = "txtValorDeslocamento";
            txtValorDeslocamento.ReadOnly = true;
            txtValorDeslocamento.Size = new Size(119, 30);
            txtValorDeslocamento.TabIndex = 421;
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
            txtValorOS.Location = new Point(1686, 1091);
            txtValorOS.Margin = new Padding(6, 7, 6, 7);
            txtValorOS.MaxLength = 100;
            txtValorOS.Name = "txtValorOS";
            txtValorOS.ReadOnly = true;
            txtValorOS.Size = new Size(119, 30);
            txtValorOS.TabIndex = 420;
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
            txtValorTotal.Location = new Point(1686, 1152);
            txtValorTotal.Margin = new Padding(6, 7, 6, 7);
            txtValorTotal.MaxLength = 100;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(251, 40);
            txtValorTotal.TabIndex = 419;
            txtValorTotal.Text = "R$00.000,00";
            txtValorTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRemover
            // 
            btnRemover.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatAppearance.BorderColor = Color.White;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Image = Properties.Resources.removeIcon;
            btnRemover.Location = new Point(67, 1061);
            btnRemover.Margin = new Padding(0);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(54, 62);
            btnRemover.TabIndex = 418;
            btnRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpFatura.SetToolTip(btnRemover, "Remover linha");
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(61, 71);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 30);
            label6.TabIndex = 309;
            label6.Text = "Data:";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.White;
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescricao.ForeColor = Color.Black;
            txtDescricao.Location = new Point(405, 111);
            txtDescricao.Margin = new Padding(6, 7, 6, 7);
            txtDescricao.MaxLength = 20;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(964, 39);
            txtDescricao.TabIndex = 305;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricao.ForeColor = SystemColors.ControlDarkDark;
            lblDescricao.Location = new Point(399, 71);
            lblDescricao.Margin = new Padding(6, 0, 6, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(111, 30);
            lblDescricao.TabIndex = 306;
            lblDescricao.Text = "Descrição:";
            // 
            // dtpData
            // 
            dtpData.CalendarForeColor = SystemColors.ControlLight;
            dtpData.CustomFormat = "";
            dtpData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(67, 111);
            dtpData.Margin = new Padding(6, 7, 6, 7);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(320, 39);
            dtpData.TabIndex = 304;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(1550, 1152);
            lblTotal.Margin = new Padding(6, 0, 6, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 41);
            lblTotal.TabIndex = 300;
            lblTotal.Text = "TOTAL:";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.ForeColor = SystemColors.MenuText;
            lblSubtotal.Location = new Point(1556, 1091);
            lblSubtotal.Margin = new Padding(6, 0, 6, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(98, 30);
            lblSubtotal.TabIndex = 299;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
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
            dgvOS.Columns.AddRange(new DataGridViewColumn[] { id, data_ordem, referencia, profissional_cod, atividade_cod, cidade, nome_cliente, data_vistoria, data_concluída, valor_atividade, valor_deslocamento, ProfessionalId, InvoiceId, Status, Invoiced });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvOS.DefaultCellStyle = dataGridViewCellStyle9;
            dgvOS.GridColor = SystemColors.InactiveCaption;
            dgvOS.Location = new Point(67, 266);
            dgvOS.Margin = new Padding(6, 7, 6, 7);
            dgvOS.MultiSelect = false;
            dgvOS.Name = "dgvOS";
            dgvOS.ReadOnly = true;
            dgvOS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvOS.RowHeadersVisible = false;
            dgvOS.RowHeadersWidth = 82;
            dgvOS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvOS.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvOS.RowTemplate.Height = 60;
            dgvOS.RowTemplate.ReadOnly = true;
            dgvOS.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOS.ShowEditingIcon = false;
            dgvOS.Size = new Size(1870, 788);
            dgvOS.TabIndex = 223;
            // 
            // btnFaturar
            // 
            btnFaturar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFaturar.BackColor = Color.MediumBlue;
            btnFaturar.FlatAppearance.BorderColor = Color.MediumBlue;
            btnFaturar.FlatStyle = FlatStyle.Flat;
            btnFaturar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFaturar.ForeColor = SystemColors.Control;
            btnFaturar.Location = new Point(1656, 1277);
            btnFaturar.Margin = new Padding(6, 7, 6, 7);
            btnFaturar.Name = "btnFaturar";
            btnFaturar.Size = new Size(325, 62);
            btnFaturar.TabIndex = 296;
            btnFaturar.Text = "&Faturar";
            btnFaturar.UseVisualStyleBackColor = false;
            btnFaturar.Click += btnFaturar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(1372, 1277);
            btnCancelar.Margin = new Padding(6, 7, 6, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(271, 62);
            btnCancelar.TabIndex = 297;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 200;
            // 
            // data_ordem
            // 
            data_ordem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            data_ordem.DataPropertyName = "OrderDate";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_ordem.DefaultCellStyle = dataGridViewCellStyle2;
            data_ordem.HeaderText = "Data da Ordem";
            data_ordem.MinimumWidth = 75;
            data_ordem.Name = "data_ordem";
            data_ordem.ReadOnly = true;
            data_ordem.Width = 75;
            // 
            // referencia
            // 
            referencia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            referencia.DataPropertyName = "ReferenceCode";
            referencia.HeaderText = "Referência";
            referencia.MinimumWidth = 130;
            referencia.Name = "referencia";
            referencia.ReadOnly = true;
            referencia.Width = 130;
            // 
            // profissional_cod
            // 
            profissional_cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            profissional_cod.DataPropertyName = "Professional";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            profissional_cod.DefaultCellStyle = dataGridViewCellStyle3;
            profissional_cod.HeaderText = "Pro.";
            profissional_cod.MinimumWidth = 45;
            profissional_cod.Name = "profissional_cod";
            profissional_cod.ReadOnly = true;
            profissional_cod.Width = 45;
            // 
            // atividade_cod
            // 
            atividade_cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            atividade_cod.DataPropertyName = "Service";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            atividade_cod.DefaultCellStyle = dataGridViewCellStyle4;
            atividade_cod.HeaderText = "Tipo";
            atividade_cod.MinimumWidth = 45;
            atividade_cod.Name = "atividade_cod";
            atividade_cod.ReadOnly = true;
            atividade_cod.Width = 45;
            // 
            // cidade
            // 
            cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            cidade.DataPropertyName = "City";
            cidade.HeaderText = "Cidade";
            cidade.MinimumWidth = 60;
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            cidade.Width = 60;
            // 
            // nome_cliente
            // 
            nome_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nome_cliente.DataPropertyName = "CustomerName";
            nome_cliente.HeaderText = "Nome do Cliente";
            nome_cliente.MinimumWidth = 130;
            nome_cliente.Name = "nome_cliente";
            nome_cliente.ReadOnly = true;
            // 
            // data_vistoria
            // 
            data_vistoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            data_vistoria.DataPropertyName = "SurveyDate";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_vistoria.DefaultCellStyle = dataGridViewCellStyle5;
            data_vistoria.HeaderText = "Data da Vistoria";
            data_vistoria.MinimumWidth = 75;
            data_vistoria.Name = "data_vistoria";
            data_vistoria.ReadOnly = true;
            data_vistoria.Width = 75;
            // 
            // data_concluída
            // 
            data_concluída.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            data_concluída.DataPropertyName = "DoneDate";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_concluída.DefaultCellStyle = dataGridViewCellStyle6;
            data_concluída.HeaderText = "Data da Conclusão";
            data_concluída.MinimumWidth = 75;
            data_concluída.Name = "data_concluída";
            data_concluída.ReadOnly = true;
            data_concluída.Width = 75;
            // 
            // valor_atividade
            // 
            valor_atividade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            valor_atividade.DataPropertyName = "ServiceAmount";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.Padding = new Padding(0, 0, 5, 0);
            valor_atividade.DefaultCellStyle = dataGridViewCellStyle7;
            valor_atividade.HeaderText = "Valor OS";
            valor_atividade.MinimumWidth = 55;
            valor_atividade.Name = "valor_atividade";
            valor_atividade.ReadOnly = true;
            valor_atividade.Width = 55;
            // 
            // valor_deslocamento
            // 
            valor_deslocamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            valor_deslocamento.DataPropertyName = "MileageAllowance";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.Padding = new Padding(0, 0, 5, 0);
            valor_deslocamento.DefaultCellStyle = dataGridViewCellStyle8;
            valor_deslocamento.HeaderText = "Desloca.";
            valor_deslocamento.MinimumWidth = 55;
            valor_deslocamento.Name = "valor_deslocamento";
            valor_deslocamento.ReadOnly = true;
            valor_deslocamento.Width = 55;
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
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 10;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Visible = false;
            Status.Width = 200;
            // 
            // Invoiced
            // 
            Invoiced.DataPropertyName = "Invoiced";
            Invoiced.HeaderText = "Invoiced";
            Invoiced.MinimumWidth = 10;
            Invoiced.Name = "Invoiced";
            Invoiced.ReadOnly = true;
            Invoiced.Visible = false;
            Invoiced.Width = 200;
            // 
            // uctAddInvoice
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlLinha2);
            Controls.Add(btnFaturar);
            Controls.Add(txtValorDeslocamento);
            Controls.Add(btnCancelar);
            Controls.Add(txtValorOS);
            Controls.Add(panel1);
            Controls.Add(txtValorTotal);
            Controls.Add(btnRemover);
            Controls.Add(dgvOS);
            Controls.Add(label6);
            Controls.Add(lblSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(dtpData);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Margin = new Padding(6, 7, 6, 7);
            Name = "uctAddInvoice";
            Size = new Size(2000, 1400);
            Load += frmAddFatura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvOS;
        private Label lblTotal;
        private Label lblSubtotal;
        private Button btnFaturar;
        private Button btnCancelar;
        private DateTimePicker dtpData;
        private Label label6;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Button btnRemover;
        private TextBox txtValorTotal;
        private TextBox txtValorDeslocamento;
        private TextBox txtValorOS;
        private Panel pnlLinha2;
        private ToolTip ttpFatura;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn data_ordem;
        private DataGridViewTextBoxColumn referencia;
        private DataGridViewTextBoxColumn profissional_cod;
        private DataGridViewTextBoxColumn atividade_cod;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn nome_cliente;
        private DataGridViewTextBoxColumn data_vistoria;
        private DataGridViewTextBoxColumn data_concluída;
        private DataGridViewTextBoxColumn valor_atividade;
        private DataGridViewTextBoxColumn valor_deslocamento;
        private DataGridViewTextBoxColumn ProfessionalId;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Invoiced;
    }
}