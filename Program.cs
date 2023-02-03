// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (n == m)
    Console.WriteLine($"В числа {m} и {n}, сумма равна: {m + n}");
else if (m > n) //Если число M ,больше N
{
    Recurs1(m, n, 0);
    void Recurs1(int num1, int num2, int s)
    {
        if (num1 == num2)
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}, равна: {s + num2}");
            return;
        }
        s = s + num2++;
        Recurs1(num1, num2, s);
    }
}
else
{   //Если число N ,больше M
    Recurs2(m, n, 0);
    void Recurs2(int num1, int num2, int s)
    {
        if (num1 == num2)
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}, равна: {s + num2}");
            return;
        }
        s = s + num1++;
        Recurs2(num1, num2, s);
    }
}

