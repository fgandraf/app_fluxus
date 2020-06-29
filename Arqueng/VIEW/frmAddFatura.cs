using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Globalization;

namespace Arqueng.VIEW
{
    public partial class frmAddFatura : Form
    {
        OsMODEL modelOS = new OsMODEL();
        OsENT dadoOS = new OsENT();
        FaturasMODEL modelFatura = new FaturasMODEL();
        FaturasENT dadoFatura = new FaturasENT();

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
            txtValorTotal.Text = string.Format("{0:N}", (Convert.ToDecimal(txtValorOS.Text) + Convert.ToDecimal(txtValorDeslocamento.Text)));
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
                var result = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells[1].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells[3].Value.ToString(), "Não Faturar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);
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
            dadoFatura.Valor_os = txtValorOS.Text.Replace(',', '.');
            dadoFatura.Valor_deslocamento = txtValorDeslocamento.Text.Replace(',', '.');
            dadoFatura.Valor_total = txtValorTotal.Text.Replace(',', '.');
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
            MessageBox.Show("Ordens faturadas com sucesso!", "Faturadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmAddFatura_Load(object sender, EventArgs e)
        {

            SomarValores();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
