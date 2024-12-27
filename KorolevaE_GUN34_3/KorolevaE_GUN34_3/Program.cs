namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //С помощью цикла for (или while) выведите первые 10 чисел Фиббоначи (см.Задание из 3 урока)

            int[] b = new int[10];

            b[0] = 0;
            b[1] = 1;
            Console.WriteLine("Task 1. First 10 fibonacci numbers: ");
            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);

            for (int i = 2; i < b.Length; i++)
            {
                b[i] = b[i - 1] + b[i - 2];
                
                Console.WriteLine(b[i]);
            }
            Console.WriteLine();

            // Задание 2
            //Используя цикл for, выведите все чётные числа от 2 до 20

            Console.WriteLine("Task 2.Even numbers from 2 to 20");

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
                
            }
            Console.WriteLine();

            //Задание 3.
            //С помощью вложенных циклов for выведите таблицу умножения от 1 до 5.
            //Каждая строка таблицы должна быть выведена в отдельной строке.

            //Console.Write(array1[(int)i, (int)j] + " "); - выведение строк

            Console.WriteLine("Task 3. Multiplication table from 1 to 5:");
            int res = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    res = i * j;
                    Console.WriteLine($"{i} * {j} = {res}");
                }
            }
            Console.WriteLine();

            //Задание 4
            //Дана строка string password = “qwerty”; 
            //Напишите программу для ввода пароля, которая считывает пользовательский ввод Console.ReadLine.
            //Подсказка: используйте do -while

            string password = "qwerty";
            string input;

            do
            {
                Console.WriteLine("Enter the password:");
                input = Console.ReadLine();

                if (input != password)
                {
                    Console.WriteLine("Incorrect password. Please try again.");
                }
                else
                {
                    Console.WriteLine("Password is correct!");
                }
            }
            while (input != password);
            {
             
            } 
            
         
        }


    }
}

