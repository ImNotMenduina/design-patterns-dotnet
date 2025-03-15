namespace observer.Models
{
    abstract class Product
    {
        public int Id { get; set; }
        public string? Name { get; private set; }
        public float Price { get; private set; }
        public int Quantity { get; private set; }

        protected Product(int id, string? name, float price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public abstract void NotifySubscribers();
        public void addQuantity(int quantity)
        {
            Quantity += quantity;
            NotifySubscribers();
        }
        public void removeQuantity(int quantity) => Quantity -= quantity;
    }
}
