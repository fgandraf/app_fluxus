namespace Arqueng.VIEW
{
    partial class frmOSFluxo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOSFluxo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linhaRecebidas = new System.Windows.Forms.Panel();
            this.lblTitRecebidas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linhaPendentes = new System.Windows.Forms.Panel();
            this.lblTitPendentes = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linhaConcluidas = new System.Windows.Forms.Panel();
            this.lblTitConcluidas = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linhaVistoriadas = new System.Windows.Forms.Panel();
            this.lblTitVistoriadas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPendentes = new System.Windows.Forms.DataGridView();
            this.referencia_pendentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRecebidas = new System.Windows.Forms.DataGridView();
            this.referencia_recebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvVistoriadas = new System.Windows.Forms.DataGridView();
            this.referencia_vistoriadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvConcluidas = new System.Windows.Forms.DataGridView();
            this.referencia_concluidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlFaturar = new System.Windows.Forms.Panel();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.pnlLinhaFaturar = new System.Windows.Forms.Panel();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.lblProfissional = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendentes)).BeginInit();
            this.menuContext.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebidas)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistoriadas)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcluidas)).BeginInit();
            this.panel9.SuspendLayout();
            this.pnlFaturar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.linhaRecebidas);
            this.panel1.Controls.Add(this.lblTitRecebidas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(35, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 25);
            this.panel1.TabIndex = 6;
            // 
            // linhaRecebidas
            // 
            this.linhaRecebidas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaRecebidas.Location = new System.Drawing.Point(0, 24);
            this.linhaRecebidas.Name = "linhaRecebidas";
            this.linhaRecebidas.Size = new System.Drawing.Size(201, 1);
            this.linhaRecebidas.TabIndex = 1;
            // 
            // lblTitRecebidas
            // 
            this.lblTitRecebidas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitRecebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitRecebidas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitRecebidas.ForeColor = System.Drawing.Color.Black;
            this.lblTitRecebidas.Location = new System.Drawing.Point(0, 0);
            this.lblTitRecebidas.Name = "lblTitRecebidas";
            this.lblTitRecebidas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitRecebidas.Size = new System.Drawing.Size(201, 25);
            this.lblTitRecebidas.TabIndex = 0;
            this.lblTitRecebidas.Text = "RECEBIDAS [0]";
            this.lblTitRecebidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.linhaPendentes);
            this.panel2.Controls.Add(this.lblTitPendentes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(251, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 25);
            this.panel2.TabIndex = 7;
            // 
            // linhaPendentes
            // 
            this.linhaPendentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaPendentes.Location = new System.Drawing.Point(0, 24);
            this.linhaPendentes.Name = "linhaPendentes";
            this.linhaPendentes.Size = new System.Drawing.Size(201, 1);
            this.linhaPendentes.TabIndex = 1;
            // 
            // lblTitPendentes
            // 
            this.lblTitPendentes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitPendentes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitPendentes.ForeColor = System.Drawing.Color.Black;
            this.lblTitPendentes.Location = new System.Drawing.Point(0, 0);
            this.lblTitPendentes.Name = "lblTitPendentes";
            this.lblTitPendentes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitPendentes.Size = new System.Drawing.Size(201, 25);
            this.lblTitPendentes.TabIndex = 1;
            this.lblTitPendentes.Text = "PENDENTES [0]";
            this.lblTitPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.linhaConcluidas);
            this.panel3.Controls.Add(this.lblTitConcluidas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(683, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 25);
            this.panel3.TabIndex = 8;
            // 
            // linhaConcluidas
            // 
            this.linhaConcluidas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaConcluidas.Location = new System.Drawing.Point(0, 24);
            this.linhaConcluidas.Name = "linhaConcluidas";
            this.linhaConcluidas.Size = new System.Drawing.Size(201, 1);
            this.linhaConcluidas.TabIndex = 1;
            // 
            // lblTitConcluidas
            // 
            this.lblTitConcluidas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitConcluidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitConcluidas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitConcluidas.ForeColor = System.Drawing.Color.Black;
            this.lblTitConcluidas.Location = new System.Drawing.Point(0, 0);
            this.lblTitConcluidas.Name = "lblTitConcluidas";
            this.lblTitConcluidas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitConcluidas.Size = new System.Drawing.Size(201, 25);
            this.lblTitConcluidas.TabIndex = 1;
            this.lblTitConcluidas.Text = "CONCLUÍDAS [0]";
            this.lblTitConcluidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.linhaVistoriadas);
            this.panel4.Controls.Add(this.lblTitVistoriadas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(467, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 25);
            this.panel4.TabIndex = 9;
            // 
            // linhaVistoriadas
            // 
            this.linhaVistoriadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaVistoriadas.Location = new System.Drawing.Point(0, 24);
            this.linhaVistoriadas.Name = "linhaVistoriadas";
            this.linhaVistoriadas.Size = new System.Drawing.Size(201, 1);
            this.linhaVistoriadas.TabIndex = 1;
            // 
            // lblTitVistoriadas
            // 
            this.lblTitVistoriadas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitVistoriadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitVistoriadas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitVistoriadas.ForeColor = System.Drawing.Color.Black;
            this.lblTitVistoriadas.Location = new System.Drawing.Point(0, 0);
            this.lblTitVistoriadas.Name = "lblTitVistoriadas";
            this.lblTitVistoriadas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitVistoriadas.Size = new System.Drawing.Size(201, 25);
            this.lblTitVistoriadas.TabIndex = 1;
            this.lblTitVistoriadas.Text = "VISTORIADAS [0]";
            this.lblTitVistoriadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Controls.Add(this.panel11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlFaturar, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlLinhaFaturar, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboProfissional, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProfissional, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 580);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SteelBlue;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(35, 499);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(201, 1);
            this.panel11.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.dgvPendentes);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(251, 60);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8);
            this.panel6.Size = new System.Drawing.Size(201, 439);
            this.panel6.TabIndex = 11;
            // 
            // dgvPendentes
            // 
            this.dgvPendentes.AllowDrop = true;
            this.dgvPendentes.AllowUserToAddRows = false;
            this.dgvPendentes.AllowUserToDeleteRows = false;
            this.dgvPendentes.AllowUserToOrderColumns = true;
            this.dgvPendentes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPendentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPendentes.ColumnHeadersHeight = 35;
            this.dgvPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendentes.ColumnHeadersVisible = false;
            this.dgvPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia_pendentes,
            this.dataGridViewTextBoxColumn4});
            this.dgvPendentes.ContextMenuStrip = this.menuContext;
            this.dgvPendentes.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendentes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendentes.EnableHeadersVisualStyles = false;
            this.dgvPendentes.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPendentes.Location = new System.Drawing.Point(8, 8);
            this.dgvPendentes.MultiSelect = false;
            this.dgvPendentes.Name = "dgvPendentes";
            this.dgvPendentes.ReadOnly = true;
            this.dgvPendentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPendentes.RowHeadersVisible = false;
            this.dgvPendentes.RowHeadersWidth = 60;
            this.dgvPendentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPendentes.RowTemplate.DividerHeight = 8;
            this.dgvPendentes.RowTemplate.Height = 50;
            this.dgvPendentes.RowTemplate.ReadOnly = true;
            this.dgvPendentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendentes.ShowEditingIcon = false;
            this.dgvPendentes.Size = new System.Drawing.Size(185, 423);
            this.dgvPendentes.TabIndex = 223;
            this.dgvPendentes.Tag = "PENDENTE";
            this.dgvPendentes.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendentes_CellMouseLeave);
            this.dgvPendentes.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPendentes_CellMouseMove);
            this.dgvPendentes.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPendentes_CellMouseUp);
            this.dgvPendentes.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvPendentes_DragDrop);
            this.dgvPendentes.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvPendentes_DragOver);
            this.dgvPendentes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPendentes_MouseDown);
            // 
            // referencia_pendentes
            // 
            this.referencia_pendentes.DataPropertyName = "referencia";
            this.referencia_pendentes.HeaderText = "Referência";
            this.referencia_pendentes.Name = "referencia_pendentes";
            this.referencia_pendentes.ReadOnly = true;
            this.referencia_pendentes.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "titulo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Título";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // menuContext
            // 
            this.menuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditar,
            this.mnuExcluir});
            this.menuContext.Name = "menuConcluida";
            this.menuContext.Size = new System.Drawing.Size(110, 48);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Size = new System.Drawing.Size(109, 22);
            this.mnuEditar.Text = "Editar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuExcluir
            // 
            this.mnuExcluir.Name = "mnuExcluir";
            this.mnuExcluir.Size = new System.Drawing.Size(109, 22);
            this.mnuExcluir.Text = "Excluir";
            this.mnuExcluir.Click += new System.EventHandler(this.mnuExcluir_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.dgvRecebidas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(35, 60);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(201, 439);
            this.panel5.TabIndex = 10;
            // 
            // dgvRecebidas
            // 
            this.dgvRecebidas.AllowDrop = true;
            this.dgvRecebidas.AllowUserToAddRows = false;
            this.dgvRecebidas.AllowUserToDeleteRows = false;
            this.dgvRecebidas.AllowUserToResizeColumns = false;
            this.dgvRecebidas.AllowUserToResizeRows = false;
            this.dgvRecebidas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvRecebidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecebidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecebidas.ColumnHeadersHeight = 35;
            this.dgvRecebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecebidas.ColumnHeadersVisible = false;
            this.dgvRecebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia_recebidas,
            this.titulo});
            this.dgvRecebidas.ContextMenuStrip = this.menuContext;
            this.dgvRecebidas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecebidas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRecebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecebidas.EnableHeadersVisualStyles = false;
            this.dgvRecebidas.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvRecebidas.Location = new System.Drawing.Point(8, 8);
            this.dgvRecebidas.MultiSelect = false;
            this.dgvRecebidas.Name = "dgvRecebidas";
            this.dgvRecebidas.ReadOnly = true;
            this.dgvRecebidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecebidas.RowHeadersVisible = false;
            this.dgvRecebidas.RowHeadersWidth = 60;
            this.dgvRecebidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecebidas.RowTemplate.DividerHeight = 8;
            this.dgvRecebidas.RowTemplate.Height = 50;
            this.dgvRecebidas.RowTemplate.ReadOnly = true;
            this.dgvRecebidas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecebidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRecebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecebidas.ShowEditingIcon = false;
            this.dgvRecebidas.Size = new System.Drawing.Size(185, 423);
            this.dgvRecebidas.TabIndex = 222;
            this.dgvRecebidas.Tag = "RECEBIDA";
            this.dgvRecebidas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecebidas_CellMouseLeave);
            this.dgvRecebidas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecebidas_CellMouseMove);
            this.dgvRecebidas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecebidas_CellMouseUp);
            this.dgvRecebidas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvRecebidas_DragDrop);
            this.dgvRecebidas.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvRecebidas_DragOver);
            this.dgvRecebidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvRecebidas_MouseDown);
            // 
            // referencia_recebidas
            // 
            this.referencia_recebidas.DataPropertyName = "referencia";
            this.referencia_recebidas.HeaderText = "Referência";
            this.referencia_recebidas.Name = "referencia_recebidas";
            this.referencia_recebidas.ReadOnly = true;
            this.referencia_recebidas.Visible = false;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo.DataPropertyName = "titulo";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.titulo.DefaultCellStyle = dataGridViewCellStyle7;
            this.titulo.HeaderText = "Título";
            this.titulo.MinimumWidth = 120;
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel7.Controls.Add(this.dgvVistoriadas);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(467, 60);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(8);
            this.panel7.Size = new System.Drawing.Size(201, 439);
            this.panel7.TabIndex = 12;
            // 
            // dgvVistoriadas
            // 
            this.dgvVistoriadas.AllowDrop = true;
            this.dgvVistoriadas.AllowUserToAddRows = false;
            this.dgvVistoriadas.AllowUserToDeleteRows = false;
            this.dgvVistoriadas.AllowUserToOrderColumns = true;
            this.dgvVistoriadas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVistoriadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVistoriadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVistoriadas.ColumnHeadersHeight = 35;
            this.dgvVistoriadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVistoriadas.ColumnHeadersVisible = false;
            this.dgvVistoriadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia_vistoriadas,
            this.dataGridViewTextBoxColumn5});
            this.dgvVistoriadas.ContextMenuStrip = this.menuContext;
            this.dgvVistoriadas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistoriadas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVistoriadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVistoriadas.EnableHeadersVisualStyles = false;
            this.dgvVistoriadas.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVistoriadas.Location = new System.Drawing.Point(8, 8);
            this.dgvVistoriadas.MultiSelect = false;
            this.dgvVistoriadas.Name = "dgvVistoriadas";
            this.dgvVistoriadas.ReadOnly = true;
            this.dgvVistoriadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVistoriadas.RowHeadersVisible = false;
            this.dgvVistoriadas.RowHeadersWidth = 60;
            this.dgvVistoriadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVistoriadas.RowTemplate.DividerHeight = 8;
            this.dgvVistoriadas.RowTemplate.Height = 50;
            this.dgvVistoriadas.RowTemplate.ReadOnly = true;
            this.dgvVistoriadas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVistoriadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVistoriadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVistoriadas.ShowEditingIcon = false;
            this.dgvVistoriadas.Size = new System.Drawing.Size(185, 423);
            this.dgvVistoriadas.TabIndex = 223;
            this.dgvVistoriadas.Tag = "VISTORIADA";
            this.dgvVistoriadas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistoriadas_CellMouseLeave);
            this.dgvVistoriadas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistoriadas_CellMouseMove);
            this.dgvVistoriadas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistoriadas_CellMouseUp);
            this.dgvVistoriadas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvVistoriadas_DragDrop);
            this.dgvVistoriadas.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvVistoriadas_DragOver);
            this.dgvVistoriadas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvVistoriadas_MouseDown);
            // 
            // referencia_vistoriadas
            // 
            this.referencia_vistoriadas.DataPropertyName = "referencia";
            this.referencia_vistoriadas.HeaderText = "referencia";
            this.referencia_vistoriadas.Name = "referencia_vistoriadas";
            this.referencia_vistoriadas.ReadOnly = true;
            this.referencia_vistoriadas.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "titulo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Título";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel8.Controls.Add(this.dgvConcluidas);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(683, 60);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(8);
            this.panel8.Size = new System.Drawing.Size(201, 439);
            this.panel8.TabIndex = 13;
            // 
            // dgvConcluidas
            // 
            this.dgvConcluidas.AllowDrop = true;
            this.dgvConcluidas.AllowUserToAddRows = false;
            this.dgvConcluidas.AllowUserToDeleteRows = false;
            this.dgvConcluidas.AllowUserToOrderColumns = true;
            this.dgvConcluidas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvConcluidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConcluidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConcluidas.ColumnHeadersHeight = 35;
            this.dgvConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConcluidas.ColumnHeadersVisible = false;
            this.dgvConcluidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia_concluidas,
            this.dataGridViewTextBoxColumn6});
            this.dgvConcluidas.ContextMenuStrip = this.menuContext;
            this.dgvConcluidas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConcluidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConcluidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConcluidas.EnableHeadersVisualStyles = false;
            this.dgvConcluidas.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvConcluidas.Location = new System.Drawing.Point(8, 8);
            this.dgvConcluidas.MultiSelect = false;
            this.dgvConcluidas.Name = "dgvConcluidas";
            this.dgvConcluidas.ReadOnly = true;
            this.dgvConcluidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConcluidas.RowHeadersVisible = false;
            this.dgvConcluidas.RowHeadersWidth = 60;
            this.dgvConcluidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConcluidas.RowTemplate.DividerHeight = 8;
            this.dgvConcluidas.RowTemplate.Height = 50;
            this.dgvConcluidas.RowTemplate.ReadOnly = true;
            this.dgvConcluidas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConcluidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConcluidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConcluidas.ShowEditingIcon = false;
            this.dgvConcluidas.Size = new System.Drawing.Size(185, 423);
            this.dgvConcluidas.TabIndex = 223;
            this.dgvConcluidas.Tag = "CONCLUÍDA";
            this.dgvConcluidas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcluidas_CellMouseLeave);
            this.dgvConcluidas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConcluidas_CellMouseMove);
            this.dgvConcluidas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConcluidas_CellMouseUp);
            this.dgvConcluidas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvConcluidas_DragDrop);
            this.dgvConcluidas.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvConcluidas_DragOver);
            this.dgvConcluidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvConcluidas_MouseDown);
            // 
            // referencia_concluidas
            // 
            this.referencia_concluidas.DataPropertyName = "referencia";
            this.referencia_concluidas.HeaderText = "referencia";
            this.referencia_concluidas.Name = "referencia_concluidas";
            this.referencia_concluidas.ReadOnly = true;
            this.referencia_concluidas.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Título";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel9
            // 
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel9.Controls.Add(this.btnAdicionar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(35, 500);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(8);
            this.panel9.Size = new System.Drawing.Size(201, 40);
            this.panel9.TabIndex = 14;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(8, 8);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(185, 24);
            this.btnAdicionar.TabIndex = 219;
            this.btnAdicionar.Text = "  Adicionar ordem de serviço";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pnlFaturar
            // 
            this.pnlFaturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFaturar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlFaturar.Controls.Add(this.btnFaturar);
            this.pnlFaturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFaturar.Location = new System.Drawing.Point(683, 500);
            this.pnlFaturar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFaturar.Name = "pnlFaturar";
            this.pnlFaturar.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFaturar.Size = new System.Drawing.Size(201, 40);
            this.pnlFaturar.TabIndex = 15;
            this.pnlFaturar.Visible = false;
            // 
            // btnFaturar
            // 
            this.btnFaturar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFaturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFaturar.FlatAppearance.BorderSize = 0;
            this.btnFaturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnFaturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturar.ForeColor = System.Drawing.Color.Black;
            this.btnFaturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturar.Location = new System.Drawing.Point(8, 8);
            this.btnFaturar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(185, 24);
            this.btnFaturar.TabIndex = 219;
            this.btnFaturar.Text = "Faturar";
            this.btnFaturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFaturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturar.UseVisualStyleBackColor = false;
            this.btnFaturar.Click += new System.EventHandler(this.btnFaturar_Click);
            // 
            // pnlLinhaFaturar
            // 
            this.pnlLinhaFaturar.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLinhaFaturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLinhaFaturar.Location = new System.Drawing.Point(683, 499);
            this.pnlLinhaFaturar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLinhaFaturar.Name = "pnlLinhaFaturar";
            this.pnlLinhaFaturar.Size = new System.Drawing.Size(201, 1);
            this.pnlLinhaFaturar.TabIndex = 1;
            this.pnlLinhaFaturar.Visible = false;
            // 
            // cboProfissional
            // 
            this.cboProfissional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProfissional.BackColor = System.Drawing.SystemColors.Window;
            this.cboProfissional.DisplayMember = "nomeid";
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.Enabled = false;
            this.cboProfissional.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboProfissional.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(683, 7);
            this.cboProfissional.Margin = new System.Windows.Forms.Padding(0);
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(201, 21);
            this.cboProfissional.TabIndex = 16;
            this.cboProfissional.ValueMember = "codigo";
            this.cboProfissional.SelectedIndexChanged += new System.EventHandler(this.cboProfissional_SelectedIndexChanged);
            // 
            // lblProfissional
            // 
            this.lblProfissional.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProfissional.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblProfissional, 2);
            this.lblProfissional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissional.Location = new System.Drawing.Point(607, 10);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(73, 15);
            this.lblProfissional.TabIndex = 17;
            this.lblProfissional.Text = "Profissional:";
            // 
            // frmOSFluxo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOSFluxo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmOSFluxo";
            this.Load += new System.EventHandler(this.frmOSFluxo_Load);
            this.Leave += new System.EventHandler(this.frmOSFluxo_Leave);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendentes)).EndInit();
            this.menuContext.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebidas)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistoriadas)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcluidas)).EndInit();
            this.panel9.ResumeLayout(false);
            this.pnlFaturar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTitRecebidas;
        private System.Windows.Forms.Label lblTitPendentes;
        private System.Windows.Forms.Label lblTitConcluidas;
        private System.Windows.Forms.Label lblTitVistoriadas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvRecebidas;
        private System.Windows.Forms.DataGridView dgvPendentes;
        private System.Windows.Forms.DataGridView dgvVistoriadas;
        private System.Windows.Forms.DataGridView dgvConcluidas;
        private System.Windows.Forms.Panel pnlFaturar;
        private System.Windows.Forms.Button btnFaturar;
        private System.Windows.Forms.Panel linhaRecebidas;
        private System.Windows.Forms.Panel linhaPendentes;
        private System.Windows.Forms.Panel linhaConcluidas;
        private System.Windows.Forms.Panel linhaVistoriadas;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnlLinhaFaturar;
        private System.Windows.Forms.ContextMenuStrip menuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuEditar;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluir;
        private System.Windows.Forms.ComboBox cboProfissional;
        private System.Windows.Forms.Label lblProfissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia_recebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia_pendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia_vistoriadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia_concluidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}