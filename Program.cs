using System;


namespace P21_c_sharp_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("---Возведение в степень---");
            int number = GetNumberFromConsole("Введите число");

            int extent = GetNumberFromConsole("Введите степень");

            int result = Pow(number, extent);
            Console.WriteLine($"Ваш результат: {result}");

            Console.WriteLine("---Помещение цифры некоего числа в конец этого числа---");
            int longNumber = GetNumberFromConsole("Введите число, длина которого больше двух символов");
            longNumber = PutSecondCharToEnd(longNumber);

            if (longNumber == -1)
            {
                Console.WriteLine("Неправильная длина числа");
            }
            else
            {
                Console.WriteLine($"Ваш результат: {longNumber}");
            }

            Console.ReadLine();
        }

        static int GetNumberFromConsole(string welcomeMessage)
        {
            int number;

            try
            {
                Console.WriteLine(welcomeMessage);
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный ввод. Попробуйте еще раз");
                return GetNumberFromConsole(welcomeMessage);
            }

            return number;
        }

        static int Pow(int number, int extent)
        {
            if (extent == 0)
            {
                return 1;
            }

            int originalNumber = number;

            for (int index = 1; index < extent; ++index)
            {
                number *= originalNumber;
            }

            return number;
        }

        static int PutSecondCharToEnd(int numberAsInt, int position = 2)
        {
            string numberAsString = Convert.ToString(numberAsInt);
            if (numberAsString.Length < position)
            {
                return -1;
            }

            char secondChar = numberAsString[position - 1];
            numberAsString = numberAsString.Remove(position - 1, 1);
            numberAsString += secondChar;

            numberAsInt = Convert.ToInt32(numberAsString);

            return numberAsInt;
        }
    }
}