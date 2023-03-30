using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.App;
using System.Globalization;

namespace Fluxus.WinUI.View
{
    public partial class uctInvoice : UserControl
    {
        private double _subtotalOs = 0.00;
        private double _subtotalDesloc = 0.00;

        public uctInvoice()
        {
            InitializeComponent();

            if (Logged.Rl)
            {
                btnRemoverOs.Show();
                btnExcluir.Show();
            }

            dgvFaturas.DataSource = new InvoiceApp().GetAll();
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
                string path = saveFileDialog.FileName;

                Profile profile = new ProfileApp().GetToPrint();

                Image logo;
                using (var stream = new MemoryStream(profile.Logo))
                    logo = System.Drawing.Image.FromStream(stream);

                int invoiceId = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value);
                var professionals = new ServiceOrderApp().GetProfessionalByInvoiceId(invoiceId);

                DataTable serviceOrders = (DataTable)dgvOS.DataSource;

                new InvoiceApp().PrintPDF(logo, profile, professionals, serviceOrders, path);
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

                var result = new InvoiceApp().RemoveOrder(idServiceOrder, invoice);

                if (result)
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
                    MessageBox.Show("Não é possível remover a Ordem de Serviço da fatura", "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                MessageBox.Show("Não é possível excluir uma fatura que possua ordens vinculadas", "Excluir Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var result = MessageBox.Show("Deseja excluir a Fatura?" + "\n\n" + dgvFaturas.CurrentRow.Cells[1].Value.ToString(), "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                new InvoiceApp().Delete((Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id_fat"].Value)));
                dgvFaturas.Rows.RemoveAt(dgvFaturas.CurrentRow.Index);
                ListarOS();
            }
        }

        private void dgvFaturas_MouseClick(object sender, MouseEventArgs e)
            => ListarOS();



        private void ListarOS()
        {
            if (dgvFaturas.Rows.Count > 0)
            {
                dgvOS.DataSource = new ServiceOrderApp().GetOrdensFaturadasDoCodigo(Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value));

                txtData.Text = Convert.ToDateTime(dgvFaturas.CurrentRow.Cells[2].Value).ToShortDateString();
                txtValorOS.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells["subtotalService"].Value);
                txtValorDeslocamento.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells["subtotalMileageAllowance"].Value);
                txtValorTotal.Text = String.Format(new CultureInfo("pt-BR"), "{0:c}", dgvFaturas.CurrentRow.Cells["total"].Value);
            }
        }

        private Invoice PopulateObject()
        {
            var totalServiceAmount = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[this.serviceAmount.Name].Value ?? 0));
            var totalMileageAllowance = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[this.mileageAllowance.Name].Value ?? 0));
            totalServiceAmount -= Convert.ToDouble(dgvOS.CurrentRow.Cells["serviceAmount"].Value);
            totalMileageAllowance -= Convert.ToDouble(dgvOS.CurrentRow.Cells["MileageAllowance"].Value);

            var invoice = new Invoice
            {
                Id = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value),
                SubtotalService = totalServiceAmount,
                SubtotalMileageAllowance = totalMileageAllowance,
                Total = totalServiceAmount + totalMileageAllowance
            };

            return invoice;
        }

    }

}