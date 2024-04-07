namespace Weapons.Domain;

public class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Hit with a sword");
    }
}