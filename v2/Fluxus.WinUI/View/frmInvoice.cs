using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.Services;
using System.Globalization;

namespace Fluxus.WinUI.View
{
    public partial class frmInvoice : Form
    {
        private double _subtotalOs = 0.00;
        private double _subtotalDesloc = 0.00;

        public frmInvoice()
        {
            InitializeComponent();

            if (Logged.Rl)
            {
                btnRemoverOs.Show();
                btnExcluir.Show();
            }

            dgvFaturas.DataSource = new FaturaService().ListarFatura();
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

                //BUSCAR DADOS DA EMPRESA PARA IMPRESSAO
                Profile profile = new ProfileService().GetToPrint();

                //CONVERTER ARRAY DE BYTES EM IMAGEM
                Image logo;
                using (var stream = new MemoryStream(profile.Logo))
                    logo = System.Drawing.Image.FromStream(stream);

                //OBTER PROFISSIONAIS DA FATURA
                int invoiceId = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value);
                DataTable professionals = new ServiceOrderService().GetProfessionalByInvoiceId(invoiceId);

                //CONVERTER DATAGRIDVIEW EM DATATABLE
                DataTable serviceOrders = (DataTable)dgvOS.DataSource;

                //CHAMAR O MÉTODO
                InvoiceReport.PrintPDF(logo, profile, professionals, serviceOrders, path);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
                return;


            var result = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells["referenceCode"].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells["customerName"].Value.ToString() + "\n\n" + "A fatura será recalculada e a Ordem de Serviço retornará ao fluxo de trabalho.", "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //ALTERA PARA ZERO O FATURA_COD
                var idServiceOrder = Convert.ToInt32(dgvOS.CurrentRow.Cells["id_os"].Value);
                new ServiceOrderService().UpdateFaturaCod(idServiceOrder, 0);//implementar async


                //APAGA DO DATAGRIDVIEW
                dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);


                //RECALCULA E APLICA OS VALORES NA TELA
                _subtotalOs = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[serviceAmount.Name].Value ?? 0));
                _subtotalDesloc = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[mileageAllowance.Name].Value ?? 0));

                txtValorOS.Text = string.Format("{0:0,0.00}", _subtotalOs);
                txtValorDeslocamento.Text = string.Format("{0:0,0.00}", _subtotalDesloc);
                txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", _subtotalOs + _subtotalDesloc);


                //ATUALIZA AS INFORMAÇÕES DA VIEW
                dgvFaturas.CurrentRow.Cells["subtotalService"].Value = _subtotalOs;
                dgvFaturas.CurrentRow.Cells["subtotalMileageAllowance"].Value = _subtotalDesloc;
                dgvFaturas.CurrentRow.Cells["total"].Value = _subtotalOs + _subtotalDesloc;


                //APLICA OS NOVOS VALORES À TABELA DE FATURA
                Invoice invoice = PopulateObject();
                new FaturaService().Update(invoice); //implementar async
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
                new FaturaService().Delete((Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id_fat"].Value)));
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
                dgvOS.DataSource = new ServiceOrderService().GetOrdensFaturadasDoCodigo(Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value));

                txtData.Text = Convert.ToDateTime(dgvFaturas.CurrentRow.Cells[2].Value).ToShortDateString();
                txtValorOS.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells["subtotalService"].Value);
                txtValorDeslocamento.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells["subtotalMileageAllowance"].Value);
                txtValorTotal.Text = String.Format(new CultureInfo("pt-BR"), "{0:c}", dgvFaturas.CurrentRow.Cells["total"].Value);
            }
        }

        private Invoice PopulateObject()
        {
            var invoice = new Invoice
            {
                Id = Convert.ToInt32(dgvFaturas.CurrentRow.Cells["id"].Value),
                SubtotalService = _subtotalOs,
                SubtotalMileageAllowance = _subtotalDesloc,
                Total = _subtotalOs + _subtotalDesloc
            };

            return invoice;
        }

    }

}