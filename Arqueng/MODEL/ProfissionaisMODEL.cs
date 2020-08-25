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
                dt = dao.SelectAllDAO();
                return dt;
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
                dao.InsertDAO(dado);
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
                dao.UpdateDAO(dado);
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
                dao.DeleteDAO(dado);
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

        public bool BuscarNomeUsuarioModel(ProfissionaisENT dado)
        {
            try
            {
                return dao.BuscarNomeUsuarioDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void BuscarUsuarioModel(ProfissionaisENT dado)
        {
            try
            {
                dao.BuscarUsuarioDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }


}
