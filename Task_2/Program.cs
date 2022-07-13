// Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100,1000);
System.Console.WriteLine($"Рандомное число - {number}");
int final=0;
final= ((number/100)*10)+(number%10);
System.Console.WriteLine($"Новое число - {final}");