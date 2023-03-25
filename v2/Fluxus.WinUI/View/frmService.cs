using Fluxus.Domain.Entities;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmService : Form
    {
        frmMain _frmPrincipal;
        
        public frmService(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvServices.DataSource = new ServiceService().ListarAtividades(false);

            if (dgvServices.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAtividade formNeto = new frmAddAtividade(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);
            var service = new ServiceService().GetBy(id);

            var formNeto = new frmAddAtividade(_frmPrincipal, service);
            formNeto.Text = "Alterar";

            _frmPrincipal.AbrirFormInPanel(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvServices.CurrentRow.Cells["id"].Value);
                new ProfessionalService().Delete(id);
                dgvServices.Rows.RemoveAt(dgvServices.CurrentRow.Index);
            }
        }

    }

}
