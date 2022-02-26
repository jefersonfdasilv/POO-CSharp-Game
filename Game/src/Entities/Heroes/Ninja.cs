using Game.Entities.Heroes;
using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game.Entities.Heroes;

public class Ninja: Hero
{
    public Ninja(string name, Level level): base(name, level, HeroType.Ninja)
    {
        
    }

    protected override void Initializer()
    {
       this.AddWeapon(new Sword(30) );
    }
}