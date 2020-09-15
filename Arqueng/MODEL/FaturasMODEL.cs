using System;
using System.Data;
using Fluxus.DAO;
using Fluxus.ENTIDADES;

namespace Fluxus.MODEL
{
    public class FaturasMODEL
    {
        FaturasDAO dao = new FaturasDAO();



        //:INSERT
        public void InsertFaturaMODEL(FaturasENT dado)
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
        public void UpdateFaturaValoresMODEL(FaturasENT dado)
        {
            try
            {
                dao.UpdateValores(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:DELETE
        public void DeleteFaturaMODEL(FaturasENT dado)
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
        public DataTable ListarFaturaMODEL()
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

        public string DescricaoFaturaMODEL(string id)
        {
            try
            {
                return dao.SelectDescricaoDaFatura(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    
    
    }



}
