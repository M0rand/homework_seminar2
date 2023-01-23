// Написать программу, которая будет на вход принимать два числа и выводить , 
// является ли второе число кратным первому 
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// System.Console.WriteLine($"Большая цифра числа {randNumber}: {randNumber / 10}"); пример

System.Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе целое");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 % number2 == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($"не кратно, остаток {number1 % number2}");
}