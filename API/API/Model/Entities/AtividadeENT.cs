using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Model.Entities
{
    public class AtividadeENT
    {
        public long Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Valor_atividade { get; set; }
        public string Valor_deslocamento { get; set; }
    }
}