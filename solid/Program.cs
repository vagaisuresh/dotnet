﻿// References
// https://code-maze.com/single-responsibility-principle/
// https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
// https://medium.com/@jeslurrahman/understanding-solid-principles-in-net-c-a-practical-guide-with-code-examples-2e759010974e
// https://medium.com/@lucas.and227/the-solid-principles-in-c-319755838805

// SOLID principles
// S: Single Responsibility Principle (SRP)
// O: Open-closed Principle (OCP)
// L: Liskov substitution Principle (LSP)
// I: Interface Segregation Principle (ISP)
// D: Dependency Inversion Principle (DIP)

using SolidPrinciples;

// O: Open-closed Principle (OCP)

// var shapes = new List<IShape>
// {
//     new Circle(5),
//     new Rectangle(4, 6),
//     new Triangle(4, 6)
// };

// var areaCalculator = new AreaCalculator();
// double totalArea = areaCalculator.CalculateTotalArea(shapes);

// Console.WriteLine($"Total Area: {totalArea}");

// L: Liskov substitution Principle (LSP)
// Initial (normal calculation)

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

SumCalculator sum = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

Console.WriteLine();

EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
