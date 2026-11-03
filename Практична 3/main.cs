using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть завдання:");
        Console.WriteLine("1. Перевернути число");
        Console.WriteLine("2. Видалити перші X слів");
        Console.WriteLine("3. Обчислити площу фігури");
        Console.WriteLine("4. Замінити символи");

        Console.Write("Ваш вибір: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ReverseNumber.Run();
                break;

            case "2":
                RemoveWords.Run();
                break;

            case "3":
                ShapeArea.Run();
                break;

            case "4":
                ReplaceCharacters.Run();
                break;

            default:
                Console.WriteLine("Невірний вибір!");
                break;
        }
    }
}