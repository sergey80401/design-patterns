using Movements.Domain;
using Spells.Domain;
using Weapons.Domain;

namespace ExampleWithPatternUsing.Factories;

internal abstract class HeroFactory
{
    public abstract Weapon? CreateWeapon();
    public abstract Spell? CreateSpell();
    public abstract Movement? CreateMovement();
}