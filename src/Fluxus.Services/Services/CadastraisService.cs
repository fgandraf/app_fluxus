using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class CadastraisService
    {



        public void Insert(Cadastrais dado)
        {
            new CompanyRepository().Insert(dado);
        }



        public void Update(Cadastrais dado)
        {
            new CompanyRepository().Update(dado);
        }



        public Cadastrais ListarCadastrais()
        {
            DataTable dt = new CompanyRepository().GetAll();
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
            return new CompanyRepository().GetToPrint();
        }



        public string GetFantasia()
        {
            return new CompanyRepository().GetName();
        }



    }



}
