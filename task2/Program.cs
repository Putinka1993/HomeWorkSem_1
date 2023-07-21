List<int> numbers = new List<int>();

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
numbers.Add(first);

Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
numbers.Add(second);

Console.WriteLine("Maximum " + numbers.Max());
Console.WriteLine("Minimum " + numbers.Min());
