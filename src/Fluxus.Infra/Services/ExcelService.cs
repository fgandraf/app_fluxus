using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using Fluxus.Domain.Records;

namespace Fluxus.Infra.Services
{
    public class ExcelService
    {
        public void ExportToExcel(List<ServiceOrderIndex> serviceOrders)
        {
            var XcelApp = new Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);

            XcelApp.Cells[1, 1] = "Status";
            XcelApp.Cells[1, 2] = "Profissional";
            XcelApp.Cells[1, 3] = "Data da Ordem";
            XcelApp.Cells[1, 4] = "Referência";
            XcelApp.Cells[1, 5] = "Atividade";
            XcelApp.Cells[1, 6] = "Cidade";
            XcelApp.Cells[1, 7] = "Nome do Cliente";
            XcelApp.Cells[1, 8] = "Data da Vistoria";
            XcelApp.Cells[1, 9] = "Data da Conclusão";

            for (int i = 0; i < serviceOrders.Count; i++)
            {
                XcelApp.Cells[i + 2, 1] = serviceOrders[i].Status.ToString();
                XcelApp.Cells[i + 2, 2] = serviceOrders[i].Professional.ToString();
                XcelApp.Cells[i + 2, 3] = Convert.ToDateTime(serviceOrders[i].OrderDate).ToShortDateString();
                XcelApp.Cells[i + 2, 4] = serviceOrders[i].ReferenceCode.ToString();
                XcelApp.Cells[i + 2, 5] = serviceOrders[i].Service.ToString();
                XcelApp.Cells[i + 2, 6] = serviceOrders[i].City.ToString();
                XcelApp.Cells[i + 2, 7] = serviceOrders[i].CustomerName.ToString();
                XcelApp.Cells[i + 2, 8] = Convert.ToDateTime(serviceOrders[i].SurveyDate).ToShortDateString();
                XcelApp.Cells[i + 2, 9] = Convert.ToDateTime(serviceOrders[i].DoneDate).ToShortDateString();
            }

            XcelApp.Columns.AutoFit();
            XcelApp.Rows.RowHeight = 15;
            XcelApp.Visible = true;
        }

    }
}
