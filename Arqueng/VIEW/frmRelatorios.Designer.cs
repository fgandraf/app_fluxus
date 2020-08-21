namespace Arqueng.VIEW
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.pctLupa = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividade_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordenada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo_execucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siopi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nome_contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatura_cod = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTitTotal = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ttpOS = new System.Windows.Forms.ToolTip(this.components);
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
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
            this.pnlBotton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.pnlBotton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLinha2.Location = new System.Drawing.Point(589, 54);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(280, 1);
            this.pnlLinha2.TabIndex = 224;
            // 
            // pctLupa
            // 
            this.pctLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctLupa.Image = ((System.Drawing.Image)(resources.GetObject("pctLupa.Image")));
            this.pctLupa.Location = new System.Drawing.Point(589, 32);
            this.pctLupa.Name = "pctLupa";
            this.pctLupa.Size = new System.Drawing.Size(20, 20);
            this.pctLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLupa.TabIndex = 223;
            this.pctLupa.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPesquisar.Location = new System.Drawing.Point(612, 33);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(257, 18);
            this.txtPesquisar.TabIndex = 222;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(50, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(35, 35);
            this.btnEditar.TabIndex = 219;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpOS.SetToolTip(this.btnEditar, "Editar Ordem de Serviço");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(91, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(35, 35);
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
            this.dgvOS.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOS.ColumnHeadersHeight = 35;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.data_ordem,
            this.titulo,
            this.referencia,
            this.Agencia,
            this.atividade_cod,
            this.cidade,
            this.nome_cliente,
            this.coordenada,
            this.prazo_execucao,
            this.profissional_cod,
            this.siopi,
            this.nome_contato,
            this.telefone_contato,
            this.data_pendente,
            this.data_vistoria,
            this.data_concluida,
            this.obs,
            this.fatura_cod});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOS.Location = new System.Drawing.Point(50, 78);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvOS.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOS.RowTemplate.Height = 25;
            this.dgvOS.RowTemplate.ReadOnly = true;
            this.dgvOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.ShowEditingIcon = false;
            this.dgvOS.Size = new System.Drawing.Size(820, 416);
            this.dgvOS.TabIndex = 221;
            this.dgvOS.DoubleClick += new System.EventHandler(this.dgvOS_DoubleClick);
            this.dgvOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOS_KeyDown);
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 90;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.Width = 90;
            // 
            // data_ordem
            // 
            this.data_ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data_ordem.DataPropertyName = "data_ordem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_ordem.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_ordem.HeaderText = "Data Ordem";
            this.data_ordem.MinimumWidth = 80;
            this.data_ordem.Name = "data_ordem";
            this.data_ordem.ReadOnly = true;
            this.data_ordem.Width = 94;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Visible = false;
            this.titulo.Width = 61;
            // 
            // referencia
            // 
            this.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.referencia.DataPropertyName = "referencia";
            this.referencia.HeaderText = "Referência";
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            this.referencia.Width = 85;
            // 
            // Agencia
            // 
            this.Agencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Agencia.DataPropertyName = "agencia";
            this.Agencia.HeaderText = "Agencia";
            this.Agencia.Name = "Agencia";
            this.Agencia.ReadOnly = true;
            this.Agencia.Visible = false;
            this.Agencia.Width = 72;
            // 
            // atividade_cod
            // 
            this.atividade_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.atividade_cod.DataPropertyName = "atividade_cod";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.atividade_cod.DefaultCellStyle = dataGridViewCellStyle3;
            this.atividade_cod.HeaderText = "Tipo";
            this.atividade_cod.MinimumWidth = 45;
            this.atividade_cod.Name = "atividade_cod";
            this.atividade_cod.ReadOnly = true;
            this.atividade_cod.Width = 55;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 60;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 68;
            // 
            // nome_cliente
            // 
            this.nome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome_cliente.DataPropertyName = "nome_cliente";
            this.nome_cliente.HeaderText = "Nome do Cliente";
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            this.nome_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nome_cliente.Width = 118;
            // 
            // coordenada
            // 
            this.coordenada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coordenada.DataPropertyName = "coordenada";
            this.coordenada.HeaderText = "Coordenada";
            this.coordenada.Name = "coordenada";
            this.coordenada.ReadOnly = true;
            this.coordenada.Visible = false;
            this.coordenada.Width = 95;
            // 
            // prazo_execucao
            // 
            this.prazo_execucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prazo_execucao.DataPropertyName = "prazo_execucao";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prazo_execucao.DefaultCellStyle = dataGridViewCellStyle4;
            this.prazo_execucao.HeaderText = "Prazo Execução";
            this.prazo_execucao.Name = "prazo_execucao";
            this.prazo_execucao.ReadOnly = true;
            this.prazo_execucao.Width = 110;
            // 
            // profissional_cod
            // 
            this.profissional_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profissional_cod.DataPropertyName = "profissional_cod";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.profissional_cod.DefaultCellStyle = dataGridViewCellStyle5;
            this.profissional_cod.HeaderText = "Pro.";
            this.profissional_cod.MinimumWidth = 40;
            this.profissional_cod.Name = "profissional_cod";
            this.profissional_cod.ReadOnly = true;
            this.profissional_cod.Width = 52;
            // 
            // siopi
            // 
            this.siopi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.siopi.DataPropertyName = "siopi";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.siopi.DefaultCellStyle = dataGridViewCellStyle6;
            this.siopi.HeaderText = "Siopi";
            this.siopi.Name = "siopi";
            this.siopi.ReadOnly = true;
            this.siopi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.siopi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.siopi.Visible = false;
            this.siopi.Width = 58;
            // 
            // nome_contato
            // 
            this.nome_contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome_contato.DataPropertyName = "nome_contato";
            this.nome_contato.HeaderText = "Nome do Contato";
            this.nome_contato.Name = "nome_contato";
            this.nome_contato.ReadOnly = true;
            this.nome_contato.Width = 124;
            // 
            // telefone_contato
            // 
            this.telefone_contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefone_contato.DataPropertyName = "telefone_contato";
            this.telefone_contato.HeaderText = "Telefone do Contato";
            this.telefone_contato.Name = "telefone_contato";
            this.telefone_contato.ReadOnly = true;
            this.telefone_contato.Width = 136;
            // 
            // data_pendente
            // 
            this.data_pendente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data_pendente.DataPropertyName = "data_pendente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_pendente.DefaultCellStyle = dataGridViewCellStyle7;
            this.data_pendente.HeaderText = "Data Pendente";
            this.data_pendente.Name = "data_pendente";
            this.data_pendente.ReadOnly = true;
            this.data_pendente.Visible = false;
            this.data_pendente.Width = 106;
            // 
            // data_vistoria
            // 
            this.data_vistoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data_vistoria.DataPropertyName = "data_vistoria";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_vistoria.DefaultCellStyle = dataGridViewCellStyle8;
            this.data_vistoria.HeaderText = "Data da Vistoria";
            this.data_vistoria.Name = "data_vistoria";
            this.data_vistoria.ReadOnly = true;
            this.data_vistoria.Width = 114;
            // 
            // data_concluida
            // 
            this.data_concluida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data_concluida.DataPropertyName = "data_concluida";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_concluida.DefaultCellStyle = dataGridViewCellStyle9;
            this.data_concluida.HeaderText = "Dt. Conclusão";
            this.data_concluida.MinimumWidth = 85;
            this.data_concluida.Name = "data_concluida";
            this.data_concluida.ReadOnly = true;
            this.data_concluida.Width = 102;
            // 
            // obs
            // 
            this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Observações";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Visible = false;
            this.obs.Width = 97;
            // 
            // fatura_cod
            // 
            this.fatura_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fatura_cod.DataPropertyName = "fatura_cod";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fatura_cod.DefaultCellStyle = dataGridViewCellStyle10;
            this.fatura_cod.HeaderText = "Faturada";
            this.fatura_cod.MinimumWidth = 60;
            this.fatura_cod.Name = "fatura_cod";
            this.fatura_cod.ReadOnly = true;
            this.fatura_cod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fatura_cod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fatura_cod.Width = 77;
            // 
            // lblTitTotal
            // 
            this.lblTitTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitTotal.AutoSize = true;
            this.lblTitTotal.Location = new System.Drawing.Point(742, 497);
            this.lblTitTotal.Name = "lblTitTotal";
            this.lblTitTotal.Size = new System.Drawing.Size(96, 13);
            this.lblTitTotal.TabIndex = 227;
            this.lblTitTotal.Text = "Total de Registros:";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(836, 497);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(34, 13);
            this.lblTotalRegistros.TabIndex = 228;
            this.lblTotalRegistros.Text = "99";
            this.lblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(745, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 1);
            this.panel1.TabIndex = 229;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(773, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(22, 20);
            this.btnFiltrar.TabIndex = 233;
            this.ttpOS.SetToolTip(this.btnFiltrar, "Filtrar");
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltro.FlatAppearance.BorderSize = 0;
            this.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparFiltro.Image")));
            this.btnLimparFiltro.Location = new System.Drawing.Point(801, 20);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(22, 20);
            this.btnLimparFiltro.TabIndex = 256;
            this.ttpOS.SetToolTip(this.btnLimparFiltro, "Limpar filtro");
            this.btnLimparFiltro.UseVisualStyleBackColor = true;
            this.btnLimparFiltro.Visible = false;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(645, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 237;
            this.label1.Text = "Faturadas";
            // 
            // cboFaturadas
            // 
            this.cboFaturadas.AutoCompleteCustomSource.AddRange(new string[] {
            "Todas",
            "Sim",
            "Nâo"});
            this.cboFaturadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaturadas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFaturadas.FormattingEnabled = true;
            this.cboFaturadas.Items.AddRange(new object[] {
            "--TODAS--",
            "FATURADAS",
            "NÂO FATURADAS"});
            this.cboFaturadas.Location = new System.Drawing.Point(646, 19);
            this.cboFaturadas.Name = "cboFaturadas";
            this.cboFaturadas.Size = new System.Drawing.Size(120, 21);
            this.cboFaturadas.TabIndex = 243;
            // 
            // cboProfissional
            // 
            this.cboProfissional.DisplayMember = "nomeid";
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(125, 19);
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(175, 21);
            this.cboProfissional.TabIndex = 247;
            this.cboProfissional.ValueMember = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(123, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 246;
            this.label3.Text = "Profissional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(561, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 249;
            this.label4.Text = "Atividade";
            // 
            // cboAtividade
            // 
            this.cboAtividade.DisplayMember = "codigo";
            this.cboAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAtividade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAtividade.FormattingEnabled = true;
            this.cboAtividade.Location = new System.Drawing.Point(562, 19);
            this.cboAtividade.Name = "cboAtividade";
            this.cboAtividade.Size = new System.Drawing.Size(78, 21);
            this.cboAtividade.TabIndex = 250;
            this.cboAtividade.ValueMember = "codigo";
            // 
            // cboCidade
            // 
            this.cboCidade.DisplayMember = "cidade";
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(412, 19);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(144, 21);
            this.cboCidade.TabIndex = 253;
            this.cboCidade.ValueMember = "cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(411, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 252;
            this.label6.Text = "Cidade";
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Todas",
            "Sim",
            "Nâo"});
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "--TODAS--",
            "RECEBIDA",
            "PENDENTE",
            "VISTORIADA",
            "CONCLUÍDA"});
            this.cboStatus.Location = new System.Drawing.Point(306, 19);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 21);
            this.cboStatus.TabIndex = 255;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(305, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 254;
            this.label7.Text = "Status";
            // 
            // pnlBotton
            // 
            this.pnlBotton.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBotton.Controls.Add(this.cboProfissional);
            this.pnlBotton.Controls.Add(this.btnLimparFiltro);
            this.pnlBotton.Controls.Add(this.cboStatus);
            this.pnlBotton.Controls.Add(this.btnFiltrar);
            this.pnlBotton.Controls.Add(this.label7);
            this.pnlBotton.Controls.Add(this.label1);
            this.pnlBotton.Controls.Add(this.cboCidade);
            this.pnlBotton.Controls.Add(this.label6);
            this.pnlBotton.Controls.Add(this.cboFaturadas);
            this.pnlBotton.Controls.Add(this.cboAtividade);
            this.pnlBotton.Controls.Add(this.label4);
            this.pnlBotton.Controls.Add(this.label3);
            this.pnlBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotton.Location = new System.Drawing.Point(0, 530);
            this.pnlBotton.Name = "pnlBotton";
            this.pnlBotton.Size = new System.Drawing.Size(920, 50);
            this.pnlBotton.TabIndex = 257;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.pnlBotton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.lblTitTotal);
            this.Controls.Add(this.pnlLinha2);
            this.Controls.Add(this.pctLupa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.pnlBotton.ResumeLayout(false);
            this.pnlBotton.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel pnlBotton;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividade_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordenada;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo_execucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissional_cod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn siopi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_vistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_concluida;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fatura_cod;
    }
}