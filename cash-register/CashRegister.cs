namespace cash_register
{
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
            {//Musisz dodać produkty, zanim przejdziesz do płatności
                throw new Exception("Before payment\t\nYou must add products");
            }
            //Receipt
            Print();
            var currentCash = cash - price;
            Products.Clear();

            return currentCash;

           
        }
    }
}
