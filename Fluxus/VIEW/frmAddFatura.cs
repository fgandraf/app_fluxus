using System;
using System.Windows.Forms;
using Fluxus.MODEL;
using Fluxus.ENTIDADES;
using System.Globalization;
using System.Linq;
using System.Data;

namespace Fluxus.VIEW
{
    public partial class frmAddFatura : Form
    {
        frmPrincipal _frmPrincipal;
        OsMODEL modelOS = new OsMODEL();
        OsENT dadoOS = new OsENT();
        FaturasMODEL modelFatura = new FaturasMODEL();
        FaturasENT dadoFatura = new FaturasENT();
        private decimal Subtotal_os = 0;
        private decimal Subtotal_desloc = 0;
        private decimal Total = 0;



        //:METHODS
        private void ListarOS()
        {
            try
            {
                OsMODEL model = new OsMODEL();
                dgvOS.DataSource = model.ListarOrdensConcluidasNaoFaturadasMODEL();

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
            Subtotal_os = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_atividade.Name].Value ?? 0));
            Subtotal_desloc = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_deslocamento.Name].Value ?? 0));
            Total = Subtotal_os + Subtotal_desloc;

            txtValorOS.Text = string.Format("{0:0,0.00}", Subtotal_os);
            txtValorDeslocamento.Text = string.Format("{0:0,0.00}", Subtotal_desloc);
            txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", Total);
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
            dadoFatura.descricao = txtDescricao.Text;
            dadoFatura.data = dtpData.Value;
            dadoFatura.subtotal_os = Subtotal_os.ToString().Replace(',', '.');
            dadoFatura.subtotal_desloc = Subtotal_desloc.ToString().Replace(',', '.');
            dadoFatura.total = Total.ToString().Replace(',', '.');

            try
            {
                modelFatura.InsertFaturaMODEL(dadoFatura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string referencia;
            string fatura_cod = dadoFatura.id.ToString();

            foreach (DataGridViewRow row in dgvOS.Rows)
            {
                referencia = row.Cells["referencia"].Value.ToString();
                modelOS.UpdateFaturaCodMODEL(referencia, fatura_cod);
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
