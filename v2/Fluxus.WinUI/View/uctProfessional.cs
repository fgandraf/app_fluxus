using Fluxus.Domain.Entities;
using Fluxus.App;

namespace Fluxus.WinUI.View
{
    public partial class uctProfessional : UserControl
    {
        frmMain _frmPrincipal;

        public uctProfessional(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvProfessionals.DataSource = new ProfessionalApp().GetAll();

            if (dgvProfessionals.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddProfessional formNeto = new uctAddProfessional(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
            var professional = new ProfessionalApp().GetBy(id);

            var formNeto = new uctAddProfessional(_frmPrincipal, professional);
            formNeto.Text = "Alterar";

            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvProfessionals.CurrentRow.Cells["id"].Value);
                new ProfessionalApp().Delete(id);
                dgvProfessionals.Rows.RemoveAt(dgvProfessionals.CurrentRow.Index);
            }
        }

    }

}
