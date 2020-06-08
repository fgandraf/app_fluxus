using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.Entidades;

namespace Arqueng.Model
{
    public class AtividadesModel
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


        public void InsertAtividadeModel(Atividades dado)
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



        public void UpdateAtividadeModel(Atividades dado)
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


        public void DeleteAtividadeModel(Atividades dado)
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
