namespace Fluxus.WinUI.View
{
    partial class frmProfessional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessional));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProfessionals = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelTecnico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.responsavelLegal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usr_ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usurioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpProfissionais = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessionals)).BeginInit();
            this.SuspendLayout();
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
            this.btnUpdate.TabIndex = 212;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpProfissionais.SetToolTip(this.btnUpdate, "Editar Profissional");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnDelete.TabIndex = 213;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpProfissionais.SetToolTip(this.btnDelete, "Excluir Profissional");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.TabIndex = 211;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttpProfissionais.SetToolTip(this.btnAdd, "Adicionar Profissional");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProfessionals
            // 
            this.dgvProfessionals.AllowUserToAddRows = false;
            this.dgvProfessionals.AllowUserToDeleteRows = false;
            this.dgvProfessionals.AllowUserToOrderColumns = true;
            this.dgvProfessionals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfessionals.BackgroundColor = System.Drawing.Color.White;
            this.dgvProfessionals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProfessionals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProfessionals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfessionals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfessionals.ColumnHeadersHeight = 35;
            this.dgvProfessionals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProfessionals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nome,
            this.nomeid,
            this.cpf,
            this.nascimento,
            this.profissao,
            this.carteira,
            this.entidade,
            this.telefone1,
            this.telefone2,
            this.email,
            this.responsavelTecnico,
            this.responsavelLegal,
            this.usr_ativo,
            this.usurioNome,
            this.usuarioSenha});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfessionals.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProfessionals.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvProfessionals.Location = new System.Drawing.Point(65, 178);
            this.dgvProfessionals.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvProfessionals.MultiSelect = false;
            this.dgvProfessionals.Name = "dgvProfessionals";
            this.dgvProfessionals.ReadOnly = true;
            this.dgvProfessionals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfessionals.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProfessionals.RowHeadersVisible = false;
            this.dgvProfessionals.RowHeadersWidth = 82;
            this.dgvProfessionals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProfessionals.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProfessionals.RowTemplate.Height = 60;
            this.dgvProfessionals.RowTemplate.ReadOnly = true;
            this.dgvProfessionals.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfessionals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProfessionals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessionals.ShowEditingIcon = false;
            this.dgvProfessionals.Size = new System.Drawing.Size(1870, 1051);
            this.dgvProfessionals.TabIndex = 214;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.DataPropertyName = "tag";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 10;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 147;
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
            // nomeid
            // 
            this.nomeid.DataPropertyName = "nameid";
            this.nomeid.HeaderText = "Nomeid";
            this.nomeid.MinimumWidth = 10;
            this.nomeid.Name = "nomeid";
            this.nomeid.ReadOnly = true;
            this.nomeid.Visible = false;
            this.nomeid.Width = 200;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cpf.DefaultCellStyle = dataGridViewCellStyle4;
            this.cpf.HeaderText = "CPF";
            this.cpf.MinimumWidth = 10;
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            this.cpf.Width = 200;
            // 
            // nascimento
            // 
            this.nascimento.DataPropertyName = "birthday";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nascimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.nascimento.HeaderText = "Nascimento";
            this.nascimento.MinimumWidth = 10;
            this.nascimento.Name = "nascimento";
            this.nascimento.ReadOnly = true;
            this.nascimento.Visible = false;
            this.nascimento.Width = 200;
            // 
            // profissao
            // 
            this.profissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profissao.DataPropertyName = "profession";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.profissao.DefaultCellStyle = dataGridViewCellStyle6;
            this.profissao.HeaderText = "Profissão";
            this.profissao.MinimumWidth = 10;
            this.profissao.Name = "profissao";
            this.profissao.ReadOnly = true;
            this.profissao.Width = 169;
            // 
            // carteira
            // 
            this.carteira.DataPropertyName = "permitNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.carteira.DefaultCellStyle = dataGridViewCellStyle7;
            this.carteira.HeaderText = "Carteira";
            this.carteira.MinimumWidth = 10;
            this.carteira.Name = "carteira";
            this.carteira.ReadOnly = true;
            this.carteira.Visible = false;
            this.carteira.Width = 200;
            // 
            // entidade
            // 
            this.entidade.DataPropertyName = "association";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.entidade.DefaultCellStyle = dataGridViewCellStyle8;
            this.entidade.HeaderText = "Entidade";
            this.entidade.MinimumWidth = 10;
            this.entidade.Name = "entidade";
            this.entidade.ReadOnly = true;
            this.entidade.Visible = false;
            this.entidade.Width = 200;
            // 
            // telefone1
            // 
            this.telefone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefone1.DataPropertyName = "phone1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.telefone1.DefaultCellStyle = dataGridViewCellStyle9;
            this.telefone1.HeaderText = "Telefone";
            this.telefone1.MinimumWidth = 10;
            this.telefone1.Name = "telefone1";
            this.telefone1.ReadOnly = true;
            this.telefone1.Width = 160;
            // 
            // telefone2
            // 
            this.telefone2.DataPropertyName = "phone2";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.telefone2.DefaultCellStyle = dataGridViewCellStyle10;
            this.telefone2.HeaderText = "Telefone 2";
            this.telefone2.MinimumWidth = 10;
            this.telefone2.Name = "telefone2";
            this.telefone2.ReadOnly = true;
            this.telefone2.Visible = false;
            this.telefone2.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.email.DefaultCellStyle = dataGridViewCellStyle11;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 10;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            this.email.Width = 200;
            // 
            // responsavelTecnico
            // 
            this.responsavelTecnico.DataPropertyName = "technicianResponsible";
            this.responsavelTecnico.HeaderText = "Rt";
            this.responsavelTecnico.MinimumWidth = 10;
            this.responsavelTecnico.Name = "responsavelTecnico";
            this.responsavelTecnico.ReadOnly = true;
            this.responsavelTecnico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.responsavelTecnico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.responsavelTecnico.Visible = false;
            this.responsavelTecnico.Width = 200;
            // 
            // responsavelLegal
            // 
            this.responsavelLegal.DataPropertyName = "legalResponsible";
            this.responsavelLegal.HeaderText = "Rl";
            this.responsavelLegal.MinimumWidth = 10;
            this.responsavelLegal.Name = "responsavelLegal";
            this.responsavelLegal.ReadOnly = true;
            this.responsavelLegal.Visible = false;
            this.responsavelLegal.Width = 200;
            // 
            // usr_ativo
            // 
            this.usr_ativo.DataPropertyName = "userActive";
            this.usr_ativo.HeaderText = "Usuário Ativo";
            this.usr_ativo.MinimumWidth = 10;
            this.usr_ativo.Name = "usr_ativo";
            this.usr_ativo.ReadOnly = true;
            this.usr_ativo.Width = 200;
            // 
            // usurioNome
            // 
            this.usurioNome.DataPropertyName = "userName";
            this.usurioNome.HeaderText = "usr_nome";
            this.usurioNome.MinimumWidth = 10;
            this.usurioNome.Name = "usurioNome";
            this.usurioNome.ReadOnly = true;
            this.usurioNome.Visible = false;
            this.usurioNome.Width = 200;
            // 
            // usuarioSenha
            // 
            this.usuarioSenha.DataPropertyName = "userPassword";
            this.usuarioSenha.HeaderText = "usr_senha";
            this.usuarioSenha.MinimumWidth = 10;
            this.usuarioSenha.Name = "usuarioSenha";
            this.usuarioSenha.ReadOnly = true;
            this.usuarioSenha.Visible = false;
            this.usuarioSenha.Width = 200;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(65, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 75);
            this.lblTitulo.TabIndex = 215;
            this.lblTitulo.Text = "Profissionais";
            // 
            // frmProfessional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2000, 1400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProfessionals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfessional";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profissionais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessionals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProfessionals;
        private System.Windows.Forms.ToolTip ttpProfissionais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteira;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn responsavelTecnico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn responsavelLegal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usr_ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usurioNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioSenha;
        private Label lblTitulo;
    }
}