using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Fluxus.Services
{
    public class InvoiceReport
    {

        public static void PrintPDF (System.Drawing.Image logotipo, string edital, string contrato, string razaosocial, string cnpj, DataTable dtPro, DataTable dtOS, string caminho)
        {

            //////////////////-CRIAÇÃO DO PDF-///////////////////////
            {

                Document doc = new Document(PageSize.A4);
                doc.SetMargins(40, 40, 30, 30);
                doc.AddCreationDate();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.Open();
                Paragraph espaco = new Paragraph();
                espaco.Add("\n");
                PdfPCell celula;
                double subtotal_os = 0.00;
                double subtotal_deslocamento = 0.00;
                double total = 0.00;


                ////////////////////-CABEÇALHO-/////////////////////////
                {
                    PdfPTable tabhead = new PdfPTable(3);
                    tabhead.WidthPercentage = 100;
                    tabhead.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabhead.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabhead.DefaultCell.BorderWidth = 1f;
                    float[] widths = new float[] { 30f, 40f, 30f };
                    tabhead.SetWidths(widths);
                    //--célula do logotipo
                    iTextSharp.text.Image imagem = iTextSharp.text.Image.GetInstance(logotipo, System.Drawing.Imaging.ImageFormat.Png);
                    imagem.ScaleAbsolute(50, 50);
                    PdfPCell celLogo = new PdfPCell(new Phrase());
                    celLogo.Border = 2;
                    celLogo.BorderColor = BaseColor.LIGHT_GRAY;
                    celLogo.BorderWidth = 1f;
                    celLogo.Rowspan = 2;
                    celLogo.AddElement(imagem);
                    tabhead.AddCell(celLogo);
                    //---célula do título
                    Phrase ptitulo = new Phrase();
                    ptitulo.Add(new Chunk("Relatório de Serviços Executados", FontFactory.GetFont("Calibre", 22, 3, BaseColor.BLACK)));
                    PdfPCell celtitulo = new PdfPCell(ptitulo);
                    celtitulo.BorderWidth = 0f;
                    celtitulo.FixedHeight = 35f;
                    celtitulo.Colspan = 2;
                    celtitulo.HorizontalAlignment = Element.ALIGN_LEFT;
                    tabhead.AddCell(celtitulo);
                    //---célula razao
                    Phrase prazao = new Phrase();
                    prazao.Add(new Chunk(razaosocial, FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY)));
                    PdfPCell celrazao = new PdfPCell(prazao);
                    celrazao.Border = 2;
                    celrazao.BorderColor = BaseColor.LIGHT_GRAY;
                    celrazao.BorderWidth = 1f;
                    celrazao.FixedHeight = 20f;
                    celrazao.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabhead.AddCell(celrazao);
                    //--célula cnpj
                    Phrase pncpj = new Phrase();
                    pncpj.Add(new Chunk("CNPJ: " + cnpj, FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY)));
                    PdfPCell celcnpj = new PdfPCell(pncpj);
                    celcnpj.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celcnpj.Border = 2;
                    celcnpj.BorderColor = BaseColor.LIGHT_GRAY;
                    celcnpj.BorderWidth = 1f;
                    celcnpj.FixedHeight = 20f;
                    celcnpj.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabhead.AddCell(celcnpj);
                    //---célula edital
                    Phrase pedital = new Phrase();
                    pedital.Add(new Chunk("Edital: ", FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.GRAY)));
                    pedital.Add(new Chunk(edital, FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.GRAY)));
                    PdfPCell celedital = new PdfPCell(pedital);
                    celedital.Border = 0;
                    celedital.BorderColor = BaseColor.LIGHT_GRAY;
                    celedital.FixedHeight = 15f;
                    celedital.Colspan = 2;
                    celedital.VerticalAlignment = Element.ALIGN_TOP;
                    tabhead.AddCell(celedital);
                    //--célula contrato
                    Phrase pcontrato = new Phrase();
                    pcontrato.Add(new Chunk("Contrato: ", FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.GRAY)));
                    pcontrato.Add(new Chunk(contrato, FontFactory.GetFont("Calibre", 9, iTextSharp.text.Font.BOLD, BaseColor.GRAY)));
                    PdfPCell celcontrato = new PdfPCell(pcontrato);
                    celcontrato.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celcontrato.Border = 0;
                    celcontrato.BorderColor = BaseColor.LIGHT_GRAY;
                    celcontrato.FixedHeight = 15f;
                    celcontrato.VerticalAlignment = Element.ALIGN_TOP;
                    tabhead.AddCell(celcontrato);
                    //--ADICIONA A TABELA
                    doc.Add(tabhead);
                    doc.Add(espaco);
                    doc.Add(espaco);
                }


                //////////-TABELA PARA CADA PROFISSIONAL-///////////////
                {
                    for (int i = 1; i <= dtPro.Rows.Count; i++)
                    {
                        PdfPTable tabmain = new PdfPTable(7);
                        tabmain.WidthPercentage = 100;
                        tabmain.DefaultCell.BorderWidth = 1;
                        float[] widths = new float[] { 11f, 31f, 7f, 21f, 11f, 10f, 9f };
                        tabmain.SetWidths(widths);
                        tabmain.DefaultCell.FixedHeight = 20;
                        tabmain.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        DataRow[] dataRowPro = dtPro.Select();


                        /////////////////LINHA - NOME DO PROFISSIONAL
                        {
                            Phrase phpro = new Phrase();
                            phpro.Add(new Chunk("Profissional: " + dataRowPro[i - 1]["nameid"].ToString(), FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                            celula = new PdfPCell(phpro);
                            celula.Border = 2;
                            celula.BorderWidth = 1f;
                            celula.BackgroundColor = BaseColor.LIGHT_GRAY;
                            celula.Colspan = 7;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            tabmain.AddCell(celula);
                        }


                        /////////////////LINHA - TÍTULOS
                        {
                            celula = new PdfPCell(new Phrase(new Chunk("Data da Ordem", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY))));
                            celula.Border = 2 + 8;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.HorizontalAlignment = Element.ALIGN_CENTER;
                            celula.BorderColor = BaseColor.GRAY;
                            tabmain.AddCell(celula);

                            celula = new PdfPCell(new Phrase(new Chunk("Referência", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY))));
                            celula.Border = 2 + 4 + 8;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.BorderColor = BaseColor.GRAY;
                            tabmain.AddCell(celula);

                            celula = new PdfPCell(new Phrase(new Chunk("Tipo", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY))));
                            celula.Border = 2 + 4 + 8;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.BorderColor = BaseColor.GRAY;
                            tabmain.AddCell(celula);

                            celula = new PdfPCell(new Phrase(new Chunk("Cidade", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY))));
                            celula.Border = 2 + 4 + 8;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.BorderColor = BaseColor.GRAY;
                            tabmain.AddCell(celula);

                            celula = new PdfPCell(new Phrase(new Chunk("Data da Conclusão", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY))));
                            celula.Border = 2 + 4 + 8;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.HorizontalAlignment = Element.ALIGN_CENTER;
                            celula.BorderColor = BaseColor.GRAY;
                            tabmain.AddCell(celula);

                            celula = new PdfPCell(new Phrase(new Chunk("Valor do Serviço", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY))));
                            celula.Border = 2 + 4 + 8;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.HorizontalAlignment = Element.ALIGN_CENTER;
                            celula.BorderColor = BaseColor.GRAY;
                            tabmain.AddCell(celula);

                            celula = new PdfPCell(new Phrase(new Chunk("Valor do Desloc.", FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY))));
                            celula.Border = 2 + 4;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.HorizontalAlignment = Element.ALIGN_CENTER;
                            celula.BorderColor = BaseColor.GRAY;
                            tabmain.AddCell(celula);
                        }

                        
                        /////////////////CÉLULAS - POPULAR
                        {
                            DataRow[] dataRow = dtOS.Select("professionalId = '" + dataRowPro[i - 1]["professionalId"].ToString() + "'");
                            for (int l = 0; l < dataRow.Length; l++)
                            {
                                //--célula
                                celula = new PdfPCell(new Phrase(new Chunk(
                                    Convert.ToDateTime(dataRow[l]["orderDate"]).ToString("dd/MM/yyyy"),
                                    FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY))));
                                celula.Border = 2 + 8;
                                celula.BorderColor = BaseColor.LIGHT_GRAY;
                                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                                celula.FixedHeight = 20;
                                tabmain.AddCell(celula);
                                //--célula
                                celula = new PdfPCell(
                                    new Phrase(
                                        new Chunk(
                                             dataRow[l]["referenceCode"].ToString(),
                                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)
                                            )
                                    )
                                    );
                                celula.Border = 2 + 4 + 8;
                                celula.BorderColor = BaseColor.LIGHT_GRAY;
                                celula.FixedHeight = 20;
                                tabmain.AddCell(celula);
                                //--célula
                                celula = new PdfPCell(
                                    new Phrase(
                                        new Chunk(
                                            dataRow[l]["service"].ToString(),
                                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)
                                            )
                                    )
                                    );
                                celula.Border = 2 + 4 + 8;
                                celula.BorderColor = BaseColor.LIGHT_GRAY;
                                celula.FixedHeight = 20;
                                tabmain.AddCell(celula);
                                //--célula
                                celula = new PdfPCell(
                                    new Phrase(
                                        new Chunk(
                                            dataRow[l]["city"].ToString(),
                                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)
                                            )
                                    )
                                    );
                                celula.Border = 2 + 4 + 8;
                                celula.BorderColor = BaseColor.LIGHT_GRAY;
                                celula.FixedHeight = 20;
                                tabmain.AddCell(celula);
                                //--célula
                                celula = new PdfPCell(
                                    new Phrase(
                                        new Chunk(
                                            Convert.ToDateTime(
                                                dataRow[l]["doneDate"]).ToString("dd/MM/yyyy"),
                                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)
                                            )
                                    )
                                    );
                                celula.Border = 2 + 4 + 8;
                                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                                celula.BorderColor = BaseColor.LIGHT_GRAY;
                                celula.FixedHeight = 20;
                                tabmain.AddCell(celula);
                                //--célula
                                celula = new PdfPCell(
                                    new Phrase(
                                        new Chunk(
                                            string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", dataRow[l]["serviceAmount"]),
                                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)
                                            )
                                    )
                                    );
                                celula.Border = 2 + 4 + 8;
                                celula.BorderColor = BaseColor.LIGHT_GRAY;
                                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                                celula.FixedHeight = 20;
                                tabmain.AddCell(celula);
                                //--célula
                                celula = new PdfPCell(
                                    new Phrase(
                                        new Chunk(
                                            string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", dataRow[l]["mileageAllowance"]),
                                            FontFactory.GetFont("Calibre", 09, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)
                                            )
                                    )
                                    );
                                celula.Border = 2 + 4;
                                celula.BorderColor = BaseColor.LIGHT_GRAY;
                                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                                celula.FixedHeight = 20;
                                tabmain.AddCell(celula);
                            }
                        }


                        /////////////////CÉLULAS - TOTAIS PARCIAIS
                        {
                            //--célula label subtotal
                            celula = new PdfPCell(new Phrase(new Chunk(
                                        "",
                                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))));
                            celula.Colspan = 5;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                            celula.Border = 1;
                            celula.FixedHeight = 12;
                            tabmain.AddCell(celula);

                            //--célula subtotal valor os
                            double somavaloratividade = double.Parse(dtOS.Compute("Sum(serviceAmount)", "professionalId = '" + dataRowPro[i - 1]["professionalId"].ToString() + "'").ToString());
                            subtotal_os += somavaloratividade;
                            celula = new PdfPCell(new Phrase(new Chunk(
                                        string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", somavaloratividade),
                                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))));
                            celula.Border = 1;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.HorizontalAlignment = Element.ALIGN_CENTER;
                            celula.FixedHeight = 12;
                            tabmain.AddCell(celula);

                            //--célula subtotal valor deslocamento
                            double somavalordeslocamento = double.Parse(dtOS.Compute("Sum(mileageAllowance)", "professionalId = '" + dataRowPro[i - 1]["professionalId"].ToString() + "'").ToString());
                            subtotal_deslocamento += somavalordeslocamento;
                            celula = new PdfPCell(new Phrase(new Chunk(
                                        string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", somavalordeslocamento),
                                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))));
                            celula.Border = 1;
                            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celula.HorizontalAlignment = Element.ALIGN_CENTER;
                            celula.FixedHeight = 12;
                            tabmain.AddCell(celula);

                            //--célula label total
                            celula = new PdfPCell(new Phrase(new Chunk(
                                        "",
                                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
                            celula.Colspan = 5;
                            celula.VerticalAlignment = Element.ALIGN_TOP;
                            celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                            celula.Border = 0;
                            celula.FixedHeight = 16;
                            tabmain.AddCell(celula);

                            //--célula valor total
                            double somatotal = somavaloratividade + somavalordeslocamento;
                            total += somatotal;
                            celula = new PdfPCell(new Phrase(new Chunk(
                                        "R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", somatotal),
                                        FontFactory.GetFont("Calibre", 08, iTextSharp.text.Font.BOLD, BaseColor.BLACK)))); ;
                            celula.Border = 1;
                            celula.BorderColor = BaseColor.GRAY;
                            celula.Colspan = 2;
                            celula.VerticalAlignment = Element.ALIGN_TOP;
                            celula.HorizontalAlignment = Element.ALIGN_CENTER;
                            celula.FixedHeight = 16;
                            tabmain.AddCell(celula);
                        }


                        doc.Add(tabmain);
                        doc.Add(espaco);
                        
                    }
                }
                        

                /////////////-TABELA COM VALOR TOTAL-//////////////////
                {
                    doc.Add(espaco);
                    doc.Add(espaco);
                    doc.Add(espaco);
                    PdfPTable tabTotal = new PdfPTable(3);
                    tabTotal.WidthPercentage = 100;
                    tabTotal.DefaultCell.BorderWidth = 1;
                    float[] largura = new float[] { 81, 10f, 9f };
                    tabTotal.SetWidths(largura);
                    tabTotal.DefaultCell.FixedHeight = 20;
                    tabTotal.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                    //---célula do título
                    Phrase phTotalFatura = new Phrase();
                    phTotalFatura.Add(new Chunk("VALOR TOTAL DA FATURA", FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                    celula = new PdfPCell(phTotalFatura);
                    celula.BorderWidth = 0f;
                    celula.BackgroundColor = BaseColor.CYAN;
                    celula.FixedHeight = 20f;
                    celula.Colspan = 3;
                    celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabTotal.AddCell(celula);

                    //--célula label subtotal
                    celula = new PdfPCell(new Phrase(new Chunk(
                                "SUBTOTAL:",
                                FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))));
                    celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.Border = 1;
                    celula.FixedHeight = 20;
                    tabTotal.AddCell(celula);

                    //--célula subtotal valor os
                    celula = new PdfPCell(new Phrase(new Chunk(
                                string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", subtotal_os),
                                FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))));
                    celula.Border = 1;
                    celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.FixedHeight = 20;
                    tabTotal.AddCell(celula);

                    //--célula subtotal valor deslocamento
                    celula = new PdfPCell(new Phrase(new Chunk(
                                string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", subtotal_deslocamento),
                                FontFactory.GetFont("Calibre", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))));
                    celula.Border = 1;
                    celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.FixedHeight = 20;
                    tabTotal.AddCell(celula);

                    //--célula label total
                    celula = new PdfPCell(new Phrase(new Chunk(
                                "TOTAL:",
                                FontFactory.GetFont("Calibre", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
                    celula.VerticalAlignment = Element.ALIGN_TOP;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.Border = 2;
                    celula.FixedHeight = 25;
                    tabTotal.AddCell(celula);

                    //--célula valor total
                    celula = new PdfPCell(new Phrase(new Chunk(
                                "R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", total),
                                FontFactory.GetFont("Calibre", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
                    celula.Border = 1;
                    celula.BorderColor = BaseColor.GRAY;
                    celula.Colspan = 2;
                    celula.VerticalAlignment = Element.ALIGN_TOP;
                    celula.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula.FixedHeight = 25;
                    tabTotal.AddCell(celula);



                    celula = new PdfPCell(new Phrase());
                    celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.Colspan = 3;
                    celula.Border = 1;
                    celula.BackgroundColor = BaseColor.CYAN;
                    celula.FixedHeight = 10;
                    tabTotal.AddCell(celula);



                    doc.Add(tabTotal);
                }


                doc.Close();

                Process.Start(new ProcessStartInfo { FileName = caminho, UseShellExecute = true });
            }
        }


    }
}
