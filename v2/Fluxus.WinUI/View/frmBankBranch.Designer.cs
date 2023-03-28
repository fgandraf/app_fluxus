namespace Fluxus.WinUI.View
{
    partial class frmBankBranch
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgvBankBranches = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            endereco = new DataGridViewTextBoxColumn();
            complemento = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            cep = new DataGridViewTextBoxColumn();
            uf = new DataGridViewTextBoxColumn();
            contato = new DataGridViewTextBoxColumn();
            telefone1 = new DataGridViewTextBoxColumn();
            telefone2 = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ttpAgencias = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvBankBranches).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.addIcon;
            btnAdd.Location = new Point(65, 75);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 86);
            btnAdd.TabIndex = 204;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpAgencias.SetToolTip(btnAdd, "Adicionar Agência");
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.deleteIcon;
            btnDelete.Location = new Point(235, 75);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 86);
            btnDelete.TabIndex = 206;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpAgencias.SetToolTip(btnDelete, "Excluir Agência");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Image = Properties.Resources.editIcon;
            btnUpdate.Location = new Point(147, 75);
            btnUpdate.Margin = new Padding(6, 7, 6, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(76, 86);
            btnUpdate.TabIndex = 205;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpAgencias.SetToolTip(btnUpdate, "Editar Agência");
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvBankBranches
            // 
            dgvBankBranches.AllowUserToAddRows = false;
            dgvBankBranches.AllowUserToDeleteRows = false;
            dgvBankBranches.AllowUserToOrderColumns = true;
            dgvBankBranches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBankBranches.BackgroundColor = Color.White;
            dgvBankBranches.BorderStyle = BorderStyle.Fixed3D;
            dgvBankBranches.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBankBranches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBankBranches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBankBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankBranches.Columns.AddRange(new DataGridViewColumn[] { id, numero, nome, endereco, complemento, bairro, cidade, cep, uf, contato, telefone1, telefone2, email });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvBankBranches.DefaultCellStyle = dataGridViewCellStyle7;
            dgvBankBranches.GridColor = SystemColors.InactiveCaption;
            dgvBankBranches.Location = new Point(65, 178);
            dgvBankBranches.Margin = new Padding(6, 7, 6, 7);
            dgvBankBranches.MultiSelect = false;
            dgvBankBranches.Name = "dgvBankBranches";
            dgvBankBranches.ReadOnly = true;
            dgvBankBranches.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvBankBranches.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvBankBranches.RowHeadersVisible = false;
            dgvBankBranches.RowHeadersWidth = 82;
            dgvBankBranches.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dgvBankBranches.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvBankBranches.RowTemplate.Height = 60;
            dgvBankBranches.RowTemplate.ReadOnly = true;
            dgvBankBranches.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvBankBranches.ScrollBars = ScrollBars.Vertical;
            dgvBankBranches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBankBranches.ShowEditingIcon = false;
            dgvBankBranches.Size = new Size(1870, 1160);
            dgvBankBranches.TabIndex = 211;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 200;
            // 
            // numero
            // 
            numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            numero.DataPropertyName = "branchNumber";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 0, 0);
            numero.DefaultCellStyle = dataGridViewCellStyle2;
            numero.HeaderText = "Número";
            numero.MinimumWidth = 10;
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Width = 158;
            // 
            // nome
            // 
            nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nome.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 0, 0);
            nome.DefaultCellStyle = dataGridViewCellStyle3;
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 10;
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // endereco
            // 
            endereco.DataPropertyName = "address";
            endereco.HeaderText = "Endereco";
            endereco.MinimumWidth = 10;
            endereco.Name = "endereco";
            endereco.ReadOnly = true;
            endereco.Visible = false;
            endereco.Width = 200;
            // 
            // complemento
            // 
            complemento.DataPropertyName = "complement";
            complemento.HeaderText = "Complemento";
            complemento.MinimumWidth = 10;
            complemento.Name = "complemento";
            complemento.ReadOnly = true;
            complemento.Visible = false;
            complemento.Width = 200;
            // 
            // bairro
            // 
            bairro.DataPropertyName = "district";
            bairro.HeaderText = "Bairro";
            bairro.MinimumWidth = 10;
            bairro.Name = "bairro";
            bairro.ReadOnly = true;
            bairro.Visible = false;
            bairro.Width = 200;
            // 
            // cidade
            // 
            cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cidade.DataPropertyName = "city";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cidade.DefaultCellStyle = dataGridViewCellStyle4;
            cidade.HeaderText = "Cidade";
            cidade.MinimumWidth = 100;
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            cidade.Width = 143;
            // 
            // cep
            // 
            cep.DataPropertyName = "zip";
            cep.HeaderText = "CEP";
            cep.MinimumWidth = 10;
            cep.Name = "cep";
            cep.ReadOnly = true;
            cep.Visible = false;
            cep.Width = 200;
            // 
            // uf
            // 
            uf.DataPropertyName = "state";
            uf.HeaderText = "UF";
            uf.MinimumWidth = 10;
            uf.Name = "uf";
            uf.ReadOnly = true;
            uf.Visible = false;
            uf.Width = 200;
            // 
            // contato
            // 
            contato.DataPropertyName = "contactName";
            contato.HeaderText = "Contato";
            contato.MinimumWidth = 10;
            contato.Name = "contato";
            contato.ReadOnly = true;
            contato.Visible = false;
            contato.Width = 200;
            // 
            // telefone1
            // 
            telefone1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefone1.DataPropertyName = "phone1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            telefone1.DefaultCellStyle = dataGridViewCellStyle5;
            telefone1.HeaderText = "Telefone";
            telefone1.MinimumWidth = 130;
            telefone1.Name = "telefone1";
            telefone1.ReadOnly = true;
            telefone1.Width = 160;
            // 
            // telefone2
            // 
            telefone2.DataPropertyName = "phone2";
            telefone2.HeaderText = "Telefone2";
            telefone2.MinimumWidth = 10;
            telefone2.Name = "telefone2";
            telefone2.ReadOnly = true;
            telefone2.Visible = false;
            telefone2.Width = 200;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email.DataPropertyName = "email";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new Padding(5, 0, 0, 0);
            email.DefaultCellStyle = dataGridViewCellStyle6;
            email.HeaderText = "Email";
            email.MinimumWidth = 10;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 124;
            // 
            // frmBankBranch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2000, 1400);
            Controls.Add(dgvBankBranches);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBankBranch";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agências Demandantes";
            ((System.ComponentModel.ISupportInitialize)dgvBankBranches).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvBankBranches;
        private System.Windows.Forms.ToolTip ttpAgencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}