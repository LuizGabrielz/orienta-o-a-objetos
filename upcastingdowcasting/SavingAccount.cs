namespace Course.Entities
{
     class SavingsAccount : Account
    {
        public double InterstRace { get; set; }

        public SavingsAccount ()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterstRace = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterstRace;
        }
    }
} 