using Fluxus.App;
using Fluxus.Domain.Entities;

namespace Fluxus.WinUI.View
{
    public partial class uctBankBranch : UserControl
    {
        frmMain _frmPrincipal;

        public uctBankBranch(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvBankBranches.DataSource = new BankBranchApp().GetAll();

            if (dgvBankBranches.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddBankBranch formNeto = new uctAddBankBranch(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
            var branch = new BankBranchApp().GetBy(id);

            var formNeto = new uctAddBankBranch(_frmPrincipal, branch);
            formNeto.Text = "Alterar";

            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
                new BankBranchApp().Delete(id);
                dgvBankBranches.Rows.RemoveAt(dgvBankBranches.CurrentRow.Index);
            }
        }

    }

}
