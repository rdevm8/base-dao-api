using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class BaseContextConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        

        public BaseContextConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
        }
    }
}