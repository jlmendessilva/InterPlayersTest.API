using FluentAssertions;
using InterPlayersTest.API.Validation;
using InterPlayersTest.Infra.Entitties;
using System;
using Xunit;
using System.Linq;
using InterPlayersTest.Infra.Validation;

namespace InterPlayersTest.Testes
{
    
    public class UserUnitTests
    {
        [Theory(DisplayName ="Teste de validação de senha")]
        [InlineData("null", "null")]
        [InlineData("", "")]
        [InlineData("Joao", "123")]
        [InlineData("Joao", "123456")]
        [InlineData("Joao", "@M15TReuvxz")]
        public void validatePassMinCharacteres(string name, string password)
        {
            var user = new User(name, password);

            var validator = new UserValidation();
            var result = validator.Validate(user);

            Assert.True(result.IsValid);

        }
    }
}
