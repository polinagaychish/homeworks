Console.Write("ВВедите число 1: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите число 2: ");
int y = int.Parse(Console.ReadLine()!);
if (x < y)
{
    Console.Write("Наименьшее: ");
    Console.Write(x);
}
else
{
    Console.Write(" Наибольшее: ");
    Console.Write(x);
}
if (y < x)
{
    Console.Write("Наименьшее: ");
    Console.Write(y);
}
else
{
    Console.Write(" Наибольшее: ");
    Console.Write(y);
}
