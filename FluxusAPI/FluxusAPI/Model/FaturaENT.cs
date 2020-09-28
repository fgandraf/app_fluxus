using System;

namespace FluxusAPI.Model
{

    public class FaturaENT
    {
        public long id { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public string subtotal_os { get; set; }
        public string subtotal_desloc { get; set; }
        public string total { get; set; }
    }


}
