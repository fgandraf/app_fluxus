using Fluxus.Core.Models;
using System.Data;
using Fluxus.Infra.Services;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.UseCases;
using System.ComponentModel;
using Fluxus.Core.Dtos.Orders;
using Fluxus.Core.Dtos;

namespace Fluxus.WinUI.View
{
    public partial class uctInvoice : UserControl
    {
        private decimal _subtotalOs = 0.00m;
        private decimal _subtotalDesloc = 0.00m;

        private readonly InvoiceUseCases _invoiceService;
        private readonly ProfileUseCases _profileService;
        private readonly OrderUseCases _orderService;

        public uctInvoice(IServiceProvider serviceProvider)
        {
            _profileService = serviceProvider.GetService<ProfileUseCases>();
            _orderService = serviceProvider.GetService<OrderUseCases>();
            _invoiceService = serviceProvider.GetService<InvoiceUseCases>();

            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            if (Logged.Rl)
            {
                btnRemoverOs.Show();
                btnExcluir.Show();
            }

            var invoices = _invoiceService.GetAll();

            if (invoices.Success)
            {
                var bindingList = new BindingList<Invoice>(invoices.Value);
                dgvFaturas.DataSource = bindingList;
            }

            if (dgvFaturas.Rows.Count > 0)
            {
                tblFaturas.Show();
                ListarOS();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var invoiceId = (long)dgvFaturas.CurrentRow.Cells["id"].Value;
                var professionals = _orderService.GetProfessionalByInvoiceId(invoiceId);
                var profile = _profileService.GetToPrint();

                if (!profile.Success)
                {
                    MessageBox.Show(profile.Message, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                if (!professionals.Success)
                {
                    MessageBox.Show(professionals.Message, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                var report = new PdfReportViewModel
                {
                    Logo = _profileService.GetLogo().Value,
                    CompanyName = profile.Value.CompanyName,
                    Cnpj = profile.Value.Cnpj,
                    ContractNotice = profile.Value.ContractNotice,
                    ContractNumber = profile.Value.ContractNumber,
                    Orders = ((BindingList<OrderInvoicedResponse>)dgvOS.DataSource).ToList(),
                    Professionals = professionals.Value,
                    Path = saveFileDialog.FileName
                };

                new TextSharpPdf().PrintPdf(report);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
                return;

            var dialog = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells["referenceCode"].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells["customerName"].Value.ToString() + "\n\n" + "A fatura será recalculada e a Ordem de Serviço retornará ao fluxo de trabalho.", "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var idServiceOrder = Convert.ToInt32(dgvOS.CurrentRow.Cells["id_os"].Value);
                Invoice invoice = PopulateObject();

                var result = _invoiceService.RemoveOrder(idServiceOrder, invoice);

                if (result.Success)
                {

                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);

                    txtValorOS.Text = invoice.SubtotalService.ToString("C", new CultureInfo("pt-br"));
                    txtValorDeslocamento.Text = invoice.SubtotalMileageAllowance.ToString("C", new CultureInfo("pt-br"));
                    txtValorTotal.Text = invoice.Total.ToString("C", new CultureInfo("pt-br"));

                    dgvFaturas.CurrentRow.Cells["subtotalService"].Value = invoice.SubtotalService;
                    dgvFaturas.CurrentRow.Cells["subtotalMileageAllowance"].Value = invoice.SubtotalMileageAllowance;
                    dgvFaturas.CurrentRow.Cells["total"].Value = invoice.Total;

                    _subtotalOs = invoice.SubtotalService;
                    _subtotalDesloc = invoice.SubtotalMileageAllowance;
                }
                else
                    MessageBox.Show(result.Message, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                MessageBox.Show("Não é possível excluir uma fatura que possua ordens vinculadas", "Excluir Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var dialog = MessageBox.Show("Deseja excluir a Fatura?" + "\n\n" + dgvFaturas.CurrentRow.Cells["descricao"].Value.ToString(), "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value);
                _invoiceService.Delete(id);

                var invoices = _invoiceService.GetAll();

                if (!invoices.Success)
                {
                    MessageBox.Show(invoices.Message, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvFaturas.DataSource = invoices.Value;
                ListarOS();
            }
        }

        private void dgvFaturas_MouseClick(object sender, MouseEventArgs e)
            => ListarOS();



        private void ListarOS()
        {
            if (dgvFaturas.Rows.Count > 0)
            {
                int selectedInvoiceId = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value);
                var date = Convert.ToDateTime(dgvFaturas.CurrentRow.Cells["data"].Value);
                var closedByInvoiceId = _orderService.GetOrdensFaturadasDoCodigo(selectedInvoiceId);
                
                if (closedByInvoiceId.Success)
                {
                    var bindingList = new BindingList<OrderInvoicedResponse>(closedByInvoiceId.Value);
                    dgvOS.DataSource = bindingList;

                    txtData.Text = date.ToShortDateString();
                    txtValorOS.Text = String.Format(new CultureInfo("pt-BR"), "{0:c}", dgvFaturas.CurrentRow.Cells["subtotalService"].Value);
                    txtValorDeslocamento.Text = String.Format(new CultureInfo("pt-BR"), "{0:c}", dgvFaturas.CurrentRow.Cells["subtotalMileageAllowance"].Value);
                    txtValorTotal.Text = String.Format(new CultureInfo("pt-BR"), "{0:c}", dgvFaturas.CurrentRow.Cells["total"].Value);

                }

            }
        }

        private Invoice PopulateObject()
        {
            var totalServiceAmount = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[this.serviceAmount.Name].Value ?? 0));
            var totalMileageAllowance = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[this.mileageAllowance.Name].Value ?? 0));
            totalServiceAmount -= Convert.ToDecimal(dgvOS.CurrentRow.Cells["serviceAmount"].Value);
            totalMileageAllowance -= Convert.ToDecimal(dgvOS.CurrentRow.Cells["MileageAllowance"].Value);

            var invoice = new Invoice
            (
                id: Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value),
                description: null,
                issueDate: DateTime.Now,
                subtotalService: totalServiceAmount,
                subtotalMileageAllowance: totalMileageAllowance,
                total: totalServiceAmount + totalMileageAllowance
            );

            return invoice;
        }

    }

}