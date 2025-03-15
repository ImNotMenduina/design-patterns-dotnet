using observer.Interfaces;

namespace observer.Models
{
    class User : ISmartTvListeners, INotebookListeners
    {
        public string? Name { get; private set; }
        public User(string name)
        {
            Name = name;
        }

        public void update(Product product)
        {
            Console.WriteLine("UPDATED!");
            Console.WriteLine(product.ToString());
        }
    }
}
