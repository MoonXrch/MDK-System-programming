
using LessonsInterface;

namespace MDK.Lab4
{
    public class Lab4 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.ReadKey();

            static void Task1()
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Массив, заполненный случайными целыми числами в диапозоне от 0 до 100");
                int n = 10;
                int[] mass = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(0, 100);
                    Console.Write(mass[i] + "\t");
                }
                Console.WriteLine();
            }

            static void Task2()
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Разделение строки с использованием метода Split");
                string str = "awd 23 f 4 rg3 3";
                string[] strArr = str.Split();
                foreach (string el in strArr)
                {
                    Console.WriteLine(el);
                }
            }

            static void Task3()
            {
                Console.WriteLine("Задание 3");
                Console.WriteLine("Метод пузырьковой сортировки одномерного целочисленного массива");
                int[] myMass = new int[5] { 3, 6, 2, 1, 4 };
                for (int i = 0; i < myMass.Length - 1; i++)
                {
                    for (int j = 0; j < myMass.Length - 1; j++)
                    {
                        if (myMass[j] > myMass[j + 1])
                        {
                            int bufer = myMass[j];
                            myMass[j] = myMass[j + 1];
                            myMass[j + 1] = bufer;
                        }
                    }
                }
                foreach (int i in myMass)
                {
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №4";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 4;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №4. Тема: Циклы";
        }
    }
}
