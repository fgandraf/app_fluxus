//using 

namespace Arqueng.ENT
{
    public class Atividades_ENT
    {
        string codigo, descricao, valor_atividade, valor_deslocamento;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Valor_atividade { get => valor_atividade; set => valor_atividade = value; }
        public string Valor_deslocamento { get => valor_deslocamento; set => valor_deslocamento = value; }
    }

    public class Agencias_ENT
    {
        string agencia, nome, endereco, complemento, bairro, cidade, cep, uf, contato, telefone1, telefone2, email;

        public string Agencia { get => agencia; set => agencia = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string CEP { get => cep; set => cep = value; }
        public string UF { get => uf; set => uf = value; }
        public string Contato { get => contato; set => contato = value; }
        public string Telefone1 { get => telefone1; set => telefone1 = value; }
        public string Telefone2 { get => telefone2; set => telefone2 = value; }
        public string Email { get => email; set => email = value; }
        
    }


}
