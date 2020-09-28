using System;
using System.Data;
using Fluxus.Model.DAO;
using Fluxus.Model.ENT;

namespace Fluxus.Controller
{
    public class FaturasController
    {



        //:INSERT
        public long InsertFatura(FaturaENT dado)
        {
            try
            {
                return new FaturaDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:UPDATE
        public void UpdateFaturaValores(long id, FaturaENT dado)
        {
            try
            {
                new FaturaDAO().UpdateTotals(id, dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:DELETE
        public void DeleteFatura(long id)
        {
            try
            {
                new FaturaDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarFatura()
        {
            try
            {
                return new FaturaDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DescricaoFatura(long id)
        {
            try
            {
                return new FaturaDAO().GetDescricaoById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    
    
    }



}
