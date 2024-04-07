namespace Movements.Domain;

public class FlyMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Fly");
    }
}