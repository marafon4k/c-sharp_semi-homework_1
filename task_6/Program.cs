﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a % 2;
// Console.WriteLine(result);

if (result == 0) {
    Console.WriteLine("Да, число четное");
} else {
    Console.WriteLine("Нет, число нечетное");
}