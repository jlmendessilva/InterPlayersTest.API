using InterPlayersTest.API.Validation;
using InterPlayersTest.Infra.Entitties;
using InterPlayersTest.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterPlayersTest.Service.Services
{
    class UserService : IUserService
    {
        public User Register(User u)
        {
            var valida = new UserValidation();
            var result_valida = valida.Validate(u).Errors;

            return u;
        }
    }
}
