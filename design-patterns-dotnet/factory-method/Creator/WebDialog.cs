using factory_method.Product;

namespace factory_method.Creator
{
    public class WebDialog : Dialog
    {
        public override Button createButton()
        {
            return new HTMLButton();
        }
    }
}
