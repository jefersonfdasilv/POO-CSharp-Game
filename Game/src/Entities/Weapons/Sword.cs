namespace Game.Entities.Weapons;

public class Sword: IWeapon
{
    public Sword(int weDamage)
    {
        Damage = weDamage;
    }
    public int Damage { get; set; }
    
    public string GetName()
    {
        return "Sword";
    }
}