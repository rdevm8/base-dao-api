using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class CodeHeaderContextConfiguration : IEntityTypeConfiguration<CodeHeader>
    {

        private readonly Guid[] _ids;

        public CodeHeaderContextConfiguration(Guid[] ids)
        {
            _ids = ids;
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
                    Description = "CodeHeader for User Roles"
                },
                new CodeHeader
                {
                    Id = _ids[1],
                    HeaderCd = "PSTATUS",
                    Description = "CodeHeader for Pool Statuses"
                },
                new CodeHeader
                {
                    Id = _ids[2],
                    HeaderCd = "PFSTATUS",
                    Description = "CodeHeader for Pool Funder Statuses"
                },
                new CodeHeader
                {
                    Id = _ids[3],
                    HeaderCd = "PASTATUS",
                    Description = "CodeHeader for Pool Activity Statuses"
                });
        }
    }
}