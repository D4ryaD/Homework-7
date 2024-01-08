// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Console.Write("Введите число M: "); 
// int M = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число N: "); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// SumFromMToN(M, N); 
// void SumFromMToN(int M, int N) 
// { 
//     Console.Write(SumMN(M - 1, N)); 
// } 
// int SumMN(int m, int n) 
// { 
//     int res = m; 
//     if (m == n) 
//     return 0; 
//         else 
//     { 
//         m++; 
//         res = m + SumMN(m, n); 
//         return res; 
//     } 
// }
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.Write("Введите число M: "); 
// int M = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число N: "); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// AkkermanFunction(M, N); 
 
// void AkkermanFunction(int M, int N) 
// { 
//     Console.Write(Akkerman(M, N)); 
// } 
 
// int Akkerman(int M, int N) 
// { 
//     if (M == 0) 
//     { 
//         return N + 1; 
//     } 
//         else if (N == 0 && M > 0) 
//     { 
//         return Akkerman(M - 1, 1); 
//     } 
//             else 
//         { 
//             return (Akkerman(M - 1, Akkerman(M, N - 1))); 
//         } 
// }
// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// class MainReturn 
// { 
// static void Main(string[] args) 
//     { 
//         int[] array = { 1, 2, 5, 0, 10, 34 }; 
 
//         PrintArrayReversed(array, array.Length - 1); 
//     } 
//      static void PrintArrayReversed(int[] arr, int index) 
//     { 
//         if (index >= 0) 
//         { 
//             Console.Write(arr[index] + " " ); 
//             PrintArrayReversed(arr, index - 1); 
//         } 
  
//     } 
// }