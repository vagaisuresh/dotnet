namespace SolidPrinciples;

// public class SumCalculator
// {
//     protected readonly int[] _numbers;

//     public SumCalculator(int[] numbers)
//     {
//         _numbers = numbers;
//     }

//     public virtual int Calculate() => _numbers.Sum();
// }

public class SumCalculator : Calculator
{
    public SumCalculator(int[] numbers)
        : base(numbers)
    {
    }

    public override int Calculate() => _numbers.Sum();
}