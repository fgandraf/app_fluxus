using Arqueng.ENTIDADES;
using Arqueng.MODEL;
using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Arqueng.RELATORIOS;
using System.Linq;

namespace Arqueng.VIEW
{


    public partial class frmFaturas : Form
    {
        //FaturasMODEL model = new FaturasMODEL();
        OsMODEL modelOS = new OsMODEL();
        OsENT dado = new OsENT();
        FaturasENT dadofat = new FaturasENT();
        private decimal Subtotal_os = 0;
        private decimal Subtotal_desloc = 0;
        private decimal Total = 0;


        //:METHODS
        private void ListarFatura()
        {
            try
            {
                FaturasMODEL model = new FaturasMODEL();
                dgvFaturas.DataSource = model.ListarFaturaModel();
                if (dgvFaturas.Rows.Count > 0)
                {
                    tblFaturas.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarOS()
        {
            if (dgvFaturas.Rows.Count > 0)
            {
                try
                {
                    OsENT dado = new OsENT();
                    OsMODEL model = new OsMODEL();


                    dgvOS.DataSource = model.ListarOSFaturaModel(dgvFaturas.CurrentRow.Cells[0].Value.ToString(), false);


                    //DataView dvOS = new DataView(DT.OSFatura);
                    //dvOS.RowFilter = String.Format("fatura_cod = '{0}'", dgvFaturas.CurrentRow.Cells[0].Value.ToString());
                    //dgvOS.DataSource = dvOS;



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


        }
        private void SomarValores()
        {
            Subtotal_os = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_atividade.Name].Value ?? 0));
            Subtotal_desloc = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valor_deslocamento.Name].Value ?? 0));
            Total = Subtotal_os + Subtotal_desloc;
        }
        private DataTable Profissionais()
        {
            DataTable dt = new DataTable();
            try
            {
                dado.Fatura_cod = dgvFaturas.CurrentRow.Cells[0].Value.ToString();
                dt = modelOS.DistinctProOSFaturadaModel(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }




        //:EVENTS
        ///_______Form
        public frmFaturas()
        {
            InitializeComponent();
        }

        private void frmFaturas_Load(object sender, EventArgs e)
        {
            ListarFatura();
            ListarOS();
            if (Globais.Rl)
            {
                btnRemoverOs.Show();
                btnExcluir.Show();
            }
        }





        ///_______Button
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string caminho;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = saveFileDialog.FileName;
                //CONVERTER bytes[] EM Imagem
                System.Drawing.Image logoImagem;
                using (var stream = new MemoryStream(Globais.Logo))
                    logoImagem = System.Drawing.Image.FromStream(stream);
                //CHAMAR O MÉTODO
                itsFatura.GerarFaturaPDF
                (
                logoImagem,
                Globais.Edital,
                Globais.Contrato,
                Globais.Razao,
                Globais.Cnpj,
                Profissionais(),
                (DataTable)dgvOS.DataSource,
                caminho
                );
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
                return;
            else
            {
                var result = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells[1].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells[5].Value.ToString() + "\n\n" + "A fatura será recalculada e a Ordem de Serviço retornará ao fluxo de trabalho.", "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //ALTERA PARA ZERO O FATURA_COD
                    OsMODEL modelOS = new OsMODEL();
                    modelOS.UpdateOsFaturadaModel(dgvOS.CurrentRow.Cells[1].Value.ToString(), "0");

                    //APAGA DO DATAGRIDVIEW
                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);

                    //RE-SOMA E APLICA OS VALORES NA TELA
                    SomarValores();
                    txtValorOS.Text = string.Format("{0:0,0.00}", Subtotal_os);
                    txtValorDeslocamento.Text = string.Format("{0:0,0.00}", Subtotal_desloc);
                    txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", Total);


                    //APLICA OS NOVOS VALORES À TABELA DE FATURA
                    FaturasENT dadofat = new FaturasENT();
                    FaturasMODEL modelFat = new FaturasMODEL();
                    dadofat.id = Convert.ToInt32(dgvFaturas.CurrentRow.Cells[0].Value);
                    dadofat.subtotal_os = Subtotal_os.ToString();
                    dadofat.subtotal_desloc = Subtotal_desloc.ToString();
                    dadofat.total = Total.ToString();
                    modelFat.UpdateFaturaValoresModel(dadofat);
                }
            }
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                MessageBox.Show("Não é possível excluir uma fatura que possua ordens vinculadas", "Excluir Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var result = MessageBox.Show("Deseja excluir a Fatura?" + "\n\n" + dgvFaturas.CurrentRow.Cells[1].Value.ToString(), "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    FaturasENT dadoFat = new FaturasENT();
                    FaturasMODEL modelFat = new FaturasMODEL();
                    dadoFat.id = Convert.ToInt32(dgvFaturas.CurrentRow.Cells[0].Value);
                    modelFat.DeleteFaturaModel(dadoFat);
                    ListarFatura();
                }
            }
        }





        ///_______DataGridView
        private void dgvFaturas_MouseClick(object sender, MouseEventArgs e)
        {
            ListarOS();
        }


    }



}