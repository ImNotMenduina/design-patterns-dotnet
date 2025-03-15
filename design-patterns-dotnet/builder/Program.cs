using Builder.Builder;
using Builder.Model;

//HamburguerBuilder hamburguerBuilder = new HamburguerBuilder();
//Hamburguer xSalad = hamburguerBuilder
//    .SetPao("Brioche")
//    .SetCarne("Vegana")
//    .SetSalada()
//    .SetBatataPalha()
//    .Build();

//hamburguerBuilder = new();
//Hamburguer xBacon = hamburguerBuilder
//    .SetPao("Frances")
//    .SetCarne("Suina")
//    .SetBacon()
//    .SetQueijo()
//    .Build();

//Console.WriteLine(xSalad.GetMessage());
//Console.WriteLine(xBacon.GetMessage());

EnemyBuilder enemyBuilder = new EnemyBuilder();
Enemy enemy1 = enemyBuilder
    .SetName("DarkOwl")
    .SetMana(50)
    .SetHealth(100)
    .SetPower(40)
    .Build();

enemyBuilder = new();
Enemy enemy2 = enemyBuilder
    .SetName("DarkHorse")
    .SetMana(70)
    .SetHealth(100)
    .SetPower(100)
    .Build();

Console.WriteLine(enemy1.GetEnemyInformation());
Console.WriteLine(enemy2 .GetEnemyInformation());
