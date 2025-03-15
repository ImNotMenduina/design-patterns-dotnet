using observer.Interfaces;
using System.Drawing;

namespace observer.Models
{
    class Notebook : Product
    {
        public string? Gpu { get; private set; }
        public string? Cpu { get; private set; }
        public int Storage { get; private set; }
        public List<INotebookListeners> Subscribers { get; private set; }
        protected static Notebook? Instance { get; set; }

        private Notebook(int id, string name, float price, int quantity, string? gpu, string? cpu, int storage) 
            : base(id, name, price, quantity) 
        {
            Gpu = gpu;
            Cpu = cpu;
            Storage = storage;
            Subscribers = new List<INotebookListeners>();
        }

        public static Notebook? GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Notebook(1, "Samsung Book 360", 3000f, 10, "1660Super", "i5 10400f", 500);
            }
            return Instance;
        }

        public void AddSubscriber(INotebookListeners user)
        {
            Subscribers.Add(user);
        }

        public override void NotifySubscribers()
        {
            foreach (INotebookListeners subscriber in Subscribers)
            {
                subscriber.update(this);
            }
        }
        public override string ToString()
        {
            return $"{Name} - {Gpu} - {Cpu} - ${Price} - {Quantity}";
        }
    }
}
