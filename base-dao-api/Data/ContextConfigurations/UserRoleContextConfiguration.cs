using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class UserRoleContextConfiguration : IEntityTypeConfiguration<UserRole>
    {
        private readonly Guid[] _userIds;
        private readonly Guid[] _roleId;

        public UserRoleContextConfiguration(Guid[] userIds, Guid[] roleId)
        {
            _userIds = userIds;
            _roleId = roleId;
        }

        public void Configure(EntityTypeBuilder<UserRole> builder)
        {

            builder.HasOne(x => x.User).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);

            builder
                .HasData(
                new UserRole
                {
                    RoleId = _roleId[0],
                    UserId = _userIds[0]

                },
                new UserRole
                {
                    RoleId = _roleId[1],
                    UserId = _userIds[1]
                });
        }
    }
}