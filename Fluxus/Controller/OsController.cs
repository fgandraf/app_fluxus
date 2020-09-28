using System;
using System.Data;
using Fluxus.Model.DAO;
using Fluxus.Model.ENT;

namespace Fluxus.Controller
{
    public class OsController
    {
        



        //:INSERT
        public void InsertOs(OsENT dado)
        {
            try
            {
                new OsDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:UPDATE
        public void UpdateOs(long id, OsENT dado)
        {
            try
            {
                new OsDAO().Update(id, dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            try
            {
                new OsDAO().UpdateFaturaCod(id, fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStatus(long id, string status)
        {
            OsDAO dao = new OsDAO();
                try
                {
                    new OsDAO().UpdateStatusTo(id, status);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }





        //:DELETE
        public void DeleteOs(long id)
        {
            try
            {
                new OsDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        //:SELECT
        public DataTable GetOrdensDoFluxo()
        {
            try
            {
                return new OsDAO().GetOrdensDoFluxo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOrdensConcluidasNaoFaturadas()
        {
            try
            {
                return new OsDAO().GetOrdensConcluidasAFaturar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOrdensFaturadasDoCodigo(long fatura_cod)
        {
            try
            {
                return new OsDAO().GetOrdensFaturadasBy(fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOrdensComFiltro(string filtro)
        {
            try
            {
                return new OsDAO().GetFiltered(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCodigoENomeidDosProfissionaisDaFatura(long fatura_cod)
        {
            try
            {
                return new OsDAO().GetCodigoENomeidDosProfissionaisDaFatura(fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarCidadesDasOrdens(bool adicionaTitulo)
        {
            DataTable distinctCidades = new DataTable();
            try
            {
                distinctCidades = new OsDAO().GetCidadesDasOrdens();
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


        public OsENT GetBy(long id)
        {
            try
            {
                return new OsDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }



}
