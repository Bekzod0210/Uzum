using Uzum.Domain.Enums;

namespace Uzum.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public int CardId { get; set; }

        public decimal Balance { get; set; }

        public UserRole Role { get; set; }

        public Card Card { get; set; }
    }
}
