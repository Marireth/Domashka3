/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Введите степень для числа А: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int Step(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
int stepen = Step(numA, numB);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"{numA} в степени {numB} = {stepen}");
Console.ResetColor();
