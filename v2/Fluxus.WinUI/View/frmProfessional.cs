﻿using Fluxus.Domain.Entities;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmProfessional : Form
    {
        frmPrincipal _frmPrincipal;

        public frmProfessional(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvProfessionals.DataSource = new ProfessionalService().GetAll();

            if (dgvProfessionals.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProfissional formNeto = new frmAddProfissional(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
            var professional = new ProfessionalService().GetBy(id);

            var formNeto = new frmAddProfissional(_frmPrincipal, professional);
            formNeto.Text = "Alterar";

            _frmPrincipal.AbrirFormInPanel(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
                new ProfessionalService().Delete(id);
                dgvProfessionals.Rows.RemoveAt(dgvProfessionals.CurrentRow.Index);
            }
        }

    }

}