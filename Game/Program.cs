using Game.Entities.Heroes;
using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game;

public static class Program
{
    public static void Main()
    {
        var hero = new Knight("Arus", Level.One);
        hero.AddWeapon(new Bow(30));
        var weapons = hero.Weapons;
        var defaultWeapon = hero.Weapons.First();
        Console.WriteLine($"{hero}, Default weapon {defaultWeapon.GetName()}, {defaultWeapon.Damage}");
    }
}