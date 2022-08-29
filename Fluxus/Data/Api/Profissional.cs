using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System.Data;

namespace Fluxus.Data.Api
{
    class Profissional
    {

        public void Insert(ProfissionalENT dado)
        {
            // POST: api/profissional/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = Connection.RequestPOST("profissional/post", jsonData);
        }


        public void Update(long id, ProfissionalENT dado)
        {
            // PUT: api/profissional/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = Connection.RequestPUT("profissional/put/" + id, jsonData);
        }


        public void Delete(long id)
        {
            // DELETE: api/profissional/delete/<id>
            string retorno = Connection.RequestDELETE("profissional/delete/", id.ToString());
        }


        public DataTable GetAll()
        {
            // GET: api/profissional
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("profissional", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }


        public DataTable GetUserInfoBy(string nomeDeUsuario)
        {
            // GET: api/profissional/getuserinfo/<userName>
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("profissional/getuserinfo/", nomeDeUsuario);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }


        public DataTable GetCodigoENomeid()
        {
            // GET: api/profissional/getcodigoenomeid
            DataTable dtProfissionais = new DataTable();
            string json = Connection.RequestGET("profissional/getcodigoenomeid", string.Empty);
            dtProfissionais = JsonConvert.DeserializeObject<DataTable>(json);
            return dtProfissionais;
        }


        public ProfissionalENT GetBy(long id)
        {
            // GET: api/profissional/getby/<id>
            ProfissionalENT retorno = new ProfissionalENT();
            string json = Connection.RequestGET("profissional/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<ProfissionalENT>(json);
            return retorno;
        }

    }
}
