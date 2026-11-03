using System;

class ReplaceCharacters
{
    public static void Run()
    {
        Console.Write("Введіть текст: ");
        string text = Console.ReadLine();

        char[] characters = text.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            int position = i + 1;

            if (position % 3 == 0)
            {
                characters[i] = 'X';
            }
            else if (position % 5 == 0)
            {
                characters[i] = '9';
            }
        }

        string result = new string(characters);

        Console.WriteLine("Результат: " + result);
    }
}