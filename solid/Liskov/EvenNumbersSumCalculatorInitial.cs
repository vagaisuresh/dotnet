namespace SolidPrinciples;

public class EvenNumbersSumCalculatorIni : SumCalculatorIni
{
    public EvenNumbersSumCalculatorIni(int[] numbers)
        : base(numbers)
    {
    }

    public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
}