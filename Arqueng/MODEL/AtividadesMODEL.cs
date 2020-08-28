using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class AtividadesMODEL
    {


        AtividadesDAO dao = new AtividadesDAO();


        public DataTable ListarAtividadesModel()
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


        public void InsertAtividadeModel(AtividadesENT dado)
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


        public void UpdateAtividadeModel(AtividadesENT dado)
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


        public void DeleteAtividadeModel(AtividadesENT dado)
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



    }


}
