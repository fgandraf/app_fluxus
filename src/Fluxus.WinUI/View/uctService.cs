using Fluxus.Domain.Entities;
using Fluxus.App;
using Fluxus.Domain.Interfaces;
using Fluxus.Infra.Repositories;

namespace Fluxus.WinUI.View
{
    public partial class uctService : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private IServiceRepository _serviceRepository;

        public uctService(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _serviceRepository = new ServiceRepository();

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvServices.DataSource = new ServiceService(_serviceRepository).GetAll(false);

            if (dgvServices.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddService formNeto = new uctAddService(_frmPrincipal);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);
            var service = new ServiceService(_serviceRepository).GetBy(id);

            var formNeto = new uctAddService(_frmPrincipal, service);

            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);
                var app = new ServiceService(_serviceRepository);
                var success = app.Delete(id);

                if (success)
                    dgvServices.DataSource = app.GetAll(false);
                else
                    MessageBox.Show(app.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
