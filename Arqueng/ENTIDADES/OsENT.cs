using System;

namespace Arqueng.ENTIDADES
{
    public class OsENT
    {

        string id, titulo, referencia, profissional_cod, atividade_cod, nome_cliente,
        cidade, nome_contato, telefone_contato, status, obs, fatura_cod;

        DateTime data_ordem, prazo_execucao, data_pendente, data_vistoria, data_concluida;

        Boolean siopi, faturada;


        public string Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public string Profissional_cod { get => profissional_cod; set => profissional_cod = value; }
        public string Atividade_cod { get => atividade_cod; set => atividade_cod = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Nome_contato { get => nome_contato; set => nome_contato = value; }
        public string Telefone_contato { get => telefone_contato; set => telefone_contato = value; }
        public string Status { get => status; set => status = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Fatura_cod { get => fatura_cod; set => fatura_cod = value; }
        public DateTime Data_ordem { get => data_ordem; set => data_ordem = value; }
        public DateTime Prazo_execucao { get => prazo_execucao; set => prazo_execucao = value; }
        public DateTime Data_pendente { get => data_pendente; set => data_pendente = value; }
        public DateTime Data_vistoria { get => data_vistoria; set => data_vistoria = value; }
        public DateTime Data_concluida { get => data_concluida; set => data_concluida = value; }
        public bool Siopi { get => siopi; set => siopi = value; }
        public bool Faturada { get => faturada; set => faturada = value; }
    }
}
