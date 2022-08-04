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
                .MaximumLength(250)
                .WithMessage("Question must be between 1 - 250 characters")
                .WithErrorCode("QUESTION_LENGTH");
        }
    }
}
