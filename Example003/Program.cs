// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 6)
{
    System.Console.WriteLine("нет");
}
else if(number == 6 || number == 7)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("В неделе семь дней");
}