namespace Course.Entities 
{
    class BusinessAccount : Account // To falando que a BusinessAccount vai ter tudo que a Account tem
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() // Esse consultor vazio é so pra gente ter a opção de criar um objeto sem passar os dados
        {

        }

        public BusinessAccount(int number, string holder, double balance, double LoanLimit) 
            : base(number, holder, balance) // No () vc vai chamar o consultor da outra classe. Chamando o consultor da classe Acconunt e depois somente acrescenta o 4 que é o LoanLimit
        {
            LoanLimit = LoanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount; // Em uma classe qualquer eu não consigo alterar o saldo, mas em uma superclasse eu consigo
            }
        }
    }
}