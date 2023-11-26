using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using Fluxus.Domain.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Fluxus.App.Services
{
    public class ReportService
    {
        public void PrintPDF(System.Drawing.Image logo, Profile profile, DataTable professionals, DataTable serviceOrders, string path)
        {
            var fontTitle = FontFactory.GetFont("Calibre", 22, Font.BOLD + Font.ITALIC, BaseColor.BLACK);
            var fontSubtitle = FontFactory.GetFont("Calibre", 9, Font.BOLD, BaseColor.BLACK);
            var fontRegular = FontFactory.GetFont("Calibre", 8, Font.NORMAL, BaseColor.DARK_GRAY);
            var fontStrong = FontFactory.GetFont("Calibre", 8, Font.BOLD, BaseColor.DARK_GRAY);

            double subtotal_os = 0.00;
            double subtotal_deslocamento = 0.00;
            double total = 0.00;

            float[] widths;

            Image imagem = Image.GetInstance(logo, BaseColor.WHITE);
            imagem.ScaleAbsolute(50, 50);



            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 30, 30);
            doc.AddCreationDate();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();


            #region HEADER
            PdfPTable tabhead = new PdfPTable(3);
            tabhead.WidthPercentage = 100;
            widths = new float[] { 30f, 40f, 30f };
            tabhead.SetWidths(widths);


            var hLogotipo = new PdfPCell
            {
                Border = 2,
                BorderColor = BaseColor.LIGHT_GRAY,
                BorderWidth = 1f,
                Rowspan = 2,
            };
            hLogotipo.AddElement(imagem);
            tabhead.AddCell(hLogotipo);

            var hTitulo = new PdfPCell()
            {
                BorderWidth = 0f,
                FixedHeight = 35f,
                Colspan = 2,
                HorizontalAlignment = Element.ALIGN_LEFT,
                Phrase = new Phrase(new Chunk("Relatório de Serviços Executados", fontTitle))
            };
            tabhead.AddCell(hTitulo);

            var hRazaoSocial = new PdfPCell()
            {
                Border = 2,
                BorderColor = BaseColor.LIGHT_GRAY,
                BorderWidth = 1f,
                FixedHeight = 20f,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Phrase = new Phrase(new Chunk(profile.CompanyName, fontSubtitle))
            };
            tabhead.AddCell(hRazaoSocial);

            var hCnpj = new PdfPCell()
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 2,
                BorderColor = BaseColor.LIGHT_GRAY,
                BorderWidth = 1f,
                FixedHeight = 20f,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Phrase = new Phrase(new Chunk("CNPJ: " + profile.Cnpj, fontSubtitle))
            };
            tabhead.AddCell(hCnpj);

            PdfPCell hEdital = new PdfPCell()
            {
                Border = 0,
                BorderColor = BaseColor.LIGHT_GRAY,
                FixedHeight = 15f,
                Colspan = 2,
                VerticalAlignment = Element.ALIGN_TOP,
                Phrase = new Phrase(new Chunk("Edital: " + profile.ContractNotice, fontRegular))
            };
            tabhead.AddCell(hEdital);

            PdfPCell hContrato = new PdfPCell()
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0,
                BorderColor = BaseColor.LIGHT_GRAY,
                FixedHeight = 15f,
                VerticalAlignment = Element.ALIGN_TOP,
                Phrase = new Phrase(new Chunk("Contrato: " + profile.ContractNumber, fontRegular))
            };
            tabhead.AddCell(hContrato);

            doc.Add(tabhead);
            #endregion


            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));


            #region TABLES

            for (int i = 1; i <= professionals.Rows.Count; i++)
            {
                widths = new float[] { 11f, 31f, 7f, 21f, 11f, 10f, 9f };

                PdfPTable tabmain = new PdfPTable(7);
                tabmain.WidthPercentage = 100;
                tabmain.DefaultCell.BorderWidth = 1;
                tabmain.SetWidths(widths);
                tabmain.DefaultCell.FixedHeight = 20;
                tabmain.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                DataRow[] dataRowPro = professionals.Select();

                /////////////////LINHA - NOME DO PROFISSIONAL
                var cellProfessionalHeader = new PdfPCell
                {
                    Border = 2,
                    BorderWidth = 1f,
                    BackgroundColor = BaseColor.LIGHT_GRAY,
                    Colspan = 7,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    FixedHeight = 20,
                    Phrase = new Phrase(new Chunk("Profissional: " + dataRowPro[i - 1]["nameid"].ToString(), fontSubtitle))
                };

                tabmain.AddCell(cellProfessionalHeader);

                /////////////////LINHA - TÍTULOS
                var cellListHeader = new PdfPCell
                {
                    Border = 2 + 4 + 8,
                    BorderColor = BaseColor.GRAY,
                    FixedHeight = 20,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    HorizontalAlignment = Element.ALIGN_CENTER
                };

                cellListHeader.Phrase = new Phrase(new Chunk("Data da Ordem", fontStrong));
                tabmain.AddCell(cellListHeader);

                cellListHeader.Phrase = new Phrase(new Chunk("Referência", fontStrong));
                tabmain.AddCell(cellListHeader);

                cellListHeader.Phrase = new Phrase(new Chunk("Tipo", fontStrong));
                tabmain.AddCell(cellListHeader);

                cellListHeader.Phrase = new Phrase(new Chunk("Cidade", fontStrong));
                tabmain.AddCell(cellListHeader);

                cellListHeader.Phrase = new Phrase(new Chunk("Data da Conclusão", fontStrong));
                tabmain.AddCell(cellListHeader);

                cellListHeader.Phrase = new Phrase(new Chunk("Valor do Serviço", fontStrong));
                tabmain.AddCell(cellListHeader);

                cellListHeader.Phrase = new Phrase(new Chunk("Valor do Desloc.", fontStrong));
                tabmain.AddCell(cellListHeader);

                /////////////////CÉLULAS - POPULAR
                var cellListBody = new PdfPCell
                {
                    Border = 2 + 4 + 8,
                    BorderColor = BaseColor.GRAY,
                    FixedHeight = 20,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    HorizontalAlignment = Element.ALIGN_LEFT
                };

                DataRow[] dataRow = serviceOrders.Select("professionalId = '" + dataRowPro[i - 1]["professionalId"].ToString() + "'");
                for (int l = 0; l < dataRow.Length; l++)
                {
                    string value = string.Empty;

                    value = Convert.ToDateTime(dataRow[l]["orderDate"]).ToString("dd/MM/yyyy");
                    cellListBody.Phrase = new Phrase(new Chunk(value, fontRegular));
                    tabmain.AddCell(cellListBody);

                    value = dataRow[l]["referenceCode"].ToString();
                    cellListBody.Phrase = new Phrase(new Chunk(value, fontRegular));
                    tabmain.AddCell(cellListBody);

                    value = dataRow[l]["service"].ToString();
                    cellListBody.Phrase = new Phrase(new Chunk(value, fontRegular));
                    tabmain.AddCell(cellListBody);

                    value = dataRow[l]["city"].ToString();
                    cellListBody.Phrase = new Phrase(new Chunk(value, fontRegular));
                    tabmain.AddCell(cellListBody);

                    value = Convert.ToDateTime(dataRow[l]["doneDate"]).ToString("dd/MM/yyyy");
                    cellListBody.Phrase = new Phrase(new Chunk(value, fontRegular));
                    tabmain.AddCell(cellListBody);

                    value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", dataRow[l]["serviceAmount"]);
                    cellListBody.Phrase = new Phrase(new Chunk(value, fontRegular));
                    tabmain.AddCell(cellListBody);

                    value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", dataRow[l]["mileageAllowance"]);
                    cellListBody.Phrase = new Phrase(new Chunk(value, fontRegular));
                    tabmain.AddCell(cellListBody);
                }


                /////////////////CÉLULAS - TOTAIS PARCIAIS

                //--célula subtotal ESPAÇO DAS PRIMEIRAS COLUNAS
                var labelSubtotal = new PdfPCell()
                {
                    Colspan = 5,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Border = 1,
                    FixedHeight = 12,
                    Phrase = new Phrase(new Chunk("", fontRegular))
                };
                tabmain.AddCell(labelSubtotal);



                //--célula subtotal valor os
                double somavaloratividade = double.Parse(serviceOrders.Compute("Sum(serviceAmount)", "professionalId = '" + dataRowPro[i - 1]["professionalId"].ToString() + "'").ToString());
                subtotal_os += somavaloratividade;
                var subTotalOrder = new PdfPCell()
                {
                    Border = 1,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    FixedHeight = 12,
                    Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", somavaloratividade), fontRegular))
                };
                tabmain.AddCell(subTotalOrder);



                //--célula subtotal valor deslocamento
                double somavalordeslocamento = double.Parse(serviceOrders.Compute("Sum(mileageAllowance)", "professionalId = '" + dataRowPro[i - 1]["professionalId"].ToString() + "'").ToString());
                subtotal_deslocamento += somavalordeslocamento;
                var subTotalDeslocamento = new PdfPCell()
                {
                    Border = 1,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    FixedHeight = 12,
                    Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", somavalordeslocamento), fontRegular))
                };
                tabmain.AddCell(subTotalDeslocamento);



                //--célula label total ESPAÇO DAS PRIMEIRAS COLUNAS
                var subTotalLabel = new PdfPCell()
                {
                    Colspan = 5,
                    VerticalAlignment = Element.ALIGN_TOP,
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Border = 0,
                    FixedHeight = 16,
                    Phrase = new Phrase(new Chunk("", fontRegular))
                };
                tabmain.AddCell(subTotalLabel);



                //--célula valor total
                double somatotal = somavaloratividade + somavalordeslocamento;
                total += somatotal;
                var subTotal = new PdfPCell()
                {
                    Border = 1,
                    BorderColor = BaseColor.GRAY,
                    Colspan = 2,
                    VerticalAlignment = Element.ALIGN_TOP,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    FixedHeight = 16,
                    Phrase = new Phrase(new Chunk("R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", somatotal), fontRegular))
                };
                tabmain.AddCell(subTotal);

                doc.Add(tabmain);
            }

            #endregion


            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));


            #region TOTALS

            PdfPTable tabTotal = new PdfPTable(3);
            tabTotal.WidthPercentage = 100;
            tabTotal.DefaultCell.BorderWidth = 1;
            float[] largura = new float[] { 81, 10f, 9f };
            tabTotal.SetWidths(largura);
            tabTotal.DefaultCell.FixedHeight = 20;
            tabTotal.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;


            var totalSubtitle = new PdfPCell()
            {
                BorderWidth = 0f,
                BackgroundColor = BaseColor.CYAN,
                FixedHeight = 20f,
                Colspan = 3,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Phrase = new Phrase(new Chunk("VALOR TOTAL DA FATURA", fontSubtitle))
            };
            tabTotal.AddCell(totalSubtitle);


            var subTotalLabel2 = new PdfPCell()
            {
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 1,
                FixedHeight = 20,
                Phrase = new Phrase(new Chunk("SUBTOTAL:", fontSubtitle))
            };
            tabTotal.AddCell(subTotalLabel2);


            var subTotalOS2 = new PdfPCell()
            {
                Border = 1,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                FixedHeight = 20,
                Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", subtotal_os), fontSubtitle))
            };
            tabTotal.AddCell(subTotalOS2);


            var subTotalDeslocamento2 = new PdfPCell()
            {
                Border = 1,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                FixedHeight = 20,
                Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", subtotal_deslocamento), fontSubtitle))
            };
            tabTotal.AddCell(subTotalDeslocamento2);


            var totalLabel2 = new PdfPCell()
            {
                Border = 2,
                VerticalAlignment = Element.ALIGN_TOP,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                FixedHeight = 25,
                Phrase = new Phrase(new Chunk("TOTAL:", fontSubtitle))
            };
            tabTotal.AddCell(totalLabel2);


            var totalOS2 = new PdfPCell()
            {
                Border = 1,
                BorderColor = BaseColor.GRAY,
                Colspan = 2,
                VerticalAlignment = Element.ALIGN_TOP,
                HorizontalAlignment = Element.ALIGN_CENTER,
                FixedHeight = 25,
                Phrase = new Phrase(new Chunk("R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", total), fontSubtitle))
            };
            tabTotal.AddCell(totalOS2);


            var linhaFinal = new PdfPCell()
            {
                Border = 1,
                Colspan = 3,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                BackgroundColor = BaseColor.CYAN,
                FixedHeight = 10,
                Phrase = new Phrase()
            };
            tabTotal.AddCell(linhaFinal);

            #endregion


            doc.Add(tabTotal);
            doc.Close();

            Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });

        }

    }
}
