Console.WriteLine("Введите m :");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите n :");
double n = Convert.ToDouble(Console.ReadLine());
if (m != n)
{
    if (m > n)
    {
        Console.WriteLine("m больше");
        n = m;
    }
    else
    {
        Console.WriteLine("n больше");
        m = n;
    }
}
else
{
    Console.WriteLine("m и n равны");
    m = 0;
    n = 0;
}
Console.WriteLine($"m = {m}");
Console.WriteLine($"n = {n}");