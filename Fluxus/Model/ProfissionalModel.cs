using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Fluxus.Model
{
    class ProfissionalModel
    {





        // POST api/profissional/post
        public void Insert(ProfissionalENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = WebAPI.RequestPOST("profissional/post", jsonData);
        }





        // PUT api/profissional/put/<id>
        public void Update(long id, ProfissionalENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = WebAPI.RequestPUT("profissional/put/" + id, jsonData);
        }





        // DELETE api/profissional/delete/<id>
        public void Delete(long id)
        {
            string retorno = WebAPI.RequestDELETE("profissional/delete/", id.ToString());
        }





        // GET: api/profissional
        public DataTable ListarProfissionais()
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("profissional", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/profissional/getuserinfo/<userName>
        public DataTable BuscarUsuario(string nomeDeUsuario)
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("profissional/getuserinfo/", nomeDeUsuario);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/profissional/getcodigoenomeid
        public DataTable ListarCodigoENomeid(bool adicionaTitulo)
        {
            DataTable dtProfissionais = new DataTable();
            try
            {
                string json = WebAPI.RequestGET("profissional/getcodigoenomeid", string.Empty);
                dtProfissionais = JsonConvert.DeserializeObject<DataTable>(json);

                if (adicionaTitulo)
                {
                    DataRow linha = dtProfissionais.NewRow();
                    linha[1] = "--TODAS--";
                    dtProfissionais.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtProfissionais;
        }





        // GET api/profissional/getby/<id>
        public ProfissionalENT GetBy(long id)
        {
            ProfissionalENT retorno = new ProfissionalENT();
            string json = WebAPI.RequestGET("profissional/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<ProfissionalENT>(json);
            return retorno;
        }
    
    
    
    
    
    }
}
