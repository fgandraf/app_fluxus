//using
using System;

namespace Arqueng.ENTIDADES
{
    public class FaturasENT
    {
        int id = 0;

        string descricao, rrtart, subtotal_os, subtotal_desloc, total;
        DateTime data;
         

        public string Descricao { get => descricao; set => descricao = value; }
        public string Rrtart { get => rrtart; set => rrtart = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Subtotal_os { get => subtotal_os; set => subtotal_os = value; }
        public string Subtotal_desloc { get => subtotal_desloc; set => subtotal_desloc = value; }
        public string Total { get => total; set => total = value; }
        public int Id { get => id; set => id = value; }
    }
}
