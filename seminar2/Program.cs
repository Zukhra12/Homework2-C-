/* TASK1
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int GetSecondNumber (int num)
{
    int num2 = (num / 10) % 10;
    return num2;
} 

Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetSecondNumber (number);
Console.WriteLine($"The second digit {result} is from the number {number}");
*/

/* TASK2 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int GetThirdNum (int num)
{
    while (num > 999)
    {
       num /= 10; 
    }
    if (num > 100)
    {
        num = num % 10;
        return num;
    }
    else
    {
        return 0;
    }
}

Console.Write("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetThirdNum (number);
if (number < 99 )
{
    Console.Write("This number not have third digit");
}
else
{
    Console.WriteLine($"The third digit {result} is from the number {number}");
}
*/

/* TASK3
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool Week (int n)
{
    if (n == 6 && n == 7) return true;
    else return false;
}
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool day = Week(num);
if (num > 7 || num < 1)
{
    Console.WriteLine("There is no such day of the week :(");
}

else 
{
    if (num == 1) Console.WriteLine("Monday");
    if (num == 2) Console.WriteLine("Tuesday");
    if (num == 3) Console.WriteLine("Wednesday");
    if (num == 4) Console.WriteLine("Thursday");
    if (num == 5) Console.WriteLine("Friday");
    if (num == 6) Console.WriteLine("Saturday.Hip, hop, hooray! Day off :)");
    if (num == 7) Console.WriteLine("Sunday.Hip, hop, hooray! Day off :)");
}
*/
