using System.Threading.Tasks;

namespace SingleSignOn.Contracts
{
    public interface IAuthServerConnect
    {
        Task<string> RequestClientCredentialsTokenAsync();
    }
}
