using InterPlayersTest.API.Validation;
using InterPlayersTest.Infra.Entitties;
using Xunit;

namespace InterPlayersTest.Testes
{

    public class UserUnitTests
    {
        [Theory(DisplayName ="Teste de validação geral de senha")]

        [InlineData("", "")] 
        [InlineData("Joao", "123")]
        [InlineData("Joao", "1234567890")]
        [InlineData("Joao", "123456789A")]
        [InlineData("Joao", "123456789Aa")]
        [InlineData("Joao", "123456789Aa$")]

        public void Validador(string name, string password)
        {
            var user = new User(name, password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid);

        }

        [Theory(DisplayName = "Teste de validação senha vazia")]

        [InlineData("")]
        [InlineData("123456789Aa$")]

        public void valPassEmpty(string password)
        {
            var user = new User(password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid, "NO OK");

        }

        [Theory(DisplayName = "Teste de validação no minimo 9 (nove) caracateres")]

        [InlineData("123")]
        [InlineData("123456789Aa$")]

        public void valMinCharacters(string password)
        {
            var user = new User(password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid, "NO OK");

        }

        [Theory(DisplayName = "Sua senha tem que ter pelo menos 1 (um) numero")]

        [InlineData("@Abcdefgh")]
        [InlineData("@Abcdefgh1")]

        public void valMinNumber(string password)
        {
            var user = new User(password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid, "NO OK");

        }

        [Theory(DisplayName = "Sua senha tem que ter pelo menos 1 (um) caractere minúsculo")]

        [InlineData("@Abcdefgh")]
        [InlineData("@Abcdefgh1")]

        public void valLowerCase(string password)
        {
            var user = new User(password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid, "NO OK");

        }

        [Theory(DisplayName = "Senha deve ter pelo menos 1 (um) caractere maiúsculo")]

        [InlineData("@abcdefgh")]
        [InlineData("@Abcdefgh1")]

        public void valUpperCase(string password)
        {
            var user = new User(password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid, "NO OK");

        }

        [Theory(DisplayName = "Senha tem que ter pelo menos 1 (um) caractere especial Ex.: (!@#$%^&*()")]

        [InlineData("abcdefgh1")]
        [InlineData("@Abcdefgh1")]

        public void valCharactersSpecial(string password)
        {
            var user = new User(password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid, "NO OK");

        }

        [Theory(DisplayName = "Senha não pode ter caracter repetido")]

        [InlineData("@Abcdefgh1")]
        [InlineData("@AAbcdefgh1")]

        public void valCharactersDuplicate(string password)
        {
            var user = new User(password);
            var result = new UserValidation().Validate(user);

            Assert.True(result.IsValid, "NO OK");

        }
    }
}
