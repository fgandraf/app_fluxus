
namespace Fluxus.Core.Models;


public class Branch
{

    public string Id { get; private set; }
    public string Name { get; private set; }
    public string Address { get; private set; }
    public string Complement { get; private set; }
    public string District { get; private set; }
    public string City { get; private set; }
    public string Zip { get; private set; }
    public string State { get; private set; }
    public string ContactName { get; private set; }
    public string Phone1 { get; private set; }
    public string Phone2 { get; private set; }
    public string Email { get; private set; }



    public Branch(string id, string name, string address, string complement, string district, string city, string zip, string state, string contactName, string phone1, string phone2, string email)
    {
        Id = id;
        Name = name;
        Address = address;
        Complement = complement;
        District = district;
        City = city;
        Zip = zip;
        State = state;
        ContactName = contactName;
        Phone1 = phone1;
        Phone2 = phone2;
        Email = email;
    }

    
}
