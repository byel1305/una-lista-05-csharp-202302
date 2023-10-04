using System;

public class Exercise_06
{
    public void run()
    {
        double[] averages = new double[10];
        int studentsAboveSeven = 0;

        for (int i = 0; i < 10; i++)
        {
            double sum = 0;
            Console.WriteLine($"Enter the four grades for student {i + 1}:");
            for (int j = 0; j < 4; j++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            averages[i] = sum / 4;
            if (averages[i] >= 7.0)
            {
                studentsAboveSeven++;
            }
        }

        Console.WriteLine($"Number of students with an average of 7.0 or higher: {studentsAboveSeven}");
    }
}