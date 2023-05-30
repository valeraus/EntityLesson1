namespace Task1
{
    internal class DatabaseMoq
    {
        public static List<UserModel> Users { get; set; }

        static DatabaseMoq()
        {
            Users = new List<UserModel>()
            {
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User1",
                    LastName = "Userovich1",
                    Login = "US1",
                    Password = "111",
                    Email = "us1@ukr.net"
                },
                 new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User2",
                    LastName = "Userovich2",
                    Login = "US2",
                    Password = "222",
                    Email = "us2@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User3",
                    LastName = "Userovich3",
                    Login = "US3",
                    Password = "333",
                    Email = "us3@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User4",
                    LastName = "Userovich4",
                    Login = "US4",
                    Password = "444",
                    Email = "us4@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User5",
                    LastName = "Userovich5",
                    Login = "US5",
                    Password = "555",
                    Email = "us5@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User6",
                    LastName = "Userovich6",
                    Login = "US6",
                    Password = "666",
                    Email = "us6@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User7",
                    LastName = "Userovich7",
                    Login = "US7",
                    Password = "777",
                    Email = "us7@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User8",
                    LastName = "Userovich8",
                    Login = "US8",
                    Password = "888",
                    Email = "us8@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User9",
                    LastName = "Userovich9",
                    Login = "US9",
                    Password = "999",
                    Email = "us9@ukr.net"
                },
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Name = "User0",
                    LastName = "Userovich0",
                    Login = "US0",
                    Password = "000",
                    Email = "us0@ukr.net"
                }
            };
        }
    }
}
