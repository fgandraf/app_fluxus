using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Fluxus.Model
{
    class FaturaModel
    {





        // POST api/fatura/post
        public long Insert(FaturaENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("fatura/post", jsonData);

            return Convert.ToInt64(json);
        }





        // PUT api/fatura/puttotals/<id>
        public void Update(long id, FaturaENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("fatura/puttotals/" + id, jsonData);

        }





        // DELETE api/fatura/delete/<id>
        public void Delete(long id)
        {
            string retorno = WebAPI.RequestDELETE("fatura/delete/", id.ToString());
        }





        // GET: api/fatura
        public DataTable ListarFatura()
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("fatura", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/fatura/getdescricao/<id>
        public string DescricaoFatura(long id)
        {
            string json = WebAPI.RequestGET("fatura/getdescricao/", id.ToString());
            return JsonConvert.DeserializeObject<string>(json);
        }





    }
}