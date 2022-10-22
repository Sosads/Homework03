// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = ReadInt("Введите число: ");
int m = 1;

for (m = 1; m <= number; m++)
{
    Console.WriteLine($"{Math.Pow(m, 3)}");
}

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}