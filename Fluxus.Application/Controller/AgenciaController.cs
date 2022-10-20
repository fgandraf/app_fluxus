using Newtonsoft.Json;
using System.Data;
using Fluxus.Domain.Models;


namespace Fluxus.Application.Controller
{
    class AgenciaController
    {



        public void Insert(Agencia dado)
        {
            // POST: api/agencia/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPOST("agencia/post", jsonData);
        }



        public void Update(long id, Agencia dado)
        {
            // PUT: api/agencia/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPUT("agencia/put/" + id, jsonData);
        }



        public void Delete(long id)
        {
            // DELETE: api/agencia/delete/<id>
            string retorno = Connection.RequestDELETE("agencia/delete/", id.ToString());
        }



        public DataTable GetAll()
        {
            // GET: api/agencia
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("agencia", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }



        public DataTable BuscarAgencia(string agenciaCodigo)
        {
            // GET: api/agencia/getsomeby/<agenciaCodigo>
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("agencia/getsomeby/", agenciaCodigo);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }



        public Agencia GetBy(long id)
        {
            // GET: api/agencia/getby/<id>
            Agencia retorno = new Agencia();
            string json = Connection.RequestGET("agencia/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<Agencia>(json);
            return retorno;
        }



    }



}
