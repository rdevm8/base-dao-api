using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace base_dao_api.Models
{
    public class User : Base
    {
        public User()
        {
            Id = Guid.NewGuid();
            WalletAddress = String.Empty;
            Name = String.Empty;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(42)]
        public string WalletAddress { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

    }
}
