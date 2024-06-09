using Movements.Domain;
using Spells.Domain;
using Weapons.Domain;


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

internal static class Program
{
    public static void Main(string[] args)
    {
        // A warrior with a sword who can run but cannot cast spells
        var warrior = new Hero(
            new Sword(),
            null,
            new RunMovement()
        );
        
        // An archer who can run, but cannot cast spells
        var archer = new Hero(
            new Bow(),
            null,
            new RunMovement()
        );
        
        var killer = new Hero(
            new Pistol(),
            new FalconVision(),
            new RunMovement()
        );
        
        // Fire mage
        var fireMage = new Hero(
            null,
            new FireBall(),
            new FlyMovement()
        );

        // Frozen mage
        var frozenMage = new Hero(
            null,
            new FrozenTouch(),
            new FlyMovement()
        );
        
        // Warrior gameplay
        warrior.Move();
        warrior.Hit();
        warrior.Cast();
        
        // Archer gameplay
        archer.Move();
        archer.Hit();
        archer.Cast();
        
        // Killer gameplay
        killer.Move();
        killer.Hit();
        killer.Cast();
        
        // FireMage gameplay
        fireMage.Move();
        fireMage.Hit();
        fireMage.Cast();
        
        // FrozenMge gameplay
        frozenMage.Move();
        frozenMage.Hit();
        frozenMage.Cast();
    }
}