using System;

namespace MDK;

class Program
{
    static void Main()
    {
        List<ILabs> labs = new List<ILabs>();

        labs.Add(new MDK.Lab1.Lab1());           
        labs.Add(new MDK.Lab2.Lab2());
        labs.Add(new MDK.Lab3.Lab3());
        labs.Add(new MDK.Lab4.Lab4());
        labs.Add(new MDK.Lab5.Lab5());
        labs.Add(new MDK.Lab6.Lab6());
        labs.Add(new MDK.Lab7.Lab7());
        LabsInfo(labs);                 // выводим информацию о всех лабах

        bool running = true;

        while (running)                // запускаем бесконечный цикл
        {
            Console.Write("Введите ID лабораторной: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "clear":
                    Clear();
                    break;
                case "info":
                    LabsInfo(labs);
                    break;
                case "help":
                    Help();
                    break;
                case "exit":
                    running = false;
                    break;
                default:
                    {
                        Demo(labs, command);
                    }
                    break;
            }
        }
    }

    /// <summary>
    /// Метод запускает Demo по введенному ID
    /// </summary>
    /// <param name="labs"></param>
    /// <param name="id"></param>
    static void Demo(List<ILabs> labs, string id)
    {
        try
        {
            int ID = Convert.ToInt32(id);
            foreach (ILabs lab in labs)
            {
                if (ID == lab.Id())
                {
                    lab.Demo();
                }
            }
        }
        catch
        {
            Console.WriteLine("Неверная команда. Попробуйте еще раз.");
        }
    }

    /// <summary>
    /// Метод выводит информацию обо всех доступных лабораторных
    /// </summary>
    /// <param name="labs"></param>
    static void LabsInfo(List<ILabs> labs)
    {
        foreach (ILabs lab in labs)
        {
            Console.WriteLine(lab.Id());
            Console.WriteLine(lab.Title());
            Console.WriteLine(lab.Description());
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Метод очищает экран
    /// </summary>
    static void Clear()
    {
        Console.Clear();
    }

    /// <summary>
    /// Метод выводит все доступные команды
    /// </summary>
    static void Help()
    {
        string[] commands =
        {
            "<ID> - запуск демонстрации лабораторной по ID",
            "<exit> - выход",
            "<help> - список доступных команд",
            "<clear> - очистка экрана",
            "<info> - вывод информации о всех лабораторных"
        };

        foreach (string command in commands)
        {
            Console.WriteLine(command);
        }
    }
}
