using Fluxus.Model.ENT;
using System.Data;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class OsModel
    {



        public void Insert(OsENT dado)
        {
            new Api.Os().Insert(dado);
        }



        public void Update(long id, OsENT dado)
        {
            new Api.Os().Update(id, dado);
        }



        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            new Api.Os().UpdateFaturaCod(id, fatura_cod);
        }



        public async void UpdateStatus(long id, string status)
        {
            await new Api.Os().UpdateStatus(id, status);
        }



        public void Delete(long id)
        {
            new Api.Os().Delete(id);
        }



        public DataTable GetOrdensDoFluxo()
        {
            return new Api.Os().GetOrdensDoFluxo();
        }



        public DataTable GetOrdensConcluidasNaoFaturadas()
        {
            return new Api.Os().GetOrdensConcluidasAFaturar();
        }



        public DataTable GetOrdensFaturadasDoCodigo(long fatura_cod)
        {
            return new Api.Os().GetOrdensFaturadasBy(fatura_cod);
        }



        public DataTable GetOrdensComFiltro(string filtro)
        {
            return new Api.Os().GetFiltered(filtro);
        }



        public DataTable GetProfissionaisDaFatura(long fatura_cod)
        {
            return new Api.Os().GetProfissionaisDaFatura(fatura_cod);
        }



        public DataTable GetCidadesDasOrdens(bool adicionaTitulo)
        {
            DataTable distinctCidades = new DataTable();
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
            return new Api.Os().GetBy(id);
        }



    }



}
