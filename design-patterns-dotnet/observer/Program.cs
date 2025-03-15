using observer.Models;

Stock stock = new Stock();
var smart = SmartTV.GetInstance();
var notebook = Notebook.GetInstance();

User user = new("Lucas");

if (smart != null)
{
    smart.Subscribers.Add(user);
}
if (notebook != null)
{
    notebook.Subscribers.Add(user);
}

stock.AddProduct(6, "SMARTTV");
stock.AddProduct(6, "NOTEBOOK");
