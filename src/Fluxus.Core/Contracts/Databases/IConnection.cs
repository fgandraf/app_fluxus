

namespace Fluxus.Core.Contracts.Databases;

public interface IConnection
{
    string Get(string model, string param);
    bool Put(string model, string json);
    bool Delete(string model, string param);
    int Post(string model, string json);
    (bool, string) Login(string model, string json);
}
