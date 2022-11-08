using Fluxus.Domain.Models;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Presentation.Controller
{
    class CadastraisController
    {



        public void Insert(Cadastrais dado)
        {
            // POST: api/cadastrais/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPOST("cadastrais/post", jsonData);
        }



        public void Update(Cadastrais dado)
        {
            // PUT api/cadastrais/put
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPUT("cadastrais/put", jsonData);
        }



        public Cadastrais ListarCadastrais()
        {
            // GET: api/cadastrais
            string json = Connection.RequestGET("cadastrais", string.Empty);
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);

            Cadastrais retorno = new Cadastrais
            {
                Cnpj = dt.Rows[0]["cnpj"].ToString(),
                Fantasia = dt.Rows[0]["fantasia"].ToString(),
                Razao = dt.Rows[0]["razao"].ToString(),
                Ie = dt.Rows[0]["ie"].ToString(),
                Im = dt.Rows[0]["im"].ToString(),
                Endereco = dt.Rows[0]["endereco"].ToString(),
                Complemento = dt.Rows[0]["complemento"].ToString(),
                Bairro = dt.Rows[0]["bairro"].ToString(),
                Cidade = dt.Rows[0]["cidade"].ToString(),
                Cep = dt.Rows[0]["cep"].ToString(),
                Uf = dt.Rows[0]["uf"].ToString(),
                Constituicao = dt.Rows[0]["constituicao"].ToString(),
                Telefone = dt.Rows[0]["telefone"].ToString(),
                Telefone2 = dt.Rows[0]["telefone2"].ToString(),
                Email = dt.Rows[0]["email"].ToString(),
                Db_banco = dt.Rows[0]["db_banco"].ToString(),
                Db_tipo = dt.Rows[0]["db_tipo"].ToString(),
                Db_agencia = dt.Rows[0]["db_agencia"].ToString(),
                Db_operador = dt.Rows[0]["db_operador"].ToString(),
                Db_conta = dt.Rows[0]["db_conta"].ToString(),
                Ct_tomador = dt.Rows[0]["ct_tomador"].ToString(),
                Ct_edital = dt.Rows[0]["ct_edital"].ToString(),
                Ct_contrato = dt.Rows[0]["ct_contrato"].ToString(),
                Ct_celebrado = dt.Rows[0]["ct_celebrado"].ToString(),
                Ct_inicio = dt.Rows[0]["ct_inicio"].ToString(),
                Ct_termino = dt.Rows[0]["ct_termino"].ToString(),
                Logo = dt.Rows[0]["logo"].ToString()
            };
            return retorno;
        }



        public DataTable DadosParaImpressao()
        {
            // GET: api/cadastrais/gettoprint
            DataTable retorno = new DataTable();
            string json = Connection.RequestGET("cadastrais/gettoprint", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }



        public string GetFantasia()
        {
            // GET: api/cadastrais/getfantasia
            string json = Connection.RequestGET("cadastrais/getfantasia", string.Empty);
            return json;
        }



    }



}
