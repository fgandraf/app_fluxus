using System;
using System.Data;
using Fluxus.DAO;
using Fluxus.ENTIDADES;

namespace Fluxus.MODEL
{
    public class OsMODEL
    {
        OsDAO dao = new OsDAO();



        //:INSERT
        public void InsertOsMODEL(OsENT dado)
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
        public void UpdateOsMODEL(OsENT dado)
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

        public void UpdateFaturaCodMODEL(string referencia, string fatura_cod)
        {
            try
            {
                dao.UpdateFaturaCod(referencia, fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStatusMODEL(OsENT dado)
        {
            if (dado.Status == "RECEBIDA")
            {
                try
                {
                    dao.UpdateStatusToRecebida(dado);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (dado.Status == "PENDENTE")
            {
                try
                {
                    dao.UpdateStatusToPendente(dado);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (dado.Status == "VISTORIADA")
            {
                try
                {
                    dao.UpdateStatusToVistoriada(dado);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    dao.UpdateStatusToConcluida(dado);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }





        //:DELETE
        public void DeleteOsMODEL(OsENT dado)
        {
            try
            {
                dao.DeleteOs(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable ListarOrdensNaoFaturadasMODEL()
        {
            try
            {
                return dao.SelectOrdensNaoFaturadas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOrdensConcluidasNaoFaturadasMODEL()
        {
            try
            {
                return dao.SelectOrdensConcluidasNaoFaturadas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOrdensFaturadasDoCodigoMODEL(string fatura_cod)
        {
            try
            {
                return dao.SelectOrdensFaturadasDoCodigo(fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOrdensComFiltroMODEL(string filtro)
        {
            try
            {
                return dao.SelectOrdensComFiltro(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCodigoENomeidDosProfissionaisDaFaturaMODEL(string fatura_cod)
        {
            try
            {
                return dao.SelectCodigoENomeidDosProfissionaisDaFatura(fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCidadesDasOrdensMODEL(bool adicionaTitulo)
        {
            DataTable distinctCidades = new DataTable();
            try
            {
                distinctCidades = dao.SelectCidadesDasOrdens();
                if (adicionaTitulo)
                {
                    DataRow linha = distinctCidades.NewRow();
                    linha[0] = "--TODAS--";
                    distinctCidades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return distinctCidades;
        }

   

    }



}
