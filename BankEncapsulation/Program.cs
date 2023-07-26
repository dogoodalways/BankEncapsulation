namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance right now is {account.GetBalance()}");
        }
    }
}
