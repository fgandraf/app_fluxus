using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using Fluxus.Core.Contracts.Services;
using Fluxus.Core.Dtos.Orders;

namespace Fluxus.Infra.Services
{
    public class ExcelInterop : IExcelReport
    {
        public void ExportToExcel(List<OrderFilteredResponse> serviceOrders)
        {
            var XcelApp = new Excel.Application();
            var workbook = XcelApp.Workbooks.Add(Type.Missing);
            var worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            worksheet.Cells[2, 2] = "Status";
            worksheet.Cells[2, 3] = "Profissional";
            worksheet.Cells[2, 4] = "Data da Ordem";
            worksheet.Cells[2, 5] = "Referência";
            worksheet.Cells[2, 6] = "Atividade";
            worksheet.Cells[2, 7] = "Cidade";
            worksheet.Cells[2, 8] = "Nome do Cliente";
            worksheet.Cells[2, 9] = "Data da Vistoria";
            worksheet.Cells[2, 10] = "Data da Conclusão";

            var headerRange = worksheet.get_Range("B2", "J2");
            headerRange.Font.Bold = true;

            for (int i = 1; i < serviceOrders.Count; i++)
            {
                worksheet.Cells[i + 2, 2] = serviceOrders[i].Status.ToString();
                worksheet.Cells[i + 2, 3] = serviceOrders[i].Professional.ToString();
                worksheet.Cells[i + 2, 4] = Convert.ToDateTime(serviceOrders[i].OrderDate).ToShortDateString();
                worksheet.Cells[i + 2, 5] = serviceOrders[i].ReferenceCode.ToString();
                worksheet.Cells[i + 2, 6] = serviceOrders[i].Service.ToString();
                worksheet.Cells[i + 2, 7] = serviceOrders[i].City.ToString();
                worksheet.Cells[i + 2, 8] = serviceOrders[i].CustomerName.ToString();
                worksheet.Cells[i + 2, 9] = Convert.ToDateTime(serviceOrders[i].SurveyDate).ToShortDateString();
                worksheet.Cells[i + 2, 10] = Convert.ToDateTime(serviceOrders[i].DoneDate).ToShortDateString();
            }

            ((Excel.Range)worksheet.Columns[2]).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            ((Excel.Range)worksheet.Columns[3]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)worksheet.Columns[4]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)worksheet.Columns[5]).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            ((Excel.Range)worksheet.Columns[6]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)worksheet.Columns[7]).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            ((Excel.Range)worksheet.Columns[8]).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            ((Excel.Range)worksheet.Columns[9]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)worksheet.Columns[10]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            worksheet.Columns.AutoFit();
            for (int colIndex = 1; colIndex <= 9; colIndex++)
            {
                Excel.Range column = (Excel.Range)worksheet.Columns[colIndex];
                double columnWidth = (double)(column.ColumnWidth);
                column.ColumnWidth = columnWidth * 1.2;
            }


            worksheet.Rows.RowHeight = 17;
            XcelApp.Visible = true;
        }
    }
}
