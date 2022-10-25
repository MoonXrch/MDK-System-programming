
namespace MDK.Lab5
{
    public class Lab5 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            int[,] matrix = RandomMatrix();
            Console.WriteLine();
            Console.WriteLine("ЗАДАНИЕ №1");
            Console.WriteLine();
            
            PrintMainMass(matrix);
            PrintSecondaryMass(matrix);
            Console.WriteLine();
            Console.WriteLine(SummMatrix(matrix));


            static int[,] RandomMatrix()
            {
                int[,] matrix = new int[4,4];
                Random rnd = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(-100,100);
                    }
                }
                return matrix;
            }

            static void PrintMainMass(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    Console.WriteLine(matrix[i,i]);
                Console.WriteLine();
            }

            static void PrintSecondaryMass(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    Console.WriteLine(matrix[i, matrix.GetLength(0)-i-1]+ "\t");
            }

            static int SummMatrix(int[,] matrix)
            {
                int sum = 0;
                for (int i = 0; i<matrix.GetLength(0); i++)
                {
                    for (int j = 0; j<matrix.GetLength(1); j++)
                    {
                        sum+=matrix[i,j];
                    }
                }
                return sum;
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №5";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 5;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №5. Тема: Двумерные массивы";
        }
    }
}
