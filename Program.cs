using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод массива с клавиатуры
        Console.WriteLine("Введите элементы массива, разделяя их запятой:");
        string input = Console.ReadLine();
        string[] array = input.Split(',');

        // Формирование нового массива
        string[] newArray = new string[array.Length];
        int newIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[newIndex] = array[i];
                newIndex++;
            }
        }

        // Вывод нового массива
        Console.Write("[");
        for (int i = 0; i < newIndex; i++)
        {
            Console.Write(newArray[i]);
            if (i < newIndex - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
}