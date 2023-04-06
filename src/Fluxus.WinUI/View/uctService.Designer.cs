namespace Fluxus.WinUI.View
{
    partial class uctService
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
            dgvServices = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            valor_atividade = new DataGridViewTextBoxColumn();
            valor_deslocamento = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ttpAtividades = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToOrderColumns = true;
            dgvServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServices.BackgroundColor = Color.White;
            dgvServices.BorderStyle = BorderStyle.Fixed3D;
            dgvServices.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvServices.ColumnHeadersHeight = 35;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvServices.Columns.AddRange(new DataGridViewColumn[] { id, codigo, descricao, valor_atividade, valor_deslocamento });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvServices.DefaultCellStyle = dataGridViewCellStyle6;
            dgvServices.GridColor = SystemColors.InactiveCaption;
            dgvServices.Location = new Point(65, 178);
            dgvServices.Margin = new Padding(7, 6, 7, 6);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvServices.RowHeadersVisible = false;
            dgvServices.RowHeadersWidth = 82;
            dgvServices.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgvServices.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvServices.RowTemplate.Height = 60;
            dgvServices.RowTemplate.ReadOnly = true;
            dgvServices.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvServices.ScrollBars = ScrollBars.Vertical;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.ShowEditingIcon = false;
            dgvServices.Size = new Size(1870, 1160);
            dgvServices.TabIndex = 4;
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
            // descricao
            // 
            descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descricao.DataPropertyName = "description";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 0, 0);
            descricao.DefaultCellStyle = dataGridViewCellStyle3;
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 10;
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // valor_atividade
            // 
            valor_atividade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valor_atividade.DataPropertyName = "serviceAmount";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            valor_atividade.DefaultCellStyle = dataGridViewCellStyle4;
            valor_atividade.HeaderText = "Atividade (R$)";
            valor_atividade.MinimumWidth = 10;
            valor_atividade.Name = "valor_atividade";
            valor_atividade.ReadOnly = true;
            valor_atividade.Width = 228;
            // 
            // valor_deslocamento
            // 
            valor_deslocamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valor_deslocamento.DataPropertyName = "mileageAllowance";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            valor_deslocamento.DefaultCellStyle = dataGridViewCellStyle5;
            valor_deslocamento.HeaderText = "Deslocamento (R$)";
            valor_deslocamento.MinimumWidth = 10;
            valor_deslocamento.Name = "valor_deslocamento";
            valor_deslocamento.ReadOnly = true;
            valor_deslocamento.Width = 285;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.addIcon;
            btnAdd.Location = new Point(65, 77);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 85);
            btnAdd.TabIndex = 1;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpAtividades.SetToolTip(btnAdd, "Adicionar Atividade");
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.deleteIcon;
            btnDelete.Location = new Point(238, 77);
            btnDelete.Margin = new Padding(7, 6, 7, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 85);
            btnDelete.TabIndex = 3;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpAtividades.SetToolTip(btnDelete, "Excluir Atividade");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Image = Properties.Resources.editIcon;
            btnUpdate.Location = new Point(148, 77);
            btnUpdate.Margin = new Padding(7, 6, 7, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(76, 85);
            btnUpdate.TabIndex = 2;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttpAtividades.SetToolTip(btnUpdate, "Editar Atividade");
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmService
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2000, 1400);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvServices);
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmService";
            Text = "Atividades";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolTip ttpAtividades;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn valor_atividade;
        private DataGridViewTextBoxColumn valor_deslocamento;
    }
}