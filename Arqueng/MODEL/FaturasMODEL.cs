using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class FaturasMODEL
    {


        FaturasDAO dao = new FaturasDAO();


        public DataTable ListarFaturaModel()
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


        public void InsertFaturaModel(FaturasENT dado)
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


        public void UpdateFaturaValoresModel(FaturasENT dado)
        {
            try
            {
                dao.UpdateValoresDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteFaturaModel(FaturasENT dado)
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

        public string DescricaoFaturaModel(string id)
        {
            try
            {
                return dao.DescricaoDAO(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }


}
