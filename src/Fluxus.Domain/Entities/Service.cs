
namespace Fluxus.Domain.Entities
{

    public class Service
    {

        public bool IsValid { get; private set; }
        public string? Message { get; private set; }



        public int Id { get; set; }
        public string? Tag { get; set; }
        public string? Description { get; set; }
        public string? ServiceAmount { get; set; }
        public string? MileageAllowance { get; set; }

        public Service() { }


        public Service(int id, string tag, string description, string serviceAmount, string mileageAllowance)
        {
            Id = id;
            Tag = tag;
            Description = description;
            ServiceAmount = serviceAmount;
            MileageAllowance = mileageAllowance;

            Validate();
        }

        public Service(string tag)
        {
            Tag = tag;

            Validate();
        }


        private void Validate()
        {
            if (string.IsNullOrEmpty(Tag))
            {
                Message = "Campos com * são obrigatório";
                IsValid = false;
            }

            IsValid = true;
        }

        
    }


}
