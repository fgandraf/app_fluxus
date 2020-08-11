using Arqueng.ENTIDADES;
using Arqueng.MODEL;
using Arqueng.RELATORIOS;
using System;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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


        private void ListarFatura()
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


        private void ListarOSFaturada()
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


                dat.data_ordem = Convert.ToDateTime(dgvOS.Rows[i].Cells["data_ordem"].Value);
                dat.referencia = dgvOS.Rows[i].Cells["referencia"].Value.ToString();
                dat.atividade_cod = dgvOS.Rows[i].Cells["atividade_cod"].Value.ToString();
                dat.cidade = dgvOS.Rows[i].Cells["cidade"].Value.ToString();
                dat.data_concluida = Convert.ToDateTime(dgvOS.Rows[i].Cells["data_concluida"].Value);
                dat.valor_atividade = dgvOS.Rows[i].Cells["valor_atividade"].Value.ToString();
                dat.valor_deslocamento = dgvOS.Rows[i].Cells["valor_deslocamento"].Value.ToString();

                rep.Datos.Add(dat);
            }
            rep.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //////////////////-CRIAÇÃO DO PDF-///////////////////////
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 30, 30);
            doc.AddCreationDate();
            string caminho = @"D:\pdf\" + "relatorio.pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            doc.Open();

            ////////////////////-CABEÇALHO-/////////////////////////
            /////////////////TABELA COM 2 COLUNAS
            PdfPTable tabhead = new PdfPTable(3);
            tabhead.WidthPercentage = 100;
            tabhead.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tabhead.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabhead.DefaultCell.BorderWidth = 1f;
            float[] widths = new float[] { 12f, 38f, 50f };
            tabhead.SetWidths(widths);
            //--célula do logotipo
            string simg = System.Environment.CurrentDirectory + @"\logoaye.png";
            iTextSharp.text.Image logotipo = iTextSharp.text.Image.GetInstance(simg);
            logotipo.ScaleAbsolute(50, 50);
            PdfPCell celLogo = new PdfPCell(new Phrase());
            celLogo.BorderWidth = 0f;
            celLogo.Rowspan = 2;
            celLogo.AddElement(logotipo);
            tabhead.AddCell(celLogo);
            //---célula do título
            Phrase ptitulo = new Phrase();
            ptitulo.Add(new Chunk("Relatório de Serviços Executados", FontFactory.GetFont("Calibre", 22, 3, BaseColor.BLACK)));
            PdfPCell celtitulo = new PdfPCell(ptitulo);
            celtitulo.BorderWidth = 0f;
            celtitulo.FixedHeight = 35f;
            celtitulo.Colspan = 2;
            celtitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            tabhead.AddCell(celtitulo);
            //--célula do subtítulo
            Phrase psubtitulo = new Phrase();
            psubtitulo.Add(new Chunk("Caixa Econômica Federal", FontFactory.GetFont("Calibre", 11, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY)));
            PdfPCell celsubtitulo = new PdfPCell(psubtitulo);
            celsubtitulo.BorderWidth = 0f;
            celsubtitulo.FixedHeight = 15f;
            celsubtitulo.Colspan = 2;
            celsubtitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            tabhead.AddCell(celsubtitulo);
            //---célula edital
            Phrase pedital = new Phrase();
            pedital.Add(new Chunk("Edital: ", FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY)));
            pedital.Add(new Chunk(Globais.Edital, FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)));
            PdfPCell celedital = new PdfPCell(pedital);
            celedital.Border = 2;
            celedital.BorderColor = BaseColor.LIGHT_GRAY;
            celedital.BorderWidth = 1f;
            celedital.FixedHeight = 30f;
            celedital.Colspan = 2;
            celedital.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabhead.AddCell(celedital);
            //--célula contrato
            Phrase pcontrato = new Phrase();
            pcontrato.Add(new Chunk("Contrato: ", FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY)));
            pcontrato.Add(new Chunk(Globais.Contrato, FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)));
            PdfPCell celcontrato = new PdfPCell(pcontrato);
            celcontrato.HorizontalAlignment = Element.ALIGN_RIGHT;
            celcontrato.Border = 2;
            celcontrato.BorderColor = BaseColor.LIGHT_GRAY;
            celcontrato.BorderWidth = 1f;
            celcontrato.FixedHeight = 30f;
            celcontrato.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabhead.AddCell(celcontrato);
            //--ADICIONA A TABELA
            doc.Add(tabhead);
            //////////////////-FIM DO CABEÇALHO-////////////////////


            ////////////////////-ESPAÇO-/////////////////////////
            Paragraph espaco = new Paragraph();
            espaco.Add("\n\n");
            doc.Add(espaco);
            //////////////////-FIM DO ESPAÇO-////////////////////


            ////////////////////-CORPO-/////////////////////////
            /////////////////TABELA COM 7 COLUNAS
            PdfPTable tabmain = new PdfPTable(7);
            tabmain.WidthPercentage = 100;
            tabmain.DefaultCell.BorderWidth = 1;
            widths = new float[] { 11f, 31f, 7f, 21f, 11f, 10f, 9f };
            tabmain.SetWidths(widths);
            tabmain.DefaultCell.FixedHeight = 20;
            tabmain.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            PdfPCell celula;

            //---PROFISSIONAL---//
            Phrase phpro = new Phrase();
            phpro.Add(new Chunk("Profissional: Nome do Profissional", FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
            celula = new PdfPCell(phpro);
            celula.BorderWidth = 0f;
            celula.BackgroundColor = BaseColor.LIGHT_GRAY;
            celula.FixedHeight = 20f;
            celula.Colspan = 7;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabmain.AddCell(celula);

            //---TÍTULOS---//
            celula = new PdfPCell(new Phrase(new Chunk("Data da Ordem", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            celula.Border = 1 + 2 + 8;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabmain.AddCell(celula);

            celula = new PdfPCell(new Phrase(new Chunk("Referência", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabmain.AddCell(celula);

            celula = new PdfPCell(new Phrase(new Chunk("Tipo", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabmain.AddCell(celula);

            celula = new PdfPCell(new Phrase(new Chunk("Cidade", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabmain.AddCell(celula);

            celula = new PdfPCell(new Phrase(new Chunk("Data da Conclusão", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabmain.AddCell(celula);

            celula = new PdfPCell(new Phrase(new Chunk("Valor do Serviço", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
            tabmain.AddCell(celula);

            celula = new PdfPCell(new Phrase(new Chunk("Valor do Desloc.", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            celula.Border = 1 + 2 + 4;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
            tabmain.AddCell(celula);


            //---TABELA DE DADOS---//
            for (int i = 0; i < dgvOS.Rows.Count; i++)
            {
                //--célula
                celula = new PdfPCell(
                    new Phrase(
                        new Chunk(
                            Convert.ToDateTime(dgvOS.Rows[i].Cells["data_ordem"].Value).ToString("dd/MM/yyyy"),
                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                            )
                    )
                    );
                celula.Border = 2 + 8;
                celula.BorderColor = BaseColor.GRAY;
                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                celula.FixedHeight = 20;
                tabmain.AddCell(celula);
                //--célula
                celula = new PdfPCell(
                    new Phrase(
                        new Chunk(
                            dgvOS.Rows[i].Cells["referencia"].Value.ToString(),
                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                            )
                    )
                    );
                celula.Border = 2 + 4 + 8;
                celula.BorderColor = BaseColor.GRAY;
                celula.FixedHeight = 20;
                tabmain.AddCell(celula);
                //--célula
                celula = new PdfPCell(
                    new Phrase(
                        new Chunk(
                            dgvOS.Rows[i].Cells["atividade_cod"].Value.ToString(),
                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                            )
                    )
                    );
                celula.Border = 2 + 4 + 8;
                celula.BorderColor = BaseColor.GRAY;
                celula.FixedHeight = 20;
                tabmain.AddCell(celula);
                //--célula
                celula = new PdfPCell(
                    new Phrase(
                        new Chunk(
                            dgvOS.Rows[i].Cells["cidade"].Value.ToString(),
                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                            )
                    )
                    );
                celula.Border = 2 + 4 + 8;
                celula.BorderColor = BaseColor.GRAY;
                celula.FixedHeight = 20;
                tabmain.AddCell(celula);
                //--célula
                celula = new PdfPCell(
                    new Phrase(
                        new Chunk(
                            Convert.ToDateTime(dgvOS.Rows[i].Cells["data_concluida"].Value).ToString("dd/MM/yyyy"),
                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                            )
                    )
                    );
                celula.Border = 2 + 4 + 8;
                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                celula.BorderColor = BaseColor.GRAY;
                celula.FixedHeight = 20;
                tabmain.AddCell(celula);
                //--célula
                celula = new PdfPCell(
                    new Phrase(
                        new Chunk(
                            dgvOS.Rows[i].Cells["valor_atividade"].Value.ToString(),
                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                            )
                    )
                    );
                celula.Border = 2 + 4 + 8;
                celula.BorderColor = BaseColor.GRAY;
                celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                celula.FixedHeight = 20;
                tabmain.AddCell(celula);
                //--célula
                celula = new PdfPCell(
                    new Phrase(
                        new Chunk(
                            dgvOS.Rows[i].Cells["valor_deslocamento"].Value.ToString(),
                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                            )
                    )
                    );
                celula.Border = 2 + 4;
                celula.BorderColor = BaseColor.GRAY;
                celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                celula.FixedHeight = 20;
                tabmain.AddCell(celula);
            }
            
            //---SUB-TOTAL---//
            //--célula label subtotal
            celula = new PdfPCell(
                new Phrase(
                    new Chunk(
                        "SUBTOTAL:",
                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                        )
                )
                );
            celula.Colspan = 5;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
            celula.Border = 1;
            celula.FixedHeight = 20;
            tabmain.AddCell(celula);

            //--célula subtotal valor os
            celula = new PdfPCell(
                new Phrase(
                    new Chunk(
                        string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[3].Value),
                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                        )
                )
                );
            celula.Border = 1;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
            celula.FixedHeight = 20;
            tabmain.AddCell(celula);

            //--célula subtotal valor deslocamento
            celula = new PdfPCell(
                new Phrase(
                    new Chunk(
                        string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[4].Value),
                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                        )
                )
                );
            celula.Border = 1;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
            celula.FixedHeight = 20;
            tabmain.AddCell(celula);

            //--célula label total
            celula = new PdfPCell(
                new Phrase(
                    new Chunk(
                        "TOTAL:",
                        FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
                        )
                )
                );
            celula.Colspan = 5;
            celula.VerticalAlignment = Element.ALIGN_TOP;
            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
            celula.Border = 0;
            celula.FixedHeight = 20;
            tabmain.AddCell(celula);

            //--célula valor total
            celula = new PdfPCell(
                new Phrase(
                    new Chunk(
                        "R$ " + string.Format("{0:0,0.00}", dgvFaturas.CurrentRow.Cells[5].Value),
                        FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
                        )
                )
                );
            celula.Border = 0;
            celula.Colspan = 2;
            celula.VerticalAlignment = Element.ALIGN_TOP;
            celula.HorizontalAlignment = Element.ALIGN_CENTER;
            celula.FixedHeight = 20;
            tabmain.AddCell(celula);

            //--ADICIONA A TABELA
            doc.Add(tabmain);
            //--ADICIONA ESPAÇO
            doc.Add(espaco);
            ////////////////////-FIM DO CORPO-//////////////////////










            /////////////////////-FECHA A EDIÇÃO-///////////////////
            doc.Close();
            ////////////////////////////////////////////////////////




            ////////////////////-ABRE O ARQUIVO-////////////////////
            System.Diagnostics.Process.Start(caminho);
            ////////////////////////////////////////////////////////
        }
    }


}
