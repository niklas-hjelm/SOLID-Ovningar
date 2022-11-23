namespace WorkshopHandsOn25.Banks
{
    public class SwedBank : Bank
    {
        public static IBank Create(IAccount account)
        {
            return new SwedBank(account);
        }

        private SwedBank(IAccount account)
            : base(account)
        { }
    }
}
