namespace csharp_practice_4;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("--- ATM ---");
            BankAccount myAccount = new BankAccount("CHICK1234567890", "Chick Chirick", 5000m, 3000m);
            myAccount.GetAccountInfo();
            Console.WriteLine("");
            
            myAccount.Deposit(1500m);
            Console.WriteLine($"Balance after deposit: {myAccount.Balance}");
            myAccount.Withdraw(2000m);
            Console.WriteLine($"Balance after withdraw: {myAccount.Balance}");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}