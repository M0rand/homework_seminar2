// Напишите программу, которая выводит случайное число из отрезка [10, 99] и выводит наибольшее число
// 85 -> 8
// 26 -> 6

Random rand = new Random(); // Объявление объекта класса Random
int randNumber = rand.Next(10, 100); // Генерация переменной от 10 до 99
System.Console.WriteLine(randNumber);

if(randNumber/10 > randNumber%10)
{
    System.Console.WriteLine(randNumber/10);
}
else
{
    System.Console.WriteLine(randNumber%10);
}