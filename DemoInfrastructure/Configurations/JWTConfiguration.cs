namespace Uzum.Infrastructure.Configurations
{
    public class JWTConfiguration
    {
        public string ValidAudience { get; set; } = string.Empty;
        public string ValidIssuer { get; set; } = null!;
        public string Secret { get; set; } = null!;
    }
}
