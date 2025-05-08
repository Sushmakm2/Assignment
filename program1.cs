using System;
class Program1
{
    static void Main()
    {
        Console.Write("enter height of triangle: ");
        int height = int.Parse(Console.ReadLine());
        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}
