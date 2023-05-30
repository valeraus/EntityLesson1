namespace Task1
{
    internal class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName} = {Login} ***{Password}*** ({Email})";
        }
    }
}
