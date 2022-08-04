using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class UserRole : BaseEntity
    {
        public UserRole()
        {
        }

        [ForeignKey("CodeDetailId")]
        public Guid CodeDetailId { get; set; }
        public CodeDetail CodeDetail { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
