using InterPlayersTest.API.Validation;
using InterPlayersTest.Infra.Entitties;
using InterPlayersTest.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterPlayersTest.Service.Services
{
    public class UserService : IUserService
    {
        public async Task<List<string>> Register(User u)
        {
            var valida = new UserValidation();
            var resultValidation = valida.Validate(u).Errors;
            var listResult = new List<string>();

            foreach (var item in resultValidation)
                listResult.Add(item.ErrorMessage);

            if (listResult.Count > 0)
                return listResult;

            listResult.Add("Acesso liberado!!");

            return listResult;

        }
    }
}
