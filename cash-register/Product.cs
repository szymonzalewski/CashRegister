namespace cash_register
{
    class Product
    {
        private static int quantity = 0; //In this case, it is only used to generate the id. it's supposed to simulate a bit as if the data came from a database
        public int id;
        public string name;
        public string description;
        public double price;
        public Product(string name, string ingredients, double price)
        {
            id = quantity;
            quantity += 1;
            this.name = name;
            this.description = ingredients;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine(" ID: {0}\n Name of product: {1}\n   ingredients: {2}\n   price: {3}zł", id, name, description, price);
        }
    }
}
