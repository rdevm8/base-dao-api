using base_dao_api.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public abstract class BaseEntity : IEntity
    {
        private readonly string sysName = "SYSTEM";

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedBy = sysName;
            CreateDttm = DateTime.UtcNow;
            UpdatedBy= sysName;
            UpdateDttm = DateTime.UtcNow;
            IsDeleted = false;
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(250)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreateDttm { get; set; }

        [StringLength(250)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdateDttm { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

    }
}
