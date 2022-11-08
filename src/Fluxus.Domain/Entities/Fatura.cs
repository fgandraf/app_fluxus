using System;

namespace Fluxus.Domain.Entities
{

    public class Fatura
    {
        public long id { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public double subtotal_os { get; set; }
        public double subtotal_desloc { get; set; }
        public double total { get; set; }
    }


}
