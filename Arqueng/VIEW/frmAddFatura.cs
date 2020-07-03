using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Globalization;
using System.Linq;

namespace Arqueng.VIEW
{
    public partial class frmAddFatura : Form
    {
        OsMODEL modelOS = new OsMODEL();
        OsENT dadoOS = new OsENT();
        FaturasMODEL modelFatura = new FaturasMODEL();
        FaturasENT dadoFatura = new FaturasENT();
        decimal _valor_os = 0;
        decimal _valor_desloca = 0;
        decimal _valor_soma = 0;


        public void ListarOS()
        {
            try
            {
                dgvOS.DataSource = modelOS.ListarOSAFaturarModel();
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

        public void SomarValores()
        {
            _valor_os = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_atividade.Name].Value ?? 0));
            _valor_desloca = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_deslocamento.Name].Value ?? 0));
            _valor_soma = _valor_os + _valor_desloca;

            
            txtValorOS.Text = string.Format("{0:0,0.00}", _valor_os);
            txtValorDeslocamento.Text = string.Format("{0:0,0.00}", _valor_desloca);
            txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", _valor_soma);
            
        }

        public frmAddFatura()
        {
            InitializeComponent();
            ListarOS();
            txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
                return;
            else
            {
                var result = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells[2].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells[5].Value.ToString(), "Não Faturar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);
                    SomarValores();
                }
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            //POPULATE
            dadoFatura.Descricao = txtDescricao.Text;
            dadoFatura.Data = dtpData.Value;
            dadoFatura.Valor_os = _valor_os.ToString().Replace(',', '.');
            dadoFatura.Valor_deslocamento = _valor_desloca.ToString().Replace(',', '.');
            dadoFatura.Valor_total = _valor_soma.ToString().Replace(',', '.');
            dadoFatura.Rrtart = txtRRTART.Text;
            try
            {
                modelFatura.InsertFaturaModel(dadoFatura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            dadoOS.Fatura_cod = dadoFatura.Id.ToString();
            foreach (DataGridViewRow row in dgvOS.Rows)
            {
                dadoOS.Id = row.Cells["id"].Value.ToString();
                modelOS.UpdateOsFaturadaModel(dadoOS);
            }

            var result = MessageBox.Show("Ordens faturadas com sucesso!" + "\n\n" + "Deseja imprimir agora?", "Fatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //fromulariodeimpressao form = new formulariodeimpressa();
                //form.ShowDialog();
            }
            this.Close();

        }

        private void frmAddFatura_Load(object sender, EventArgs e)
        {

            SomarValores();
        }


    }
}
