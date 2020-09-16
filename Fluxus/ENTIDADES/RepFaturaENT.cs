using System;

namespace Arqueng.ENTIDADES
{

    public class RepFaturaENT
    {
        public DateTime data_ordem { get; set; }
        public string referencia { get; set; }
        public string atividade_cod { get; set; }
        public string cidade { get; set; }
        public DateTime data_concluida { get; set; }
        public string valor_atividade { get; set; }
        public string valor_deslocamento { get; set; }
    }


}
