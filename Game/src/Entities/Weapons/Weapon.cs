namespace Game.Entities.Weapons;

public abstract class Weapon: IWeapon
{
    private string _name;

    protected Weapon(string name, int damage)
    {
        _name = name;
        Damage = damage;
    }

    public int Damage { get; set; }

    string IWeapon.Name
    {
        get => _name;
        set => _name = value;
    }
}