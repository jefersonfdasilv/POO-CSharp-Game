using Game.Entities.Heroes;
using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game;

public static class Program
{
    public static void Main()
    {
        var hero = new Knight("Arus", Level.Five);
        var bow = new Bow(30);
        hero.AddWeapon(bow);
        Console.WriteLine(hero.Attack());
        Console.WriteLine(hero.Attack(bow));
        Console.WriteLine(hero.Attack(new Magic(20)));
    }
}