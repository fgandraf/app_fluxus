//using
using System;

namespace Arqueng.ENTIDADES
{
    public class FaturasENT
    {
        int id = 0;

        string descricao, rrtart, valor_os, valor_deslocamento, valor_total;
        DateTime data;
         

        public string Descricao { get => descricao; set => descricao = value; }
        public string Rrtart { get => rrtart; set => rrtart = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Valor_os { get => valor_os; set => valor_os = value; }
        public string Valor_deslocamento { get => valor_deslocamento; set => valor_deslocamento = value; }
        public string Valor_total { get => valor_total; set => valor_total = value; }
        public int Id { get => id; set => id = value; }
    }
}
