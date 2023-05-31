using System;
using System.Collections.Generic;

namespace Task3
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
