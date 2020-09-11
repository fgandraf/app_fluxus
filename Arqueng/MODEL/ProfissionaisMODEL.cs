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
                return dao.SelectAllDAO();
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


        public DataTable BuscarUsuarioModel(string nomeDeUsuario)
        {
            try
            {
                return dao.BuscarUsuarioDAO(nomeDeUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCodigoENomeidModel(bool adicionaTitulo)
        {
            DataTable dtPro = new DataTable();
            try
            {
               
                dtPro = dao.ListarCodigoENomeidDAO();

                if (adicionaTitulo)
                {
                    DataRow linha = dtPro.NewRow();
                    linha[1] = "--TODOS--";
                    dtPro.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtPro;
        }

    }


}
