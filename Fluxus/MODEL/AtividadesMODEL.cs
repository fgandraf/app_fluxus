using System;
using System.Data;
using Fluxus.DAO;
using Fluxus.ENTIDADES;

namespace Fluxus.MODEL
{
    public class AtividadesMODEL
    {
        AtividadesDAO dao = new AtividadesDAO();



        //:INSERT
        public void InsertAtividadeMODEL(AtividadesENT dado)
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
        public void UpdateAtividadeMODEL(AtividadesENT dado)
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
        public void DeleteAtividadeMODEL(AtividadesENT dado)
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
        public DataTable ListarAtividadesMODEL(bool adicionaTitulo)
        {
            DataTable dtAtividades = new DataTable();
            try
            {
                DataView dvAtividades = new DataView(dao.SelectAll());
                dtAtividades = dvAtividades.ToTable("Selected", false, "codigo", "descricao", "valor_atividade", "valor_deslocamento");
                if (adicionaTitulo)
                {
                    DataRow linha = dtAtividades.NewRow();
                    linha[0] = "--TODAS--";
                    dtAtividades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAtividades;
        }



    }



}