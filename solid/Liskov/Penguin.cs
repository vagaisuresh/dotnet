namespace SolidPrinciples;

// public class Penguin2 : Bird
// {
//     public override void Fly()
//     {
//         // Penguins can't fly, so we can override with a message or throw an exception
//         throw new InvalidOperationException("Penguins can't fly.");
//     }
// }

public class Penguin : Bird
{
    public override void Move()
    {
        Console.WriteLine("Penguin is swimming.");
    }
}
