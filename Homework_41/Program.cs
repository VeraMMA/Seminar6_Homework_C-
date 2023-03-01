// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
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
            Print("Сколько чисел больше 0 ввел пользователь.");

            Print("Заполните массив");
            int[] myArray = GetNumbersFromUser(6);
            PrintArray(myArray);
            CountDigit(myArray);

        }
        static int[] GetNumbersFromUser(uint size)
        {
            int[] myArray = new int[6];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return myArray;
        }
        public static void PrintArray(int[] myArray)
        {
            for (int j = 0; j < myArray.Length; j++)
            {
                if (myArray[j] > 0)
                    System.Console.WriteLine("Числа больше 0: " + myArray[j]);
            }
        }

        public static void CountDigit(int[] myArray)
        {
            int countOfDigits = 0;
            int[] result = myArray.Where(i => i > 0).ToArray();
            for (int k = 0; k < result.Length; k++)
            {
                countOfDigits++;
            }
            System.Console.WriteLine(countOfDigits);
        }


    }
}
