using Game.Entities.Weapons;
using Game.Enumerations;

namespace Game.Entities.Heroes;

public abstract class Hero
{
    public string Name { get; set; }
    public Level Level { get; set; }
    public HeroType HeroType { get; set; }

    public int MagicPoint { get; set; }

    public int HitPoint { get; set; }

    public IList<IWeapon> Weapons { get; set; }

    public void AddWeapon(IWeapon weapon)
    {
        this.Weapons.Add(weapon);
    }

    protected Hero()
    {
        Name = String.Empty;
        Level = Level.Zero;
        Console.WriteLine();
        Weapons = new List<IWeapon>();
        Initializer();
    }

    protected Hero(string name, Level level, HeroType type)
    {
        Name = name;
        Level = level;
        HeroType = type;
        Weapons = new List<IWeapon>();
        Initializer();
    }

    public virtual string Attack()
    {
        var weapon = DefaultWeapon();
        return Attack(weapon);
    }

    public virtual string Attack(IWeapon weapon)
    {
        if (this.Weapons.Contains(weapon))
        {
            return $"{this.Name} made a {weapon.Name} attack";
        }
        
        return $"{this.Name} can't attack with a {weapon.Name}";
        
    }

    public virtual IWeapon DefaultWeapon()
    {
        return this.Weapons.First();
    }

    public override string ToString()
    {
        return $"{Name} {Level} {HeroType}";
    }

    abstract protected void Initializer();
}