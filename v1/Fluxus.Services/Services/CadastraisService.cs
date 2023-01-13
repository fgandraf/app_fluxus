using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class CadastraisService
    {



        public void Insert(Cadastrais body)
        {
            new CompanyRepository().Insert(body);
        }



        public void Update(Cadastrais body)
        {
            new CompanyRepository().Update(body);
        }



        public Cadastrais ListarCadastrais()
        {
            DataTable dt = new CompanyRepository().GetAll();
            Cadastrais retorno = new Cadastrais
            {
                Cnpj = dt.Rows[0]["Cnpj"].ToString(),
                Nome = dt.Rows[0]["Nome"].ToString(),
                RazaoSocial = dt.Rows[0]["RazaoSocial"].ToString(),
                InscricaoEstadual = dt.Rows[0]["InscricaoEstadual"].ToString(),
                InscricaoMunicipal = dt.Rows[0]["InscricaoMunicipal"].ToString(),
                Endereco = dt.Rows[0]["Endereco"].ToString(),
                Complemento = dt.Rows[0]["Complemento"].ToString(),
                Bairro = dt.Rows[0]["Bairro"].ToString(),
                Cidade = dt.Rows[0]["Cidade"].ToString(),
                Cep = dt.Rows[0]["Cep"].ToString(),
                Uf = dt.Rows[0]["Uf"].ToString(),
                Constituicao = dt.Rows[0]["Constituicao"].ToString(),
                Telefone = dt.Rows[0]["Telefone"].ToString(),
                Telefone2 = dt.Rows[0]["Telefone2"].ToString(),
                Email = dt.Rows[0]["Email"].ToString(),
                BancoNome = dt.Rows[0]["BancoNome"].ToString(),
                BancoTipo = dt.Rows[0]["BancoTipo"].ToString(),
                BancoAgencia = dt.Rows[0]["BancoAgencia"].ToString(),
                BancoOperador = dt.Rows[0]["BancoOperador"].ToString(),
                BancoConta = dt.Rows[0]["BancoConta"].ToString(),
                ContratoTomador = dt.Rows[0]["ContratoTomador"].ToString(),
                ContratoEdital = dt.Rows[0]["ContratoEdital"].ToString(),
                ContratoNumero = dt.Rows[0]["ContratoNumero"].ToString(),
                ContratoCelebrado = dt.Rows[0]["ContratoCelebrado"].ToString(),
                ContratoInicio = dt.Rows[0]["ContratoInicio"].ToString(),
                ContratoTermino = dt.Rows[0]["ContratoTermino"].ToString(),
                Logotipo = dt.Rows[0]["Logotipo"].ToString()
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
