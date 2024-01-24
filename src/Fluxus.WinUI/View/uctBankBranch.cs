using Fluxus.App.Services;
using Fluxus.Domain.Models;
using Fluxus.Domain.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

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


            var result = bankService.GetIndex();
            if (result.Success)
            {
                dgvBankBranches.DataSource = new BindingList<BranchesIndexViewModel>(result.Value);

                if (dgvBankBranches.Rows.Count == 0)
                {
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddBankBranch formNeto = new uctAddBankBranch(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = dgvBankBranches.CurrentRow.Cells["id"].Value.ToString();
            var bankService = _serviceProvider.GetService<BankBranchService>();
            var result = bankService.GetById(id);

            Branch branch;
            if (result.Success)
            {
                branch = result.Value;
                var formNeto = new uctAddBankBranch(_frmPrincipal, branch, _serviceProvider);
                _frmPrincipal.OpenUserControl(formNeto);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var id = dgvBankBranches.CurrentRow.Cells["id"].Value.ToString();
                var bankService = _serviceProvider.GetService<BankBranchService>();
                var result = bankService.Delete(id);

                if (result.Success)
                    dgvBankBranches.DataSource = bankService.GetIndex().Value;
                else
                    MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
