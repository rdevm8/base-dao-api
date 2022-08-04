using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class Pool : Base
    {
        public Pool()
        {
            Id = Guid.NewGuid();
            Title = String.Empty;
            Description = String.Empty;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, 99999999)]
        public decimal MinInvestment { get; set; }

        [ForeignKey("CodeDetailId")]
        public Guid CodeDetailId { get; set; }
        public CodeDetail CodeDetail { get; set; }

        public ICollection<PoolFunder> PoolFunders { get; set; }

        public ICollection<PoolActivity> PoolActivities { get; set; }


    }
}
