using System.Security.Cryptography;
using System.Text;
using Uzum.Aplication.Abstractions;


namespace Uzum.Infrastructure.Services
{
    public class HashService : IHashService
    {
        public string GetHash(string value)
        {
#pragma warning disable
            var sha256 = new SHA256Managed();
#pragma warning restore
            var bytes = Encoding.UTF8.GetBytes(value);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
