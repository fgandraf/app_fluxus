using System;
using System.Data;
using Fluxus.Model.DAO;
using Fluxus.Model.ENT;

namespace Fluxus.Controller
{
    public class ProfissionaisController
    {



        //:INSERT
        public void InsertProfissional(ProfissionalENT dado)
        {
            try
            {
                new ProfissionalDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        
        //:UPDATE
        public void UpdateProfissional(long id, ProfissionalENT profissional)
        {
            try
            {
                new ProfissionalDAO().Update(id, profissional);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:DELETE
        public void DeleteProfissional(long id)
        {
            try
            {
                new ProfissionalDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarProfissionais()
        {
            try
            {
                return new ProfissionalDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarUsuario(string nomeDeUsuario)
        {
            try
            {
                return new ProfissionalDAO().GetUserInfoBy(nomeDeUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCodigoENomeid(bool adicionaTitulo)
        {
            DataTable dtPro = new DataTable();
            try
            {
               
                dtPro = new ProfissionalDAO().GetCodigoENomeid();

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


        public ProfissionalENT GetBy(long id)
        {
            try
            {
                return new ProfissionalDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }



}
