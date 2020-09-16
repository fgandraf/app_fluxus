using System;
using System.Data;
using Fluxus.DAO;
using Fluxus.ENTIDADES;

namespace Fluxus.MODEL
{
    public class CadastraisMODEL
    {
        CadastraisDAO dao = new CadastraisDAO();



        //:INSERT
        public void InsertCadastraisMODEL(CadastraisENT dado)
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
        public void UpdateCadastraisMODEL(CadastraisENT dado)
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





        //:SELECT
        public DataTable ListarCadastraisMODEL()
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

        public DataTable DadosParaImpressaoMODEL()
        {
            try
            {
                return dao.SelectDadosParaImpressao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }



}
