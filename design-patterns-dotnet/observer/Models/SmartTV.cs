using observer.Interfaces;

namespace observer.Models
{
    class SmartTV : Product
    {
        public float Size { get; private set; }
        public List<ISmartTvListeners> Subscribers { get; private set; }
        protected static SmartTV? Instance { get; set; }


        private SmartTV(int id, string? name, float price, int quantity, float size) : base(id, name, price, quantity)
        {
            Size = size;
            Subscribers = new List<ISmartTvListeners>();
        }

        public static SmartTV? GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SmartTV(0, "LG Smart TV", 1000f, 10, 32.5f);
            }
            return Instance;
        }

        public void Subscribre(ISmartTvListeners user)
        {
            Subscribers.Add(user);
        }

        public void Unsubscribe(ISmartTvListeners user)
        {
            Subscribers.Remove(user);
        }

        public override void NotifySubscribers()
        {
            foreach(ISmartTvListeners listener in Subscribers)
            {
                listener.update(this);
            }
        }

        public override string ToString()
        {
            return $"{Name}({Size}\") - ${Price} - {Quantity}";
        }
    }
}
