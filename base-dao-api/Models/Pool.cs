using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class Pool : BaseEntity
    {
        public Pool()
        {
            Title = String.Empty;
            Description = String.Empty;
        }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, 99999999)]
        public decimal MinInvestment { get; set; }

        [ForeignKey("StatusId")]
        public Guid StatusId { get; set; }
        public CodeDetail Status { get; set; }

        public ICollection<PoolFunder> PoolFunders { get; set; }

        public ICollection<PoolActivity> PoolActivities { get; set; }


    }
}
