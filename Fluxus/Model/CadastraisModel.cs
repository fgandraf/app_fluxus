using Fluxus.DAO;
using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Data;

namespace Fluxus.Model
{
    class CadastraisModel
    {

        bool localDataBase = Util.LocalDB;


        public void Insert(CadastraisENT dado)
        {
            if (localDataBase)
                InsertLocal(dado);
            else
                PostAPI(dado);
        }
        public void Update(CadastraisENT dado)
        {
            if (localDataBase)
                UpdateLocal(dado);
            else
                PutAPI(dado);
        }
        public CadastraisENT ListarCadastrais()
        {
            if (localDataBase)
                return ListarCadastraisLocal();
            else
                return ListarCadastraisAPI();
        }
        public DataTable DadosParaImpressao()
        {
            if (localDataBase)
                return GetToPrintLocal();
            else
                return GetToPrintAPI();
        }
        public string GetFantasia()
        {
            if (localDataBase)
                return GetFantasiaLocal();
            else
                return GetFantasiaAPI();
        }





        //----------
        private void InsertLocal(CadastraisENT dado)
        {
            try
            {
                new CadastraisDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PostAPI(CadastraisENT dado)
        {
            // POST: api/cadastrais/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("cadastrais/post", jsonData);
        }
        //----------
        private void UpdateLocal(CadastraisENT dado)
        {
            try
            {
                new CadastraisDAO().Update(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PutAPI(CadastraisENT dado)
        {
            // PUT api/cadastrais/put
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("cadastrais/put", jsonData);
        }
        //----------
        private CadastraisENT ListarCadastraisLocal()
        {
            try
            {
                return new CadastraisDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private CadastraisENT ListarCadastraisAPI()
        {
            // GET: api/cadastrais
            string json = WebAPI.RequestGET("cadastrais", string.Empty);
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);

            CadastraisENT retorno = new CadastraisENT
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
        //----------
        private DataTable GetToPrintLocal()
        {
            try
            {
                return new CadastraisDAO().GetToPrint();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetToPrintAPI()
        {
            // GET: api/cadastrais/gettoprint
            DataTable retorno = new DataTable();
                    string json = WebAPI.RequestGET("cadastrais/gettoprint", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private string GetFantasiaLocal()
        {
            try
            {
                return new CadastraisDAO().GetFantasia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string GetFantasiaAPI()
        {
            // GET: api/cadastrais/getfantasia
            string json = WebAPI.RequestGET("cadastrais/getfantasia", string.Empty);
            return json;
        }
        //----------

    }


}
