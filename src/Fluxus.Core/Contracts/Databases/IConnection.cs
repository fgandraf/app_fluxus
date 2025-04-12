

namespace Fluxus.Core.Contracts.Databases;

public interface IConnection
{
    string Get(string model, string param);
    public string GetWithBody(string model, string json);
    bool Put(string model, string json);
    bool Delete(string model, string param);
    long Post(string model, string json);
    public string PostWithResponse(string model, string json);
    (bool, string) Login(string model, string json);
}
