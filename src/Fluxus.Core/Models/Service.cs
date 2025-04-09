
namespace Fluxus.Core.Models;


public class Service
{
    public long Id { get; set; }
    public string Tag { get; set; }
    public string? Description { get; set; }
    public decimal ServiceAmount { get; set; }
    public decimal MileageAllowance { get; set; }


    public Service(long id, string tag, string description, decimal serviceAmount, decimal mileageAllowance)
    {
        Id = id;
        Tag = tag;
        Description = description;
        ServiceAmount = serviceAmount;
        MileageAllowance = mileageAllowance;
    }
    
}
