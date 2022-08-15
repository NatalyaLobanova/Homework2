// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int number = ReadInt("Введите число: ");

if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
    }  
    Console.WriteLine("Третья цифра " + number % 10);  
}

else if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    Console.WriteLine("Третья цифра " + number % 10);
}  

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}