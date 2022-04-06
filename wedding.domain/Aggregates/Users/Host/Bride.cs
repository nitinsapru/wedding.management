namespace wedding.domain.Aggregates.Users.Host
{
    public class Bride : User
    {
        public virtual IList<Parent>? Parents { get; set; }

        public virtual IList<Sibling>? Siblings { get; set; }

        public virtual IList<Friend>? Friends { get; set; }

        public Groom Groom { get; set; }
    }
}
