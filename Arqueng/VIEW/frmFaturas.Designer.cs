﻿namespace Arqueng.VIEW
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblFaturas = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFaturas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_desloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rrtart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNenhuma = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtRRTART = new System.Windows.Forms.TextBox();
            this.txtValorOS = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtValorDeslocamento = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.valor_deslocamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_atividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_concluída = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividade_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.Button();
            this.lblrrtart = new System.Windows.Forms.Label();
            this.pnlFaturaMain = new System.Windows.Forms.Panel();
            this.tblFaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.pnlFaturaMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFaturas
            // 
            this.tblFaturas.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblFaturas.ColumnCount = 2;
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblFaturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFaturas.Controls.Add(this.pnlFaturaMain, 1, 0);
            this.tblFaturas.Controls.Add(this.dgvFaturas, 0, 0);
            this.tblFaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFaturas.Location = new System.Drawing.Point(0, 0);
            this.tblFaturas.Margin = new System.Windows.Forms.Padding(0);
            this.tblFaturas.Name = "tblFaturas";
            this.tblFaturas.RowCount = 1;
            this.tblFaturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFaturas.Size = new System.Drawing.Size(920, 580);
            this.tblFaturas.TabIndex = 424;
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
            this.dgvFaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFaturas.ColumnHeadersHeight = 35;
            this.dgvFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFaturas.ColumnHeadersVisible = false;
            this.dgvFaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.descricao,
            this.data,
            this.subtotal_os,
            this.subtotal_desloc,
            this.total,
            this.rrtart});
            this.dgvFaturas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturas.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaturas.EnableHeadersVisualStyles = false;
            this.dgvFaturas.GridColor = System.Drawing.SystemColors.Window;
            this.dgvFaturas.Location = new System.Drawing.Point(1, 21);
            this.dgvFaturas.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.dgvFaturas.MultiSelect = false;
            this.dgvFaturas.Name = "dgvFaturas";
            this.dgvFaturas.ReadOnly = true;
            this.dgvFaturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFaturas.RowHeadersVisible = false;
            this.dgvFaturas.RowHeadersWidth = 60;
            this.dgvFaturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFaturas.RowTemplate.DividerHeight = 5;
            this.dgvFaturas.RowTemplate.Height = 50;
            this.dgvFaturas.RowTemplate.ReadOnly = true;
            this.dgvFaturas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaturas.ShowEditingIcon = false;
            this.dgvFaturas.Size = new System.Drawing.Size(200, 538);
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
            // rrtart
            // 
            this.rrtart.DataPropertyName = "rrtart";
            this.rrtart.HeaderText = "rrtart";
            this.rrtart.Name = "rrtart";
            this.rrtart.ReadOnly = true;
            this.rrtart.Visible = false;
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
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotal.Location = new System.Drawing.Point(518, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 20);
            this.lblTotal.TabIndex = 426;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblSubtotal.Location = new System.Drawing.Point(521, 510);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 13);
            this.lblSubtotal.TabIndex = 425;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorTotal.Location = new System.Drawing.Point(581, 535);
            this.txtValorTotal.MaxLength = 100;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(116, 20);
            this.txtValorTotal.TabIndex = 427;
            this.txtValorTotal.Text = "R$00.000,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRRTART
            // 
            this.txtRRTART.BackColor = System.Drawing.SystemColors.Window;
            this.txtRRTART.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRRTART.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRRTART.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRRTART.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRRTART.Location = new System.Drawing.Point(101, 20);
            this.txtRRTART.MaxLength = 100;
            this.txtRRTART.Name = "txtRRTART";
            this.txtRRTART.ReadOnly = true;
            this.txtRRTART.Size = new System.Drawing.Size(107, 20);
            this.txtRRTART.TabIndex = 423;
            this.txtRRTART.Text = "000000";
            // 
            // txtValorOS
            // 
            this.txtValorOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorOS.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorOS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorOS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorOS.Location = new System.Drawing.Point(581, 510);
            this.txtValorOS.MaxLength = 100;
            this.txtValorOS.Name = "txtValorOS";
            this.txtValorOS.ReadOnly = true;
            this.txtValorOS.Size = new System.Drawing.Size(55, 15);
            this.txtValorOS.TabIndex = 428;
            this.txtValorOS.Text = "00.000,00";
            this.txtValorOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BackColor = System.Drawing.SystemColors.Window;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtData.Location = new System.Drawing.Point(607, 20);
            this.txtData.MaxLength = 100;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(90, 20);
            this.txtData.TabIndex = 421;
            this.txtData.Text = "00/00/0000";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorDeslocamento
            // 
            this.txtValorDeslocamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDeslocamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorDeslocamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorDeslocamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDeslocamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDeslocamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorDeslocamento.Location = new System.Drawing.Point(642, 510);
            this.txtValorDeslocamento.MaxLength = 100;
            this.txtValorDeslocamento.Name = "txtValorDeslocamento";
            this.txtValorDeslocamento.ReadOnly = true;
            this.txtValorDeslocamento.Size = new System.Drawing.Size(55, 15);
            this.txtValorDeslocamento.TabIndex = 429;
            this.txtValorDeslocamento.Text = "00.000,00";
            this.txtValorDeslocamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbData.Location = new System.Drawing.Point(555, 20);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(46, 20);
            this.lbData.TabIndex = 420;
            this.lbData.Text = "Data:";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha2.Location = new System.Drawing.Point(508, 531);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(190, 1);
            this.pnlLinha2.TabIndex = 430;
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
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvOS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOS.Location = new System.Drawing.Point(20, 60);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.RowHeadersWidth = 40;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvOS.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.RowTemplate.Height = 30;
            this.dgvOS.RowTemplate.ReadOnly = true;
            this.dgvOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.ShowEditingIcon = false;
            this.dgvOS.Size = new System.Drawing.Size(677, 428);
            this.dgvOS.TabIndex = 224;
            // 
            // valor_deslocamento
            // 
            this.valor_deslocamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_deslocamento.DataPropertyName = "valor_deslocamento";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valor_deslocamento.DefaultCellStyle = dataGridViewCellStyle19;
            this.valor_deslocamento.HeaderText = "Desloca.";
            this.valor_deslocamento.MinimumWidth = 55;
            this.valor_deslocamento.Name = "valor_deslocamento";
            this.valor_deslocamento.ReadOnly = true;
            this.valor_deslocamento.Width = 55;
            // 
            // valor_atividade
            // 
            this.valor_atividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.valor_atividade.DataPropertyName = "valor_atividade";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valor_atividade.DefaultCellStyle = dataGridViewCellStyle18;
            this.valor_atividade.HeaderText = "Valor OS";
            this.valor_atividade.MinimumWidth = 55;
            this.valor_atividade.Name = "valor_atividade";
            this.valor_atividade.ReadOnly = true;
            this.valor_atividade.Width = 55;
            // 
            // data_concluída
            // 
            this.data_concluída.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_concluída.DataPropertyName = "data_concluida";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_concluída.DefaultCellStyle = dataGridViewCellStyle17;
            this.data_concluída.HeaderText = "Data da Conclusão";
            this.data_concluída.MinimumWidth = 75;
            this.data_concluída.Name = "data_concluída";
            this.data_concluída.ReadOnly = true;
            this.data_concluída.Width = 75;
            // 
            // data_vistoria
            // 
            this.data_vistoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_vistoria.DataPropertyName = "data_vistoria";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_vistoria.DefaultCellStyle = dataGridViewCellStyle16;
            this.data_vistoria.HeaderText = "Data da Vistoria";
            this.data_vistoria.MinimumWidth = 75;
            this.data_vistoria.Name = "data_vistoria";
            this.data_vistoria.ReadOnly = true;
            this.data_vistoria.Width = 75;
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
            // referencia
            // 
            this.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.referencia.DataPropertyName = "referencia";
            this.referencia.HeaderText = "Referência";
            this.referencia.MinimumWidth = 80;
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // data_ordem
            // 
            this.data_ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.data_ordem.DataPropertyName = "data_ordem";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_ordem.DefaultCellStyle = dataGridViewCellStyle15;
            this.data_ordem.HeaderText = "Data da Ordem";
            this.data_ordem.MinimumWidth = 75;
            this.data_ordem.Name = "data_ordem";
            this.data_ordem.ReadOnly = true;
            this.data_ordem.Width = 75;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn.Location = new System.Drawing.Point(15, 524);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(105, 24);
            this.btn.TabIndex = 431;
            this.btn.Text = "Imprimir";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblrrtart
            // 
            this.lblrrtart.AutoSize = true;
            this.lblrrtart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrrtart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblrrtart.Location = new System.Drawing.Point(16, 20);
            this.lblrrtart.Name = "lblrrtart";
            this.lblrrtart.Size = new System.Drawing.Size(79, 20);
            this.lblrrtart.TabIndex = 422;
            this.lblrrtart.Text = "RRT/ART:";
            this.lblrrtart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFaturaMain
            // 
            this.pnlFaturaMain.Controls.Add(this.lblrrtart);
            this.pnlFaturaMain.Controls.Add(this.btn);
            this.pnlFaturaMain.Controls.Add(this.dgvOS);
            this.pnlFaturaMain.Controls.Add(this.pnlLinha2);
            this.pnlFaturaMain.Controls.Add(this.lbData);
            this.pnlFaturaMain.Controls.Add(this.txtValorDeslocamento);
            this.pnlFaturaMain.Controls.Add(this.txtData);
            this.pnlFaturaMain.Controls.Add(this.txtValorOS);
            this.pnlFaturaMain.Controls.Add(this.txtRRTART);
            this.pnlFaturaMain.Controls.Add(this.txtValorTotal);
            this.pnlFaturaMain.Controls.Add(this.lblSubtotal);
            this.pnlFaturaMain.Controls.Add(this.lblTotal);
            this.pnlFaturaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFaturaMain.Location = new System.Drawing.Point(202, 1);
            this.pnlFaturaMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFaturaMain.Name = "pnlFaturaMain";
            this.pnlFaturaMain.Size = new System.Drawing.Size(717, 578);
            this.pnlFaturaMain.TabIndex = 432;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.pnlFaturaMain.ResumeLayout(false);
            this.pnlFaturaMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblFaturas;
        private System.Windows.Forms.DataGridView dgvFaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_desloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn rrtart;
        private System.Windows.Forms.Label lblNenhuma;
        private System.Windows.Forms.Panel pnlFaturaMain;
        private System.Windows.Forms.Label lblrrtart;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgvOS;
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
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txtValorDeslocamento;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtValorOS;
        private System.Windows.Forms.TextBox txtRRTART;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
    }
}