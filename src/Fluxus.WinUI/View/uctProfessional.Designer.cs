namespace Fluxus.WinUI.View
{
    partial class uctProfessional
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvProfessionals = new DataGridView();
            ttpProfissionais = new ToolTip(components);
            id = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            profissao = new DataGridViewTextBoxColumn();
            telefone1 = new DataGridViewTextBoxColumn();
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
            btnUpdate.Image = Properties.Resources.editIcon;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProfessionals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProfessionals.ColumnHeadersHeight = 35;
            dgvProfessionals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProfessionals.Columns.AddRange(new DataGridViewColumn[] { id, codigo, nome, profissao, telefone1 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProfessionals.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProfessionals.GridColor = SystemColors.InactiveCaption;
            dgvProfessionals.Location = new Point(65, 178);
            dgvProfessionals.Margin = new Padding(6, 7, 6, 7);
            dgvProfessionals.MultiSelect = false;
            dgvProfessionals.Name = "dgvProfessionals";
            dgvProfessionals.ReadOnly = true;
            dgvProfessionals.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProfessionals.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProfessionals.RowHeadersVisible = false;
            dgvProfessionals.RowHeadersWidth = 82;
            dgvProfessionals.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgvProfessionals.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            // profissao
            // 
            profissao.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            profissao.DataPropertyName = "profession";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            profissao.DefaultCellStyle = dataGridViewCellStyle4;
            profissao.HeaderText = "Profissão";
            profissao.MinimumWidth = 10;
            profissao.Name = "profissao";
            profissao.ReadOnly = true;
            profissao.Width = 169;
            // 
            // telefone1
            // 
            telefone1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefone1.DataPropertyName = "phone1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            telefone1.DefaultCellStyle = dataGridViewCellStyle5;
            telefone1.HeaderText = "Telefone";
            telefone1.MinimumWidth = 10;
            telefone1.Name = "telefone1";
            telefone1.ReadOnly = true;
            telefone1.Visible = false;
            telefone1.Width = 160;
            // 
            // uctProfessional
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvProfessionals);
            Margin = new Padding(6, 7, 6, 7);
            Name = "uctProfessional";
            Size = new Size(2000, 1400);
            ((System.ComponentModel.ISupportInitialize)dgvProfessionals).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProfessionals;
        private System.Windows.Forms.ToolTip ttpProfissionais;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn profissao;
        private DataGridViewTextBoxColumn telefone1;
    }
}