
using InterPlayersTest.Infra.Entitties;
using System.Threading.Tasks;

namespace InterPlayersTest.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> Register(User u);
    }
}
