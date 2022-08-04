using Microsoft.EntityFrameworkCore;
using base_dao_api.Data.ContextConfigurations;
using base_dao_api.Models;

namespace base_dao_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            var userIds = new Guid[] { Guid.NewGuid(), Guid.NewGuid()};
            var headerIds = new Guid[] { Guid.NewGuid(), Guid.NewGuid() };
            var detailIds = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            var systemId = userIds[1];

            // Apply configuration for the three contexts in our application
            // This will create the demo data for our GraphQL endpoint

            builder.ApplyConfiguration(new CodeHeaderContextConfiguration(headerIds, systemId));
            builder.ApplyConfiguration(new CodeDetailContextConfiguration(headerIds, detailIds, systemId));
            builder.ApplyConfiguration(new FaqContextConfiguration(systemId));
            builder.ApplyConfiguration(new UserContextConfiguration(userIds));
            builder.ApplyConfiguration(new UserRoleContextConfiguration(userIds, detailIds[0]));
            builder.ApplyConfiguration(new PoolContextConfiguration());
            builder.ApplyConfiguration(new PoolFunderContextConfiguration());
            builder.ApplyConfiguration(new PoolActivityContextConfiguration());
        }

        // Add the DbSets for each of our models we would like at our database
        public DbSet<CodeHeader> CodeHeaders { get; set; }
        public DbSet<CodeDetail> CodeDetails { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Pool> Pools { get; set; }

        public DbSet<PoolActivity> PoolActivities { get; set; }

        public DbSet<PoolFunder> PoolFunders { get; set; }
    }
}