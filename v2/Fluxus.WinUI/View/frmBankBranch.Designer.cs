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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankBranch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvBankBranches = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpAgencias = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(65, 1236);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 86);
            this.btnAdd.TabIndex = 204;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpAgencias.SetToolTip(this.btnAdd, "Adicionar Agência");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(236, 1236);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 86);
            this.btnDelete.TabIndex = 206;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpAgencias.SetToolTip(this.btnDelete, "Excluir Agência");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(147, 1236);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 86);
            this.btnUpdate.TabIndex = 205;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpAgencias.SetToolTip(this.btnUpdate, "Editar Agência");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvBankBranches
            // 
            this.dgvBankBranches.AllowUserToAddRows = false;
            this.dgvBankBranches.AllowUserToDeleteRows = false;
            this.dgvBankBranches.AllowUserToOrderColumns = true;
            this.dgvBankBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBankBranches.BackgroundColor = System.Drawing.Color.White;
            this.dgvBankBranches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBankBranches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBankBranches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankBranches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBankBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numero,
            this.nome,
            this.endereco,
            this.complemento,
            this.bairro,
            this.cidade,
            this.cep,
            this.uf,
            this.contato,
            this.telefone1,
            this.telefone2,
            this.email});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankBranches.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBankBranches.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvBankBranches.Location = new System.Drawing.Point(65, 178);
            this.dgvBankBranches.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvBankBranches.MultiSelect = false;
            this.dgvBankBranches.Name = "dgvBankBranches";
            this.dgvBankBranches.ReadOnly = true;
            this.dgvBankBranches.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankBranches.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBankBranches.RowHeadersVisible = false;
            this.dgvBankBranches.RowHeadersWidth = 82;
            this.dgvBankBranches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBankBranches.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBankBranches.RowTemplate.Height = 60;
            this.dgvBankBranches.RowTemplate.ReadOnly = true;
            this.dgvBankBranches.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankBranches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBankBranches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankBranches.ShowEditingIcon = false;
            this.dgvBankBranches.Size = new System.Drawing.Size(1870, 1051);
            this.dgvBankBranches.TabIndex = 211;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numero.DataPropertyName = "branchNumber";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.numero.DefaultCellStyle = dataGridViewCellStyle2;
            this.numero.HeaderText = "Número";
            this.numero.MinimumWidth = 10;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 158;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 10;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "address";
            this.endereco.HeaderText = "Endereco";
            this.endereco.MinimumWidth = 10;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Visible = false;
            this.endereco.Width = 200;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complement";
            this.complemento.HeaderText = "Complemento";
            this.complemento.MinimumWidth = 10;
            this.complemento.Name = "complemento";
            this.complemento.ReadOnly = true;
            this.complemento.Visible = false;
            this.complemento.Width = 200;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "district";
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 10;
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Visible = false;
            this.bairro.Width = 200;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cidade.DataPropertyName = "city";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cidade.DefaultCellStyle = dataGridViewCellStyle4;
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 100;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 143;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "zip";
            this.cep.HeaderText = "CEP";
            this.cep.MinimumWidth = 10;
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Visible = false;
            this.cep.Width = 200;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "state";
            this.uf.HeaderText = "UF";
            this.uf.MinimumWidth = 10;
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Visible = false;
            this.uf.Width = 200;
            // 
            // contato
            // 
            this.contato.DataPropertyName = "contactName";
            this.contato.HeaderText = "Contato";
            this.contato.MinimumWidth = 10;
            this.contato.Name = "contato";
            this.contato.ReadOnly = true;
            this.contato.Visible = false;
            this.contato.Width = 200;
            // 
            // telefone1
            // 
            this.telefone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefone1.DataPropertyName = "phone1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.telefone1.DefaultCellStyle = dataGridViewCellStyle5;
            this.telefone1.HeaderText = "Telefone";
            this.telefone1.MinimumWidth = 130;
            this.telefone1.Name = "telefone1";
            this.telefone1.ReadOnly = true;
            this.telefone1.Width = 160;
            // 
            // telefone2
            // 
            this.telefone2.DataPropertyName = "phone2";
            this.telefone2.HeaderText = "Telefone2";
            this.telefone2.MinimumWidth = 10;
            this.telefone2.Name = "telefone2";
            this.telefone2.ReadOnly = true;
            this.telefone2.Visible = false;
            this.telefone2.Width = 200;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.email.DefaultCellStyle = dataGridViewCellStyle6;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 10;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 124;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(65, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 75);
            this.lblTitulo.TabIndex = 212;
            this.lblTitulo.Text = "Agências";
            // 
            // frmBankBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2000, 1400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvBankBranches);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankBranch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agências Demandantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankBranches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label lblTitulo;
    }
}