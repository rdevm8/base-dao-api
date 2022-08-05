using System.ComponentModel.DataAnnotations;

namespace base_dao_api.GraphQl.Mutations.Payloads
{
    public class PoolStatusPayload
    {
        [Required]
        public Guid StatusId { get; set; }
    }
}
