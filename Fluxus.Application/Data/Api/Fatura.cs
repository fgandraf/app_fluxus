using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Fluxus.Data.Api
{
    class Fatura
    {

        public long Insert(FaturaENT dado)
        {
            // POST: api/fatura/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPOST("fatura/post", jsonData);

            return Convert.ToInt64(json);
        }


        public void Update(long id, FaturaENT dado)
        {
            // PUT: api/fatura/puttotals/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPUT("fatura/puttotals/" + id, jsonData);
        }


        public void Delete(long id)
        {
            // DELETE: api/fatura/delete/<id>
            string retorno = Connection.RequestDELETE("fatura/delete/", id.ToString());
        }


        public string GetDescricaoById(long id)
        {
            // GET: api/fatura/getdescricao/<id>
            string json = Connection.RequestGET("fatura/getdescricao/", id.ToString());
            return json;
        }


        public DataTable GetAll()
        {
            // GET: api/fatura
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("fatura", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }

    }
}