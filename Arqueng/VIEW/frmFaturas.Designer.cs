namespace Arqueng.VIEW
{
    partial class frmFaturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblFaturas = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFaturaMain = new System.Windows.Forms.Panel();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.lbData = new System.Windows.Forms.Label();
            this.txtValorDeslocamento = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtValorOS = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvFaturas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_desloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblNenhuma = new System.Windows.Forms.Label();
            this.data_ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividade_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_atividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_deslocamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFaturas.SuspendLayout();
            this.pnlFaturaMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFaturas
            // 
            this.tblFaturas.ColumnCount = 3;
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFaturas.Controls.Add(this.panel3, 0, 1);
            this.tblFaturas.Controls.Add(this.panel1, 1, 0);
            this.tblFaturas.Controls.Add(this.pnlFaturaMain, 2, 2);
            this.tblFaturas.Controls.Add(this.dgvFaturas, 0, 0);
            this.tblFaturas.Controls.Add(this.panel2, 2, 0);
            this.tblFaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFaturas.Location = new System.Drawing.Point(0, 0);
            this.tblFaturas.Margin = new System.Windows.Forms.Padding(0);
            this.tblFaturas.Name = "tblFaturas";
            this.tblFaturas.RowCount = 3;
            this.tblFaturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblFaturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tblFaturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFaturas.Size = new System.Drawing.Size(920, 580);
            this.tblFaturas.TabIndex = 424;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(204, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 1);
            this.panel3.TabIndex = 435;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.tblFaturas.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(1, 574);
            this.panel1.TabIndex = 433;
            // 
            // pnlFaturaMain
            // 
            this.pnlFaturaMain.Controls.Add(this.dgvOS);
            this.pnlFaturaMain.Controls.Add(this.pnlLinha2);
            this.pnlFaturaMain.Controls.Add(this.lbData);
            this.pnlFaturaMain.Controls.Add(this.txtValorDeslocamento);
            this.pnlFaturaMain.Controls.Add(this.txtData);
            this.pnlFaturaMain.Controls.Add(this.txtValorOS);
            this.pnlFaturaMain.Controls.Add(this.txtValorTotal);
            this.pnlFaturaMain.Controls.Add(this.lblSubtotal);
            this.pnlFaturaMain.Controls.Add(this.lblTotal);
            this.pnlFaturaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFaturaMain.Location = new System.Drawing.Point(201, 56);
            this.pnlFaturaMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFaturaMain.Name = "pnlFaturaMain";
            this.pnlFaturaMain.Size = new System.Drawing.Size(719, 524);
            this.pnlFaturaMain.TabIndex = 432;
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AllowUserToOrderColumns = true;
            this.dgvOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOS.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOS.ColumnHeadersHeight = 35;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_ordem,
            this.referencia,
            this.atividade_cod,
            this.profissional_cod,
            this.cidade,
            this.nome_cliente,
            this.data_vistoria,
            this.data_concluida,
            this.valor_atividade,
            this.valor_deslocamento});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOS.Location = new System.Drawing.Point(20, 50);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.RowHeadersWidth = 40;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOS.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.RowTemplate.Height = 30;
            this.dgvOS.RowTemplate.ReadOnly = true;
            this.dgvOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.ShowEditingIcon = false;
            this.dgvOS.Size = new System.Drawing.Size(679, 400);
            this.dgvOS.TabIndex = 224;
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha2.Location = new System.Drawing.Point(510, 477);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(190, 1);
            this.pnlLinha2.TabIndex = 430;
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbData.Location = new System.Drawing.Point(557, 10);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(46, 20);
            this.lbData.TabIndex = 420;
            this.lbData.Text = "Data:";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorDeslocamento
            // 
            this.txtValorDeslocamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDeslocamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorDeslocamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorDeslocamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDeslocamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorDeslocamento.Location = new System.Drawing.Point(644, 456);
            this.txtValorDeslocamento.MaxLength = 100;
            this.txtValorDeslocamento.Name = "txtValorDeslocamento";
            this.txtValorDeslocamento.ReadOnly = true;
            this.txtValorDeslocamento.Size = new System.Drawing.Size(55, 15);
            this.txtValorDeslocamento.TabIndex = 429;
            this.txtValorDeslocamento.Text = "00.000,00";
            this.txtValorDeslocamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BackColor = System.Drawing.SystemColors.Window;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtData.Location = new System.Drawing.Point(609, 10);
            this.txtData.MaxLength = 100;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(90, 20);
            this.txtData.TabIndex = 421;
            this.txtData.Text = "00/00/0000";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorOS
            // 
            this.txtValorOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorOS.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorOS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorOS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorOS.Location = new System.Drawing.Point(583, 456);
            this.txtValorOS.MaxLength = 100;
            this.txtValorOS.Name = "txtValorOS";
            this.txtValorOS.ReadOnly = true;
            this.txtValorOS.Size = new System.Drawing.Size(55, 15);
            this.txtValorOS.TabIndex = 428;
            this.txtValorOS.Text = "00.000,00";
            this.txtValorOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorTotal.Location = new System.Drawing.Point(583, 481);
            this.txtValorTotal.MaxLength = 100;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(116, 20);
            this.txtValorTotal.TabIndex = 427;
            this.txtValorTotal.Text = "R$00.000,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblSubtotal.Location = new System.Drawing.Point(523, 456);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 13);
            this.lblSubtotal.TabIndex = 425;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotal.Location = new System.Drawing.Point(520, 481);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 20);
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
            this.dgvFaturas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFaturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFaturas.ColumnHeadersHeight = 35;
            this.dgvFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFaturas.ColumnHeadersVisible = false;
            this.dgvFaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.descricao,
            this.data,
            this.subtotal_os,
            this.subtotal_desloc,
            this.total});
            this.dgvFaturas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturas.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaturas.EnableHeadersVisualStyles = false;
            this.dgvFaturas.GridColor = System.Drawing.SystemColors.Window;
            this.dgvFaturas.Location = new System.Drawing.Point(10, 20);
            this.dgvFaturas.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.dgvFaturas.MultiSelect = false;
            this.dgvFaturas.Name = "dgvFaturas";
            this.dgvFaturas.ReadOnly = true;
            this.dgvFaturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFaturas.RowHeadersVisible = false;
            this.dgvFaturas.RowHeadersWidth = 60;
            this.dgvFaturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblFaturas.SetRowSpan(this.dgvFaturas, 3);
            this.dgvFaturas.RowTemplate.DividerHeight = 5;
            this.dgvFaturas.RowTemplate.Height = 50;
            this.dgvFaturas.RowTemplate.ReadOnly = true;
            this.dgvFaturas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaturas.ShowEditingIcon = false;
            this.dgvFaturas.Size = new System.Drawing.Size(180, 540);
            this.dgvFaturas.TabIndex = 223;
            this.dgvFaturas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFaturas_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 50;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Visible = false;
            // 
            // subtotal_os
            // 
            this.subtotal_os.DataPropertyName = "subtotal_os";
            this.subtotal_os.HeaderText = "Subtotal OS";
            this.subtotal_os.Name = "subtotal_os";
            this.subtotal_os.ReadOnly = true;
            this.subtotal_os.Visible = false;
            // 
            // subtotal_desloc
            // 
            this.subtotal_desloc.DataPropertyName = "subtotal_desloc";
            this.subtotal_desloc.HeaderText = "Subtotal Desloc.";
            this.subtotal_desloc.Name = "subtotal_desloc";
            this.subtotal_desloc.ReadOnly = true;
            this.subtotal_desloc.Visible = false;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(204, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 32);
            this.panel2.TabIndex = 434;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(665, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(30, 30);
            this.btnImprimir.TabIndex = 431;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblNenhuma
            // 
            this.lblNenhuma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNenhuma.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNenhuma.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNenhuma.Location = new System.Drawing.Point(0, 0);
            this.lblNenhuma.Margin = new System.Windows.Forms.Padding(0);
            this.lblNenhuma.Name = "lblNenhuma";
            this.lblNenhuma.Size = new System.Drawing.Size(920, 580);
            this.lblNenhuma.TabIndex = 432;
            this.lblNenhuma.Text = "Nenhuma fatura gerada!";
            this.lblNenhuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_ordem
            // 
            this.data_ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_ordem.DataPropertyName = "data_ordem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_ordem.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_ordem.HeaderText = "Data da Ordem";
            this.data_ordem.MinimumWidth = 75;
            this.data_ordem.Name = "data_ordem";
            this.data_ordem.ReadOnly = true;
            this.data_ordem.Width = 75;
            // 
            // referencia
            // 
            this.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.referencia.DataPropertyName = "referencia";
            this.referencia.HeaderText = "Referência";
            this.referencia.MinimumWidth = 80;
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // atividade_cod
            // 
            this.atividade_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.atividade_cod.DataPropertyName = "atividade_cod";
            this.atividade_cod.HeaderText = "Tipo";
            this.atividade_cod.MinimumWidth = 45;
            this.atividade_cod.Name = "atividade_cod";
            this.atividade_cod.ReadOnly = true;
            this.atividade_cod.Width = 45;
            // 
            // profissional_cod
            // 
            this.profissional_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.profissional_cod.DataPropertyName = "profissional_cod";
            this.profissional_cod.HeaderText = "Pro.";
            this.profissional_cod.MinimumWidth = 45;
            this.profissional_cod.Name = "profissional_cod";
            this.profissional_cod.ReadOnly = true;
            this.profissional_cod.Width = 45;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 60;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 60;
            // 
            // nome_cliente
            // 
            this.nome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_cliente.DataPropertyName = "nome_cliente";
            this.nome_cliente.HeaderText = "Nome do Cliente";
            this.nome_cliente.MinimumWidth = 110;
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            // 
            // data_vistoria
            // 
            this.data_vistoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_vistoria.DataPropertyName = "data_vistoria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_vistoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_vistoria.HeaderText = "Data da Vistoria";
            this.data_vistoria.MinimumWidth = 75;
            this.data_vistoria.Name = "data_vistoria";
            this.data_vistoria.ReadOnly = true;
            this.data_vistoria.Width = 75;
            // 
            // data_concluida
            // 
            this.data_concluida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_concluida.DataPropertyName = "data_concluida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_concluida.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_concluida.HeaderText = "Data da Conclusão";
            this.data_concluida.MinimumWidth = 75;
            this.data_concluida.Name = "data_concluida";
            this.data_concluida.ReadOnly = true;
            this.data_concluida.Width = 75;
            // 
            // valor_atividade
            // 
            this.valor_atividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_atividade.DataPropertyName = "valor_atividade";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valor_atividade.DefaultCellStyle = dataGridViewCellStyle5;
            this.valor_atividade.HeaderText = "Valor OS";
            this.valor_atividade.MinimumWidth = 55;
            this.valor_atividade.Name = "valor_atividade";
            this.valor_atividade.ReadOnly = true;
            this.valor_atividade.Width = 55;
            // 
            // valor_deslocamento
            // 
            this.valor_deslocamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_deslocamento.DataPropertyName = "valor_deslocamento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valor_deslocamento.DefaultCellStyle = dataGridViewCellStyle6;
            this.valor_deslocamento.HeaderText = "Desloca.";
            this.valor_deslocamento.MinimumWidth = 55;
            this.valor_deslocamento.Name = "valor_deslocamento";
            this.valor_deslocamento.ReadOnly = true;
            this.valor_deslocamento.Width = 55;
            // 
            // frmFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.tblFaturas);
            this.Controls.Add(this.lblNenhuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFaturas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFaturas";
            this.Load += new System.EventHandler(this.frmFaturas_Load);
            this.tblFaturas.ResumeLayout(false);
            this.pnlFaturaMain.ResumeLayout(false);
            this.pnlFaturaMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblFaturas;
        private System.Windows.Forms.DataGridView dgvFaturas;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_desloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividade_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissional_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_vistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_concluida;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_atividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_deslocamento;
    }
}