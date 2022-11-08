using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class CompanyRepository
    {
        public void Insert(Cadastrais dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Post("cadastrais/post", json);
        }

        public void Update(Cadastrais dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Put("cadastrais/put", json);
        }

        public DataTable GetAll()
        {
            string json = Request.Get("cadastrais", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetToPrint()
        {
            string json = Request.Get("cadastrais/gettoprint", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public string GetName()
        {
            return Request.Get("cadastrais/getfantasia", string.Empty);
        }
    }
}
