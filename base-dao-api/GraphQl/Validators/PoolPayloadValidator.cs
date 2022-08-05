using FluentValidation;
using base_dao_api.GraphQl.Mutations.Payloads;

namespace base_dao_api.GraphQl.Validators
{
    public class PoolPayloadValidator : AbstractValidator<PoolPayload>, IValidator
    {
        double min = 0.01;
        public PoolPayloadValidator()
        {
            RuleFor(x => x.Title)
                .MinimumLength(1)
                .MaximumLength(250);

            RuleFor(x => x.Description)
                .MinimumLength(1)
                .MaximumLength(250);

            RuleFor(x => x.MinInvestment)
                .GreaterThan(0)
                .ScalePrecision(2, 18);
        }
    }
}
