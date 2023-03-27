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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessional));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvProfessionals = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            nomeid = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            nascimento = new DataGridViewTextBoxColumn();
            profissao = new DataGridViewTextBoxColumn();
            carteira = new DataGridViewTextBoxColumn();
            entidade = new DataGridViewTextBoxColumn();
            telefone1 = new DataGridViewTextBoxColumn();
            telefone2 = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            responsavelTecnico = new DataGridViewCheckBoxColumn();
            responsavelLegal = new DataGridViewCheckBoxColumn();
            usr_ativo = new DataGridViewCheckBoxColumn();
            usurioNome = new DataGridViewTextBoxColumn();
            usuarioSenha = new DataGridViewTextBoxColumn();
            ttpProfissionais = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvProfessionals).BeginInit();
            SuspendLayout();
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
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(147, 75);
            btnUpdate.Margin = new Padding(6, 7, 6, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(76, 86);
            btnUpdate.TabIndex = 212;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpProfissionais.SetToolTip(btnUpdate, "Editar Profissional");
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(235, 75);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 86);
            btnDelete.TabIndex = 213;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpProfissionais.SetToolTip(btnDelete, "Excluir Profissional");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(65, 75);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 86);
            btnAdd.TabIndex = 211;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpProfissionais.SetToolTip(btnAdd, "Adicionar Profissional");
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProfessionals
            // 
            dgvProfessionals.AllowUserToAddRows = false;
            dgvProfessionals.AllowUserToDeleteRows = false;
            dgvProfessionals.AllowUserToOrderColumns = true;
            dgvProfessionals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProfessionals.BackgroundColor = Color.White;
            dgvProfessionals.BorderStyle = BorderStyle.Fixed3D;
            dgvProfessionals.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProfessionals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProfessionals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProfessionals.ColumnHeadersHeight = 35;
            dgvProfessionals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProfessionals.Columns.AddRange(new DataGridViewColumn[] { id, codigo, nome, nomeid, cpf, nascimento, profissao, carteira, entidade, telefone1, telefone2, email, responsavelTecnico, responsavelLegal, usr_ativo, usurioNome, usuarioSenha });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvProfessionals.DefaultCellStyle = dataGridViewCellStyle12;
            dgvProfessionals.GridColor = SystemColors.InactiveCaption;
            dgvProfessionals.Location = new Point(65, 178);
            dgvProfessionals.Margin = new Padding(6, 7, 6, 7);
            dgvProfessionals.MultiSelect = false;
            dgvProfessionals.Name = "dgvProfessionals";
            dgvProfessionals.ReadOnly = true;
            dgvProfessionals.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvProfessionals.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvProfessionals.RowHeadersVisible = false;
            dgvProfessionals.RowHeadersWidth = 82;
            dgvProfessionals.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dgvProfessionals.RowsDefaultCellStyle = dataGridViewCellStyle14;
            dgvProfessionals.RowTemplate.Height = 60;
            dgvProfessionals.RowTemplate.ReadOnly = true;
            dgvProfessionals.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvProfessionals.ScrollBars = ScrollBars.Vertical;
            dgvProfessionals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProfessionals.ShowEditingIcon = false;
            dgvProfessionals.Size = new Size(1870, 1160);
            dgvProfessionals.TabIndex = 214;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 200;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            codigo.DataPropertyName = "tag";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 0, 0);
            codigo.DefaultCellStyle = dataGridViewCellStyle2;
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 10;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 147;
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
            // nomeid
            // 
            nomeid.DataPropertyName = "nameid";
            nomeid.HeaderText = "Nomeid";
            nomeid.MinimumWidth = 10;
            nomeid.Name = "nomeid";
            nomeid.ReadOnly = true;
            nomeid.Visible = false;
            nomeid.Width = 200;
            // 
            // cpf
            // 
            cpf.DataPropertyName = "cpf";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cpf.DefaultCellStyle = dataGridViewCellStyle4;
            cpf.HeaderText = "CPF";
            cpf.MinimumWidth = 10;
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Visible = false;
            cpf.Width = 200;
            // 
            // nascimento
            // 
            nascimento.DataPropertyName = "birthday";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nascimento.DefaultCellStyle = dataGridViewCellStyle5;
            nascimento.HeaderText = "Nascimento";
            nascimento.MinimumWidth = 10;
            nascimento.Name = "nascimento";
            nascimento.ReadOnly = true;
            nascimento.Visible = false;
            nascimento.Width = 200;
            // 
            // profissao
            // 
            profissao.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            profissao.DataPropertyName = "profession";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            profissao.DefaultCellStyle = dataGridViewCellStyle6;
            profissao.HeaderText = "Profissão";
            profissao.MinimumWidth = 10;
            profissao.Name = "profissao";
            profissao.ReadOnly = true;
            profissao.Width = 169;
            // 
            // carteira
            // 
            carteira.DataPropertyName = "permitNumber";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            carteira.DefaultCellStyle = dataGridViewCellStyle7;
            carteira.HeaderText = "Carteira";
            carteira.MinimumWidth = 10;
            carteira.Name = "carteira";
            carteira.ReadOnly = true;
            carteira.Visible = false;
            carteira.Width = 200;
            // 
            // entidade
            // 
            entidade.DataPropertyName = "association";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            entidade.DefaultCellStyle = dataGridViewCellStyle8;
            entidade.HeaderText = "Entidade";
            entidade.MinimumWidth = 10;
            entidade.Name = "entidade";
            entidade.ReadOnly = true;
            entidade.Visible = false;
            entidade.Width = 200;
            // 
            // telefone1
            // 
            telefone1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefone1.DataPropertyName = "phone1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            telefone1.DefaultCellStyle = dataGridViewCellStyle9;
            telefone1.HeaderText = "Telefone";
            telefone1.MinimumWidth = 10;
            telefone1.Name = "telefone1";
            telefone1.ReadOnly = true;
            telefone1.Width = 160;
            // 
            // telefone2
            // 
            telefone2.DataPropertyName = "phone2";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            telefone2.DefaultCellStyle = dataGridViewCellStyle10;
            telefone2.HeaderText = "Telefone 2";
            telefone2.MinimumWidth = 10;
            telefone2.Name = "telefone2";
            telefone2.ReadOnly = true;
            telefone2.Visible = false;
            telefone2.Width = 200;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            email.DefaultCellStyle = dataGridViewCellStyle11;
            email.HeaderText = "Email";
            email.MinimumWidth = 10;
            email.Name = "email";
            email.ReadOnly = true;
            email.Visible = false;
            email.Width = 200;
            // 
            // responsavelTecnico
            // 
            responsavelTecnico.DataPropertyName = "technicianResponsible";
            responsavelTecnico.HeaderText = "Rt";
            responsavelTecnico.MinimumWidth = 10;
            responsavelTecnico.Name = "responsavelTecnico";
            responsavelTecnico.ReadOnly = true;
            responsavelTecnico.Resizable = DataGridViewTriState.True;
            responsavelTecnico.SortMode = DataGridViewColumnSortMode.Automatic;
            responsavelTecnico.Visible = false;
            responsavelTecnico.Width = 200;
            // 
            // responsavelLegal
            // 
            responsavelLegal.DataPropertyName = "legalResponsible";
            responsavelLegal.HeaderText = "Rl";
            responsavelLegal.MinimumWidth = 10;
            responsavelLegal.Name = "responsavelLegal";
            responsavelLegal.ReadOnly = true;
            responsavelLegal.Visible = false;
            responsavelLegal.Width = 200;
            // 
            // usr_ativo
            // 
            usr_ativo.DataPropertyName = "userActive";
            usr_ativo.HeaderText = "Usuário Ativo";
            usr_ativo.MinimumWidth = 10;
            usr_ativo.Name = "usr_ativo";
            usr_ativo.ReadOnly = true;
            usr_ativo.Width = 200;
            // 
            // usurioNome
            // 
            usurioNome.DataPropertyName = "userName";
            usurioNome.HeaderText = "usr_nome";
            usurioNome.MinimumWidth = 10;
            usurioNome.Name = "usurioNome";
            usurioNome.ReadOnly = true;
            usurioNome.Visible = false;
            usurioNome.Width = 200;
            // 
            // usuarioSenha
            // 
            usuarioSenha.DataPropertyName = "userPassword";
            usuarioSenha.HeaderText = "usr_senha";
            usuarioSenha.MinimumWidth = 10;
            usuarioSenha.Name = "usuarioSenha";
            usuarioSenha.ReadOnly = true;
            usuarioSenha.Visible = false;
            usuarioSenha.Width = 200;
            // 
            // frmProfessional
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(2000, 1400);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvProfessionals);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProfessional";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profissionais";
            ((System.ComponentModel.ISupportInitialize)dgvProfessionals).EndInit();
            ResumeLayout(false);
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
    }
}