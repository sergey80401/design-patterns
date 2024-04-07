namespace Weapons.Domain;

public class Pistol : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Shoot a pistol");
    }
}