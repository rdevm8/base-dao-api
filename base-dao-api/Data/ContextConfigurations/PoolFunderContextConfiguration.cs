using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class PoolFunderContextConfiguration : IEntityTypeConfiguration<PoolFunder>
    {

        public PoolFunderContextConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<PoolFunder> builder)
        {
            builder.Property(x => x.AmtInvested).HasPrecision(18, 2);
            builder.Property(x => x.AmtReturned).HasPrecision(18, 2);

            builder.HasOne(x => x.Pool).WithMany(x => x.PoolFunders).HasForeignKey(x => x.PoolId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}