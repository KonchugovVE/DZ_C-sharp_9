// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N 
//с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int EnterNum(string text)
{
    System.Console.WriteLine(text);

    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ValidationCheck(int m, int n)
{
    if (m > 0 && n > 0)       //Существуют два подхода к определению натуральных чисел:
    {                        //числа, возникающие при подсчёте (нумерации) предметов: первый, второй, третий, четвёртый, пятый…;
        return true;           //числа, возникающие при обозначении количества предметов: 0 предметов, 1 предмет, 2 предмета, 3 предмета, 4 предмета, 5 предметов…
    }                        //В первом случае ряд натуральных чисел начинается с единицы, во втором — с нуля. Не существует единого для большинства математиков 
                             //мнения о предпочтительности первого или второго подхода (то есть считать ли ноль натуральным числом или нет). 
    return false;               //В подавляющем большинстве российских источников традиционно принят первый подход.
}

void OutputEvenNumbersFromMtoN(int m, int n, int num)
{
    if (num % 2 == 0)
    {
        System.Console.Write($"{num}\t");
    }
    num ++;
    if (num > n)
    {
        return;
    }
    OutputEvenNumbersFromMtoN(m, n, num);
}

int m = EnterNum("Введите первое число");








int n = EnterNum("Введите второу число");

int num = m;

if (ValidationCheck (m,n))
{
  System.Console.Write($"Четные числа от {m} до {n}: ");
  OutputEvenNumbersFromMtoN(m,n,num);   
}
else
{
    System.Console.WriteLine("Задано не корректное условие");
}