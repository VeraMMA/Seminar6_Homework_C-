// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using System.Linq;
namespace homework
{
    class Program
    {
        static void Print(string word)
        {
            System.Console.WriteLine(word);
        }

        static void Main()
        {
            Print("Найти точку пересечения двух прямых,");
            Print("Введите число b1:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Print("Введите число k1:");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Print("Введите число b2:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Print("Введите число k2:");
            int k2 = Convert.ToInt32(Console.ReadLine());


            CrossPoint(k1, b1, k2, b2);

        }

        static void CrossPoint(double k1, double b1, double k2, double b2)
        {
            double x = (b1 - b2) / (k2 - k1);
            double y = (k2 * b1 - k1 * b2) / (k2 - k1);
            System.Console.WriteLine($" ({x}; {y})");
            if (k1 == k2)
            {
                Console.Write("Прямые совпадают");
            }
            else
                Console.Write("Прямые параллельны");
        }




    }

}

