namespace Weapons.Domain;

public class Bow : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Shoot a bow");
    }
}