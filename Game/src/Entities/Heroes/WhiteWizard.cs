using Game.Entities.Heroes;
using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game.Entities.Heroes;

public class WhiteWizard: Hero
{
    public WhiteWizard(string name, Level level): base(name, level, HeroType.WhiteWizard)
    {
        
    }

    protected override void Initializer()
    {
        this.AddWeapon(new Magic(10));
    }
}