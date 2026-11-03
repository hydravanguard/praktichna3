using System;

class ShapeArea
{
    public static void Run()
    {
        Console.WriteLine("Оберіть фігуру:");
        Console.WriteLine("1. Квадрат");
        Console.WriteLine("2. Коло");
        Console.WriteLine("3. Прямокутник");
        Console.WriteLine("4. Трикутник");

        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double area = 0;

        switch (choice)
        {
            case 1:
                Console.Write("Введіть сторону квадрата: ");
                double side = Convert.ToDouble(Console.ReadLine());
                area = side * side;
                break;

            case 2:
                Console.Write("Введіть радіус кола: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * radius * radius;
                break;

            case 3:
                Console.Write("Введіть довжину: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть ширину: ");
                double width = Convert.ToDouble(Console.ReadLine());

                area = length * width;
                break;

            case 4:
                Console.Write("Введіть основу трикутника: ");
                double triangleBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть висоту трикутника: ");
                double height = Convert.ToDouble(Console.ReadLine());

                area = triangleBase * height / 2;
                break;

            default:
                Console.WriteLine("Невірний вибір!");
                return;
        }

        Console.WriteLine($"Площа фігури: {area:F2}");
    }
}