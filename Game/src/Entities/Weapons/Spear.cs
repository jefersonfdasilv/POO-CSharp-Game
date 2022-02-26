namespace Game.Entities.Weapons;

public class Spear: IWeapon
{
    public Spear(int damage)
    {
        this.Damage = damage;
    }

    public int Damage { get; set; }
    public string GetName()
    {
        return "Spear";
    }
}