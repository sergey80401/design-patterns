using Movements.Domain;
using Spells.Domain;
using Weapons.Domain;

namespace ExampleWithoutPattern;

internal static class Program
{
    public static void Main(string[] args)
    {
        // Let's create 3 warriors
        var warrior1 = new Hero(
            new Sword(),
            null,
            new RunMovement()
        );

        var warrior2 = new Hero(
            new Sword(),
            null,
            new RunMovement()
        );

        var warrior3 = new Hero(
            new Sword(),
            null,
            new RunMovement()
        );

        // Let's create two fire magicians and three ice magicians
        var fireMage1 = new Hero(
            null,
            new FireBall(),
            new FlyMovement()
        );

        var fireMage2 = new Hero(
            null,
            new FireBall(),
            new FlyMovement()
        );

        var frozenMage1 = new Hero(
            null,
            new FrozenTouch(),
            new FlyMovement()
        );

        var frozenMage2 = new Hero(
            null,
            new FrozenTouch(),
            new FlyMovement()
        );

        var frozenMage3 = new Hero(
            null,
            new FrozenTouch(),
            new FlyMovement()
        );

        // Some warrior gameplay
        // The first warrior runs and fights
        warrior1.Move();
        warrior1.Hit();

        // The second one hopes that he is a magician
        warrior2.Cast();
        warrior2.Cast();
        warrior2.Cast();
        warrior2.Cast();
        warrior2.Cast();

        // The third warrior is still running somewhere
        warrior3.Move();
        warrior3.Move();
        warrior3.Move();
        warrior3.Move();

        // Some mage gameplay
        // Fire mages love to fly up and throw fireballs from high
        fireMage1.Move();
        fireMage1.Cast();
        fireMage2.Move();
        fireMage2.Cast();

        // Two ice mages attack while standing still
        frozenMage1.Cast();
        frozenMage1.Cast();
        frozenMage2.Cast();
        frozenMage2.Cast();

        // And others are stupid and think they have weapons
        frozenMage3.Cast();
        frozenMage3.Cast();
    }
}