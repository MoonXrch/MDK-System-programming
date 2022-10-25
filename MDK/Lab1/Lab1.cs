namespace MDK.Lab1
{
    public class Lab1 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            cw();
            Console.WriteLine("ЗАДАНИЕ №1");
            Console.WriteLine(Task1());
            cw();
            Console.WriteLine("ЗАДАНИЕ №2");
            Console.WriteLine(Task2());
            cw();
            Console.WriteLine("ЗАДАНИЕ №3");
            Task3();
            cw();
            Console.WriteLine("ЗАДАНИЕ №4");
            Console.WriteLine(Task4());
            Console.ReadLine();
            //Задание 1
    static double Task1()
    {
        cw();
        double a;
        a = Math.Sqrt(((Math.Pow(2, 2)- Math.Pow(3, 3)) /(Math.Sqrt(Math.Pow(3, 4)- Math.Pow(2, 4))))+(Math.Abs(Math.Pow(3,5)- Math.Pow(15, 2.5))));
        return a;
    }


    //Задание 2
    static double Task2() 
    {
        cw();
        Random rnd = new Random();
        double a = rnd.Next(0,100);
        double b = rnd.Next(0,100);
        double c = (Math.Pow(a,2)+Math.Cbrt(b))/(a+b);

        return c;
    }

    //Задание 3
    static void Task3()
    {
        cw();
        double a = 5.93576;
        int b = Convert.ToInt32(a);
        Console.WriteLine(b);
        int c = Convert.ToInt32(Math.Ceiling(a));
        Console.WriteLine(c);
        int d = Convert.ToInt32(Math.Floor(a));
        Console.WriteLine(d);
        double e = Math.Round(a,1);
        Console.WriteLine(e);
        int f = 5;
        int g = f++;
        Console.WriteLine(g);
        int t = 5;
        int j = ++t;
        Console.WriteLine(j);

    }
    
    //Задание 4
    static int Task4()
    {
        cw();
        Random rnd = new Random();
        int a = rnd.Next();
        return a;
    }



    static void cw()
    {
        Console.WriteLine();
    }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №1";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 1;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №1. Тема: Арифметические операции. Классы Random и Math. Приведение числовых типов данных. Округление. Суффиксы и префиксы";
        }
    }
}
