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
                    DetailCd = "ROLE-SYSTEM",
                    Description = "System User",
                    CodeHeaderId = _headerIds[0]
                },
                new CodeDetail
                {
                    Id = _detailIds[1],
                    DetailCd = "ROLE-ADMIN",
                    Description = "Admin User",
                    CodeHeaderId = _headerIds[0]
                },
                new CodeDetail
                {
                    Id = _detailIds[2],
                    DetailCd = "ROLE-NORMAL",
                    Description = "Normal User",
                    CodeHeaderId = _headerIds[0]
                },
                new CodeDetail
                {
                    Id = _detailIds[3],
                    DetailCd = "PSTATUS-OPEN",
                    Description = "Pool OPEN",
                    CodeHeaderId = _headerIds[1]
                },
                new CodeDetail
                {
                    Id = _detailIds[4],
                    DetailCd = "PSTATUS-ONGOING",
                    Description = "Pool ONGOING",
                    CodeHeaderId = _headerIds[1]
                },
                new CodeDetail
                {
                    Id = _detailIds[5],
                    DetailCd = "PSTATUS-CLOSED",
                    Description = "Pool CLOSED",
                    CodeHeaderId = _headerIds[1]
                },
                new CodeDetail
                {
                    Id = _detailIds[6],
                    DetailCd = "PFSTATUS-IN",
                    Description = "Pool funder IN",
                    CodeHeaderId = _headerIds[2]
                },
                new CodeDetail
                {
                    Id = _detailIds[7],
                    DetailCd = "PFTATUS-OUT",
                    Description = "Pool funder OUT",
                    CodeHeaderId = _headerIds[2]
                },
                new CodeDetail
                {
                    Id = _detailIds[8],
                    DetailCd = "PASTATUS-SU",
                    Description = "Pool activity status update",
                    CodeHeaderId = _headerIds[3]
                },
                new CodeDetail
                {
                    Id = _detailIds[9],
                    DetailCd = "PASTATUS-PU",
                    Description = "Pool activity descriptions update",
                    CodeHeaderId = _headerIds[3]
                },
                new CodeDetail
                {
                    Id = _detailIds[10],
                    DetailCd = "PASTATUS-FU",
                    Description = "Pool activity funders update",
                    CodeHeaderId = _headerIds[3]
                }
                );
        }
    }
}