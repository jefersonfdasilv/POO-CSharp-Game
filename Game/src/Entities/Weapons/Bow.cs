namespace Game.Entities.Weapons;

public class Bow: IWeapon
{
    public Bow(int damage)
    {
        Damage = damage;
    }
    public int Damage { get; set; }
    public string GetName()
    {
        return "Bow";
    }
}