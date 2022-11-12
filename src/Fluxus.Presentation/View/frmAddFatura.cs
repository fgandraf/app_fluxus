using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using System.Globalization;
using Fluxus.Services;
using System.Linq;

namespace Fluxus.Presentation.View
{
    public partial class frmAddFatura : Form
    {


        frmPrincipal _frmPrincipal;
        private double _subtotal_os = 0.00;
        private double _subtotal_desloc = 0.00;



        public frmAddFatura(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        private void frmAddFatura_Load(object sender, EventArgs e)
        {
            dgvOS.DataSource = new OsService().GetOrdensConcluidasNaoFaturadas();
            SomarValores();
            txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
                return;
            else
            {
                var result = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells[2].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells[6].Value.ToString(), "Não Faturar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                
                if (result == DialogResult.Yes)
                {
                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);
                    SomarValores();
                }
            }
        }


        private void btnFaturar_Click(object sender, EventArgs e)
        {
            Fatura invoice = PopulateToObject();
            long invoiceId = new FaturaService().Insert(invoice);

            foreach (DataGridViewRow row in dgvOS.Rows)
            {
                long idOS = Convert.ToInt64(row.Cells["id"].Value);
                new OsService().UpdateFaturaCod(idOS, invoiceId);
            }

            MessageBox.Show("Ordens faturadas com sucesso!", "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Back();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }


        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
        }









        private void SomarValores()
        {
            _subtotal_os = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells["valor_atividade"].Value ?? 0));
            _subtotal_desloc = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells["valor_deslocamento"].Value ?? 0));

            txtValorOS.Text = string.Format("{0:0,0.00}", _subtotal_os);
            txtValorDeslocamento.Text = string.Format("{0:0,0.00}", _subtotal_desloc);
            txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", _subtotal_os + _subtotal_desloc);
        }


        private Fatura PopulateToObject()
        {
            Fatura dado = new Fatura
            {
                Descricao = txtDescricao.Text,
                Data = dtpData.Value,
                SubtotalOs = _subtotal_os,
                SubtotalDeslocamento = _subtotal_desloc,
                Total = _subtotal_os + _subtotal_desloc
            };
            return dado;
        }


        private void Back()
        {
            this.Close();
            _frmPrincipal.lblTitulo.Text = "Ordens de Serviços";
            _frmPrincipal.lblTitulo.Refresh();
            frmOS formFilho = new frmOS(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
        }
    }


}
