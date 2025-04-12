using Fluxus.Core.Models;

namespace Fluxus.Core.Dtos.Branches;

public record BranchUpdateRequest
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Complement { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Zip { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ContactName { get; set; } = string.Empty;
    public string Phone1 { get; set; } = string.Empty;
    public string Phone2 { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public BranchUpdateRequest(Branch branch)
    {
        Id = branch.Id;
        Name = branch.Name;
        Address = branch.Address;
        Complement = branch.Complement;
        District = branch.District;
        City = branch.City;
        Zip = branch.Zip;
        State = branch.State;
        ContactName = branch.ContactName;
        Phone1 = branch.Phone1;
        Phone2 = branch.Phone2;
        Email = branch.Email;
    }

    public BranchUpdateRequest() { }
}