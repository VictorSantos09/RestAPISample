namespace RestAPISample.Entity
{
    public class UserEntity
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public UserEntity(int age, string name, string email)
        {
            Age = age;
            Name = name;
            Email = email;
        }
    }
}