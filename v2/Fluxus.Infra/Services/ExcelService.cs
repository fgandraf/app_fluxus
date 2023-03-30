using System;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace Fluxus.Infra.Services
{
    public class ExcelService
    {
        public void ExportToExcel(DataTable serviceOrders)
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

            for (int i = 0; i < serviceOrders.Rows.Count - 1; i++)
            {
                XcelApp.Cells[i + 2, 1] = serviceOrders.Rows[i]["status"].ToString();
                XcelApp.Cells[i + 2, 2] = serviceOrders.Rows[i]["professional"].ToString();
                XcelApp.Cells[i + 2, 3] = Convert.ToDateTime(serviceOrders.Rows[i]["orderDate"]).ToShortDateString();
                XcelApp.Cells[i + 2, 4] = serviceOrders.Rows[i]["referenceCode"].ToString();
                XcelApp.Cells[i + 2, 5] = serviceOrders.Rows[i]["service"].ToString();
                XcelApp.Cells[i + 2, 6] = serviceOrders.Rows[i]["city"].ToString();
                XcelApp.Cells[i + 2, 7] = serviceOrders.Rows[i]["customerName"].ToString();
                XcelApp.Cells[i + 2, 8] = Convert.ToDateTime(serviceOrders.Rows[i]["surveyDate"]).ToShortDateString();
                XcelApp.Cells[i + 2, 9] = Convert.ToDateTime(serviceOrders.Rows[i]["doneDate"]).ToShortDateString();
            }

            XcelApp.Columns.AutoFit();
            XcelApp.Rows.RowHeight = 15;
            XcelApp.Visible = true;
        }

    }
}
