// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int number = ReadInt("Введите трёхзначное число: ");
int secondDigit = number % 100 / 10;
Console.WriteLine(secondDigit);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}