using System;

public class Exercise_04
{
    public void run()
    {
        char[] characters = new char[10];
        int consonantCount = 0;

        Console.WriteLine("Enter 10 characters:");
        for (int i = 0; i < 10; i++)
        {
            characters[i] = Console.ReadLine()[0];
            if (char.IsLetter(characters[i]) && !IsVowel(characters[i]))
            {
                consonantCount++;
            }
        }

        Console.WriteLine("Consonants:");
        foreach (char character in characters)
        {
            if (char.IsLetter(character) && !IsVowel(character))
            {
                Console.WriteLine(character);
            }
        }

        Console.WriteLine("Consonant count: " + consonantCount);
    }

    private bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return Array.IndexOf(vowels, char.ToLower(c)) != -1;
    }
}