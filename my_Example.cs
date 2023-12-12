using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите исходный массив:");
        string[] array = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();

        Console.WriteLine("Массив строк длиной не более 3 символа:");
        foreach (string s in array.Where(s => s.Length <= 3))
            Console.WriteLine(s);
    }
}