using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class PoolActivity : Base
    {
        public PoolActivity()
        {
            Id = Guid.NewGuid();
            Description = String.Empty;
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey("CodeDetailId")]
        public Guid CodeDetailId { get; set; }
        public CodeDetail CodeDetail { get; set; }


        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [ForeignKey("PoolId")]
        public Guid PoolId { get; set; }
        public Pool Pool { get; set; }


    }
}
