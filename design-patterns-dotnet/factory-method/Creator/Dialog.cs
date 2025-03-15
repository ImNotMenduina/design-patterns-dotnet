using factory_method.Product;

namespace factory_method.Creator
{
    public abstract class Dialog
    {
        public abstract Button createButton();
        public void Render()
        {
            Console.WriteLine("");
        }
    }
}
