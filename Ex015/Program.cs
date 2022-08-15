//  Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int number = ReadInt("Введите число: ");

if(number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else if(number >= 1 && number < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}