using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class CodeHeader : Base
    {
        public CodeHeader()
        {
            Id = Guid.NewGuid();
            HeaderCd = String.Empty;
            Description = String.Empty;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25)]
        public string HeaderCd { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public ICollection<CodeDetail> CodeDetails { get; set; }



    }
}
