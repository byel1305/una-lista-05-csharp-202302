using System;

public class Exercise_05
{
    public void run()
    {
        int[] numbers = new int[20];
        int[] evenNumbers = new int[20];
        int[] oddNumbers = new int[20];
        int evenCount = 0;
        int oddCount = 0;

        Console.WriteLine("Enter 20 integers:");
        for (int i = 0; i < 20; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] % 2 == 0)
            {
                evenNumbers[evenCount] = numbers[i];
                evenCount++;
            }
            else
            {
                oddNumbers[oddCount] = numbers[i];
                oddCount++;
            }
        }

        Console.WriteLine("All Numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenCount; i++)
        {
            Console.WriteLine(evenNumbers[i]);
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddCount; i++)
        {
            Console.WriteLine(oddNumbers[i]);
        }
    }
}