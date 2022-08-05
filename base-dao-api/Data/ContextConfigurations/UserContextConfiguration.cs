using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class UserContextConfiguration : IEntityTypeConfiguration<User>
    {
        private readonly Guid[] _ids;

        public UserContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            //HARDCODED TEST WALLET ADDRESS
            string walletAddress = "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266";

            builder.HasIndex(x => x.WalletAddress).IsUnique();

            builder
                .HasData(
                new User
                {
                    Id = _ids[0],
                    WalletAddress = "0x8c268f32D7F129ac0D9FB1E5B490d90810dFa446",
                    Name = "SYSTEM"
                },
                new User
                {
                    Id = _ids[1],
                    WalletAddress = walletAddress,
                    Name = "ADMIN-1"
                });
        }
    }
}