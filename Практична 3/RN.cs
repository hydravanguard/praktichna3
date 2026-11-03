using System;

class ReverseNumber
{
    public static void Run()
    {
        Console.Write("Введіть ціле число (не менше 5 цифр): ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sign = number < 0 ? -1 : 1;
        number = Math.Abs(number);

        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        reversed *= sign;

        Console.WriteLine("Результат: " + reversed);
    }
}