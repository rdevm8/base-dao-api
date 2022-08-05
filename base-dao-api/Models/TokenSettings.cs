namespace base_dao_api.Models
{
    public class TokenSettings
    {
        public TokenSettings()
        {
            Issuer = String.Empty;
            Audience = String.Empty;
            Key = String.Empty;
            Expiration = 0;
        }

        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }

        public int Expiration { get; set; }
    }
}
