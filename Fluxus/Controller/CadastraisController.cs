using System;
using System.Data;
using Fluxus.Model.DAO;
using Fluxus.Model.ENT;

namespace Fluxus.Controller
{
    public class CadastraisController
    {



        //:INSERT
        public void InsertCadastrais(CadastraisENT dado)
        {
            try
            {
                new CadastraisDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:UPDATE
        public void UpdateCadastrais(CadastraisENT dado)
        {
            try
            {
                new CadastraisDAO().Update(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarCadastrais()
        {
            try
            {
                return new CadastraisDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DadosParaImpressao()
        {
            try
            {
                return new CadastraisDAO().GetToPrint();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string GetFantasia()
        {
            try
            {
                return new CadastraisDAO().GetFantasia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }



}
