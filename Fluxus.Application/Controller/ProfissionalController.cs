using Fluxus.Domain.Models;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Application.Controller
{
    class ProfissionalController
    {



        public void Insert(Profissional dado)
        {
            // POST: api/profissional/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = Connection.RequestPOST("profissional/post", jsonData);
        }



        public void Update(long id, Profissional dado)
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



        public DataTable ListarProfissionais()
        {
            // GET: api/profissional
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("profissional", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }



        public DataTable BuscarUsuario(string nomeDeUsuario)
        {
            // GET: api/profissional/getuserinfo/<userName>
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("profissional/getuserinfo/", nomeDeUsuario);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }



        public DataTable ListarCodigoENomeid(bool adicionaTitulo)
        {
            // GET: api/profissional/getcodigoenomeid
            DataTable dtPro = new DataTable();
            string json = Connection.RequestGET("profissional/getcodigoenomeid", string.Empty);
            dtPro = JsonConvert.DeserializeObject<DataTable>(json);

            if (adicionaTitulo)
            {
                DataRow linha = dtPro.NewRow();
                linha[1] = "--TODOS--";
                dtPro.Rows.InsertAt(linha, 0);
            }

            return dtPro;

        }



        public Profissional GetBy(long id)
        {
            // GET: api/profissional/getby/<id>
            Profissional retorno = new Profissional();
            string json = Connection.RequestGET("profissional/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<Profissional>(json);
            return retorno;
        }



    }



}
