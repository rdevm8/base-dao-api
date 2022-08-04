using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class PoolActivityContextConfiguration : IEntityTypeConfiguration<PoolActivity>
    {

        public PoolActivityContextConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<PoolActivity> builder)
        {

            builder.HasOne(x => x.Pool).WithMany(x => x.PoolActivities).HasForeignKey(x => x.PoolId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}