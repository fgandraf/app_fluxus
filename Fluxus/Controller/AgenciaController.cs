using System;
using System.Data;
using Fluxus.Model.DAO;
using Fluxus.Model.ENT;

namespace Fluxus.Controller
{
    public class AgenciaController
    {
        



        //:INSERT
        public void InsertAgencia(AgenciaENT dado)
        {
            try
            {
                new AgenciaDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:UPDATE
        public void UpdateAgencia(long id, AgenciaENT dado)
        {
            try
            {
                new AgenciaDAO().Update(id, dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:DELETE
        public void DeleteAgencia(long id)
        {
            try
            {
                new AgenciaDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarAgencias()
        {
            try
            {
                return new AgenciaDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarAgencia(string agenciaCodigo)
        {
            try
            {
                return new AgenciaDAO().GetNomeTelefone1EmailBy(agenciaCodigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public AgenciaENT GetBy(long id)
        {
            try
            {
                return new AgenciaDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }



}
