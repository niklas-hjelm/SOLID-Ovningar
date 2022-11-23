namespace WorkshopHandsOn25.ValueObject
{
    public sealed class SocialSecurityNumber
    {
        public long Id { get; }
        public string NameOfPerson { get; }

        public static SocialSecurityNumber Create(long idnumber, string nameOfPerson)
        {
            return new SocialSecurityNumber(idnumber, nameOfPerson);
        }

        private SocialSecurityNumber(long idnumber, string name)
        {
            Id = idnumber;
            NameOfPerson = name;
        }
    }
}
