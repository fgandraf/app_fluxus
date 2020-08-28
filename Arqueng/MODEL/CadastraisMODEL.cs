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
                DataTable dt = new DataTable();
                dt = dao.SelectAllDAO();
                return dt;
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
