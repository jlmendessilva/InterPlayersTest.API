namespace InterPlayersTest.Infra.Validation
{
    public static class ErrorMessages
    {
        public static string passwordNull = "Sua senha não pode ser nula";
        public static string passwordMincharacters = "Sua senha tem que ter no minimo 9 (nove) caracateres)";
        public static string passwordMinNumber = "Sua senha tem que ter pelo menos 1 (um) numero";
        public static string passwordLowerCase = "Sua senha tem que ter pelo menos 1 (um) caractere minúsculo";
        public static string passwordUpperCase = "Senha deve ter pelo menos 1 (um) caracter maiúsculo";
        public static string passwordCharactersSpecial = "Senha tem que ter pelo menos 1 (um) caracter especial Ex.: (!@#$%^&*()-+)";
        public static string passwordCharactersDuplicate = "Senha não pode ter caracter repetido";
        public static string passwordEmpty = "Sua senha não pode ser vazia";

    }
}
