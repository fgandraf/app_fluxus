using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System.Data;

namespace Fluxus.Data.Api
{
    class Atividade
    {

        public void Insert(AtividadeENT dado)
        {
            // POST: api/atividade/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPOST("atividade/post", jsonData);
        }


        public void Update(long id, AtividadeENT dado)
        {
            // PUT: api/atividade/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPUT("atividade/put/" + id, jsonData);
        }


        public void Delete(long id)
        {
            // DELETE: api/atividade/delete/<id>
            string retorno = Connection.RequestDELETE("atividade/delete/", id.ToString());
        }


        public DataTable GetAll()
        {
            // GET: api/atividade
            DataTable dtAtividades = new DataTable();
            string json = Connection.RequestGET("atividade", string.Empty);
            dtAtividades = JsonConvert.DeserializeObject<DataTable>(json);
            return dtAtividades;
        }


        public AtividadeENT GetBy(long id)
        {
            // GET: api/atividade/getby/<id>
            AtividadeENT retorno = new AtividadeENT();
            string json = Connection.RequestGET("atividade/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<AtividadeENT>(json);
            return retorno;
        }


    }
}
