using FluentValidation;
using base_dao_api.GraphQl.Mutations.Payloads;

namespace base_dao_api.GraphQl.Validators
{
    public class PoolStatusPayloadValidator : AbstractValidator<PoolStatusPayload>, IValidator
    {
        public PoolStatusPayloadValidator()
        {
            RuleFor(x => x.StatusId)
                .NotNull()
                .NotEmpty()
                .NotEqual(Guid.Empty);

        }
    }
}
