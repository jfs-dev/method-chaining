using method_chaining.Builders;
using method_chaining.Entities;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Method Chaining");
Console.WriteLine("---------------");
Console.ForegroundColor = ConsoleColor.Magenta;

SuperHero spiderMan = new SpiderManBuilder()
    .BuildName("Homem-Aranha")
    .BuildSecretIdentity("Peter Parker")
    .BuildAbilities("Agilidade Aracnídea, Sentido Aranha, Força Aumentada")
    .BuildEquipment("Traje Especial, Lançadores de Teia")
    .GetSuperHero();

Console.WriteLine(spiderMan);
Console.WriteLine();

SuperHero ironMan = new IronManBuilder()
    .BuildName("Homem de Ferro")
    .BuildSecretIdentity("Tony Stark")
    .BuildAbilities("Gênio")
    .BuildEquipment("Armaduras Mark")
    .GetSuperHero();

Console.WriteLine(ironMan);
