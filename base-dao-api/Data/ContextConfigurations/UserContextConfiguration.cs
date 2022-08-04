using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class UserContextConfiguration : IEntityTypeConfiguration<User>
    {
        private readonly Guid[] _ids;
        private readonly Guid _systemId;

        public UserContextConfiguration(Guid[] ids)
        {
            _ids = ids;
            _systemId = _ids[1];
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
                    WalletAddress = walletAddress,
                    Name = "",
                    CreateUserId = _systemId,
                    UpdateUserId = _systemId


                },
                new User
                {
                    Id = _systemId,
                    WalletAddress = "",
                    Name = "SYSTEM",
                    CreateUserId = _systemId,
                    UpdateUserId = _systemId
                });
        }
    }
}