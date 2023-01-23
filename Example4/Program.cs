// Написать программу, которая выводит случайное трехзначное число и удаляет среднюю цифру
// 486 -> 46

Random rand = new Random(); // Объявление объекта класса Random
int randNumber = rand.Next(100, 1000); // Генерация переменной от 100 до 999 
System.Console.WriteLine(randNumber);
int number1 = randNumber/100;
int number2 = randNumber%10;
System.Console.WriteLine(number1*10 + number2);