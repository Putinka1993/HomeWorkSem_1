

List<int> numbers = new List<int>();

int n = 3, i = 0;

while (i != n)
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    numbers.Add(num);
    i++;
}

Console.WriteLine("Maximum " + numbers.Max());

