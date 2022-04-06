namespace wedding.domain.Aggregates.Users
{
    public class Sibling : User
    {
        public virtual IReadOnlyCollection<Parent>? Parents { get; set; }
    }
}
