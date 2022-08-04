using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class UserRoleContextConfiguration : IEntityTypeConfiguration<UserRole>
    {
        private readonly Guid[] _userIds;
        private readonly Guid _roleId;
        private readonly Guid _systemId;

        public UserRoleContextConfiguration(Guid[] userIds, Guid roleId)
        {
            _userIds = userIds;
            _roleId = roleId;
            _systemId = _userIds[1];
        }

        public void Configure(EntityTypeBuilder<UserRole> builder)
        {

            builder
                .HasData(
                new UserRole
                {
                    CodeDetailId = _roleId,
                    UserId = _userIds[0],
                    CreateUserId = _systemId,
                    UpdateUserId = _systemId

                },
                new UserRole
                {
                    CodeDetailId = _roleId,
                    UserId = _userIds[1],
                    CreateUserId = _systemId,
                    UpdateUserId = _systemId
                });
        }
    }
}