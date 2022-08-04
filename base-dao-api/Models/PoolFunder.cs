using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class PoolFunder : BaseEntity
    {
        public PoolFunder()
        {
            WalletAddress = String.Empty;
        }

        [Required]
        [StringLength(42)]
        public string WalletAddress { get; set; }

        [Required]
        [Range(0.01, 99999999)]
        public decimal AmtInvested { get; set; }

        [Required]
        public decimal AmtReturned { get; set; }

        [ForeignKey("PoolId")]
        public Guid PoolId { get; set; }
        public Pool Pool { get; set; }


    }
}
