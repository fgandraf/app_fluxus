using Fluxus.Model.ENT;
using System.Data;

using MySQL = Fluxus.Data.MySQL;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class OsModel
    {



        public void Insert(OsENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Os().Insert(dado);
            else
                new Api.Os().Insert(dado);
        }



        public void Update(long id, OsENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Os().Update(id, dado);
            else
                new Api.Os().Update(id, dado);
        }



        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Os().UpdateFaturaCod(id, fatura_cod);
            else
                new Api.Os().UpdateFaturaCod(id, fatura_cod);
        }



        public async void UpdateStatus(long id, string status)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Os().UpdateStatus(id, status);
            else
                await new Api.Os().UpdateStatus(id, status);
        }



        public void Delete(long id)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Os().Delete(id);
            else
                new Api.Os().Delete(id);
        }



        public DataTable GetOrdensDoFluxo()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Os().GetOrdensDoFluxo();
            else
                return new Api.Os().GetOrdensDoFluxo();
        }



        public DataTable GetOrdensConcluidasNaoFaturadas()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Os().GetOrdensConcluidasAFaturar();
            else
                return new Api.Os().GetOrdensConcluidasAFaturar();
        }



        public DataTable GetOrdensFaturadasDoCodigo(long fatura_cod)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Os().GetOrdensFaturadasBy(fatura_cod);
            else
                return new Api.Os().GetOrdensFaturadasBy(fatura_cod);
        }



        public DataTable GetOrdensComFiltro(string filtro)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Os().GetFiltered(filtro);
            else
                return new Api.Os().GetFiltered(filtro);
        }



        public DataTable GetProfissionaisDaFatura(long fatura_cod)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Os().GetProfissionaisDaFatura(fatura_cod);
            else
                return new Api.Os().GetProfissionaisDaFatura(fatura_cod);
        }



        public DataTable GetCidadesDasOrdens(bool adicionaTitulo)
        {
            DataTable distinctCidades = new DataTable();
            if (Util.DataSource == "MySQL")
                distinctCidades = new MySQL.Os().GetCidadesDasOrdens();
            else
                distinctCidades = new Api.Os().GetCidadesDasOrdens();
            if (adicionaTitulo)
            {
                DataRow linha = distinctCidades.NewRow();
                linha[0] = "--TODAS--";
                distinctCidades.Rows.InsertAt(linha, 0);
            }
            return distinctCidades;
        }



        public OsENT GetBy(long id)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Os().GetBy(id);
            else
                return new Api.Os().GetBy(id);
        }



    }



}
