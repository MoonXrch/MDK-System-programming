using LessonsInterface;

namespace MDK.Lab2
{
    public class Lab2 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            Task1();
            Task2();
            Task3();
            static void Task1()
            {
                Console.WriteLine("Задача №1");
                int number;
                while (true)
                {
                    Console.Write("Введите число от 1 до 7:");
                    bool isNomber = false;
                    isNomber = int.TryParse(Console.ReadLine(), out number);
                    if (isNomber)
                    {
                        if (number >= 1 && number <= 7)
                        {
                            break;
                        }
                        else
                            Console.WriteLine("Число не в приделах диапазона");
                    }
                    else
                        Console.WriteLine("Введено не число");
                }
                string day = "";
                switch (number)
                {
                    case 1:
                        day = "понедельник";
                        break;
                    case 2:
                        day = "вторник";
                        break;
                    case 3:
                        day = "среда";
                        break;
                    case 4:
                        day = "четверг";
                        break;
                    case 5:
                        day = "пятница";
                        break;
                    case 6:
                        day = "суббота";
                        break;
                    case 7:
                        day = "воскресенье";
                        break;
                }
                Console.WriteLine("День недели: " + day);
            }
            static void Task2()
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("BuzzFizz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine("Число не делится на 3 и 5 без остатка");
                }
            }

            static void Task3()
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Простой калькулятор");
                Console.Write("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите действие: ");
                var c = "";
                    c = Console.ReadLine();
                double result = 0;
                switch (c)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                       
                        break;
                }
                Console.WriteLine(a + c + b + " = " + result);
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №2";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 2;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №2. Тема: Условия. Операторы сравнения.";
        }
    }
}
