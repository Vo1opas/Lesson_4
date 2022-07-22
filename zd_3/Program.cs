//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите N:");
int count = int.Parse(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    Console.WriteLine(powCube(i));
}
int powCube(int number)
{
    return number * number * number;
}