using decorator.Decorators;
using decorator.Interface;
using decorator.NovaPasta;

Character player1 = new Hero("Lucas", 100f, 100f, 100f);

Console.WriteLine("=== Before Pills ===");
print(player1);

Console.WriteLine("\n=== After Speed Power Up ===");

player1 = new SpeedDecorator(player1);
print(player1);

Console.WriteLine("\n=== After Jump Power Up ===");

player1 = new JumpDecorator(player1);
print(player1);

player1 = new FlyDecorator(player1);
print(player1);

void print(Character player)
{
    Console.WriteLine(player1.Punch());
    Console.WriteLine(player1.Kick());
    Console.WriteLine(player1.MoveLeft());
    Console.WriteLine(player1.MoveRight());
}



