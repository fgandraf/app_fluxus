using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System.Data;

namespace Fluxus.Model
{
    class CadastraisModel
    {





        // POST api/cadastrais/post
        public void Insert(CadastraisENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("cadastrais/post", jsonData);
        }





        // PUT api/cadastrais/put
        public void Update(CadastraisENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("cadastrais/put", jsonData);
        }





        // GET: api/cadastrais
        public DataTable ListarCadastrais()
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("cadastrais", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/cadastrais/gettoprint
        public DataTable DadosParaImpressao()
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("cadastrais/gettoprint", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/cadastrais/getfantasia
        public string GetFantasia()
        {
            string json = WebAPI.RequestGET("cadastrais/getfantasia", string.Empty);
            return json;
        }




    }


}
