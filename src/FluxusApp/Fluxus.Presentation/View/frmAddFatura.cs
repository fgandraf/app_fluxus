using System;
using System.Windows.Forms;
using Fluxus.Domain.Models;
using System.Globalization;
using Fluxus.Presentation.Controller;

namespace Fluxus.Presentation.View
{
    public partial class frmAddFatura : Form
    {


        frmPrincipal _frmPrincipal;
        private double _subtotal_os = 0.00;
        private double _subtotal_desloc = 0.00;





        //:METHODS
        private void ListarOS()
        {
            try
            {
                dgvOS.DataSource = new OsController().GetOrdensConcluidasNaoFaturadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SomarValores()
        {
            _subtotal_os = Util.CellSum(dgvOS, "valor_atividade");
            _subtotal_desloc = Util.CellSum(dgvOS, "valor_deslocamento");

            txtValorOS.Text = string.Format("{0:0,0.00}", _subtotal_os);
            txtValorDeslocamento.Text = string.Format("{0:0,0.00}", _subtotal_desloc);
            txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", _subtotal_os + _subtotal_desloc);
        }


        private Fatura PopulateObject()
        {
            Fatura dado = new Fatura
            {
                descricao = txtDescricao.Text,
                data = dtpData.Value,
                subtotal_os = _subtotal_os,
                subtotal_desloc = _subtotal_desloc,
                total = _subtotal_os + _subtotal_desloc
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





        //:EVENTS
        public frmAddFatura(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        private void frmAddFatura_Load(object sender, EventArgs e)
        {
            ListarOS();
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
            try
            {

                Fatura dado = PopulateObject();
                long fatura_cod = new FaturaController().Insert(dado);


                foreach (DataGridViewRow row in dgvOS.Rows)
                {
                    long idOS = Convert.ToInt64(row.Cells["id"].Value);
                    new OsController().UpdateFaturaCod(idOS, fatura_cod);
                }

                MessageBox.Show("Ordens faturadas com sucesso!", "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao tentar faturar. \n\n" + ex, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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


    }


}
