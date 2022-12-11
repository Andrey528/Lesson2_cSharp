Console.WriteLine($"Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

int number = 0;

Console.Write($"Введите трехзначное число: ");
int.TryParse(Console.ReadLine()!, out number);

if ((number / 100 == 0) || (number / 100 > 9)) Console.WriteLine($"Это не трехзначное число");
else Console.WriteLine($"Вторая его цифра: {(number / 10) % 10}");

// -------------------------------------------------------------------------------------------------------------------

Console.WriteLine($"Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

number = 0;

Console.Write($"Введите целое число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number / 100 == 0) Console.WriteLine($"Третьей цифры у числа нет");
else Console.WriteLine($"Третья его цифра: {(number / 100) % 10}");

// -------------------------------------------------------------------------------------------------------------------

Console.WriteLine($"Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

number = 0;

Console.Write($"Введите порядковый номер дня недели: ");
int.TryParse(Console.ReadLine()!, out number);

weekends(number);

void weekends(int day)
{
    if (day <= 7)
    {
        if (day > 5) Console.WriteLine($"Это выходной");
        else Console.WriteLine($"Это будний день");
    }
    else Console.WriteLine($"В неделе 7 дней, вы ввели некорректно");
}