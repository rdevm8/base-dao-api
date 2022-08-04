using FluentValidation;
using base_dao_api.GraphQl.Payloads;

namespace base_dao_api.GraphQl.Validators
{
    public class FaqPayloadValidator : AbstractValidator<FaqPayload>, IValidator
    {
        public FaqPayloadValidator()
        {
            RuleFor(x => x.Question)
                .MinimumLength(1)
                .MaximumLength(250);

            RuleFor(x => x.Answer)
                .MinimumLength(1)
                .MaximumLength(250);

            RuleFor(x => x.Order)
                .GreaterThan(0);
        }
    }
}
