namespace observer.Models
{
    class Stock
    {
        public Dictionary<string, Product> Products { get; set; }
        public Stock()
        {
            Products = new Dictionary<string, Product>();
        }
        public void AddProduct(int items, string ty)
        {
            switch (ty)
            {
                case "SMARTTV":
                    var sm = SmartTV.GetInstance();
                    if (sm != null && !Products.ContainsKey(ty))
                    {
                        Products[ty] = sm;
                    }
                    Products[ty].addQuantity(items);
                    break; 

                case "NOTEBOOK":
                    var nt = Notebook.GetInstance();
                    if (nt != null && !Products.ContainsKey(ty))
                    {
                        Products[ty] = nt;
                    }
                    Products[ty].addQuantity(items);
                    break;

                default:
                    Console.WriteLine($"There's no product called {ty}");
                    break;
            }
        }
        public void ListProducts()
        {
            if (Products == null)
            {
                throw new ArgumentNullException(nameof(Products));
            }
            foreach (var product in Products)
            {
                Console.WriteLine(product.Value.ToString());
            }
        }
    }
}
