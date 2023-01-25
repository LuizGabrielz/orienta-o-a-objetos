namespace Course.Entities
{
    class Account
    {
        public int Number { get; private set; } // Não pode alterar, só acessar
        public string Holder { get; private set; }
        public double Balance { get; protected set;} // Não pode alterar, só pode acessar

        public Account()
        {

        }   

        public Account(int number, string holder, double balance) 
        {

        }     
    }
}