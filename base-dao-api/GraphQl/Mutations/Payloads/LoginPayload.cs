using System.ComponentModel.DataAnnotations;

namespace base_dao_api.GraphQl.Mutations.Payloads
{
    public class LoginPayload
    {
        public LoginPayload()
        {
            WalletAddress = String.Empty;
        }

        [Required]
        [StringLength(42)]
        public string WalletAddress { get; set; }
    }
}
