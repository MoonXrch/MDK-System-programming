
namespace MDK.Lab3
{
    public class Lab3 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            Console.WriteLine();
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            static void Task1()
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Числа в диапозоне от 0 до 100, которые делятся нацело на 24" + "\n");
                Console.WriteLine("Цикл-счетчик");
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (i % 24 == 0)
                        {
                            Console.Write(i + "\t");
                        }
                    }
                }

                Console.WriteLine();

                {
                    Console.WriteLine("Цикл с предусловием");
                    int i = 0;
                    while (i <= 100)
                    {
                        if (i % 24 == 0)
                        {
                            Console.Write(i + "\t");
                        }
                        i++;
                    }
                }

                Console.WriteLine();

                {
                    Console.WriteLine("Цикл с постусловием");
                    int i = 0;
                    do
                    {
                        if (i % 24 == 0)
                        {
                            Console.Write(i + "\t");
                        }
                        i++;
                    }
                    while (i <= 100);
                }

                Console.WriteLine();
            }
            static void Task2()
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Определить сумму всех нечетных числел в диапазоне [0; 30]");
                int sum = 0;
                
                for (int i = 0; i <30; i++)
                {
                    if (i % 2 == 0)
                    {
                    }
                    else
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("Сумма равна: "+sum);
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №3";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 3;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №3. Тема: Массивы. Строки.";
        }
    }
}
