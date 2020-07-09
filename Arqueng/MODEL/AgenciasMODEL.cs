using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class AgenciasMODEL
    {


        AgenciasDAO dao = new AgenciasDAO();


        public DataTable ListarAgenciasModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarAgenciasDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void BuscarAgenciaModel(AgenciasENT dado)
        {
            try
            {
                dao.BuscarAgenciaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void InsertAgenciaModel(AgenciasENT dado)
        {
            try
            {
                dao.InsertAgenciaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void UpdateAgenciaModel(AgenciasENT dado)
        {
            try
            {
                dao.UpdateAgenciaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void DeleteAgenciaModel(AgenciasENT dado)
        {
            try
            {
                dao.DeleteAgenciaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}
