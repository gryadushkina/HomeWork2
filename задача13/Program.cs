﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100){
    Console.WriteLine("третьей цифры нет");
}
int GetThirdRank (int num) 
{
while (num > 999) 
{
    num /= 10;
}
return num % 10; 
}
Console.WriteLine(GetThirdRank(num));



