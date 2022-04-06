namespace wedding.domain.Aggregates.Users.Host
{
    public class Groom
    {
        public virtual IList<Parent>? Parents { get; set; }

        public virtual IList<Sibling>? Siblings { get; set; }

        public virtual IList<Friend>? Friends { get; set; }

        public Bride Bride { get; set; }
    }
}
