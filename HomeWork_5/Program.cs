using System;

namespace HomeWork_5
{
    class Program
    {

        /// <summary>
        /// метод для заполнения матрицы
        /// </summary>
        /// <param name="line"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        static int[,] InputMatrix(int line, int column)
        {
            int[,] matrix = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент матрицы: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return matrix;
        }

        /// <summary>
        /// метод для вывода матрицы на консоль
        /// </summary>
        /// <param name="Args"></param>
        static void PrintMatrix(int[,] Args)
        {
            
            for (int i = 0; i < Args.GetLength(0); i++)
            {
                for (int j = 0; j < Args.GetLength(1); j++)
                {
                    Console.Write($"{Args[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// метод для умножения матрицы на число
        /// </summary>
        /// <param name="number"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int[,] NumberMultiMatrix(int number, int[,] Args)
        {
            int n = Args.GetLength(0);
            int m = Args.GetLength(1);
            int[,] newMatrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = number * Args[i, j];
                }
            }
            return newMatrix;
        }

        /// <summary>
        /// сложение двух матриц
        /// </summary>
        /// <param name="number"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int[,] additionMatrix(int[,] Args1, int[,] Args2)
        {
            int n = Args1.GetLength(0);
            int m = Args2.GetLength(1);
            int[,] newMatrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = Args1[i, j] + Args2[i, j];
                }
            }
            return newMatrix;
        }

        /// <summary>
        /// вычитание матриц
        /// </summary>
        /// <param name="Args1"></param>
        /// <param name="Args2"></param>
        /// <returns></returns>
        static int[,] substractionMatrix(int[,] Args1, int[,] Args2)
        {
            int n = Args1.GetLength(0);
            int m = Args2.GetLength(1);
            int[,] newMatrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = Args1[i, j] - Args2[i, j];
                }
            }
            return newMatrix;
        }

        /// <summary>
        /// умножение матриц
        /// </summary>
        /// <param name="Args1"></param>
        /// <param name="Args2"></param>
        /// <returns></returns>
        static int[,] multiMatrix(int[,] Args1, int[,] Args2)
        {
            int n = Args1.GetLength(0);
            int m = Args1.GetLength(1);
            int p = Args2.GetLength(1);
            int[,] newMatrix = new int[n, p];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        newMatrix[i, j] += Args1[i, k] * Args2[k, j];
                    }
                }
            }
            return newMatrix;
        }

        /// <summary>
        /// метод для ввода неотрицательного числа
        /// </summary>
        /// <returns></returns>
        static int nonNegativeNumber()
        {
            int chislo = int.Parse(Console.ReadLine());
            while (chislo < 0)
            {
                Console.Write("Введите неотрицательное число: "); chislo = int.Parse(Console.ReadLine());
            }
            return chislo;
        }

        static void Delay()
        {
            Console.ReadKey();
            Console.Clear();
        }
      
        static void Main(string[] args)
        {
            //Задание 1. Создание методов, которые производят вычисления с матрицами

            //Умножение матрицы на число
            Console.Write("Введите количество строк матрицы: "); int line = nonNegativeNumber(); //ввод количество строк матрицы с предварительной проверкой на неотрицательность
            Console.Write("Введите количество столбцов матрицы: "); int column = nonNegativeNumber();  //ввод количество столбцов матрицы с предварительной проверкой на неотрицательность
            Console.Write("Введите число для умножения: "); int number = int.Parse(Console.ReadLine()); //ввод числа для умножения матрицы на него
            Console.WriteLine();
            int[,] matrix1 = new int[line,column]; //инициализация исходной матрицы
            int[,] resultMatrix1 = new int[line, column]; //инициализация результирующей матрицы
            
            matrix1 = InputMatrix(line, column); //ввод элементов исходной матрицы
            resultMatrix1 = NumberMultiMatrix(number, matrix1); //применение метода умножения матрицы на число с присвоением результата матрице resultMatrix1

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix1); //вывод исходной матрицы
            Console.WriteLine($"Результат умножения матрицы на число {number}:");
            PrintMatrix(resultMatrix1); //вывод матрицы умноженной на число
            Delay(); //метод для задержки до нажатия любой клавиши и очистка окна консоли

            //Сложение матриц
            Console.Write("Введите количество строк матриц: "); line = nonNegativeNumber();
            Console.Write("Введите количество столбцов матриц: "); column = nonNegativeNumber();
            int[,] matrix2 = new int[line, column];
            int[,] matrix3 = new int[line, column];
            int[,] resultMatrix2 = new int[line, column];

            matrix2 = InputMatrix(line, column);
            matrix3 = InputMatrix(line, column);
            resultMatrix2 = additionMatrix(matrix2, matrix3); //метод для сложения двух матриц
            
            Console.WriteLine("Исходные матрицы:");
            PrintMatrix(matrix2);
            PrintMatrix(matrix3);

            Console.WriteLine("Результат сложения матриц:");
            PrintMatrix(resultMatrix2);
            Delay();

            //Вычитание матриц
            Console.Write("Введите количество строк матриц: "); line = nonNegativeNumber();
            Console.Write("Введите количество столбцов матриц: "); column = nonNegativeNumber();
            int[,] matrix4 = new int[line, column];
            int[,] matrix5 = new int[line, column];
            int[,] resultMatrix3 = new int[line, column];

            matrix4 = InputMatrix(line, column);
            matrix5 = InputMatrix(line, column);
            resultMatrix3 = substractionMatrix(matrix2, matrix3); //метод для вычитания двух матриц

            Console.WriteLine("Исходные матрицы:");
            PrintMatrix(matrix4);
            PrintMatrix(matrix5);

            Console.WriteLine("Результат вычитания матриц:");
            PrintMatrix(resultMatrix3);
            Delay();

            //Умножение матриц
            Console.Write("Введите количество строк матрицы А: "); line = nonNegativeNumber();
            Console.Write("Введите количество столбцов матрицы А: "); int columnA = nonNegativeNumber();
            Console.Write("Введите количество строк матрицы B: "); int columnB = nonNegativeNumber();
            int[,] matrix8 = new int[line, columnA];
            int[,] matrix9 = new int[columnA, columnB];
            int[,] resultMatrix4 = new int[line, columnB];

            matrix8 = InputMatrix(line, columnA);
            matrix9 = InputMatrix(columnA, columnB);
            resultMatrix4 = multiMatrix(matrix8, matrix9);

            Console.WriteLine("Исходные матрицы:");
            PrintMatrix(matrix8);
            PrintMatrix(matrix9);

            Console.WriteLine("Результат умножения матриц: ");
            PrintMatrix(resultMatrix4);
            Delay();
        }
    }
}
