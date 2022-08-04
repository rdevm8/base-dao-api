using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class CodeDetailContextConfiguration : IEntityTypeConfiguration<CodeDetail>
    {

        private readonly Guid[] _headerIds;
        private readonly Guid[] _detailIds;

        public CodeDetailContextConfiguration(Guid[] headerIds, Guid[] detailIds)
        {
            _headerIds = headerIds;
            _detailIds = detailIds;
        }

        public void Configure(EntityTypeBuilder<CodeDetail> builder)
        {
            builder.HasIndex(x => x.DetailCd).IsUnique();

            builder
                .HasData(
                new CodeDetail
                {
                    Id = _detailIds[0],
                    DetailCd = "ROLE-ADMIN",
                    Description = "Admin User",
                    CodeHeaderId = _headerIds[0]
                },
                new CodeDetail
                {
                    Id = _detailIds[1],
                    DetailCd = "ROLE-NORMAL",
                    Description = "Normal User",
                    CodeHeaderId = _headerIds[0]
                },
                new CodeDetail
                {
                    Id = _detailIds[2],
                    DetailCd = "PSTATUS-OPEN",
                    Description = "Pool OPEN",
                    CodeHeaderId = _headerIds[1]
                },
                new CodeDetail
                {
                    Id = _detailIds[3],
                    DetailCd = "PSTATUS-ONGOING",
                    Description = "Pool ONGOING",
                    CodeHeaderId = _headerIds[1]
                },
                new CodeDetail
                {
                    Id = _detailIds[4],
                    DetailCd = "PSTATUS-CLOSED",
                    Description = "Pool CLOSED",
                    CodeHeaderId = _headerIds[1]
                }
                );
        }
    }
}