﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число "); // просим пользователя ввести число
int x = int.Parse(Console.ReadLine()); // компьютер принимает от пользователя число
void ost (int num) // объявление метода
{
    int counter = 0; // 
    
    while (num !=0)
    {    
        num /= 10; // сколько раз делили на 10 число с остатком столько цифр и находится в числе
        counter ++;
    }

    Console.WriteLine ($"Количество цифр в числе: {counter} ");

}

ost (x);
