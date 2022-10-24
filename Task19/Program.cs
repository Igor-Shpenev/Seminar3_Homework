// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void CheckingPalindrome(int num)
{
    int digit1 = num / 10000;
    int digit5 = num % 10;
    int digit2 = (num / 1000) % 10;
    int digit4 = (num / 10) % 10;
    if (digit1 == digit5 & digit2 == digit4)
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} НЕ является палиндромом");
}

}


Console.Write("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 & number < 100000)
{
    CheckingPalindrome(number);
}
else
{
    Console.WriteLine("Введено не пятизначное число!");
}
