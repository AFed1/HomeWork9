Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(FromN1(n));

string FromN1(int n)
{
   
    if (n == 1)
    {
        return $"{n}";
    }
    else
    {
        return  n  + ", " + FromN1(n - 1);
    }
}