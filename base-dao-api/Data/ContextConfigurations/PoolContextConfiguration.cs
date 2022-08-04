using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class PoolContextConfiguration : IEntityTypeConfiguration<Pool>
    {

        public PoolContextConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Pool> builder)
        {
            builder.Property(x => x.MinInvestment).HasPrecision(18, 2);
        }
    }
}