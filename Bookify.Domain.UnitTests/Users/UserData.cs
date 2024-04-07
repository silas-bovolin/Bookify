using Bookify.Domain.Users;

namespace Bookify.Domain.UnitTests.Users
{
    internal static class UserData
    {
        public static readonly FirstName FirstName = new("FirstName");
        public static readonly LastName LastName = new("LastName");
        public static readonly Email Email = new("teste@test.com");
    }
}
