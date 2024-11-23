namespace SolidPrinciples;

// https://code-maze.com/liskov-substitution-principle/
// The Liskov Substitution Principle (LSP) states that child class objects should be able to replace parent class objects without compromising application integrity.

public class SumCalculatorIni
{
    protected readonly int[] _numbers;

    public SumCalculatorIni(int[] numbers)
    {
        _numbers = numbers;
    }

    public int Calculate() => _numbers.Sum();
}