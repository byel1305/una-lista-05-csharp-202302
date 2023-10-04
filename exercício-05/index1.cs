using System;

public class Exercise_01
{
    public void run()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You entered the following numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}