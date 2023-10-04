using System;

public class Exercise_03
{
    public void run()
    {
        double[] grades = new double[4];

        Console.WriteLine("Enter 4 grades:");
        for (int i = 0; i < 4; i++)
        {
            grades[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Grades:");
        foreach (double grade in grades)
        {
            Console.WriteLine(grade);
        }

        double average = (grades[0] + grades[1] + grades[2] + grades[3]) / 4;
        Console.WriteLine("Average: " + average);
    }
}