using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class CodeDetail : BaseEntity
    {
        public CodeDetail()
        {
            DetailCd = String.Empty;
            Description = String.Empty;
        }

        [ForeignKey("CodeHeaderId")]
        public Guid CodeHeaderId { get; set; }
        public CodeHeader CodeHeader { get; set; }

        [Required]
        [StringLength(25)]
        public string DetailCd { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }



    }
}
