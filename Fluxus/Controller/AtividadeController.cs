using System;
using System.Data;
using Fluxus.Model.DAO;
using Fluxus.Model.ENT;

namespace Fluxus.Controller
{
    public class AtividadeController
    {


        //:INSERT
        public void InsertAtividade(AtividadeENT dado)
        {
            try
            {
                new AtividadeDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:UPDATE
        public void UpdateAtividade(long id, AtividadeENT dado)
        {
            try
            {
                new AtividadeDAO().Update(id, dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:DELETE
        public void DeleteAtividade(long id)
        {
            try
            {
                new AtividadeDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarAtividades(bool adicionaTitulo)
        {
            DataTable dtAtividades = new DataTable();
            try
            {
                DataView dvAtividades = new DataView(new AtividadeDAO().GetAll());
                dtAtividades = dvAtividades.ToTable("Selected", false, "id", "codigo", "descricao", "valor_atividade", "valor_deslocamento");
                
                if (adicionaTitulo)
                {
                    DataRow linha = dtAtividades.NewRow();
                    linha[1] = "--TODAS--";
                    dtAtividades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAtividades;
        }



        public AtividadeENT GetBy(long id)
        {
            try
            {
                return new AtividadeDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }



}