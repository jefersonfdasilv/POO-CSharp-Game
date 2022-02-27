namespace Game.Entities.Weapons;

public interface IWeapon
{
    public int Damage { get; set; }
    public string Name { get; protected set; }
}