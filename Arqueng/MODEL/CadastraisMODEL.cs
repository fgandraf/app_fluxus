using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class CadastraisMODEL
    {


        CadastraisDAO dao = new CadastraisDAO();


        public DataTable ListarCadastraisModel()
        {
            try
            {
                return dao.SelectAllDAO();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DadosParaImpressaoModel()
        {
            try
            {
                return dao.DadosParaImpressaoDAO();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string NomeFantasiaModel()
        {
            try
            {
                return dao.NomeFantasiaDAO();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertCadastraisModel(CadastraisENT dado)
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


        public void UpdateCadastraisModel(CadastraisENT dado)
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


    }


}
