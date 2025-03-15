// See https://aka.ms/new-console-template for more information
using factory_method.Creator;
using factory_method.Product;

Tela tela1 = new CreatorTelaSmartTv().CriarTela();
Console.WriteLine("tela de smart tv: " + tela1.GetMessage());