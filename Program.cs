using System;
using System.Collections;

public static class Maths
{
    static void min()
    {
        int number1 = 0;
        int number2 = 0;
        Console.WriteLine("Type a number and press Enter");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number and press Enter");
        number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 <= number2)
        {
            Console.WriteLine(" => Lower number: " + number1);
        }
        else
        {
            Console.WriteLine(" => Lower number: " + number2);
        }
    }
    static void max()
    {
        int number1 = 0;
        int number2 = 0;
        Console.WriteLine("Type a number and press Enter");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number and press Enter");
        number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 >= number2)
        {
            Console.WriteLine(" => Higher number: " + number1);
        }
        else
        {
            Console.WriteLine(" => Higher number: " + number2);
        }
    }
    static void factorial()
    {
        int number1 = 0;
        Console.WriteLine("Type a number(0-16) and press Enter");
        number1 = Convert.ToInt32(Console.ReadLine());
        while (number1 < 0)
        {
            Console.WriteLine("Please enter a number between 0 and 16: ");
            number1 = Convert.ToInt32(Console.ReadLine());
        }
        while (number1 > 16)
        {
            Console.WriteLine("Please enter a number between 0 and 16: ");
            number1 = Convert.ToInt32(Console.ReadLine());
        }
        long fact = GetFactorial(number1);
        Console.WriteLine(" => {0}! is {1}", number1, fact);
    }
    private static int GetFactorial(int number1)
    {
        if (number1 == 0)
        {
            return 1;
        }
        return number1 * GetFactorial(number1 - 1);
    }
    public static void sort()
    {
        Console.WriteLine("Type a number and press Enter");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" => Sorted Array: " );
    }
    static int[] Sort(int[] array)
    {

        int[] sortedArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            sortedArray[i] = array[i];
        }

        for (int i = 0; i < sortedArray.Length; i++)
        {
            for (int j = 0; j < sortedArray.Length; j++)
            {
                if (sortedArray[i] < sortedArray[j])
                {
                    int temp = sortedArray[i];
                    sortedArray[i] = sortedArray[j];
                    sortedArray[j] = temp;
                }
            }
        }
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
        return sortedArray;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Which operation do you want to do?");
        Console.WriteLine("\t     a - Find the lower value");
        Console.WriteLine("\t     b - Find the higher value");
        Console.WriteLine("\t     c - Get the factorial of the number");
        Console.WriteLine("\t     d - Sort the numbers");
        Console.WriteLine(" any other key - Exit");
        Console.Write("Your option?(Type the letter next to the wanted operation and then press Enter) ");
        switch (Console.ReadLine())
        {
            case "a":
                min();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Main(args);
                break;          
            case "b":
                max();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Main(args);
                break;
            case "c":
                factorial();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Main(args);
                break;
            case "d":
                sort();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Main(args);
                break;
        }
    }
}