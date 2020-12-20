namespace ConsoleApp.Shop
{
    public class User
    {
        public double Wallet
        {
            get; set;
        } = 100;

        public void Balance()
        {
            System.Console.WriteLine($"Your balance is: {Wallet} eur");
        }
        public void Topup(string money)
        {
            Wallet = Wallet + double.Parse(money);
            System.Console.WriteLine($"Your wallet has been replenished, your balance now is: {Wallet} eur");
        }
    }
}