
namespace Fluxus.Domain.Models;


public class Service
{
    public int Id { get; set; }
    public string Tag { get; set; }
    public string? Description { get; set; }
    public decimal ServiceAmount { get; set; }
    public decimal MileageAllowance { get; set; }


    public Service(int id, string tag, string description, decimal serviceAmount, decimal mileageAllowance)
    {
        Id = id;
        Tag = tag;
        Description = description;
        ServiceAmount = serviceAmount;
        MileageAllowance = mileageAllowance;
    }
    
}
