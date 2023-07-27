//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int GetDigit(int num) {
    return num / 10 % 10;
}
Console.Write("\nYour num: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999) {
    Console.WriteLine("Error");
    return;
}
int result = GetDigit(number);
Console.WriteLine($"{number} -> {result}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
int GetDigitThird(int num1) {
    return num1 % 10;
}
Console.Write("\nYour num: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 100 || number1 > 999) {
    Console.WriteLine(-1);
    return;
} 
int result1 = GetDigitThird(number1);
Console.WriteLine($"{number1} -> {result1}"); 

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool GetDays(int day) {
    return day == 6 || day == 7; 
}
Console.Write("\nYour day: ");
int userday = Convert.ToInt32(Console.ReadLine());
if (userday < 1 || userday > 7) {
    Console.WriteLine("Error");
    return;
}
bool result2 = GetDays(userday);
    if (result2 == true) Console.WriteLine($"{userday} -> Yes");
    else Console.WriteLine($"{userday} -> No");
