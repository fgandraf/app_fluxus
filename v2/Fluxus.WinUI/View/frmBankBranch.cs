using Fluxus.Services;
using Fluxus.Domain.Entities;

namespace Fluxus.WinUI.View
{
    public partial class frmBankBranch : UserControl
    {
        frmMain _frmPrincipal;

        public frmBankBranch(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvBankBranches.DataSource = new BankBranchService().GetAll();

            if (dgvBankBranches.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAgencia formNeto = new frmAddAgencia(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirUserControlInPanel(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
            var branch = new BankBranchService().GetBy(id);

            var formNeto = new frmAddAgencia(_frmPrincipal, branch);
            formNeto.Text = "Alterar";

            _frmPrincipal.AbrirUserControlInPanel(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
                new BankBranchService().Delete(id);
                dgvBankBranches.Rows.RemoveAt(dgvBankBranches.CurrentRow.Index);
            }
        }

    }

}
