using Game.Entities.Heroes;
using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game.Entities;

public class BlackWizard : Hero
{

    public BlackWizard(string name, Level level): base(name, level, HeroType.BlackWizard)
    {
        
    }

    protected override void Initializer()
    {
       this.AddWeapon(new Magic(100));
    }
}