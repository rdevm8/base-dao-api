using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class Faq : BaseEntity
    {
        public Faq()
        {
            Question = String.Empty;
            Answer = String.Empty;
        }

        [Required]
        [Range(1,9999)]
        public int Order { get; set; }

        [Required]
        [StringLength(250)]
        public string Question { get; set; }

        [Required]
        [StringLength(250)]
        public string Answer { get; set; }


    }
}
