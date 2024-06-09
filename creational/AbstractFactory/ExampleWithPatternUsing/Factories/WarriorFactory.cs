using Movements.Domain;
using Spells.Domain;
using Weapons.Domain;

namespace ExampleWithPatternUsing.Factories;

internal class WarriorFactory : HeroFactory
{
    public override Weapon? CreateWeapon()
    {
        return new Sword();
    }

    public override Spell? CreateSpell()
    {
        return null;
    }

    public override Movement CreateMovement()
    {
        return new RunMovement();
    }
}