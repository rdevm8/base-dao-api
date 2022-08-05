using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class PoolActivity : BaseEntity
    {
        public PoolActivity()
        {
            Description = String.Empty;
        }

        [ForeignKey("PoolId")]
        public Guid PoolId { get; set; }
        public Pool Pool { get; set; }


        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [ForeignKey("StatusId")]
        public Guid StatusId { get; set; }
        public CodeDetail Status { get; set; }



    }
}
