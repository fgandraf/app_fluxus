using Fluxus.Model.ENT;
using System.Data;
using Newtonsoft.Json;

namespace Fluxus.Model
{
    class AgenciaModel
    {





        // POST api/agencia/post
        public void Insert(AgenciaENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("agencia/post", jsonData);
        }





        // PUT api/agencia/put/<id>
        public void Update(long id, AgenciaENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("agencia/put/" + id, jsonData);
        }





        // DELETE api/agencia/delete/<id>
        public void Delete(long id)
        {
            string retorno = WebAPI.RequestDELETE("agencia/delete/", id.ToString());
        }





        // GET api/agencia
        public DataTable ListarAgencias()
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("agencia", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/agencia/getsomeby/<agenciaCodigo>
        public DataTable BuscarAgencia(string agenciaCodigo)
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("agencia/getsomeby/", agenciaCodigo);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/agencia/getby/<id>
        public AgenciaENT GetBy(long id)
        {
            AgenciaENT retorno = new AgenciaENT();
            string json = WebAPI.RequestGET("agencia/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<AgenciaENT>(json);
            return retorno;
        }





    }
}
