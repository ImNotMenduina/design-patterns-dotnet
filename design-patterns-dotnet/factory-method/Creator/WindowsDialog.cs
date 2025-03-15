using factory_method.Product;

namespace factory_method.Creator
{
    public class WindowsDialog : Dialog
    {
        public override Button createButton()
        {
            return new WindowsButton();
        }
    }
}
