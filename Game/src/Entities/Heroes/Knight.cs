using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game.Entities.Heroes;

public class Knight: Hero
{
    public Knight(string name, Level level): base(name, level, HeroType.Knight)
    {
    }

    protected override void Initializer()
    {
        this.AddWeapon(new Spear(30));
    }
}