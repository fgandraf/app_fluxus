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
                dt = dao.ListarCadastraisDAO();
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
                dao.InsertCadastraisDAO(dado);
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
                dao.UpdateCadastraisDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
