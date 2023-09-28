Console.WriteLine("Введите a :");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b :");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c :");
double c = Convert.ToDouble(Console.ReadLine());
int res = 0;
if (a > 0)
{
    res++;
}
if (b > 0)
{
    res++;
}
if (c > 0)
{
    res++;
}
Console.WriteLine(res);