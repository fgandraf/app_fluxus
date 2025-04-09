﻿using Fluxus.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using Fluxus.UseCases;
using Fluxus.Core.Dtos.Professionals;

namespace Fluxus.WinUI.View
{
    public partial class uctProfessional : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private IServiceProvider _serviceProvider;
        private ProfessionalUseCases _professionalService;

        public uctProfessional(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _professionalService = _serviceProvider.GetService<ProfessionalUseCases>();

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            var profissionais = _professionalService.GetIndex();

            if (profissionais == null)
            {
                MessageBox.Show(profissionais.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dgvProfessionals.DataSource = new BindingList<ProfessionalIndexResponse>(profissionais.Value);

            if (dgvProfessionals.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddProfessional formNeto = new uctAddProfessional(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
            var result = _professionalService.GetById(id);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var formNeto = new uctAddProfessional(_frmPrincipal, result.Value, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Deseja realmente excluir?\n\n O usuário associado ao profissional também será removido.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
                var result = _professionalService.Delete(id);                
                


                if (result.Success)
                    dgvProfessionals.DataSource = _professionalService.GetIndex().Value;
                else
                    MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
