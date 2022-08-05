using FluentValidation;
using base_dao_api.GraphQl.Mutations.Payloads;

namespace base_dao_api.GraphQl.Validators
{
    public class LoginPayloadValidator : AbstractValidator<LoginPayload>, IValidator
    {
        public LoginPayloadValidator()
        {
            RuleFor(x => x.WalletAddress)
                .MinimumLength(1)
                .MaximumLength(42);
        }
    }
}
