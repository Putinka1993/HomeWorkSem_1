

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int c = 1; //count

while (c != n+1)
{
    if (n <= 1)
    {
        Console.WriteLine("Некорректное число");
        c+=n;
    }
    else if (c % 2 == 0) 
    {
        Console.WriteLine(c);
        c++;
    }
   else c++;

}
