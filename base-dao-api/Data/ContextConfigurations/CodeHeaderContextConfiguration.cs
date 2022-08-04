using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class CodeHeaderContextConfiguration : IEntityTypeConfiguration<CodeHeader>
    {

        private readonly Guid[] _ids;
        private readonly Guid _systemId;

        public CodeHeaderContextConfiguration(Guid[] ids, Guid systemId)
        {
            _ids = ids;
            _systemId = systemId;
        }

        public void Configure(EntityTypeBuilder<CodeHeader> builder)
        {
            builder.HasIndex(x => x.HeaderCd).IsUnique();

            builder
                .HasData(
                new CodeHeader
                {
                    Id = _ids[0],
                    HeaderCd = "ROLE",
                    Description = "CodeHeader for User Roles",
                    CreateUserId = _systemId,
                    UpdateUserId = _systemId
                },
                new CodeHeader
                {
                    Id = _ids[1],
                    HeaderCd = "PSTATUS",
                    Description = "CodeHeader for Pool Statuses",
                    CreateUserId = _systemId,
                    UpdateUserId = _systemId
                });
        }
    }
}