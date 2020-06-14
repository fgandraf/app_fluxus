using System;

namespace Arqueng.ENTIDADES
{
    public class ProfissionaisENT
    {
        string codigo, nome, cpf, profissao, carteira, entidade, telefone1, telefone2, email;
        DateTime nascimento;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Profissao { get => profissao; set => profissao = value; }
        public string Carteira { get => carteira; set => carteira = value; }
        public string Entidade { get => entidade; set => entidade = value; }
        public string Telefone1 { get => telefone1; set => telefone1 = value; }
        public string Telefone2 { get => telefone2; set => telefone2 = value; }
        public string Email { get => email; set => email = value; }
    }
}
