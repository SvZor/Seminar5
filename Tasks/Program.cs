// // Разбор двумерных массивов
// int[,] array = new int[5, 4]; // инт с запятой к квадратных строчках означает
// // что мы задаем числовые значения целых чисел в двумерный массив
// // далее создаем массив и прописыаем в нем число строчек - 5 и число столбцов 2
// for (int i = 0; i < array.GetLength(0); i++) // гетленс это специальная функция
// // которая берет одну размерность и в круглых скобках указываем какую именно
// // если 0 то это строчки, если 1 то столбцы.
// {
//     for (int j = 0; j < array.GetLength(1); j++) //сначала пройдет 
//     // внутренний цикл
//     // потом он перейдет на внешний цикл
//     // всю работу на себя берет внутренний цикл, 
//     // внешний переносит на следующую строку
//     {
//         array[i, j] = new Random().Next(1, 10);
//         System.Console.Write(array[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }

// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 16 3
// 4 3 4 1
// 4 9 25 4

// int[,] array = new int[5, 4];

// void FillingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
// }

// FillingArray();
// PrintArray();
// ChangeArray();
// System.Console.WriteLine();
// PrintArray();

// // Задайте двумерный массив. Найдите сумму элементов,
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и
// // т.д.
// // Пример
// // 2 3 4 3
// // 4 3 4 1 => 2 + 3 + 5 = 10
// // 2 9 5 4

// int[,] array = new int[5, 4];
// void FillingArray() // заполнение массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray() //печать массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int GetSumInArray() // сумма цифр по диагонали
// {
//     int sum = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j) // если номер строки совпадает с нолмером столбца
//             {
//                 sum += array[i, j]; // суммируются данные ячеек
//                 // sum = sum+ array[i,j];
//             }
//         }
//     }
//     return sum;
// }

// FillingArray();
// PrintArray();

// System.Console.WriteLine(GetSumInArray());

// // Задайте двумерный массив из целых чисел. Сформируйте новый
// // одномерный массив, состоящий из средних арифметических
// // значений по строкам двумерного массива.
// // Пример
// // 2 3 4 3
// // 4 3 4 1 => [3 3 5]
// // 2 9 5 4

// int[,] array = new int[5, 4];
// double[] array2 = new double[array.GetLength(0)]; //создали оджномерный массив
// // он не инт а дабл, т к среднее арифметическое это дробное число
// // длина массива будет равно числу строе, поэтому в гетлент будет число 0
// // т е строка

// void FillingArray() // войд, которный ничего не возвращает, 
// //только создает массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray() // печать созданного массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void GetSumInArray() // создание массива из 
// // среднеарифметических первого массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         double sum = 0; // переменная обнуляется, поэтому она внутри цикла

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         array2[i] = sum / array.GetLength(1);
//     }
// }

// void PrintArray2() // печать второго массива 
// {
//     for (int i = 0; i < array2.Length; i++)
//     {
//         System.Console.Write(array2[i] + " ");
//     }
// }

// FillingArray();
// PrintArray();

// GetSumInArray();
// System.Console.WriteLine();
// PrintArray2();

