using FluentValidation;
using InterPlayersTest.Infra.Entitties;
using InterPlayersTest.Infra.Validation;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterPlayersTest.API.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.Password).NotNull().WithMessage(ErrorMessages.passwordNull)
                .MinimumLength(9).WithMessage(ErrorMessages.passwordMincharacters)
                .Must(VerifyDigit).WithMessage(ErrorMessages.passwordMinNumber)
                .Must(VerifyLowerCase).WithMessage(ErrorMessages.passwordLowerCase)
                .Must(VerifyUpperCase).WithMessage(ErrorMessages.passwordUpperCase)
                .Must(VerifyNonAlphanumeric).WithMessage(ErrorMessages.passwordCharactersSpecial)
                .Must(VerifyDuplicate).WithMessage(ErrorMessages.passwordCharactersDuplicate)
                .NotEmpty().WithMessage(ErrorMessages.passwordEmpty);

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
