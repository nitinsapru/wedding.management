namespace wedding.domain.Aggregates.Users
{
    public class Parent : User
    {
        public string? Religion { get; set; }

        public string? Caste { get; set; }

        public virtual IReadOnlyCollection<User>? Children { get; set; }
    }
}
