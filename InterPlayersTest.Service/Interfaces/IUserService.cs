
using System.Threading.Tasks;
using InterPlayersTest.Infra.Entitties;

namespace InterPlayersTest.Service.Interfaces
{
    public interface IUserService
    {
        User Register(User u);
    }
}
