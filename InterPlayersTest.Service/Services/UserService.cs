using InterPlayersTest.API.Validation;
using InterPlayersTest.Infra.Entitties;
using InterPlayersTest.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterPlayersTest.Service.Services
{
    public class UserService : IUserService
    {
        public async Task<List<string>> Register(User u)
        {
            var valid = new UserValidation().Validate(u);
            var listResult = new List<string>();

            if (!valid.IsValid)
            {
                listResult = valid.Errors.Select(e => e.ErrorMessage).ToList();
                return listResult;
            }

            listResult.Add("Cadastrado com sucesso! Usuário atende os critérios de senha.");

            return listResult;

        }
    }
}
