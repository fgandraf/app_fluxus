using System;
using System.Drawing;

namespace Fluxus.Model.ENT
{

    public class CadastraisENT
    {
        public long Id { get; set; }
        public string Cnpj { get; set; }
        public string Fantasia { get; set; }
        public string Razao { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Db_banco { get; set; }
        public string Db_tipo { get; set; }
        public string Db_agencia { get; set; }
        public string Db_operador { get; set; }
        public string Db_conta { get; set; }
        public DateTime Constituicao { get; set; }
        public string Ct_tomador { get; set; }
        public string Ct_edital { get; set; }
        public string Ct_contrato { get; set; }
        public DateTime Ct_celebrado { get; set; }
        public DateTime Ct_inicio { get; set; }
        public DateTime Ct_termino { get; set; }
        public byte[] Logo { get; set; }
        
    }


}
