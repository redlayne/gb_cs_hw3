// господи, какой же я ленивый. так хотел допилить дополнительные задачи
// но я, честное слово, иду в продакты, поэтому что уж тут...

void Break()
{
    Console.WriteLine();
    Console.WriteLine(new string('*', 50));
    Console.WriteLine();
}

int Input (string inputmessage)
{
    Console.Write(inputmessage);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int SuperPower(int powbase, int exponent) // целочисленное возведение в степень
{
    if (exponent == 0) return 1;
    
    int result = 1;
    for (int i = 1; i <= exponent; i ++)
    {
        result = result * powbase;
    }
    return result;
}

int CountDigits (int tocount) // считаем знаки в числе без конвертации типов
{
    int temp = tocount;
    int counter = 0;
    while (temp > 0)
    {
        temp = temp / 10;
        counter ++;
    }
    return counter;
}

string PalindromeTask19 () // надо было с пятизначным, но тк дз уже разобрали, я усложнил себе жизнь
{
    int ispalindrome = Input ("Enter a number, let's chek if it is a palindrome: ");
    int digits = CountDigits(ispalindrome);

    for (int i = 0; i <= digits / 2 - 1 ; i++)
    {
        if ((ispalindrome /  SuperPower(10, i)) % 10 != (ispalindrome / SuperPower(10, (digits-i-1))) % 10) // последний знак != первый знак
        {
            return("Not a palindrome...");
        }
    }
    return("It is a palindrome!");
}

void Distance3DTask21()
{
    int x1 = Input("Enter x coordinate for 1st point: ");
    int y1 = Input("Enter y coordinate for 1st point: ");
    int z1 = Input("Enter z coordinate for 1st point: ");
    Console.WriteLine();
    int x2 = Input("Enter x coordinate for 2nd point: ");
    int y2 = Input("Enter y coordinate for 2nd point: ");
    int z2 = Input("Enter z coordinate for 2nd point: ");

    double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
    Console.WriteLine("\nDistanse between points is " + Math.Round(dist, 2));

}

void AllPow3ToNTask23()
{
    int numberN = Input("Input a number N: ");
    while (numberN > 1290 || numberN < -1290 || numberN == 0) numberN = Input("Come on, we have integers here! And no zeroes!\nInput another number: ");
    for (int i = 1; i <= numberN; i++) Console.WriteLine($"{i}^3 = {SuperPower(i, 3)}");
    for (int i = -1; i >= numberN; i--) Console.WriteLine($"{i}^3 = {SuperPower(i, 3)}"); // Здесь для понятности кода можно было бы явно проверять условие знака числа, но в прицнципе так тоже работает ))
}

Console.Clear();

Console.WriteLine(PalindromeTask19());

Break();

Distance3DTask21();

Break();

AllPow3ToNTask23();