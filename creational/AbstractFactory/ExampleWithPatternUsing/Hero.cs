using ExampleWithPatternUsing.Factories;
using Movements.Domain;
using Spells.Domain;
using Weapons.Domain;

namespace ExampleWithPatternUsing;

internal class Hero
{
    private Weapon? _weapon;
    private Spell? _spell;
    private Movement? _movement;

    public Hero(HeroFactory heroFactory)
    {
        _weapon = heroFactory.CreateWeapon();
        _spell = heroFactory.CreateSpell();
        _movement = heroFactory.CreateMovement();
    }
    
    public void Hit()
    {
        if (_weapon == null)
            Console.WriteLine("I have no weapon");
        else _weapon.Hit();
    }

    public void Move()
    {
        if (_movement == null)
            Console.WriteLine("I cant move!!!");
        else _movement.Move();
    }

    public void Cast()
    {
        if (_spell == null)
            Console.WriteLine("I have no spell");
        else _spell.Cast();
    }
}