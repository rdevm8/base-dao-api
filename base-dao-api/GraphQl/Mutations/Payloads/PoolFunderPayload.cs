using System.ComponentModel.DataAnnotations;

namespace base_dao_api.GraphQl.Mutations.Payloads
{
    public class PoolFunderPayload
    {
        [Required]
        [StringLength(42, MinimumLength =1)]
        public string WalletAddress { get; set; } = String.Empty;
        public decimal AmtInvested { get; set; }
    }
}
