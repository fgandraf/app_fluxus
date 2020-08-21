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
                dt = dao.ListarAtividadesDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCodigoAtividadesModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarCodigosAtividadesDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void BuscarAtividadesModel(AtividadesENT dado)
        {
            try
            {
                dao.BuscarAtividadesDAO(dado);
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
                dao.InsertAtividadeDAO(dado);
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
                dao.UpdateAtividadeDAO(dado);
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
                dao.DeleteAtividadeDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}
