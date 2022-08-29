using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System.Data;
using System.Threading.Tasks;

namespace Fluxus.Data.Api
{
    class Os
    {

        public void Insert(OsENT dado)
        {
            // POST api/os/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPOST("os/post", jsonData);
        }


        public void Update(long id, OsENT dado)
        {
            // PUT api/os/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPUT("os/put/" + id, jsonData);
        }


        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            // PUT api/os/updatefaturacod/<id>,<fatura_cod>
            string json = Connection.RequestPUT("os/updatefaturacod/" + id + "," + fatura_cod, string.Empty);
        }

        public async Task UpdateStatus(long id, string status)
        {
            // PUT api/os/updatestatus/<id>,<status>
            await Task.Run(() => Connection.RequestPUT("os/updatestatus/" + id + "," + status, string.Empty));
        }


        public void Delete(long id)
        {
            // DELETE api/os/delete/<id>
            string retorno = Connection.RequestDELETE("os/delete/", id.ToString());
        }


        public DataTable GetOrdensDoFluxo()
        {
            // GET: api/os/getordensdofluxo
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("os/getordensdofluxo", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }


        public DataTable GetOrdensConcluidasAFaturar()
        {
            // GET: api/os/getordensconcluidasafaturar
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("os/getordensconcluidasafaturar", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }


        public DataTable GetOrdensFaturadasBy(long fatura_cod)
        {
            // GET api/os/getordensfaturadas/<fatura_cod>
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("os/getordensfaturadas/", fatura_cod.ToString());
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }


        public DataTable GetFiltered(string filtro)
        {
            // GET: api/os/getfiltered/<filtro>
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("os/getfiltered/", filtro);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }


        public DataTable GetProfissionaisDaFatura(long fatura_cod)
        {
            // GET api/os/getprofissionaisdafatura/<fatura_cod>
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("os/getprofissionaisdafatura/", fatura_cod.ToString());
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }


        public DataTable GetCidadesDasOrdens()
        {
            // GET: api/os/getcidadesdasordens
            DataTable dtCidades = new DataTable();
            string json = Connection.RequestGET("os/getcidadesdasordens", string.Empty);
            dtCidades = JsonConvert.DeserializeObject<DataTable>(json);
            return dtCidades;
        }


        public OsENT GetBy(long id)
        {
            // GET api/os/getby/<id>
            OsENT retorno = new OsENT();
            string json = Connection.RequestGET("os/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<OsENT>(json);
            return retorno;
        }

    }
}
