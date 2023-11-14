using Fluxus.App;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Infra.Repositories;

namespace Fluxus.WinUI.View
{
    public partial class uctBankBranch : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private IBankBranchRepository _bankBranchRepository;

        public uctBankBranch(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _bankBranchRepository = new BankBranchRepository();

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvBankBranches.DataSource = new BankBranchService(_bankBranchRepository).GetIndex();

            if (dgvBankBranches.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddBankBranch formNeto = new uctAddBankBranch(_frmPrincipal);
            formNeto.Tag = "Adicionar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
            var branch = new BankBranchService(_bankBranchRepository).GetById(id);

            var formNeto = new uctAddBankBranch(_frmPrincipal, branch);
            formNeto.Tag = "Alterar";

            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
                var app = new BankBranchService(_bankBranchRepository);
                var success = app.Delete(id);

                if (success)
                    dgvBankBranches.DataSource = new BankBranchService(_bankBranchRepository).GetIndex();
                else
                    MessageBox.Show(app.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
