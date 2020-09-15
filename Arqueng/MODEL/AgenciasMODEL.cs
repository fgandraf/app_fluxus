using System;
using System.Data;
using Fluxus.DAO;
using Fluxus.ENTIDADES;

namespace Fluxus.MODEL
{
    public class AgenciasMODEL
    {
        AgenciasDAO dao = new AgenciasDAO();



        //:INSERT
        public void InsertAgenciaMODEL(AgenciasENT dado)
        {
            try
            {
                dao.Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:UPDATE
        public void UpdateAgenciaMODEL(AgenciasENT dado)
        {
            try
            {
                dao.Update(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:DELETE
        public void DeleteAgenciaMODEL(AgenciasENT dado)
        {
            try
            {
                dao.Delete(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarAgenciasMODEL()
        {
            try
            {
                return dao.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarAgenciaMODEL(AgenciasENT dado)
        {
            try
            {
                return dao.BuscarPelaAgencia(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }



}
