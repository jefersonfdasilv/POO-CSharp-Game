namespace Game.Entities.Weapons;

public class Magic: IWeapon
{
    public Magic(int damage)
    {
        this.Damage = damage;
    }
    public int Damage { get; set; }
    public string GetName()
    {
        return "Magic";
    }
}