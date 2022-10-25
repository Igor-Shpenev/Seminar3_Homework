// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumber(int num)
{
    /*for (int i = 1; i<= num; i++)
    {
        Console.Write($"{i * i * i} ");   // Решение через цикл for
    }*/

    int x = 1;
    while (x <= num)
    {
        int result = x * x * x;
        x++;
        Console.Write($"{result} ");
    }
    
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeNumber(number);
