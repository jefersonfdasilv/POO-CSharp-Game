using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game.Entities.Heroes;

public class Wizard : Hero
{
    public Wizard(string name, Level level): base(name,level,HeroType.Wizard)
    {
       
    }

    public Wizard(): base()
    {
    }

    protected override void Initializer()
    {
        this.AddWeapon(new Magic(50));
    }

    public override string Attack()
    {
       return this.Name + "Lança magia";
    }
}