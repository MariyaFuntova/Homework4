Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int sumInNumber(int numberA)
{
    int sum = 0;
    while (numberA > 0)
    {
        int mod =numberA % 10;
        sum = sum + mod;
        int div = numberA / 10;
        numberA = div;
    }
    return sum;
}
int sum = sumInNumber(numberA);
Console.WriteLine($"Сумма цифр в числе {numberA} = {sum}");
