using Fluxus.Domain.Contracts.Services;
using Fluxus.Domain.ViewModels;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using Font = iTextSharp.text.Font;
using Document = iTextSharp.text.Document;
using System.Diagnostics;


namespace Fluxus.Infra.Services;

public class TextSharpPdf : IPdfReport
{
    private static double _subtotal_os = 0.00;
    private static double _subtotal_deslocamento = 0.00;
    private static double _total = 0.00;

    public void PrintPdf(PdfReportViewModel model)
    {
        var document = DrawNewDocument(model.Path);
        var header = DrawHeader(model);
        var body = DrawBody(model);
        var footer = DrawFooter(model);

        document.Open();
        document.Add(header);
        document.Add(BlankLine(2));
        document.Add(body);
        document.Add(BlankLine(4));
        document.Add(footer);
        document.Close();

        Process.Start(new ProcessStartInfo { FileName = model.Path, UseShellExecute = true });
    }



    private Document DrawNewDocument(string path)
    {
        Document doc = new Document(PageSize.A4);
        doc.SetMargins(40, 40, 30, 30);
        doc.AddCreationDate();
        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
        return doc;
    }

    private PdfPTable DrawHeader(PdfReportViewModel model)
    {
        System.Drawing.Image logo;

        using var stream = new MemoryStream(model.Logo);
        logo = System.Drawing.Image.FromStream(stream);

        Font _title = FontFactory.GetFont("Calibre", 22, Font.BOLD + Font.ITALIC, BaseColor.BLACK);
        Font _subtitle = FontFactory.GetFont("Calibre", 9, Font.BOLD, BaseColor.BLACK);
        Font _regular = FontFactory.GetFont("Calibre", 8, Font.NORMAL, BaseColor.DARK_GRAY);

        Image imagem = iTextSharp.text.Image.GetInstance(logo, BaseColor.WHITE);
        imagem.ScaleAbsolute(50, 50);


        PdfPTable tabhead = new PdfPTable(3);
        tabhead.WidthPercentage = 100;
        var widths = new float[] { 30f, 40f, 30f };
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
            Phrase = new Phrase(new Chunk("Relatório de Serviços Executados", _title))
        };
        tabhead.AddCell(hTitulo);

        var hRazaoSocial = new PdfPCell()
        {
            Border = 2,
            BorderColor = BaseColor.LIGHT_GRAY,
            BorderWidth = 1f,
            FixedHeight = 20f,
            VerticalAlignment = Element.ALIGN_MIDDLE,
            Phrase = new Phrase(new Chunk(model.CompanyName, _subtitle))
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
            Phrase = new Phrase(new Chunk("CNPJ: " + model.Cnpj, _subtitle))
        };
        tabhead.AddCell(hCnpj);

        PdfPCell hEdital = new PdfPCell()
        {
            Border = 0,
            BorderColor = BaseColor.LIGHT_GRAY,
            FixedHeight = 15f,
            Colspan = 2,
            VerticalAlignment = Element.ALIGN_TOP,
            Phrase = new Phrase(new Chunk("Edital: " + model.ContractNotice, _regular))
        };
        tabhead.AddCell(hEdital);

        PdfPCell hContrato = new PdfPCell()
        {
            HorizontalAlignment = Element.ALIGN_RIGHT,
            Border = 0,
            BorderColor = BaseColor.LIGHT_GRAY,
            FixedHeight = 15f,
            VerticalAlignment = Element.ALIGN_TOP,
            Phrase = new Phrase(new Chunk("Contrato: " + model.ContractNumber, _regular))
        };
        tabhead.AddCell(hContrato);
        return tabhead;
    }

    private PdfPTable DrawBody(PdfReportViewModel model)
    {
        PdfPTable tabmain = new PdfPTable(7);
        Font _subtitle = FontFactory.GetFont("Calibre", 9, Font.BOLD, BaseColor.BLACK);
        Font _regular = FontFactory.GetFont("Calibre", 8, Font.NORMAL, BaseColor.DARK_GRAY);
        Font _strong = FontFactory.GetFont("Calibre", 8, Font.BOLD, BaseColor.DARK_GRAY);

        foreach (var professional in model.Professionals)
        {
            var widths = new float[] { 11f, 31f, 7f, 21f, 11f, 10f, 9f };
            tabmain.WidthPercentage = 100;
            tabmain.DefaultCell.BorderWidth = 1;
            tabmain.SetWidths(widths);
            tabmain.DefaultCell.FixedHeight = 20;
            tabmain.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;

            /////////////////LINHA - NOME DO PROFISSIONAL
            var cellProfessionalHeader = new PdfPCell
            {
                Border = 2,
                BorderWidth = 1f,
                BackgroundColor = BaseColor.LIGHT_GRAY,
                Colspan = 7,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                FixedHeight = 20,
                Phrase = new Phrase(new Chunk("Profissional: " + professional.Nameid, _subtitle))
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

            cellListHeader.Phrase = new Phrase(new Chunk("Data da Ordem", _strong));
            tabmain.AddCell(cellListHeader);

            cellListHeader.Phrase = new Phrase(new Chunk("Referência", _strong));
            tabmain.AddCell(cellListHeader);

            cellListHeader.Phrase = new Phrase(new Chunk("Tipo", _strong));
            tabmain.AddCell(cellListHeader);

            cellListHeader.Phrase = new Phrase(new Chunk("Cidade", _strong));
            tabmain.AddCell(cellListHeader);

            cellListHeader.Phrase = new Phrase(new Chunk("Data da Conclusão", _strong));
            tabmain.AddCell(cellListHeader);

            cellListHeader.Phrase = new Phrase(new Chunk("Valor do Serviço", _strong));
            tabmain.AddCell(cellListHeader);

            cellListHeader.Phrase = new Phrase(new Chunk("Valor do Desloc.", _strong));
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

            var orders = model.Orders.Where(x => x.ProfessionalId == professional.Id);

            foreach (var order in orders)
            {
                string value = string.Empty;

                value = order.OrderDate.ToString("dd/MM/yyyy");
                cellListBody.Phrase = new Phrase(new Chunk(value, _regular));
                tabmain.AddCell(cellListBody);

                value = order.ReferenceCode.ToString();
                cellListBody.Phrase = new Phrase(new Chunk(value, _regular));
                tabmain.AddCell(cellListBody);

                value = order.Service.ToString();
                cellListBody.Phrase = new Phrase(new Chunk(value, _regular));
                tabmain.AddCell(cellListBody);

                value = order.City.ToString();
                cellListBody.Phrase = new Phrase(new Chunk(value, _regular));
                tabmain.AddCell(cellListBody);

                value = order.DoneDate.ToString("dd/MM/yyyy");
                cellListBody.Phrase = new Phrase(new Chunk(value, _regular));
                tabmain.AddCell(cellListBody);

                value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", order.ServiceAmount);
                cellListBody.Phrase = new Phrase(new Chunk(value, _regular));
                tabmain.AddCell(cellListBody);

                value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", order.MileageAllowance);
                cellListBody.Phrase = new Phrase(new Chunk(value, _regular));
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
                Phrase = new Phrase(new Chunk("", _regular))
            };
            tabmain.AddCell(labelSubtotal);

            //--célula subtotal valor os
            double somavaloratividade = (double)orders.Where(order => order.ProfessionalId == professional.Id).Sum(order => order.ServiceAmount);
            _subtotal_os += somavaloratividade;
            var subTotalOrder = new PdfPCell()
            {
                Border = 1,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_CENTER,
                FixedHeight = 12,
                Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", somavaloratividade), _regular))
            };
            tabmain.AddCell(subTotalOrder);


            //--célula subtotal valor deslocamento
            double somavalordeslocamento = (double)orders.Where(order => order.ProfessionalId == professional.Id).Sum(order => order.MileageAllowance);
            _subtotal_deslocamento += somavalordeslocamento;
            var subTotalDeslocamento = new PdfPCell()
            {
                Border = 1,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_CENTER,
                FixedHeight = 12,
                Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", somavalordeslocamento), _regular))
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
                Phrase = new Phrase(new Chunk("", _regular))
            };
            tabmain.AddCell(subTotalLabel);



            //--célula valor total
            double somatotal = somavaloratividade + somavalordeslocamento;
            _total += somatotal;
            var subTotal = new PdfPCell()
            {
                Border = 1,
                BorderColor = BaseColor.GRAY,
                Colspan = 2,
                VerticalAlignment = Element.ALIGN_TOP,
                HorizontalAlignment = Element.ALIGN_CENTER,
                FixedHeight = 16,
                Phrase = new Phrase(new Chunk("R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", somatotal), _regular))
            };
            tabmain.AddCell(subTotal);
        }
        return tabmain;
    }

    private PdfPTable DrawFooter(PdfReportViewModel model)
    {

        Font _subtitle = FontFactory.GetFont("Calibre", 9, Font.BOLD, BaseColor.BLACK);
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
            Phrase = new Phrase(new Chunk("VALOR TOTAL DA FATURA", _subtitle))
        };
        tabTotal.AddCell(totalSubtitle);


        var subTotalLabel2 = new PdfPCell()
        {
            VerticalAlignment = Element.ALIGN_MIDDLE,
            HorizontalAlignment = Element.ALIGN_RIGHT,
            Border = 1,
            FixedHeight = 20,
            Phrase = new Phrase(new Chunk("SUBTOTAL:", _subtitle))
        };
        tabTotal.AddCell(subTotalLabel2);


        var subTotalOS2 = new PdfPCell()
        {
            Border = 1,
            VerticalAlignment = Element.ALIGN_MIDDLE,
            HorizontalAlignment = Element.ALIGN_RIGHT,
            FixedHeight = 20,
            Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", _subtotal_os), _subtitle))
        };
        tabTotal.AddCell(subTotalOS2);


        var subTotalDeslocamento2 = new PdfPCell()
        {
            Border = 1,
            VerticalAlignment = Element.ALIGN_MIDDLE,
            HorizontalAlignment = Element.ALIGN_RIGHT,
            FixedHeight = 20,
            Phrase = new Phrase(new Chunk(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", _subtotal_deslocamento), _subtitle))
        };
        tabTotal.AddCell(subTotalDeslocamento2);


        var totalLabel2 = new PdfPCell()
        {
            Border = 2,
            VerticalAlignment = Element.ALIGN_TOP,
            HorizontalAlignment = Element.ALIGN_RIGHT,
            FixedHeight = 25,
            Phrase = new Phrase(new Chunk("TOTAL:", _subtitle))
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
            Phrase = new Phrase(new Chunk("R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", _total), _subtitle))
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

        return tabTotal;
    }

    private Paragraph BlankLine(int count)
    {
        string blank = string.Empty;

        for (int i = 0; i < count; i++)
            blank += "\n";
        
        return new Paragraph(blank);
    }

}
