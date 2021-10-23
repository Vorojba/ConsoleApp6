using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine();//пустая строка
            Console.Write("Введите свое имя: ");// Ввод имени
            userName = Console.ReadLine();
            Console.WriteLine("  Привет {0}!, userName");
            Console.Write(" Введите число ");//Теперь введите число
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите еще число ");//Введите еще одно число
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма чисел{0}+{1}={2}.",//Сумма чисел
            firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("Разность чисел {0}-{1}={2}.",//Результат вычитания
            firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("Произведение чисел {0} и {1} будет {2}.",//Результат умножения
            firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("Результат деления  чисел {0} на {1} будет {2}. ",//Результат деления 
            firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("Остаток от деления  числа {0} на {1} равно {2}.",//Остаток от деления  
            firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();
        }
    }
}
