using InterPlayersTest.API.Validation;
using InterPlayersTest.Infra.Entitties;
using Xunit;

namespace InterPlayersTest.Testes
{

    public class UserUnitTests
    {
        [Theory(DisplayName ="Teste de validação de senha")]

        [InlineData("", "")] 
        [InlineData("Joao", "123")]
        [InlineData("Joao", "1234567890")]
        [InlineData("Joao", "123456789A")]
        [InlineData("Joao", "123456789Aa")]
        [InlineData("Joao", "123456789Aa$")]

        public void Validador(string name, string password)
        {
            var user = new User(name, password);

            var validator = new UserValidation();
            var result = validator.Validate(user);

            Assert.True(result.IsValid);

        }
    }
}
