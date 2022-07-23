/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

    int Akkerman(int n, int m) 
    {
        if (n == 0)
        {
            return m + 1;
        }
        else
        {
            if ((n!= 0) && (m == 0))
            {
                return Akkerman((n - 1), 1);
            }
            else
            {
                return Akkerman((n - 1), Akkerman (n, (m-1)));
            }
        }
    }



Console.WriteLine("введите число M");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N");
int m = int.Parse(Console.ReadLine());
int result = Akkerman(n,m);
Console.WriteLine($"Результат: {result}");
