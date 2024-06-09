using Movements.Domain;
using Spells.Domain;
using Weapons.Domain;

namespace ExampleWithoutPattern;

internal class Hero
{
    private Weapon? _weapon;
    private Spell? _spell;
    private Movement? _movement;

    public Hero(Weapon? weapon, Spell? spell, Movement? movement)
    {
        _weapon = weapon;
        _spell = spell;
        _movement = movement;
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