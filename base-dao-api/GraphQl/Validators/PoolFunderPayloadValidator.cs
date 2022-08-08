using FluentValidation;
using base_dao_api.GraphQl.Mutations.Payloads;

namespace base_dao_api.GraphQl.Validators
{
    public class PoolFunderPayloadValidator : AbstractValidator<PoolFunderPayload>, IValidator
    {
        public PoolFunderPayloadValidator()
        {
            RuleFor(x => x.WalletAddress)
                .MinimumLength(1)
                .MaximumLength(42);

            RuleFor(x => x.AmtInvested)
                .NotNull()
                .GreaterThan(0)
                .ScalePrecision(2, 18);
        }
    }
}
