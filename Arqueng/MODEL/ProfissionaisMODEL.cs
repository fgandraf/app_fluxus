using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class ProfissionaisMODEL
    {


        ProfissionaisDAO dao = new ProfissionaisDAO();


        public DataTable ListarProfissionaisModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarProfissionaisDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarCodNomeProModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarCodNomeProDAO();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void BuscarProfissionalModel(ProfissionaisENT dado)
        {
            try
            {
                dao.BuscarProfissionalDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void InsertProfissionalModel(ProfissionaisENT dado)
        {
            try
            {
                dao.InsertProfissionalDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void UpdateProfissionalModel(ProfissionaisENT dado)
        {
            try
            {
                dao.UpdateProfissionalDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void DeleteProfissionalModel(ProfissionaisENT dado)
        {
            try
            {
                dao.DeleteProfissionalDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}
