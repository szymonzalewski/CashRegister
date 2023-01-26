namespace cash_register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You can create a customer class that will have a wallet assigned to it
            double wallet = 300.50;
            var cashRegister = new CashRegister();
            var bread = new Product("PUTKA BIO rye bread", "Natural RYE sourdough (59%) (BIO RYE flour (32%), Water, BIO WHEAT malt flour), BIO RYE flour (26%), Non-iodized rock salt, BIO yeast, BIO potato flakes", 6.50);
            var kabanos = new Product("KABANOSY TARCZYŃSKI EXCLUSIVE Z KURCZAKA", "Natural RYE sourdough (59%) (BIO RYE flour (32%), Water, BIO WHEAT malt flour), BIO RYE flour (26%), Non-iodized rock salt, BIO yeast, BIO potato flakes", 5.99);

            try
            {

                cashRegister.AddProduct(kabanos);
                cashRegister.AddProduct(kabanos);
                cashRegister.AddProduct(kabanos);
                cashRegister.AddProduct(bread);
                cashRegister.AddProduct(bread);


                wallet = cashRegister.Payment(wallet);

                Console.WriteLine("\n\nNotification from the bank: You have enough funds left in your account {0}zł\n", wallet);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nInfo:\n{0}", ex.Message.ToString());
            }
        }
    }
}
