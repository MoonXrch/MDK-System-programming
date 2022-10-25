using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK.Lab7
{
    internal class Lab7 : ILabs
    {
        public void Demo()
        {
                Group PKS20 = new Group();
                PKS20.Add(new Student("Евгения", 18, "женский", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Дмитрий", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Дмитрий", 19, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Андрей", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Иван    ", 19, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Геннадий", 20, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Андрей", 19, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Михаил", 18, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Василий", 19, "мужской", "PKS20", "ВКУиНТ", "Техник-программист"));
                PKS20.Add(new Student("Юлия", 19, "женский", "PKS20", "ВКУиНТ", "Техник-программист"));

                Group ODL = new Group();
                ODL.Add(new Student("Кирилл", 20, "мужской", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Валентина", 19, "женский", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Кристина", 18, "женский", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Анастасия", 19, "женский", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Михаил", 19, "мужской", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Владимир", 20, "мужской", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Вячеслав", 18, "мужской", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Артемий", 19, "мужской", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Владислав", 21, "мужской", "ODL", "ВКУиНТ", "Логист"));
                ODL.Add(new Student("Иван", 18, "мужской", "ODL", "ВКУиНТ", "Логист"));

                Group ADT = new Group();
                ADT.Add(new Student("Геннадий", 20, "мужской", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Наталья", 18, "женский", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Людмила", 18, "женский", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Алексей", 20, "мужской", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Александр", 18, "мужской", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Борис", 20, "мужской", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Дмитрий", 19, "мужской", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Василий", 19, "мужской", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Анна   ", 19, "женский", "ADT", "ВКУиНТ", "Инженер-технолог"));
                ADT.Add(new Student("Владимир", 18, "мужской", "ADT", "ВКУиНТ", "Инженер-технолог"));

            List<Group> GroupList = new List<Group>();
                GroupList.Add(PKS20);
                GroupList.Add(ODL);
                GroupList.Add(ADT);

                Console.WriteLine("Список студентов группы ПКС:");
                PKS20.PrintGroup();
                Console.WriteLine();
                Console.WriteLine("Список студентов группы ОДЛ:");
                ODL.PrintGroup();
                Console.WriteLine();
                Console.WriteLine("Список студентов группы АДТ:");
                ADT.PrintGroup();

                Console.WriteLine();
                Console.ReadKey();
        }

        public string Description()
        {
            return "Задания лабы 7";
        }

        public int Id()
        {
            return 7;
        }

        public string Title()
        {
            return "Лабораторная №7. Тема: Сериализация";
        }
    }
}
