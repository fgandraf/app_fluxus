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
        FaturasENT dadofat = new FaturasENT();


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
            if (dgvFaturas.Rows.Count > 0)
            {
                try
                {
                    dado.Fatura_cod = dgvFaturas.CurrentRow.Cells[0].Value.ToString();
                    dgvOS.DataSource = modelOS.ListarOSFaturadaModel(dado);

                    txtData.Text = dgvFaturas.CurrentRow.Cells[2].Value.ToString();
                    txtValorOS.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[3].Value);
                    txtValorDeslocamento.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[4].Value);
                    txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[5].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                tblFaturas.Hide();
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


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string _contrato = "7062.01.2528.552/2019";
            dadofat.subtotal_os = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[3].Value);
            dadofat.subtotal_desloc = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[4].Value);
            dadofat.total = "R$ " + string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[5].Value);


            frmRPFatura rep = new frmRPFatura(_contrato, dadofat.subtotal_os, dadofat.subtotal_desloc, dadofat.total);

            for (int i = 0; i < dgvOS.Rows.Count; i++)
            {
                RepFaturaENT dat = new RepFaturaENT();
                
                dat.data_ordem = Convert.ToDateTime(dgvOS.Rows[i].Cells[0].Value);
                dat.referencia = dgvOS.Rows[i].Cells[1].Value.ToString();
                dat.atividade_cod = dgvOS.Rows[i].Cells[2].Value.ToString();
                dat.cidade = dgvOS.Rows[i].Cells[3].Value.ToString();
                dat.data_concluida = Convert.ToDateTime(dgvOS.Rows[i].Cells[6].Value);
                dat.valor_atividade = dgvOS.Rows[i].Cells[7].Value.ToString();
                dat.valor_deslocamento = dgvOS.Rows[i].Cells[8].Value.ToString();

                rep.Datos.Add(dat);
            }
            rep.ShowDialog();
        }

    }


}
