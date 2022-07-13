// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void prov (int number){
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        System.Console.WriteLine(Convert.ToString(number)[2]);
    }
}
System.Console.Write("Введите число - ");
int n = Convert.ToInt32(System.Console.ReadLine());
prov(n);

// Это я решил тему прошлой лекции по функциям сюда присоединить))