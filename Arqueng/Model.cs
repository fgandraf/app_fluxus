using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENT;

namespace Arqueng.Model
{
    public class Atividades_Model
    {

        DAO.Atividades_DAO dao = new DAO.Atividades_DAO();

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
        public void InsertAtividadeModel(ENT.Atividades_ENT dado)
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
        public void UpdateAtividadeModel(ENT.Atividades_ENT dado)
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
        public void DeleteAtividadeModel(ENT.Atividades_ENT dado)
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


    public class Agencias_Model
    {

        DAO.Agencias_DAO dao = new DAO.Agencias_DAO();

        public DataTable ListarAgenciasModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarAgenciasDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertAgenciaModel(ENT.Agencias_ENT dado)
        {
            try
            {
                dao.InsertAgenciaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateAgenciaModel(ENT.Agencias_ENT dado)
        {
            try
            {
                dao.UpdateAgenciaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteAgenciaModel(ENT.Agencias_ENT dado)
        {
            try
            {
                dao.DeleteAgenciaDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}