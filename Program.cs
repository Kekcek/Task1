// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool checkPolindrom(int number, int SizeNumber)
{
    while (SizeNumber > 0)
    {
        if (number % 10 == Convert.ToInt32(number / Math.Pow(10, SizeNumber)) & (SizeNumber > 0)) 
        {
            number = number - Convert.ToInt32(number / Math.Pow(10, SizeNumber)) * Convert.ToInt32(Math.Pow(10, SizeNumber));
            number= number / 10;
        }
        else
        {
            return false;
        }
        SizeNumber = SizeNumber - 2; 
    };
    return true;
}

int SizeOfNumber(int LengthNumber)
{
    int counter = 0;
    while(LengthNumber > 0)
{
    LengthNumber = LengthNumber / 10;
    counter++;
}
return counter;
}

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int SizeNumber = SizeOfNumber(Number);
bool result = checkPolindrom(Number, SizeNumber-1);
Console.WriteLine(result);