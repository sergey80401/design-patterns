using Movements.Domain;
using Spells.Domain;
using Weapons.Domain;

namespace ExampleWithPatternUsing.Factories;

internal class FireMageFactory : HeroFactory
{
    public override Weapon? CreateWeapon()
    {
        return null;
    }

    public override Spell CreateSpell()
    {
        return new FireBall();
    }

    public override Movement CreateMovement()
    {
        return new FlyMovement();
    }
}