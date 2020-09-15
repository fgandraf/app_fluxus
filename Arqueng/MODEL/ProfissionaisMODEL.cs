using System;
using System.Data;
using Fluxus.DAO;
using Fluxus.ENTIDADES;

namespace Fluxus.MODEL
{
    public class ProfissionaisMODEL
    {
        ProfissionaisDAO dao = new ProfissionaisDAO();



        //:INSERT
        public void InsertProfissionalMODEL(ProfissionaisENT dado)
        {
            try
            {
                dao.Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        
        //:UPDATE
        public void UpdateProfissionalMODEL(ProfissionaisENT dado)
        {
            try
            {
                dao.Update(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:DELETE
        public void DeleteProfissionalMODEL(ProfissionaisENT dado)
        {
            try
            {
                dao.Delete(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarProfissionaisMODEL()
        {
            try
            {
                return dao.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarUsuarioMODEL(string nomeDeUsuario)
        {
            try
            {
                return dao.BuscarUsuario(nomeDeUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCodigoENomeidMODEL(bool adicionaTitulo)
        {
            DataTable dtPro = new DataTable();
            try
            {
               
                dtPro = dao.SelectCodigoENomeid();

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
