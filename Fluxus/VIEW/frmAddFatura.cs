using System;
using System.Windows.Forms;
using Fluxus.Model.ENT;
using System.Globalization;
using System.Linq;
using System.Data;
using Fluxus.Model;

namespace Fluxus.View
{
    public partial class frmAddFatura : Form
    {


        frmPrincipal _frmPrincipal;
        private decimal _subtotal_os = 0;
        private decimal _subtotal_desloc = 0;
        private decimal _total = 0;



        //:METHODS
        private void ListarOS()
        {
            try
            {
                dgvOS.DataSource = new OsModel().GetOrdensConcluidasNaoFaturadas();

                if (dgvOS.Rows.Count == 0)
                {
                    dgvOS.Enabled = false;
                }
                else
                {
                    dgvOS.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SomarValores()
        {
            _subtotal_os = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_atividade.Name].Value ?? 0));
            _subtotal_desloc = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_deslocamento.Name].Value ?? 0));
            _total = _subtotal_os + _subtotal_desloc;

            txtValorOS.Text = string.Format("{0:0,0.00}", _subtotal_os);
            txtValorDeslocamento.Text = string.Format("{0:0,0.00}", _subtotal_desloc);
            txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", _total);
        }





        //:EVENTS
        ///_______Form
        public frmAddFatura(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            ListarOS();
            txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
        }

        private void frmAddFatura_Load(object sender, EventArgs e)
        {
            SomarValores();
        }





        ///_______Button
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
            //POPULATE
            FaturaENT fatura = new FaturaENT
            {
                descricao = txtDescricao.Text,
                data = dtpData.Value,
                subtotal_os = _subtotal_os.ToString().Replace(',', '.'),
                subtotal_desloc = _subtotal_desloc.ToString().Replace(',', '.'),
                total = _total.ToString().Replace(',', '.')
            };

            long fatura_cod = new FaturaModel().Insert(fatura);

            foreach (DataGridViewRow row in dgvOS.Rows)
            {
                long idOS = Convert.ToInt64(row.Cells["id"].Value);
                new OsModel().UpdateFaturaCod(idOS, fatura_cod);
            }


            MessageBox.Show("Ordens faturadas com sucesso!", "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
            _frmPrincipal.lblTitulo.Text = "Ordens de Serviços";
            _frmPrincipal.lblTitulo.Refresh();

            frmOS formFilho = new frmOS(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmPrincipal.lblTitulo.Text = "Ordens de Serviços";
            _frmPrincipal.lblTitulo.Refresh();
            frmOS formFilho = new frmOS(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
        }





        ///_______DateTimePicker
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
        }



    }



}
