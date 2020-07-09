using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class OsMODEL
    {


        OsDAO dao = new OsDAO();


        public void BuscarOsModel(OsENT dado)
        {
            try
            {
                dao.BuscarOSDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarOSAFaturarModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarOSAFaturarDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarOSFaturadaModel(OsENT dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarOSFaturadaDAO(dado);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarOsStatusModel(OsENT dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarOsStatusDAO(dado);
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


        public void UpdateOsFaturadaModel(OsENT dado)
        {
            try
            {
                dao.UpdateOsFaturada(dado);
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
