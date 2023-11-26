using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.App.Services;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Infra.Records;

namespace Fluxus.WinUI.View
{
    public partial class uctInvoice : UserControl
    {
        private double _subtotalOs = 0.00;
        private double _subtotalDesloc = 0.00;
        private IServiceProvider _serviceProvider;

        private InvoiceService _invoiceService;

        public uctInvoice(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _invoiceService = _serviceProvider.GetService<InvoiceService>();

            if (Logged.Rl)
            {
                btnRemoverOs.Show();
                btnExcluir.Show();
            }

            var invoiceService = _serviceProvider.GetService<InvoiceService>();
            var invoices = invoiceService.GetAll();

            if (invoices.Success)
                dgvFaturas.DataSource = invoices.Value;
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
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
                int invoiceId = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value);

                var serviceOrderService = _serviceProvider.GetService<ServiceOrderService>();


                var professionals = serviceOrderService.GetProfessionalByInvoiceId(invoiceId);
                DataTable professionalsTable = new DataTable();

                if (professionals.Success)
                {
                    
                    professionalsTable.Columns.Add("ProfessionalId", typeof(int));
                    professionalsTable.Columns.Add("Nameid", typeof(string));

                    foreach (var professional in professionals.Value)
                    {
                        DataRow row = professionalsTable.NewRow();
                        row["ProfessionalId"] = professional.ProfessionalId;
                        row["Nameid"] = professional.Nameid;
                        professionalsTable.Rows.Add(row);
                    }

                }
                

                

                


                string path = saveFileDialog.FileName;


                var profileService = _serviceProvider.GetService<ProfileService>();
                var result = profileService.GetToPrint();

                if (!result.Success)
                {
                    MessageBox.Show(result.Message, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                var profile = result.Value;
                Image logo;
                using (var stream = new MemoryStream(profile.Logo))
                    logo = System.Drawing.Image.FromStream(stream);


                var serviceOrders = (List<ServiceOrderIndex>)dgvOS.DataSource;
                var serviceTable = new DataTable();
                
                foreach (var serviceOrder in serviceOrders)
                {
                    DataRow row = serviceTable.NewRow();

                    row["Id"] = serviceOrder.Id;
                    row["OrderDate"] = serviceOrder.OrderDate;
                    row["ReferenceCode"] = serviceOrder.ReferenceCode;
                    row["Professional"] = serviceOrder.Professional;
                    row["ProfessionalId"] = serviceOrder.ProfessionalId;
                    row["Service"] = serviceOrder.Service;
                    row["City"] = serviceOrder.City;
                    row["CustomerName"] = serviceOrder.CustomerName;
                    row["SurveyDate"] = serviceOrder.SurveyDate;
                    row["DoneDate"] = serviceOrder.DoneDate;
                    row["ServiceAmount"] = serviceOrder.ServiceAmount;
                    row["MileageAllowance"] = serviceOrder.MileageAllowance;
                    row["Invoiced"] = serviceOrder.Invoiced;
                    row["InvoiceId"] = serviceOrder.InvoiceId;
                    row["Status"] = serviceOrder.Status;
                    serviceTable.Rows.Add(row);
                }




                new ReportService().PrintPDF(logo, profile, professionalsTable, serviceTable, path);
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

                    txtValorOS.Text = string.Format("{0:0,0.00}", invoice.SubtotalService);
                    txtValorDeslocamento.Text = string.Format("{0:0,0.00}", invoice.SubtotalMileageAllowance);
                    txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", invoice.Total);

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


            var dialog = MessageBox.Show("Deseja excluir a Fatura?" + "\n\n" + dgvFaturas.CurrentRow.Cells[1].Value.ToString(), "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
                var serviceOrderService = _serviceProvider.GetService<ServiceOrderService>();

                int selectedInvoiceId = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value);
                var date = Convert.ToDateTime(dgvFaturas.CurrentRow.Cells["data"].Value);
                var closedByInvoiceId = serviceOrderService.GetOrdensFaturadasDoCodigo(selectedInvoiceId);
                
                if (closedByInvoiceId.Success)
                {
                    dgvOS.DataSource = closedByInvoiceId.Value;

                    txtData.Text = date.ToShortDateString();
                    txtValorOS.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells["subtotalService"].Value);
                    txtValorDeslocamento.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells["subtotalMileageAllowance"].Value);
                    txtValorTotal.Text = String.Format(new CultureInfo("pt-BR"), "{0:c}", dgvFaturas.CurrentRow.Cells["total"].Value);

                }

            }
        }

        private Invoice PopulateObject()
        {
            var totalServiceAmount = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[this.serviceAmount.Name].Value ?? 0));
            var totalMileageAllowance = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[this.mileageAllowance.Name].Value ?? 0));
            totalServiceAmount -= Convert.ToDouble(dgvOS.CurrentRow.Cells["serviceAmount"].Value);
            totalMileageAllowance -= Convert.ToDouble(dgvOS.CurrentRow.Cells["MileageAllowance"].Value);

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