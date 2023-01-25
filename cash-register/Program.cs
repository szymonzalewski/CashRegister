namespace cash_register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You can create a customer class that will have a wallet assigned to it
            double wallet = 3004.50;
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

                cashRegister.RemoveProduct(bread);//You remove the bread from the cash register
                cashRegister.RemoveProduct(1);//You delete the first item from cash register


                wallet = cashRegister.Payment(wallet);
                wallet = cashRegister.Payment(wallet);

                Console.WriteLine("\n\nNotification from the bank: You have enough funds left in your account {0}zł\n", wallet);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nWaring!\n{0}", ex.Message.ToString());
            }
        }
    }

    class Product
    {
        private static int quantity = 0; //In this case, it is only used to generate the id. it's supposed to simulate a bit as if the data came from a database
        public int id;
        public string name;
        public string description;
        public double price;
        public Product(string name, string description, double price)
        {
            id = quantity;
            quantity += 1;
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine(" ID: {0}\n Name of product: {1}\n   description: {2}\n   price: {3}zł", id, name, description, price);
        }
    }

    class CashRegister
    {
        public List<Product> Products { get; }
        public CashRegister()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }



        public void RemoveProduct(int order)
        {
            Products.RemoveAt(order);
        }

        public double FullPrice()
        {
            double fullPrice = 0;
            foreach (Product product in Products)
            {
                fullPrice += product.price;
            }
            return fullPrice;
        }

        public void Print()
        {
            foreach (Product product in Products)
            {
                product.Print();

            }
            Console.WriteLine("------------------\nFull price: {0}zł", FullPrice());
        }

        public double Payment(double cash)
        {
            double price = FullPrice();
            if (price > cash)
            {
                throw new Exception("Not enough funds");
            }
            if (Products.Count == 0)
            {
                throw new Exception("You have no registered products");
            }
            //Receipt
            Print();
            var currentCash = cash - price;
            Products.Clear();

            return currentCash;
        }
    }
}
