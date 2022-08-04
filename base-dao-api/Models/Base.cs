using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class Base
    {
        public Base()
        {
            CreateDttm = DateTime.Now;
            CreateUserId = Guid.Empty;
            UpdateDttm = DateTime.Now;
            UpdateUserId = Guid.Empty;
            IsActive = true;
        }

        [Required]
        public DateTime CreateDttm { get; set; }
        [Required]
        public Guid CreateUserId { get; set; }
        [Required]
        public DateTime UpdateDttm { get; set; }
        [Required]
        public Guid UpdateUserId { get; set; }
        [Required]
        public bool IsActive { get; set; }


    }
}
