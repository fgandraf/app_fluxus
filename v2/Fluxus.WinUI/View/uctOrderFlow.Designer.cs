namespace Fluxus.WinUI.View
{
    partial class uctOrderFlow
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            linhaRecebidas = new Panel();
            lblTitRecebidas = new Label();
            panel2 = new Panel();
            linhaPendentes = new Panel();
            lblTitPendentes = new Label();
            panel3 = new Panel();
            linhaConcluidas = new Panel();
            lblTitConcluidas = new Label();
            panel4 = new Panel();
            linhaVistoriadas = new Panel();
            lblTitVistoriadas = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel11 = new Panel();
            panel6 = new Panel();
            dgvPendentes = new DataGridView();
            panel5 = new Panel();
            dgvRecebidas = new DataGridView();
            panel7 = new Panel();
            dgvVistoriadas = new DataGridView();
            panel8 = new Panel();
            dgvConcluidas = new DataGridView();
            panel9 = new Panel();
            btnAdicionar = new Button();
            pnlFaturar = new Panel();
            btnFaturar = new Button();
            pnlLinhaFaturar = new Panel();
            cboProfissional = new ComboBox();
            lblProfissional = new Label();
            menuContext = new ContextMenuStrip(components);
            mnuEditar = new ToolStripMenuItem();
            mnuExcluir = new ToolStripMenuItem();
            id_recebidas = new DataGridViewTextBoxColumn();
            titulo_recebida = new DataGridViewTextBoxColumn();
            status_recebida = new DataGridViewTextBoxColumn();
            profissional_cod_recebida = new DataGridViewTextBoxColumn();
            id_pendente = new DataGridViewTextBoxColumn();
            titulo_pendente = new DataGridViewTextBoxColumn();
            status_pendente = new DataGridViewTextBoxColumn();
            profissional_cod_pendente = new DataGridViewTextBoxColumn();
            id_vistoriada = new DataGridViewTextBoxColumn();
            titulo_vistoriada = new DataGridViewTextBoxColumn();
            status_vistoriada = new DataGridViewTextBoxColumn();
            profissional_cod_vistoriada = new DataGridViewTextBoxColumn();
            id_concluida = new DataGridViewTextBoxColumn();
            titulo_concluida = new DataGridViewTextBoxColumn();
            status_concluida = new DataGridViewTextBoxColumn();
            profissional_cod_concluida = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendentes).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecebidas).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVistoriadas).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConcluidas).BeginInit();
            panel9.SuspendLayout();
            pnlFaturar.SuspendLayout();
            menuContext.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(linhaRecebidas);
            panel1.Controls.Add(lblTitRecebidas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(43, 111);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 62);
            panel1.TabIndex = 6;
            // 
            // linhaRecebidas
            // 
            linhaRecebidas.BackColor = Color.DimGray;
            linhaRecebidas.Dock = DockStyle.Bottom;
            linhaRecebidas.Location = new Point(0, 60);
            linhaRecebidas.Margin = new Padding(7, 6, 7, 6);
            linhaRecebidas.Name = "linhaRecebidas";
            linhaRecebidas.Size = new Size(449, 2);
            linhaRecebidas.TabIndex = 1;
            // 
            // lblTitRecebidas
            // 
            lblTitRecebidas.BackColor = Color.LightSteelBlue;
            lblTitRecebidas.Dock = DockStyle.Fill;
            lblTitRecebidas.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitRecebidas.ForeColor = Color.Black;
            lblTitRecebidas.Location = new Point(0, 0);
            lblTitRecebidas.Margin = new Padding(7, 0, 7, 0);
            lblTitRecebidas.Name = "lblTitRecebidas";
            lblTitRecebidas.Padding = new Padding(22, 0, 0, 0);
            lblTitRecebidas.Size = new Size(449, 62);
            lblTitRecebidas.TabIndex = 0;
            lblTitRecebidas.Text = "RECEBIDAS [0]";
            lblTitRecebidas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(linhaPendentes);
            panel2.Controls.Add(lblTitPendentes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(525, 111);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 62);
            panel2.TabIndex = 7;
            // 
            // linhaPendentes
            // 
            linhaPendentes.BackColor = Color.DimGray;
            linhaPendentes.Dock = DockStyle.Bottom;
            linhaPendentes.Location = new Point(0, 60);
            linhaPendentes.Margin = new Padding(7, 6, 7, 6);
            linhaPendentes.Name = "linhaPendentes";
            linhaPendentes.Size = new Size(449, 2);
            linhaPendentes.TabIndex = 1;
            // 
            // lblTitPendentes
            // 
            lblTitPendentes.BackColor = Color.LightSteelBlue;
            lblTitPendentes.Dock = DockStyle.Fill;
            lblTitPendentes.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitPendentes.ForeColor = Color.Black;
            lblTitPendentes.Location = new Point(0, 0);
            lblTitPendentes.Margin = new Padding(7, 0, 7, 0);
            lblTitPendentes.Name = "lblTitPendentes";
            lblTitPendentes.Padding = new Padding(22, 0, 0, 0);
            lblTitPendentes.Size = new Size(449, 62);
            lblTitPendentes.TabIndex = 1;
            lblTitPendentes.Text = "PENDENTES [0]";
            lblTitPendentes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(linhaConcluidas);
            panel3.Controls.Add(lblTitConcluidas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1489, 111);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 62);
            panel3.TabIndex = 8;
            // 
            // linhaConcluidas
            // 
            linhaConcluidas.BackColor = Color.DimGray;
            linhaConcluidas.Dock = DockStyle.Bottom;
            linhaConcluidas.Location = new Point(0, 60);
            linhaConcluidas.Margin = new Padding(7, 6, 7, 6);
            linhaConcluidas.Name = "linhaConcluidas";
            linhaConcluidas.Size = new Size(449, 2);
            linhaConcluidas.TabIndex = 1;
            // 
            // lblTitConcluidas
            // 
            lblTitConcluidas.BackColor = Color.LightSteelBlue;
            lblTitConcluidas.Dock = DockStyle.Fill;
            lblTitConcluidas.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitConcluidas.ForeColor = Color.Black;
            lblTitConcluidas.Location = new Point(0, 0);
            lblTitConcluidas.Margin = new Padding(7, 0, 7, 0);
            lblTitConcluidas.Name = "lblTitConcluidas";
            lblTitConcluidas.Padding = new Padding(22, 0, 0, 0);
            lblTitConcluidas.Size = new Size(449, 62);
            lblTitConcluidas.TabIndex = 1;
            lblTitConcluidas.Text = "CONCLUÍDAS [0]";
            lblTitConcluidas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(linhaVistoriadas);
            panel4.Controls.Add(lblTitVistoriadas);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1007, 111);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 62);
            panel4.TabIndex = 9;
            // 
            // linhaVistoriadas
            // 
            linhaVistoriadas.BackColor = Color.DimGray;
            linhaVistoriadas.Dock = DockStyle.Bottom;
            linhaVistoriadas.Location = new Point(0, 60);
            linhaVistoriadas.Margin = new Padding(7, 6, 7, 6);
            linhaVistoriadas.Name = "linhaVistoriadas";
            linhaVistoriadas.Size = new Size(449, 2);
            linhaVistoriadas.TabIndex = 1;
            // 
            // lblTitVistoriadas
            // 
            lblTitVistoriadas.BackColor = Color.LightSteelBlue;
            lblTitVistoriadas.Dock = DockStyle.Fill;
            lblTitVistoriadas.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitVistoriadas.ForeColor = Color.Black;
            lblTitVistoriadas.Location = new Point(0, 0);
            lblTitVistoriadas.Margin = new Padding(7, 0, 7, 0);
            lblTitVistoriadas.Name = "lblTitVistoriadas";
            lblTitVistoriadas.Padding = new Padding(22, 0, 0, 0);
            lblTitVistoriadas.Size = new Size(449, 62);
            lblTitVistoriadas.TabIndex = 1;
            lblTitVistoriadas.Text = "VISTORIADAS [0]";
            lblTitVistoriadas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.Controls.Add(panel11, 1, 3);
            tableLayoutPanel1.Controls.Add(panel6, 3, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 7, 1);
            tableLayoutPanel1.Controls.Add(panel4, 5, 1);
            tableLayoutPanel1.Controls.Add(panel2, 3, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 2);
            tableLayoutPanel1.Controls.Add(panel7, 5, 2);
            tableLayoutPanel1.Controls.Add(panel8, 7, 2);
            tableLayoutPanel1.Controls.Add(panel9, 1, 4);
            tableLayoutPanel1.Controls.Add(pnlFaturar, 7, 4);
            tableLayoutPanel1.Controls.Add(pnlLinhaFaturar, 7, 3);
            tableLayoutPanel1.Controls.Add(cboProfissional, 7, 0);
            tableLayoutPanel1.Controls.Add(lblProfissional, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(7, 6, 7, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(2000, 1400);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DimGray;
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(43, 1274);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(449, 2);
            panel11.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.LightSteelBlue;
            panel6.Controls.Add(dgvPendentes);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(525, 173);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(17, 19, 17, 19);
            panel6.Size = new Size(449, 1101);
            panel6.TabIndex = 11;
            // 
            // dgvPendentes
            // 
            dgvPendentes.AllowDrop = true;
            dgvPendentes.AllowUserToAddRows = false;
            dgvPendentes.AllowUserToDeleteRows = false;
            dgvPendentes.AllowUserToResizeColumns = false;
            dgvPendentes.AllowUserToResizeRows = false;
            dgvPendentes.BackgroundColor = Color.LightSteelBlue;
            dgvPendentes.BorderStyle = BorderStyle.None;
            dgvPendentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendentes.ColumnHeadersHeight = 35;
            dgvPendentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendentes.ColumnHeadersVisible = false;
            dgvPendentes.Columns.AddRange(new DataGridViewColumn[] { id_pendente, titulo_pendente, status_pendente, profissional_cod_pendente });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPendentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPendentes.Dock = DockStyle.Fill;
            dgvPendentes.EnableHeadersVisualStyles = false;
            dgvPendentes.GridColor = Color.LightSteelBlue;
            dgvPendentes.Location = new Point(17, 19);
            dgvPendentes.Margin = new Padding(7, 6, 7, 6);
            dgvPendentes.MultiSelect = false;
            dgvPendentes.Name = "dgvPendentes";
            dgvPendentes.ReadOnly = true;
            dgvPendentes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPendentes.RowHeadersVisible = false;
            dgvPendentes.RowHeadersWidth = 60;
            dgvPendentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPendentes.RowTemplate.DividerHeight = 10;
            dgvPendentes.RowTemplate.Height = 50;
            dgvPendentes.RowTemplate.ReadOnly = true;
            dgvPendentes.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvPendentes.ScrollBars = ScrollBars.Vertical;
            dgvPendentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendentes.ShowEditingIcon = false;
            dgvPendentes.Size = new Size(415, 1063);
            dgvPendentes.TabIndex = 223;
            dgvPendentes.Tag = "2";
            dgvPendentes.CellMouseLeave += DataGridView_CellMouseLeave;
            dgvPendentes.CellMouseMove += DataGridView_CellMouseMove;
            dgvPendentes.CellMouseUp += DataGridView_CellMouseUp;
            dgvPendentes.DragDrop += DataGridView_DragDrop;
            dgvPendentes.DragOver += DataGridView_DragOver;
            dgvPendentes.MouseDown += DataGridView_MouseDown;
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.BackColor = Color.LightSteelBlue;
            panel5.Controls.Add(dgvRecebidas);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(43, 173);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(17, 19, 17, 19);
            panel5.Size = new Size(449, 1101);
            panel5.TabIndex = 10;
            // 
            // dgvRecebidas
            // 
            dgvRecebidas.AllowDrop = true;
            dgvRecebidas.AllowUserToAddRows = false;
            dgvRecebidas.AllowUserToDeleteRows = false;
            dgvRecebidas.AllowUserToResizeColumns = false;
            dgvRecebidas.AllowUserToResizeRows = false;
            dgvRecebidas.BackgroundColor = Color.LightSteelBlue;
            dgvRecebidas.BorderStyle = BorderStyle.None;
            dgvRecebidas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRecebidas.ColumnHeadersHeight = 35;
            dgvRecebidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecebidas.ColumnHeadersVisible = false;
            dgvRecebidas.Columns.AddRange(new DataGridViewColumn[] { id_recebidas, titulo_recebida, status_recebida, profissional_cod_recebida });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRecebidas.DefaultCellStyle = dataGridViewCellStyle5;
            dgvRecebidas.Dock = DockStyle.Fill;
            dgvRecebidas.EnableHeadersVisualStyles = false;
            dgvRecebidas.GridColor = Color.LightSteelBlue;
            dgvRecebidas.Location = new Point(17, 19);
            dgvRecebidas.Margin = new Padding(7, 6, 7, 6);
            dgvRecebidas.MultiSelect = false;
            dgvRecebidas.Name = "dgvRecebidas";
            dgvRecebidas.ReadOnly = true;
            dgvRecebidas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecebidas.RowHeadersVisible = false;
            dgvRecebidas.RowHeadersWidth = 60;
            dgvRecebidas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRecebidas.RowTemplate.DividerHeight = 10;
            dgvRecebidas.RowTemplate.Height = 50;
            dgvRecebidas.RowTemplate.ReadOnly = true;
            dgvRecebidas.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvRecebidas.ScrollBars = ScrollBars.Vertical;
            dgvRecebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecebidas.ShowEditingIcon = false;
            dgvRecebidas.Size = new Size(415, 1063);
            dgvRecebidas.TabIndex = 222;
            dgvRecebidas.Tag = "1";
            dgvRecebidas.CellMouseLeave += DataGridView_CellMouseLeave;
            dgvRecebidas.CellMouseMove += DataGridView_CellMouseMove;
            dgvRecebidas.CellMouseUp += DataGridView_CellMouseUp;
            dgvRecebidas.DragDrop += DataGridView_DragDrop;
            dgvRecebidas.DragOver += DataGridView_DragOver;
            dgvRecebidas.MouseDown += DataGridView_MouseDown;
            // 
            // panel7
            // 
            panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel7.BackColor = Color.LightSteelBlue;
            panel7.Controls.Add(dgvVistoriadas);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1007, 173);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(17, 19, 17, 19);
            panel7.Size = new Size(449, 1101);
            panel7.TabIndex = 12;
            // 
            // dgvVistoriadas
            // 
            dgvVistoriadas.AllowDrop = true;
            dgvVistoriadas.AllowUserToAddRows = false;
            dgvVistoriadas.AllowUserToDeleteRows = false;
            dgvVistoriadas.AllowUserToResizeColumns = false;
            dgvVistoriadas.AllowUserToResizeRows = false;
            dgvVistoriadas.BackgroundColor = Color.LightSteelBlue;
            dgvVistoriadas.BorderStyle = BorderStyle.None;
            dgvVistoriadas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVistoriadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvVistoriadas.ColumnHeadersHeight = 35;
            dgvVistoriadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVistoriadas.ColumnHeadersVisible = false;
            dgvVistoriadas.Columns.AddRange(new DataGridViewColumn[] { id_vistoriada, titulo_vistoriada, status_vistoriada, profissional_cod_vistoriada });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.Padding = new Padding(10);
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvVistoriadas.DefaultCellStyle = dataGridViewCellStyle7;
            dgvVistoriadas.Dock = DockStyle.Fill;
            dgvVistoriadas.EnableHeadersVisualStyles = false;
            dgvVistoriadas.GridColor = Color.LightSteelBlue;
            dgvVistoriadas.Location = new Point(17, 19);
            dgvVistoriadas.Margin = new Padding(7, 6, 7, 6);
            dgvVistoriadas.MultiSelect = false;
            dgvVistoriadas.Name = "dgvVistoriadas";
            dgvVistoriadas.ReadOnly = true;
            dgvVistoriadas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVistoriadas.RowHeadersVisible = false;
            dgvVistoriadas.RowHeadersWidth = 60;
            dgvVistoriadas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvVistoriadas.RowTemplate.DividerHeight = 10;
            dgvVistoriadas.RowTemplate.Height = 50;
            dgvVistoriadas.RowTemplate.ReadOnly = true;
            dgvVistoriadas.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvVistoriadas.ScrollBars = ScrollBars.Vertical;
            dgvVistoriadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVistoriadas.ShowEditingIcon = false;
            dgvVistoriadas.Size = new Size(415, 1063);
            dgvVistoriadas.TabIndex = 223;
            dgvVistoriadas.Tag = "3";
            dgvVistoriadas.CellMouseLeave += DataGridView_CellMouseLeave;
            dgvVistoriadas.CellMouseMove += DataGridView_CellMouseMove;
            dgvVistoriadas.CellMouseUp += DataGridView_CellMouseUp;
            dgvVistoriadas.DragDrop += DataGridView_DragDrop;
            dgvVistoriadas.DragOver += DataGridView_DragOver;
            dgvVistoriadas.MouseDown += DataGridView_MouseDown;
            // 
            // panel8
            // 
            panel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel8.BackColor = Color.LightSteelBlue;
            panel8.Controls.Add(dgvConcluidas);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1489, 173);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(17, 19, 17, 19);
            panel8.Size = new Size(449, 1101);
            panel8.TabIndex = 13;
            // 
            // dgvConcluidas
            // 
            dgvConcluidas.AllowDrop = true;
            dgvConcluidas.AllowUserToAddRows = false;
            dgvConcluidas.AllowUserToDeleteRows = false;
            dgvConcluidas.AllowUserToResizeColumns = false;
            dgvConcluidas.AllowUserToResizeRows = false;
            dgvConcluidas.BackgroundColor = Color.LightSteelBlue;
            dgvConcluidas.BorderStyle = BorderStyle.None;
            dgvConcluidas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvConcluidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvConcluidas.ColumnHeadersHeight = 35;
            dgvConcluidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConcluidas.ColumnHeadersVisible = false;
            dgvConcluidas.Columns.AddRange(new DataGridViewColumn[] { id_concluida, titulo_concluida, status_concluida, profissional_cod_concluida });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.Padding = new Padding(10);
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvConcluidas.DefaultCellStyle = dataGridViewCellStyle9;
            dgvConcluidas.Dock = DockStyle.Fill;
            dgvConcluidas.EnableHeadersVisualStyles = false;
            dgvConcluidas.GridColor = Color.LightSteelBlue;
            dgvConcluidas.Location = new Point(17, 19);
            dgvConcluidas.Margin = new Padding(7, 6, 7, 6);
            dgvConcluidas.MultiSelect = false;
            dgvConcluidas.Name = "dgvConcluidas";
            dgvConcluidas.ReadOnly = true;
            dgvConcluidas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvConcluidas.RowHeadersVisible = false;
            dgvConcluidas.RowHeadersWidth = 60;
            dgvConcluidas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvConcluidas.RowTemplate.DividerHeight = 10;
            dgvConcluidas.RowTemplate.Height = 50;
            dgvConcluidas.RowTemplate.ReadOnly = true;
            dgvConcluidas.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvConcluidas.ScrollBars = ScrollBars.Vertical;
            dgvConcluidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConcluidas.ShowEditingIcon = false;
            dgvConcluidas.Size = new Size(415, 1063);
            dgvConcluidas.TabIndex = 223;
            dgvConcluidas.Tag = "4";
            dgvConcluidas.CellMouseLeave += DataGridView_CellMouseLeave;
            dgvConcluidas.CellMouseMove += DataGridView_CellMouseMove;
            dgvConcluidas.CellMouseUp += DataGridView_CellMouseUp;
            dgvConcluidas.DragDrop += DataGridView_DragDrop;
            dgvConcluidas.DragOver += DataGridView_DragOver;
            dgvConcluidas.MouseDown += DataGridView_MouseDown;
            // 
            // panel9
            // 
            panel9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel9.BackColor = Color.LightSteelBlue;
            panel9.Controls.Add(btnAdicionar);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(43, 1276);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(17, 19, 17, 19);
            panel9.Size = new Size(449, 98);
            panel9.TabIndex = 14;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.LightSteelBlue;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Dock = DockStyle.Fill;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Image = Properties.Resources.addIcon;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(17, 19);
            btnAdicionar.Margin = new Padding(0);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(415, 60);
            btnAdicionar.TabIndex = 219;
            btnAdicionar.Text = "  Adicionar";
            btnAdicionar.TextAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // pnlFaturar
            // 
            pnlFaturar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFaturar.BackColor = Color.LightSteelBlue;
            pnlFaturar.Controls.Add(btnFaturar);
            pnlFaturar.Dock = DockStyle.Fill;
            pnlFaturar.Location = new Point(1489, 1276);
            pnlFaturar.Margin = new Padding(0);
            pnlFaturar.Name = "pnlFaturar";
            pnlFaturar.Padding = new Padding(17, 19, 17, 19);
            pnlFaturar.Size = new Size(449, 98);
            pnlFaturar.TabIndex = 15;
            pnlFaturar.Visible = false;
            // 
            // btnFaturar
            // 
            btnFaturar.BackColor = Color.LightSteelBlue;
            btnFaturar.Cursor = Cursors.Hand;
            btnFaturar.Dock = DockStyle.Fill;
            btnFaturar.FlatAppearance.BorderSize = 0;
            btnFaturar.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            btnFaturar.FlatStyle = FlatStyle.Flat;
            btnFaturar.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFaturar.ForeColor = Color.Black;
            btnFaturar.Image = Properties.Resources.doneIcon;
            btnFaturar.ImageAlign = ContentAlignment.MiddleRight;
            btnFaturar.Location = new Point(17, 19);
            btnFaturar.Margin = new Padding(0);
            btnFaturar.Name = "btnFaturar";
            btnFaturar.Size = new Size(415, 60);
            btnFaturar.TabIndex = 219;
            btnFaturar.Text = "Faturar";
            btnFaturar.TextAlign = ContentAlignment.MiddleRight;
            btnFaturar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFaturar.UseVisualStyleBackColor = false;
            btnFaturar.Click += btnFaturar_Click;
            // 
            // pnlLinhaFaturar
            // 
            pnlLinhaFaturar.BackColor = Color.DimGray;
            pnlLinhaFaturar.Dock = DockStyle.Fill;
            pnlLinhaFaturar.Location = new Point(1489, 1274);
            pnlLinhaFaturar.Margin = new Padding(0);
            pnlLinhaFaturar.Name = "pnlLinhaFaturar";
            pnlLinhaFaturar.Size = new Size(449, 2);
            pnlLinhaFaturar.TabIndex = 1;
            pnlLinhaFaturar.Visible = false;
            // 
            // cboProfissional
            // 
            cboProfissional.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboProfissional.BackColor = Color.White;
            cboProfissional.DisplayMember = "nameid";
            cboProfissional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfissional.Enabled = false;
            cboProfissional.FlatStyle = FlatStyle.System;
            cboProfissional.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cboProfissional.FormattingEnabled = true;
            cboProfissional.Location = new Point(1489, 36);
            cboProfissional.Margin = new Padding(0);
            cboProfissional.Name = "cboProfissional";
            cboProfissional.Size = new Size(449, 38);
            cboProfissional.TabIndex = 16;
            cboProfissional.ValueMember = "id";
            cboProfissional.SelectedIndexChanged += cboProfissional_SelectedIndexChanged;
            // 
            // lblProfissional
            // 
            lblProfissional.Anchor = AnchorStyles.Right;
            lblProfissional.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblProfissional, 2);
            lblProfissional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfissional.Location = new Point(1326, 39);
            lblProfissional.Margin = new Padding(7, 0, 7, 0);
            lblProfissional.Name = "lblProfissional";
            lblProfissional.Size = new Size(156, 32);
            lblProfissional.TabIndex = 17;
            lblProfissional.Text = "Profissional:";
            // 
            // menuContext
            // 
            menuContext.ImageScalingSize = new Size(32, 32);
            menuContext.Items.AddRange(new ToolStripItem[] { mnuEditar, mnuExcluir });
            menuContext.Name = "menuConcluida";
            menuContext.Size = new Size(157, 80);
            // 
            // mnuEditar
            // 
            mnuEditar.Name = "mnuEditar";
            mnuEditar.Size = new Size(156, 38);
            mnuEditar.Text = "Editar";
            mnuEditar.Click += mnuEditar_Click;
            // 
            // mnuExcluir
            // 
            mnuExcluir.Name = "mnuExcluir";
            mnuExcluir.Size = new Size(156, 38);
            mnuExcluir.Text = "Excluir";
            mnuExcluir.Click += mnuExcluir_Click;
            // 
            // id_recebidas
            // 
            id_recebidas.DataPropertyName = "Id";
            id_recebidas.HeaderText = "Id";
            id_recebidas.MinimumWidth = 10;
            id_recebidas.Name = "id_recebidas";
            id_recebidas.ReadOnly = true;
            id_recebidas.Visible = false;
            id_recebidas.Width = 200;
            // 
            // titulo_recebida
            // 
            titulo_recebida.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titulo_recebida.DataPropertyName = "Title";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            titulo_recebida.DefaultCellStyle = dataGridViewCellStyle4;
            titulo_recebida.HeaderText = "Title";
            titulo_recebida.MinimumWidth = 120;
            titulo_recebida.Name = "titulo_recebida";
            titulo_recebida.ReadOnly = true;
            // 
            // status_recebida
            // 
            status_recebida.DataPropertyName = "Status";
            status_recebida.HeaderText = "Status";
            status_recebida.MinimumWidth = 10;
            status_recebida.Name = "status_recebida";
            status_recebida.ReadOnly = true;
            status_recebida.Visible = false;
            status_recebida.Width = 200;
            // 
            // profissional_cod_recebida
            // 
            profissional_cod_recebida.DataPropertyName = "ProfessionalId";
            profissional_cod_recebida.HeaderText = "ProfessionalId";
            profissional_cod_recebida.MinimumWidth = 10;
            profissional_cod_recebida.Name = "profissional_cod_recebida";
            profissional_cod_recebida.ReadOnly = true;
            profissional_cod_recebida.Visible = false;
            profissional_cod_recebida.Width = 200;
            // 
            // id_pendente
            // 
            id_pendente.DataPropertyName = "Id";
            id_pendente.HeaderText = "Id";
            id_pendente.MinimumWidth = 10;
            id_pendente.Name = "id_pendente";
            id_pendente.ReadOnly = true;
            id_pendente.Visible = false;
            id_pendente.Width = 200;
            // 
            // titulo_pendente
            // 
            titulo_pendente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titulo_pendente.DataPropertyName = "Title";
            titulo_pendente.HeaderText = "Título";
            titulo_pendente.MinimumWidth = 120;
            titulo_pendente.Name = "titulo_pendente";
            titulo_pendente.ReadOnly = true;
            // 
            // status_pendente
            // 
            status_pendente.DataPropertyName = "Status";
            status_pendente.HeaderText = "Status";
            status_pendente.MinimumWidth = 10;
            status_pendente.Name = "status_pendente";
            status_pendente.ReadOnly = true;
            status_pendente.Visible = false;
            status_pendente.Width = 200;
            // 
            // profissional_cod_pendente
            // 
            profissional_cod_pendente.DataPropertyName = "ProfessionalId";
            profissional_cod_pendente.HeaderText = "Profissional_cod";
            profissional_cod_pendente.MinimumWidth = 10;
            profissional_cod_pendente.Name = "profissional_cod_pendente";
            profissional_cod_pendente.ReadOnly = true;
            profissional_cod_pendente.Visible = false;
            profissional_cod_pendente.Width = 200;
            // 
            // id_vistoriada
            // 
            id_vistoriada.DataPropertyName = "Id";
            id_vistoriada.HeaderText = "Id";
            id_vistoriada.MinimumWidth = 10;
            id_vistoriada.Name = "id_vistoriada";
            id_vistoriada.ReadOnly = true;
            id_vistoriada.Visible = false;
            id_vistoriada.Width = 200;
            // 
            // titulo_vistoriada
            // 
            titulo_vistoriada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titulo_vistoriada.DataPropertyName = "Title";
            titulo_vistoriada.HeaderText = "Título";
            titulo_vistoriada.MinimumWidth = 120;
            titulo_vistoriada.Name = "titulo_vistoriada";
            titulo_vistoriada.ReadOnly = true;
            // 
            // status_vistoriada
            // 
            status_vistoriada.DataPropertyName = "Status";
            status_vistoriada.HeaderText = "Status";
            status_vistoriada.MinimumWidth = 10;
            status_vistoriada.Name = "status_vistoriada";
            status_vistoriada.ReadOnly = true;
            status_vistoriada.Visible = false;
            status_vistoriada.Width = 200;
            // 
            // profissional_cod_vistoriada
            // 
            profissional_cod_vistoriada.DataPropertyName = "ProfessionalId";
            profissional_cod_vistoriada.HeaderText = "Profissional_cod";
            profissional_cod_vistoriada.MinimumWidth = 10;
            profissional_cod_vistoriada.Name = "profissional_cod_vistoriada";
            profissional_cod_vistoriada.ReadOnly = true;
            profissional_cod_vistoriada.Visible = false;
            profissional_cod_vistoriada.Width = 200;
            // 
            // id_concluida
            // 
            id_concluida.DataPropertyName = "id";
            id_concluida.HeaderText = "Id";
            id_concluida.MinimumWidth = 10;
            id_concluida.Name = "id_concluida";
            id_concluida.ReadOnly = true;
            id_concluida.Visible = false;
            id_concluida.Width = 200;
            // 
            // titulo_concluida
            // 
            titulo_concluida.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titulo_concluida.DataPropertyName = "title";
            titulo_concluida.HeaderText = "Título";
            titulo_concluida.MinimumWidth = 120;
            titulo_concluida.Name = "titulo_concluida";
            titulo_concluida.ReadOnly = true;
            // 
            // status_concluida
            // 
            status_concluida.DataPropertyName = "status";
            status_concluida.HeaderText = "Status";
            status_concluida.MinimumWidth = 10;
            status_concluida.Name = "status_concluida";
            status_concluida.ReadOnly = true;
            status_concluida.Visible = false;
            status_concluida.Width = 200;
            // 
            // profissional_cod_concluida
            // 
            profissional_cod_concluida.DataPropertyName = "professionalId";
            profissional_cod_concluida.HeaderText = "Profissional_cod";
            profissional_cod_concluida.MinimumWidth = 10;
            profissional_cod_concluida.Name = "profissional_cod_concluida";
            profissional_cod_concluida.ReadOnly = true;
            profissional_cod_concluida.Visible = false;
            profissional_cod_concluida.Width = 200;
            // 
            // uctOrderFlow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(7, 6, 7, 6);
            Name = "uctOrderFlow";
            Size = new Size(2000, 1400);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendentes).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecebidas).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVistoriadas).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConcluidas).EndInit();
            panel9.ResumeLayout(false);
            pnlFaturar.ResumeLayout(false);
            menuContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn id_pendente;
        private DataGridViewTextBoxColumn titulo_pendente;
        private DataGridViewTextBoxColumn status_pendente;
        private DataGridViewTextBoxColumn profissional_cod_pendente;
        private DataGridViewTextBoxColumn id_recebidas;
        private DataGridViewTextBoxColumn titulo_recebida;
        private DataGridViewTextBoxColumn status_recebida;
        private DataGridViewTextBoxColumn profissional_cod_recebida;
        private DataGridViewTextBoxColumn id_vistoriada;
        private DataGridViewTextBoxColumn titulo_vistoriada;
        private DataGridViewTextBoxColumn status_vistoriada;
        private DataGridViewTextBoxColumn profissional_cod_vistoriada;
        private DataGridViewTextBoxColumn id_concluida;
        private DataGridViewTextBoxColumn titulo_concluida;
        private DataGridViewTextBoxColumn status_concluida;
        private DataGridViewTextBoxColumn profissional_cod_concluida;
    }
}