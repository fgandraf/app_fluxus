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
                dt = dao.SelectAllDAO();
                return dt;
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
                dao.InsertDAO(dado);
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
                dao.UpdateDAO(dado);
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
                dao.DeleteDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }















        ///////////////////////////////////////////////////////////////////////////////////////////////

















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

    }


}
