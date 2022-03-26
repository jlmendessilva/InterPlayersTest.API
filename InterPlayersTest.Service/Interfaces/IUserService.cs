
using System.Collections.Generic;
using System.Threading.Tasks;
using InterPlayersTest.Infra.Entitties;

namespace InterPlayersTest.Service.Interfaces
{
    public interface IUserService
    {
        Task<List<string>> Register(User u);
    }
}
