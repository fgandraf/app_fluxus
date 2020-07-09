using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class FaturasMODEL
    {


        FaturasDAO dao = new FaturasDAO();


        public void InsertFaturaModel(FaturasENT dado)
        {
            try
            {
                dao.InsertFaturaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarFaturaModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarFaturasDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}
