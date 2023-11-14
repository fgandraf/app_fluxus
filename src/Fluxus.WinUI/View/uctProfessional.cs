using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using Fluxus.App.Application;
using Fluxus.Domain.Interfaces;

namespace Fluxus.WinUI.View
{
    public partial class uctProfessional : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private IProfessionalRepository _repository;

        public uctProfessional(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _repository = new ProfessionalRepository();

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            var service = new ProfessionalService(_repository);
            var profissionais = service.GetIndex();

            if (profissionais == null)
            {
                MessageBox.Show(service.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dgvProfessionals.DataSource = profissionais;

            if (dgvProfessionals.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddProfessional formNeto = new uctAddProfessional(_frmPrincipal);
            formNeto.Tag = "Adicionar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
            var service = new ProfessionalService(_repository);
            var professional = service.GetById(id);

            if (professional == null)
            {
                MessageBox.Show(service.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var formNeto = new uctAddProfessional(_frmPrincipal, professional);
            formNeto.Tag = "Alterar";

            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
                var service = new ProfessionalService(_repository);
                var success = service.Delete(id);                
                


                if (success)
                    dgvProfessionals.DataSource = service.GetIndex();
                else
                    MessageBox.Show(service.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
