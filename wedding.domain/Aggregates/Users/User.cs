namespace wedding.domain.Aggregates.Users
{
    public class User
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set; }

        public Relationship Relationship { get; set; }

        public long Contact { get; set; }

        public string? Email { get; set; }

        public Gender Gender { get;set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? PostalAddress { get; set; }
    }
}
