namespace Management.Models;

    public abstract class Person
    {
        public string Name { get; set; } = string.Empty;
        public string? SocialSecurityNumber { get; set; }
        public DateTime DateBirth { get; set; }
        public string Address { get; set; } = string.Empty;
    }
