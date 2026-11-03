using System;

class RemoveWords
{
    public static void Run()
    {
        Console.Write("Введіть текст: ");
        string text = Console.ReadLine();

        Console.Write("Скільки слів видалити: ");
        int count = Convert.ToInt32(Console.ReadLine());

        string[] words = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        if (count < 0 || count > words.Length)
        {
            Console.WriteLine("Неправильна кількість слів.");
            return;
        }

        string result = string.Join(
            " ",
            words,
            count,
            words.Length - count
        );

        Console.WriteLine("Результат: " + result);
    }
}