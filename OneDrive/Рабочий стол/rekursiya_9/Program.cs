﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine(" введите N ");

// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers( int start , int end )

// {
//     if ( start == end ) return end.ToString();

//    return(start + "," + PrintNumbers(start - 1, end ) );               
    
// }

// Console.WriteLine(PrintNumbers(N , 1));


// /*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// */

// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int numberN = int.Parse(Console.ReadLine());

// ///Метод нахождения суммы натуральных элементов в промежутке от M до N
// void GapNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }

// GapNumberSum(numberM, numberN, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9

// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }