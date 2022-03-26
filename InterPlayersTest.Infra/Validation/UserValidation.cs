using FluentValidation;
using InterPlayersTest.Infra.Entitties;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterPlayersTest.API.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.Password).NotNull().WithMessage("Sua senha não pode ser nula")
                .MinimumLength(9).WithMessage("Sua senha tem que ter no minimo 9 (nove) caracateres)")
                .Must(VerifyDigit).WithMessage("Sua senha tem que ter pelo menos 1 (um) numero")
                .Must(VerifyLowerCase).WithMessage("Sua senha tem que ter pelo menos 1 (um) caractere minúsculo")
                .Must(VerifyUpperCase).WithMessage("Senha deve ter pelo menos 1 (um) caracter maiúsculo")
                .Must(VerifyNonAlphanumeric).WithMessage("Senha tem que ter pelo menos 1 (um) caracter especial Ex.: (!@#$%^&*()-+)")
                .Must(VerifyDuplicate).WithMessage("Senha não pode ter caracter repetido")
                .NotEmpty().WithMessage("Sua senha não pode ser vazia");

        }


        private bool VerifyDigit(string p)
        {
            return (p.Any(x => char.IsDigit(x)));

        }

        private bool VerifyLowerCase(string p)
        {
            return (p.Any(x => char.IsLower(x)));

        }

        private bool VerifyUpperCase(string p)
        {
            return (p.Any(x => char.IsUpper(x)));

        }

        private bool VerifyNonAlphanumeric(string p)
        {

            return (Regex.IsMatch(p, "(?=.*[!@#$%^&*()-+])"));

        }

        private bool VerifyDuplicate(string p)
        {
            bool duplicatecharacter = false;

            if (p != string.Empty)
            {
                for (int currentletterindex = 0; currentletterindex < p.Length; currentletterindex++)
                {
                    if (currentletterindex < p.Length - 1)
                    {
                        var currentletter = p.Substring(currentletterindex, 1);

                        if (p.IndexOf(currentletter, currentletterindex + 1) > -1)
                        {
                            duplicatecharacter = true;
                            break;
                        }
                    }
                }
            }

            return !duplicatecharacter;
        }
    }
}
