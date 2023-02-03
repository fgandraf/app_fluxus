namespace Fluxus.WinUI.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOSFluxo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.menuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRecebidas = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvVistoriadas = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvConcluidas = new System.Windows.Forms.DataGridView();
            this.id_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional_cod_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlFaturar = new System.Windows.Forms.Panel();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.pnlLinhaFaturar = new System.Windows.Forms.Panel();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.lblProfissional = new System.Windows.Forms.Label();
            this.id_recebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia_recebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_recebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_recebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional_cod_recebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia_pendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_pendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_pendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional_cod_pendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vistoriada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia_vistoriada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_vistoriada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_vistoriada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional_cod_vistoriada = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Location = new System.Drawing.Point(43, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 62);
            this.panel1.TabIndex = 6;
            // 
            // linhaRecebidas
            // 
            this.linhaRecebidas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaRecebidas.Location = new System.Drawing.Point(0, 60);
            this.linhaRecebidas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linhaRecebidas.Name = "linhaRecebidas";
            this.linhaRecebidas.Size = new System.Drawing.Size(434, 2);
            this.linhaRecebidas.TabIndex = 1;
            // 
            // lblTitRecebidas
            // 
            this.lblTitRecebidas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitRecebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitRecebidas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitRecebidas.ForeColor = System.Drawing.Color.Black;
            this.lblTitRecebidas.Location = new System.Drawing.Point(0, 0);
            this.lblTitRecebidas.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitRecebidas.Name = "lblTitRecebidas";
            this.lblTitRecebidas.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblTitRecebidas.Size = new System.Drawing.Size(434, 62);
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
            this.panel2.Location = new System.Drawing.Point(510, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 62);
            this.panel2.TabIndex = 7;
            // 
            // linhaPendentes
            // 
            this.linhaPendentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaPendentes.Location = new System.Drawing.Point(0, 60);
            this.linhaPendentes.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linhaPendentes.Name = "linhaPendentes";
            this.linhaPendentes.Size = new System.Drawing.Size(434, 2);
            this.linhaPendentes.TabIndex = 1;
            // 
            // lblTitPendentes
            // 
            this.lblTitPendentes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitPendentes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitPendentes.ForeColor = System.Drawing.Color.Black;
            this.lblTitPendentes.Location = new System.Drawing.Point(0, 0);
            this.lblTitPendentes.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitPendentes.Name = "lblTitPendentes";
            this.lblTitPendentes.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblTitPendentes.Size = new System.Drawing.Size(434, 62);
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
            this.panel3.Location = new System.Drawing.Point(1444, 111);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 62);
            this.panel3.TabIndex = 8;
            // 
            // linhaConcluidas
            // 
            this.linhaConcluidas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaConcluidas.Location = new System.Drawing.Point(0, 60);
            this.linhaConcluidas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linhaConcluidas.Name = "linhaConcluidas";
            this.linhaConcluidas.Size = new System.Drawing.Size(434, 2);
            this.linhaConcluidas.TabIndex = 1;
            // 
            // lblTitConcluidas
            // 
            this.lblTitConcluidas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitConcluidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitConcluidas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitConcluidas.ForeColor = System.Drawing.Color.Black;
            this.lblTitConcluidas.Location = new System.Drawing.Point(0, 0);
            this.lblTitConcluidas.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitConcluidas.Name = "lblTitConcluidas";
            this.lblTitConcluidas.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblTitConcluidas.Size = new System.Drawing.Size(434, 62);
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
            this.panel4.Location = new System.Drawing.Point(977, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 62);
            this.panel4.TabIndex = 9;
            // 
            // linhaVistoriadas
            // 
            this.linhaVistoriadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaVistoriadas.Location = new System.Drawing.Point(0, 60);
            this.linhaVistoriadas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linhaVistoriadas.Name = "linhaVistoriadas";
            this.linhaVistoriadas.Size = new System.Drawing.Size(434, 2);
            this.linhaVistoriadas.TabIndex = 1;
            // 
            // lblTitVistoriadas
            // 
            this.lblTitVistoriadas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitVistoriadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitVistoriadas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitVistoriadas.ForeColor = System.Drawing.Color.Black;
            this.lblTitVistoriadas.Location = new System.Drawing.Point(0, 0);
            this.lblTitVistoriadas.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitVistoriadas.Name = "lblTitVistoriadas";
            this.lblTitVistoriadas.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblTitVistoriadas.Size = new System.Drawing.Size(434, 62);
            this.lblTitVistoriadas.TabIndex = 1;
            this.lblTitVistoriadas.Text = "VISTORIADAS [0]";
            this.lblTitVistoriadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1933, 1261);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SteelBlue;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(43, 1135);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(434, 2);
            this.panel11.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.dgvPendentes);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(510, 173);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.panel6.Size = new System.Drawing.Size(434, 962);
            this.panel6.TabIndex = 11;
            // 
            // dgvPendentes
            // 
            this.dgvPendentes.AllowDrop = true;
            this.dgvPendentes.AllowUserToAddRows = false;
            this.dgvPendentes.AllowUserToDeleteRows = false;
            this.dgvPendentes.AllowUserToResizeColumns = false;
            this.dgvPendentes.AllowUserToResizeRows = false;
            this.dgvPendentes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPendentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPendentes.ColumnHeadersHeight = 35;
            this.dgvPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendentes.ColumnHeadersVisible = false;
            this.dgvPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pendente,
            this.referencia_pendente,
            this.titulo_pendente,
            this.status_pendente,
            this.profissional_cod_pendente});
            this.dgvPendentes.ContextMenuStrip = this.menuContext;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendentes.EnableHeadersVisualStyles = false;
            this.dgvPendentes.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPendentes.Location = new System.Drawing.Point(17, 19);
            this.dgvPendentes.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.dgvPendentes.Size = new System.Drawing.Size(400, 924);
            this.dgvPendentes.TabIndex = 223;
            this.dgvPendentes.Tag = "PENDENTE";
            this.dgvPendentes.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendentes_CellMouseLeave);
            this.dgvPendentes.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPendentes_CellMouseMove);
            this.dgvPendentes.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPendentes_CellMouseUp);
            this.dgvPendentes.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvPendentes_DragDrop);
            this.dgvPendentes.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvPendentes_DragOver);
            this.dgvPendentes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPendentes_MouseDown);
            // 
            // menuContext
            // 
            this.menuContext.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditar,
            this.mnuExcluir});
            this.menuContext.Name = "menuConcluida";
            this.menuContext.Size = new System.Drawing.Size(157, 80);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Size = new System.Drawing.Size(156, 38);
            this.mnuEditar.Text = "Editar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuExcluir
            // 
            this.mnuExcluir.Name = "mnuExcluir";
            this.mnuExcluir.Size = new System.Drawing.Size(156, 38);
            this.mnuExcluir.Text = "Excluir";
            this.mnuExcluir.Click += new System.EventHandler(this.mnuExcluir_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.dgvRecebidas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(43, 173);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.panel5.Size = new System.Drawing.Size(434, 962);
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
            this.dgvRecebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecebidas.ColumnHeadersHeight = 35;
            this.dgvRecebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecebidas.ColumnHeadersVisible = false;
            this.dgvRecebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_recebida,
            this.referencia_recebida,
            this.titulo_recebida,
            this.status_recebida,
            this.profissional_cod_recebida});
            this.dgvRecebidas.ContextMenuStrip = this.menuContext;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecebidas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecebidas.EnableHeadersVisualStyles = false;
            this.dgvRecebidas.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvRecebidas.Location = new System.Drawing.Point(17, 19);
            this.dgvRecebidas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.dgvRecebidas.Size = new System.Drawing.Size(400, 924);
            this.dgvRecebidas.TabIndex = 222;
            this.dgvRecebidas.Tag = "RECEBIDA";
            this.dgvRecebidas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecebidas_CellMouseLeave);
            this.dgvRecebidas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecebidas_CellMouseMove);
            this.dgvRecebidas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecebidas_CellMouseUp);
            this.dgvRecebidas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvRecebidas_DragDrop);
            this.dgvRecebidas.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvRecebidas_DragOver);
            this.dgvRecebidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvRecebidas_MouseDown);
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel7.Controls.Add(this.dgvVistoriadas);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(977, 173);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.panel7.Size = new System.Drawing.Size(434, 962);
            this.panel7.TabIndex = 12;
            // 
            // dgvVistoriadas
            // 
            this.dgvVistoriadas.AllowDrop = true;
            this.dgvVistoriadas.AllowUserToAddRows = false;
            this.dgvVistoriadas.AllowUserToDeleteRows = false;
            this.dgvVistoriadas.AllowUserToResizeColumns = false;
            this.dgvVistoriadas.AllowUserToResizeRows = false;
            this.dgvVistoriadas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVistoriadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVistoriadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVistoriadas.ColumnHeadersHeight = 35;
            this.dgvVistoriadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVistoriadas.ColumnHeadersVisible = false;
            this.dgvVistoriadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vistoriada,
            this.referencia_vistoriada,
            this.titulo_vistoriada,
            this.status_vistoriada,
            this.profissional_cod_vistoriada});
            this.dgvVistoriadas.ContextMenuStrip = this.menuContext;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistoriadas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVistoriadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVistoriadas.EnableHeadersVisualStyles = false;
            this.dgvVistoriadas.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVistoriadas.Location = new System.Drawing.Point(17, 19);
            this.dgvVistoriadas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.dgvVistoriadas.Size = new System.Drawing.Size(400, 924);
            this.dgvVistoriadas.TabIndex = 223;
            this.dgvVistoriadas.Tag = "VISTORIADA";
            this.dgvVistoriadas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistoriadas_CellMouseLeave);
            this.dgvVistoriadas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistoriadas_CellMouseMove);
            this.dgvVistoriadas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistoriadas_CellMouseUp);
            this.dgvVistoriadas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvVistoriadas_DragDrop);
            this.dgvVistoriadas.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvVistoriadas_DragOver);
            this.dgvVistoriadas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvVistoriadas_MouseDown);
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel8.Controls.Add(this.dgvConcluidas);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1444, 173);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.panel8.Size = new System.Drawing.Size(434, 962);
            this.panel8.TabIndex = 13;
            // 
            // dgvConcluidas
            // 
            this.dgvConcluidas.AllowDrop = true;
            this.dgvConcluidas.AllowUserToAddRows = false;
            this.dgvConcluidas.AllowUserToDeleteRows = false;
            this.dgvConcluidas.AllowUserToResizeColumns = false;
            this.dgvConcluidas.AllowUserToResizeRows = false;
            this.dgvConcluidas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvConcluidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConcluidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConcluidas.ColumnHeadersHeight = 35;
            this.dgvConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConcluidas.ColumnHeadersVisible = false;
            this.dgvConcluidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_concluida,
            this.referencia_concluida,
            this.titulo_concluida,
            this.status_concluida,
            this.profissional_cod_concluida});
            this.dgvConcluidas.ContextMenuStrip = this.menuContext;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConcluidas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConcluidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConcluidas.EnableHeadersVisualStyles = false;
            this.dgvConcluidas.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvConcluidas.Location = new System.Drawing.Point(17, 19);
            this.dgvConcluidas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.dgvConcluidas.Size = new System.Drawing.Size(400, 924);
            this.dgvConcluidas.TabIndex = 223;
            this.dgvConcluidas.Tag = "CONCLUÍDA";
            this.dgvConcluidas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcluidas_CellMouseLeave);
            this.dgvConcluidas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConcluidas_CellMouseMove);
            this.dgvConcluidas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConcluidas_CellMouseUp);
            this.dgvConcluidas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvConcluidas_DragDrop);
            this.dgvConcluidas.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvConcluidas_DragOver);
            this.dgvConcluidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvConcluidas_MouseDown);
            // 
            // id_concluida
            // 
            this.id_concluida.DataPropertyName = "id";
            this.id_concluida.HeaderText = "Id";
            this.id_concluida.MinimumWidth = 10;
            this.id_concluida.Name = "id_concluida";
            this.id_concluida.ReadOnly = true;
            this.id_concluida.Visible = false;
            this.id_concluida.Width = 200;
            // 
            // referencia_concluida
            // 
            this.referencia_concluida.DataPropertyName = "referenceCode";
            this.referencia_concluida.HeaderText = "Referencia";
            this.referencia_concluida.MinimumWidth = 10;
            this.referencia_concluida.Name = "referencia_concluida";
            this.referencia_concluida.ReadOnly = true;
            this.referencia_concluida.Visible = false;
            this.referencia_concluida.Width = 200;
            // 
            // titulo_concluida
            // 
            this.titulo_concluida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo_concluida.DataPropertyName = "title";
            this.titulo_concluida.HeaderText = "Título";
            this.titulo_concluida.MinimumWidth = 120;
            this.titulo_concluida.Name = "titulo_concluida";
            this.titulo_concluida.ReadOnly = true;
            // 
            // status_concluida
            // 
            this.status_concluida.DataPropertyName = "status";
            this.status_concluida.HeaderText = "Status";
            this.status_concluida.MinimumWidth = 10;
            this.status_concluida.Name = "status_concluida";
            this.status_concluida.ReadOnly = true;
            this.status_concluida.Visible = false;
            this.status_concluida.Width = 200;
            // 
            // profissional_cod_concluida
            // 
            this.profissional_cod_concluida.DataPropertyName = "professionalId";
            this.profissional_cod_concluida.HeaderText = "Profissional_cod";
            this.profissional_cod_concluida.MinimumWidth = 10;
            this.profissional_cod_concluida.Name = "profissional_cod_concluida";
            this.profissional_cod_concluida.ReadOnly = true;
            this.profissional_cod_concluida.Visible = false;
            this.profissional_cod_concluida.Width = 200;
            // 
            // panel9
            // 
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel9.Controls.Add(this.btnAdicionar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(43, 1137);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.panel9.Size = new System.Drawing.Size(434, 98);
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
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(17, 19);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(400, 60);
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
            this.pnlFaturar.Location = new System.Drawing.Point(1444, 1137);
            this.pnlFaturar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFaturar.Name = "pnlFaturar";
            this.pnlFaturar.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.pnlFaturar.Size = new System.Drawing.Size(434, 98);
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
            this.btnFaturar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFaturar.ForeColor = System.Drawing.Color.Black;
            this.btnFaturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturar.Location = new System.Drawing.Point(17, 19);
            this.btnFaturar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(400, 60);
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
            this.pnlLinhaFaturar.Location = new System.Drawing.Point(1444, 1135);
            this.pnlLinhaFaturar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLinhaFaturar.Name = "pnlLinhaFaturar";
            this.pnlLinhaFaturar.Size = new System.Drawing.Size(434, 2);
            this.pnlLinhaFaturar.TabIndex = 1;
            this.pnlLinhaFaturar.Visible = false;
            // 
            // cboProfissional
            // 
            this.cboProfissional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProfissional.BackColor = System.Drawing.Color.White;
            this.cboProfissional.DisplayMember = "nameid";
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.Enabled = false;
            this.cboProfissional.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboProfissional.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(1444, 36);
            this.cboProfissional.Margin = new System.Windows.Forms.Padding(0);
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(434, 38);
            this.cboProfissional.TabIndex = 16;
            this.cboProfissional.ValueMember = "id";
            this.cboProfissional.SelectedIndexChanged += new System.EventHandler(this.cboProfissional_SelectedIndexChanged);
            // 
            // lblProfissional
            // 
            this.lblProfissional.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProfissional.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblProfissional, 2);
            this.lblProfissional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfissional.Location = new System.Drawing.Point(1281, 39);
            this.lblProfissional.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(156, 32);
            this.lblProfissional.TabIndex = 17;
            this.lblProfissional.Text = "Profissional:";
            // 
            // id_recebida
            // 
            this.id_recebida.DataPropertyName = "Id";
            this.id_recebida.HeaderText = "Id";
            this.id_recebida.MinimumWidth = 10;
            this.id_recebida.Name = "id_recebida";
            this.id_recebida.ReadOnly = true;
            this.id_recebida.Visible = false;
            this.id_recebida.Width = 200;
            // 
            // referencia_recebida
            // 
            this.referencia_recebida.DataPropertyName = "ReferenceCode";
            this.referencia_recebida.HeaderText = "Referência";
            this.referencia_recebida.MinimumWidth = 10;
            this.referencia_recebida.Name = "referencia_recebida";
            this.referencia_recebida.ReadOnly = true;
            this.referencia_recebida.Visible = false;
            this.referencia_recebida.Width = 200;
            // 
            // titulo_recebida
            // 
            this.titulo_recebida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo_recebida.DataPropertyName = "Title";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.titulo_recebida.DefaultCellStyle = dataGridViewCellStyle3;
            this.titulo_recebida.HeaderText = "Título";
            this.titulo_recebida.MinimumWidth = 120;
            this.titulo_recebida.Name = "titulo_recebida";
            this.titulo_recebida.ReadOnly = true;
            // 
            // status_recebida
            // 
            this.status_recebida.DataPropertyName = "Status";
            this.status_recebida.HeaderText = "Status";
            this.status_recebida.MinimumWidth = 10;
            this.status_recebida.Name = "status_recebida";
            this.status_recebida.ReadOnly = true;
            this.status_recebida.Visible = false;
            this.status_recebida.Width = 200;
            // 
            // profissional_cod_recebida
            // 
            this.profissional_cod_recebida.DataPropertyName = "ProfessionalId";
            this.profissional_cod_recebida.HeaderText = "Profissional_cod";
            this.profissional_cod_recebida.MinimumWidth = 10;
            this.profissional_cod_recebida.Name = "profissional_cod_recebida";
            this.profissional_cod_recebida.ReadOnly = true;
            this.profissional_cod_recebida.Visible = false;
            this.profissional_cod_recebida.Width = 200;
            // 
            // id_pendente
            // 
            this.id_pendente.DataPropertyName = "Id";
            this.id_pendente.HeaderText = "Id";
            this.id_pendente.MinimumWidth = 10;
            this.id_pendente.Name = "id_pendente";
            this.id_pendente.ReadOnly = true;
            this.id_pendente.Visible = false;
            this.id_pendente.Width = 200;
            // 
            // referencia_pendente
            // 
            this.referencia_pendente.DataPropertyName = "ReferenceCode";
            this.referencia_pendente.HeaderText = "Referência";
            this.referencia_pendente.MinimumWidth = 10;
            this.referencia_pendente.Name = "referencia_pendente";
            this.referencia_pendente.ReadOnly = true;
            this.referencia_pendente.Visible = false;
            this.referencia_pendente.Width = 200;
            // 
            // titulo_pendente
            // 
            this.titulo_pendente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo_pendente.DataPropertyName = "Title";
            this.titulo_pendente.HeaderText = "Título";
            this.titulo_pendente.MinimumWidth = 120;
            this.titulo_pendente.Name = "titulo_pendente";
            this.titulo_pendente.ReadOnly = true;
            // 
            // status_pendente
            // 
            this.status_pendente.DataPropertyName = "Status";
            this.status_pendente.HeaderText = "Status";
            this.status_pendente.MinimumWidth = 10;
            this.status_pendente.Name = "status_pendente";
            this.status_pendente.ReadOnly = true;
            this.status_pendente.Visible = false;
            this.status_pendente.Width = 200;
            // 
            // profissional_cod_pendente
            // 
            this.profissional_cod_pendente.DataPropertyName = "ProfessionalId";
            this.profissional_cod_pendente.HeaderText = "Profissional_cod";
            this.profissional_cod_pendente.MinimumWidth = 10;
            this.profissional_cod_pendente.Name = "profissional_cod_pendente";
            this.profissional_cod_pendente.ReadOnly = true;
            this.profissional_cod_pendente.Visible = false;
            this.profissional_cod_pendente.Width = 200;
            // 
            // id_vistoriada
            // 
            this.id_vistoriada.DataPropertyName = "Id";
            this.id_vistoriada.HeaderText = "Id";
            this.id_vistoriada.MinimumWidth = 10;
            this.id_vistoriada.Name = "id_vistoriada";
            this.id_vistoriada.ReadOnly = true;
            this.id_vistoriada.Visible = false;
            this.id_vistoriada.Width = 200;
            // 
            // referencia_vistoriada
            // 
            this.referencia_vistoriada.DataPropertyName = "ReferenceCode";
            this.referencia_vistoriada.HeaderText = "Referencia";
            this.referencia_vistoriada.MinimumWidth = 10;
            this.referencia_vistoriada.Name = "referencia_vistoriada";
            this.referencia_vistoriada.ReadOnly = true;
            this.referencia_vistoriada.Visible = false;
            this.referencia_vistoriada.Width = 200;
            // 
            // titulo_vistoriada
            // 
            this.titulo_vistoriada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo_vistoriada.DataPropertyName = "Title";
            this.titulo_vistoriada.HeaderText = "Título";
            this.titulo_vistoriada.MinimumWidth = 120;
            this.titulo_vistoriada.Name = "titulo_vistoriada";
            this.titulo_vistoriada.ReadOnly = true;
            // 
            // status_vistoriada
            // 
            this.status_vistoriada.DataPropertyName = "Status";
            this.status_vistoriada.HeaderText = "Status";
            this.status_vistoriada.MinimumWidth = 10;
            this.status_vistoriada.Name = "status_vistoriada";
            this.status_vistoriada.ReadOnly = true;
            this.status_vistoriada.Visible = false;
            this.status_vistoriada.Width = 200;
            // 
            // profissional_cod_vistoriada
            // 
            this.profissional_cod_vistoriada.DataPropertyName = "ProfessionalId";
            this.profissional_cod_vistoriada.HeaderText = "Profissional_cod";
            this.profissional_cod_vistoriada.MinimumWidth = 10;
            this.profissional_cod_vistoriada.Name = "profissional_cod_vistoriada";
            this.profissional_cod_vistoriada.ReadOnly = true;
            this.profissional_cod_vistoriada.Visible = false;
            this.profissional_cod_vistoriada.Width = 200;
            // 
            // frmOSFluxo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1933, 1261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmOSFluxo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmOSFluxo";
            this.Load += new System.EventHandler(this.frmOSFluxo_Load);
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
        private System.Windows.Forms.DataGridView dgvVistoriadas;
        private DataGridViewTextBoxColumn id_concluida;
        private DataGridViewTextBoxColumn referencia_concluida;
        private DataGridViewTextBoxColumn titulo_concluida;
        private DataGridViewTextBoxColumn status_concluida;
        private DataGridViewTextBoxColumn profissional_cod_concluida;
        private DataGridViewTextBoxColumn id_pendente;
        private DataGridViewTextBoxColumn referencia_pendente;
        private DataGridViewTextBoxColumn titulo_pendente;
        private DataGridViewTextBoxColumn status_pendente;
        private DataGridViewTextBoxColumn profissional_cod_pendente;
        private DataGridViewTextBoxColumn id_recebida;
        private DataGridViewTextBoxColumn referencia_recebida;
        private DataGridViewTextBoxColumn titulo_recebida;
        private DataGridViewTextBoxColumn status_recebida;
        private DataGridViewTextBoxColumn profissional_cod_recebida;
        private DataGridViewTextBoxColumn id_vistoriada;
        private DataGridViewTextBoxColumn referencia_vistoriada;
        private DataGridViewTextBoxColumn titulo_vistoriada;
        private DataGridViewTextBoxColumn status_vistoriada;
        private DataGridViewTextBoxColumn profissional_cod_vistoriada;
    }
}