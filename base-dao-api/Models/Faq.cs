using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class Faq : Base
    {
        public Faq()
        {
            Id = Guid.NewGuid();
            Question = String.Empty;
            Answer = String.Empty;
        }

        [Key]
        public Guid Id { get; set; }

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
