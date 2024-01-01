using Validation.Models;

namespace Validation.Services
{
    public class MockDataService
    {
        public void FillDb()
        {
            using (var context = new DijaDbContext())
            {
                User user = new User
                {
                    Id = Guid.Parse("28C27988-5AEB-4C3F-B1DE-1A47B3E5929F"),
                    Passport = "СЮ112233",
                    Rnokpp = "1122334455",
                    BirthDate = DateTime.Parse("01.01.2001"),
                    DeviceId = Guid.Parse("CEF9AE78-5AE1-4EC4-A87F-3035DFA1AD03"),
                    DeviceOsName = "Android",
                    FirstName = "Родион",
                    LastName = "Скопич"
                };

                User user2 = new User
                {
                    Id = Guid.Parse("C662FFE5-A5AE-497E-B81C-345CD3AD7D5D"),
                    Passport = "ШЖ102203",
                    Rnokpp = "5544332211",
                    BirthDate = DateTime.Parse("02.02.1998"),
                    DeviceId = Guid.Parse("168B5D57-74A3-400F-BA6B-549B7FC09149"),
                    DeviceOsName = "IOS",
                    FirstName = "Тест",
                    LastName = "Тестов"
                };

                User user3 = new User
                {
                    Id = Guid.Parse("D40CCE8E-BD79-4D37-B389-6BFA182DD5FA"),
                    Passport = "АА123456",
                    Rnokpp = "1234567890",
                    BirthDate = DateTime.Parse("03.03.1993"),
                    DeviceId = Guid.Parse("C1F470A9-BA7F-461F-BA5C-84326AFE2B70"),
                    DeviceOsName = "IOS",
                    FirstName = "Админ",
                    LastName = "Админов"
                };

                context.Add(user);
                context.Add(user2);
                context.Add(user3);

                context.SaveChanges();
            }
        }
    }
}
