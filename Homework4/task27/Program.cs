Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int sumInNumber(int numberA)
{
    int sum = 0;
    while (numberA > 0)
    {
        int x = numberA % 10;
        sum = sum + x;
        int y = numberA / 10;
        numberA = y;
    }
    return sum;
}
int sum = sumInNumber(numberA);
Console.WriteLine($"Сумма цифр в числе {numberA} = {sum}");
