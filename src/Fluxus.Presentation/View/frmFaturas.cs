using Fluxus.Domain.Entities;
using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Linq;
using Fluxus.Services;
using System.Globalization;

namespace Fluxus.Presentation.View
{
    public partial class frmFaturas : Form
    {

        private double _subtotal_os = 0.00;
        private double _subtotal_desloc = 0.00;



        //:METHODS
        private void ListarFatura()
        {
            try
            {
                dgvFaturas.DataSource = new FaturaService().ListarFatura();


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
                    dgvOS.DataSource = new OsService().GetOrdensFaturadasDoCodigo(Convert.ToInt64(dgvFaturas.CurrentRow.Cells["id_fat"].Value));

                    txtData.Text = dgvFaturas.CurrentRow.Cells[2].Value.ToString();
                    txtValorOS.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[3].Value);
                    txtValorDeslocamento.Text = string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[4].Value);
                    txtValorTotal.Text = String.Format(new CultureInfo("pt-BR"), "{0:c}", dgvFaturas.CurrentRow.Cells[5].Value);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void SomarValores()
        {
            _subtotal_os = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[valor_atividade.Name].Value ?? 0));
            _subtotal_desloc = dgvOS.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDouble(i.Cells[valor_deslocamento.Name].Value ?? 0));
        }

        private Fatura PopulateObject()
        {
            Fatura dado = new Fatura
            {
                Id = Convert.ToInt64(dgvFaturas.CurrentRow.Cells["id_fat"].Value),
                SubtotalOs = _subtotal_os,
                SubtotalDeslocamento = _subtotal_desloc,
                Total = _subtotal_os + _subtotal_desloc
            };

            return dado;
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
            if (Logged.Rl)
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


                //BUSCAR DADOS DA EMPRESA PARA IMPRESSAO
                DataRow[] dadosDaEmpresa = (new CadastraisService().DadosParaImpressao()).Select();
                string razao = dadosDaEmpresa[0]["razao"].ToString();
                string edital = dadosDaEmpresa[0]["ct_edital"].ToString();
                string contrato = dadosDaEmpresa[0]["ct_contrato"].ToString();
                string cnpj = dadosDaEmpresa[0]["cnpj"].ToString();
                byte[] logo = Convert.FromBase64String(dadosDaEmpresa[0]["logo"].ToString());



                //CONVERTER bytes[] EM Imagem
                System.Drawing.Image logoImagem;
                using (var stream = new MemoryStream(logo))
                    logoImagem = System.Drawing.Image.FromStream(stream);


                long fatura_cod = Convert.ToInt64(dgvFaturas.CurrentRow.Cells["id_fat"].Value);

                //CHAMAR O MÉTODO
                InvoiceReport.PrintPDF
                (
                logoImagem,
                edital,
                contrato,
                razao,
                cnpj,
                new OsService().GetProfissionaisDaFatura(fatura_cod),
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
                var result = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells[2].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells[6].Value.ToString() + "\n\n" + "A fatura será recalculada e a Ordem de Serviço retornará ao fluxo de trabalho.", "Remover O.S.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //ALTERA PARA ZERO O FATURA_COD
                    new OsService().UpdateFaturaCod(Convert.ToInt64(dgvOS.CurrentRow.Cells["id_os"].Value), 0);


                    //APAGA DO DATAGRIDVIEW
                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);


                    //RE-SOMA E APLICA OS VALORES NA TELA
                    SomarValores();
                    txtValorOS.Text = string.Format("{0:0,0.00}", _subtotal_os);
                    txtValorDeslocamento.Text = string.Format("{0:0,0.00}", _subtotal_desloc);
                    txtValorTotal.Text = "R$ " + string.Format("{0:0,0.00}", _subtotal_os + _subtotal_desloc);


                    //APLICA OS NOVOS VALORES À TABELA DE FATURA
                    Fatura dado = PopulateObject();
                    new FaturaService().Update(dado);

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
                    new FaturaService().Delete((Convert.ToInt64(dgvFaturas.CurrentRow.Cells["id_fat"].Value)));
                    ListarFatura();
                    ListarOS();
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