// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.Write("Введите первое число - ");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число - ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1%n2==0){
    System.Console.WriteLine("Число кратно");
}else{
    int o=n1%n2;
    System.Console.WriteLine($"Число не кратно, остаток {o}");
}