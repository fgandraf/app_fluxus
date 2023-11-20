using Fluxus.App.Services;
using Fluxus.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI.View
{
    public partial class uctBankBranch : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private IServiceProvider _serviceProvider;

        public uctBankBranch(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;

            if (Logged.Rl == false)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            

            var bankService = _serviceProvider.GetService<BankBranchService>();
            dgvBankBranches.DataSource = bankService.GetIndex();

            if (dgvBankBranches.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddBankBranch formNeto = new uctAddBankBranch(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
            var bankService = _serviceProvider.GetService<BankBranchService>();
            var branch = bankService.GetById(id);

            var formNeto = new uctAddBankBranch(_frmPrincipal, branch, _serviceProvider);


            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvBankBranches.CurrentRow.Cells["id"].Value);
                var bankService = _serviceProvider.GetService<BankBranchService>();
                var success = bankService.Delete(id);

                if (success)
                    dgvBankBranches.DataSource = bankService.GetIndex();
                else
                    MessageBox.Show(bankService.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
