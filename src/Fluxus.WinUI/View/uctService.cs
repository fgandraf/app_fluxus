using Fluxus.Domain.Entities;
using Fluxus.App;

namespace Fluxus.WinUI.View
{
    public partial class uctService : UserControl
    {
        private readonly frmMain _frmPrincipal;

        public uctService(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvServices.DataSource = new ServiceApp().GetAll(false);

            if (dgvServices.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddService formNeto = new uctAddService(_frmPrincipal);
            formNeto.Tag = "Adicionar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);
            var service = new ServiceApp().GetBy(id);

            var formNeto = new uctAddService(_frmPrincipal, service);
            formNeto.Tag = "Alterar";

            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);
                var app = new ServiceApp();
                var success = app.Delete(id);

                if (success)
                    dgvServices.DataSource = app.GetAll(false);
                else
                    MessageBox.Show(app.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
