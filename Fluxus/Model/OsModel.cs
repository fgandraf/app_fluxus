using Fluxus.DAO;
using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Fluxus.Model
{
    class OsModel
    {


        bool localDataBase = Util.LocalDB;


        public void Insert(OsENT dado)
        {
            if (localDataBase)
                InsertLocal(dado);
            else
                PostAPI(dado);
        }
        public void Update(long id, OsENT dado)
        {
            if (localDataBase)
                UpdateLocal(id, dado);
            else
                PutAPI(id, dado);
        }
        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            if (localDataBase)
                UpdateFaturaCodLocal(id, fatura_cod);
            else
                UpdateFaturaCodAPI(id, fatura_cod);
        }
        public async void UpdateStatus(long id, string status)
        {
            if (localDataBase)
                UpdateStatusLocal(id, status);
            else
                await UpdateStatusAsyncAPI(id, status);
        }
        public void Delete(long id)
        {
            if (localDataBase)
                DeleteLocal(id);
            else
                DeleteAPI(id);
        }
        public DataTable GetOrdensDoFluxo()
        {
            if (localDataBase)
                return GetOrdensDoFluxoLocal();
            else
                return GetOrdensDoFluxoAPI();
        }
        public DataTable GetOrdensConcluidasNaoFaturadas()
        {
            if (localDataBase)
                return GetOrdensConcluidasNaoFaturadasLocal();
            else
                return GetOrdensConcluidasNaoFaturadasAPI();
        }
        public DataTable GetOrdensFaturadasDoCodigo(long fatura_cod)
        {
            if (localDataBase)
                return GetOrdensFaturadasDoCodigoLocal(fatura_cod);
            else
                return GetOrdensFaturadasDoCodigoAPI(fatura_cod);
        }
        public DataTable GetOrdensComFiltro(string filtro)
        {
            if (localDataBase)
                return GetOrdensComFiltroLocal(filtro);
            else
                return GetOrdensComFiltroAPI(filtro);
        }
        public DataTable GetProfissionaisDaFatura(long fatura_cod)
        {
            if (localDataBase)
                return GetProfissionaisDaFaturaLocal(fatura_cod);
            else
                return GetProfissionaisDaFaturaAPI(fatura_cod);
        }
        public DataTable GetCidadesDasOrdens(bool adicionaTitulo)
        {
            if (localDataBase)
                return GetCidadesDasOrdensLocal(adicionaTitulo);
            else
                return GetCidadesDasOrdensAPI(adicionaTitulo);
        }
        public OsENT GetBy(long id)
        {
            if (localDataBase)
                return GetByLocal(id);
            else
                return GetByAPI(id);
        }





        //----------
        private void InsertLocal(OsENT dado)
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
        private void PostAPI(OsENT dado)
        {
            // POST api/os/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("os/post", jsonData);
        }
        //----------
        private void UpdateLocal(long id, OsENT dado)
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
        private void PutAPI(long id, OsENT dado)
        {
            // PUT api/os/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("os/put/" + id, jsonData);
        }
        //----------
        private void UpdateFaturaCodLocal(long id, long fatura_cod)
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
        private void UpdateFaturaCodAPI(long id, long fatura_cod)
        {
            // PUT api/os/updatefaturacod/<id>,<fatura_cod>
            string json = WebAPI.RequestPUT("os/updatefaturacod/" + id + "," + fatura_cod, string.Empty);
        }
        //----------
        private void UpdateStatusLocal(long id, string status)
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
        private void UpdateStatusAPI(long id, string status)
        {
            // PUT api/os/updatestatus/<id>,<status>
            WebAPI.RequestPUT("os/updatestatus/" + id + "," + status, string.Empty);
        }
        private async Task UpdateStatusAsyncAPI(long id, string status)
        {
            // PUT api/os/updatestatus/<id>,<status>
            await Task.Run(() => WebAPI.RequestPUT("os/updatestatus/" + id + "," + status, string.Empty));
        }
        //----------
        private void DeleteLocal(long id)
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
        private void DeleteAPI(long id)
        {
            // DELETE api/os/delete/<id>
            string retorno = WebAPI.RequestDELETE("os/delete/", id.ToString());
        }
        //----------
        private DataTable GetOrdensDoFluxoLocal()
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
        private DataTable GetOrdensDoFluxoAPI()
        {
            // GET: api/os/getordensdofluxo
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getordensdofluxo", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable GetOrdensConcluidasNaoFaturadasLocal()
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
        private DataTable GetOrdensConcluidasNaoFaturadasAPI()
        {
            // GET: api/os/getordensconcluidasafaturar
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getordensconcluidasafaturar", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable GetOrdensFaturadasDoCodigoLocal(long fatura_cod)
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
        private DataTable GetOrdensFaturadasDoCodigoAPI(long fatura_cod)
        {
            // GET api/os/getordensfaturadas/<fatura_cod>
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getordensfaturadas/", fatura_cod.ToString());
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable GetOrdensComFiltroLocal(string filtro)
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
        private DataTable GetOrdensComFiltroAPI(string filtro)
        {
            // GET: api/os/getfiltered/<filtro>
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getfiltered/", filtro);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable GetProfissionaisDaFaturaLocal(long fatura_cod)
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
        private DataTable GetProfissionaisDaFaturaAPI(long fatura_cod)
        {
            // GET api/os/getprofissionaisdafatura/<fatura_cod>
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getprofissionaisdafatura/", fatura_cod.ToString());
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable GetCidadesDasOrdensLocal(bool adicionaTitulo)
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
        private DataTable GetCidadesDasOrdensAPI(bool adicionaTitulo)
        {
            // GET: api/os/getcidadesdasordens
            DataTable dtCidades = new DataTable();
            try
            {
                string json = WebAPI.RequestGET("os/getcidadesdasordens", string.Empty);
                dtCidades = JsonConvert.DeserializeObject<DataTable>(json);

                if (adicionaTitulo)
                {
                    DataRow linha = dtCidades.NewRow();
                    linha[0] = "--TODAS--";
                    dtCidades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidades;
        }
        //----------
        private OsENT GetByLocal(long id)
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
        private OsENT GetByAPI(long id)
        {
            // GET api/os/getby/<id>
            OsENT retorno = new OsENT();
            string json = WebAPI.RequestGET("os/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<OsENT>(json);
            return retorno;
        }


    }
}
