//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

int i;
bool isPalindrom = true;
string str;


Console.WriteLine("Введите строку:");
str = Console.ReadLine();

if (str.Length % 2 != 0)
{
    for (i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            isPalindrom = false;
            break;
        }
    }

}
else
{
    isPalindrom = false;
}

if (isPalindrom)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}