using Arqueng.ENTIDADES;
using Arqueng.MODEL;
using Arqueng.RELATORIOS;
using System;
using System.Windows.Forms;


namespace Arqueng.VIEW
{
    public partial class frmFaturas : Form
    {

        FaturasMODEL model = new FaturasMODEL();
        OsMODEL modelOS = new OsMODEL();
        OsENT dado = new OsENT();

        public frmFaturas()
        {
            InitializeComponent();
        }

        public void ListarFatura()
        {
            try
            {
                dgvFaturas.DataSource = model.ListarFaturaModel();
                if (dgvFaturas.Rows.Count == 0)
                {
                    dgvFaturas.Enabled = false;
                }
                else
                {
                    dgvFaturas.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarOSFaturada()
        {
            try
            {
                dado.Fatura_cod = dgvFaturas.CurrentRow.Cells[0].Value.ToString();
                dgvOS.DataSource = modelOS.ListarOSFaturadaModel(dado);
                
                txtRRTART.Text = dgvFaturas.CurrentRow.Cells[6].Value.ToString();
                txtData.Text = dgvFaturas.CurrentRow.Cells[2].Value.ToString();
                txtValorOS.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[3].Value);     
                txtValorDeslocamento.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[4].Value);
                txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[5].Value);


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


        private void frmFaturas_Load(object sender, EventArgs e)
        {
            ListarFatura();
            ListarOSFaturada();
        }

        private void dgvFaturas_MouseClick(object sender, MouseEventArgs e)
        {
            ListarOSFaturada();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            frmRPFatura frm = new frmRPFatura();
           
            frm.ShowDialog();
        }
    }
}
