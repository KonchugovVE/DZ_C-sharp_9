﻿// Задача 2: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int EnterNum(string text)
{
    System.Console.WriteLine(text);

    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ValidationCheck(int m, int n)
{
    if (m > 0 && n > 0)       //Существуют два подхода к определению натуральных чисел:
    {                         //числа, возникающие при подсчёте (нумерации) предметов: первый, второй, третий, четвёртый, пятый…;
        return true;          //числа, возникающие при обозначении количества предметов: 0 предметов, 1 предмет, 2 предмета, 3 предмета, 4 предмета, 5 предметов…
    }                         //В первом случае ряд натуральных чисел начинается с единицы, во втором — с нуля. Не существует единого для большинства математиков 
                              //мнения о предпочтительности первого или второго подхода (то есть считать ли ноль натуральным числом или нет). 
    return false;             //В подавляющем большинстве российских источников традиционно принят первый подход.
}

void SumNaturesMtoN(int m, int n, int sum = 0)
{
    if (m <= n)
    {
        sum += m;
        m++;
        SumNaturesMtoN(m, n, sum);
    }
    else
    {
        System.Console.WriteLine($" {sum}");
    }
    return;
}

int m = EnterNum("Введите первое значение");

int n = EnterNum("Введите второе значение");


if (ValidationCheck(m, n))
{
    System.Console.Write($"Сумма элиментов между {m} и {n} =");
    SumNaturesMtoN(m, n);
}
else
{
    System.Console.WriteLine("Задано не корректное условие");
}