using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Длинна массива:");
        int m = int.Parse(Console.ReadLine());
        int[] array = new int[m];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 101);
            Console.WriteLine(array[i]);
        }
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % n == 0)
            {
                sum += array[i];
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Кратных чисел нет");
        }
        else
        {
            double x = sum / count;
            Console.WriteLine($"Среднее арифметическое массива равно {x}");
        }
        
    }
}