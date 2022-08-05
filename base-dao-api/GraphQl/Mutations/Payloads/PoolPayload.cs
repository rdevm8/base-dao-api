using System.ComponentModel.DataAnnotations;

namespace base_dao_api.GraphQl.Mutations.Payloads
{
    public class PoolPayload
    {
        [Required]
        [StringLength(50, MinimumLength =1)]
        public string Title { get; set; } = String.Empty;
        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Description { get; set; } = String.Empty;
        [Required]
        [Range(0.01, 99999999)]
        public decimal MinInvestment { get; set; }
    }
}
