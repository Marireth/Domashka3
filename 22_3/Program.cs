/* Задача 23
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N */

Console.Write("Введите число N = "); 
int Number = Convert.ToInt32(Console.ReadLine());
int Squares = 1;
while (Squares <= Number)
{
    Console.WriteLine(Squares * Squares * Squares + "");
    Squares++;
}