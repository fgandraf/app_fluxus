using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{
    public class OsMODEL
    {

        OsDAO dao = new OsDAO();

        public DataTable ListarOsModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarOsDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public DataTable ListarOsNaoFatModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarOsNaoFatDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOsFatModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarOsFatDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertOsModel(OsENT dado)
        {
            try
            {
                dao.InsertOsDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateOsModel(OsENT dado)
        {
            try
            {
                dao.UpdateOsDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteOsModel(OsENT dado)
        {
            try
            {
                dao.DeleteOsDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
