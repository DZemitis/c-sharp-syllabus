namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var benben = new BankAccount("Benson", -17.5);
            benben.ShowUserNameAndBalance();
        }
    }
}
