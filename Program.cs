Console.WriteLine("Введите число и нажмите Enter");
int number = int.Parse(Console.ReadLine());
int secondDigit = (number % 100) / 10;
Console.WriteLine($"{number} -> {secondDigit}");