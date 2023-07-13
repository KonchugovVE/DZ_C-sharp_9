// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnterNum(string text)
{
    System.Console.WriteLine(text);

    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Существуют два подхода к определению натуральных чисел:
//числа, возникающие при подсчёте (нумерации) предметов: первый, второй, третий, четвёртый, пятый…;
//числа, возникающие при обозначении количества предметов: 0 предметов, 1 предмет, 2 предмета, 3 предмета, 4 предмета, 5 предметов…
//В первом случае ряд натуральных чисел начинается с единицы, во втором — с нуля. Не существует единого для большинства математиков 
//мнения о предпочтительности первого или второго подхода (то есть считать ли ноль натуральным числом или нет). 
//В подавляющем большинстве российских источников традиционно принят первый подход.

bool ValidationCheck(int m, int n)
{
    if (m <= 0 && n <= 0)
    {
        System.Console.WriteLine("Задано не корректное условие");
        return false;
    }
    else
    {
    return true;
    }

}


int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return AckermanFunction(m - 1, 1);
        }
        else
        {
            return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
        }
    }
}
int m = EnterNum("Enter first number: ");

int n = EnterNum("Enter second number: ");

if (ValidationCheck(m,n))
{
  System.Console.Write("Nubers Ackerman = ");
System.Console.Write(AckermanFunction(m,n));

}
