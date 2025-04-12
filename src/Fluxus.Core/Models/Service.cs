
namespace Fluxus.Core.Models;


public class Service
{
    public long Id { get; set; }
    public string Tag { get; set; }
    public string? Description { get; set; }
    public double ServiceAmount { get; set; }
    public double MileageAllowance { get; set; }


    public Service(long id, string tag, string description, double serviceAmount, double mileageAllowance)
    {
        Id = id;
        Tag = tag;
        Description = description;
        ServiceAmount = serviceAmount;
        MileageAllowance = mileageAllowance;
    }
    
}
