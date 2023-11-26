using Fluxus.Domain.Entities;
using Fluxus.App.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI.View
{
    public partial class uctService : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private IServiceProvider _serviceProvider;
        private ServiceService _serviceService;

        public uctService(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _serviceService = _serviceProvider.GetService<ServiceService>();

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvServices.DataSource = _serviceService.GetAll(false).Value;

            if (dgvServices.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddService formNeto = new uctAddService(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);
            var result = _serviceService.GetById(id);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formNeto = new uctAddService(_frmPrincipal, result.Value, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);

                var response = _serviceService.Delete(id);

                if (response.Success)
                    dgvServices.DataSource = _serviceService.GetAll(false).Value;
                else
                    MessageBox.Show(response.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
