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

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("RoleId")]
        public Guid RoleId { get; set; }
        public CodeDetail Role { get; set; }



    }
}
