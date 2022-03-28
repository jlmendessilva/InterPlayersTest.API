using System;

namespace InterPlayersTest.Infra.Entitties
{
    public class User
    {
        public User(string name, string password)
        {
            Id = new Guid();
            Name = name;
            Password = password;
        }

        public User(string password)
        {
            Password = password;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
    }
}
