// Task 2.Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
/*Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write($"The Number {num1} is greater than number {num2}");
}
else if(num1 < num2)
{
    Console.Write($"The Number {num2} is greater than number {num1}");
}
else {
    Console.Write($"The Number {num1} is equal to the number {num2}");
}*/

// Task 4. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
/*Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{
    max = num2;
}

if(num3 > max)
{
    max = num3;
}
Console.Write($"max number: {max}");*/

// Task 6. Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
/*Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = num % 2;

if (res == 0)
{
    Console.Write($"number {num} is even");
}
else {
    Console.Write($"number {num} is not even");
}*/

// Task 8. Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
/*Console.Write("Input a number: ");

int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
int res = 0;

while(current <= num)
{ res = current % 2;

    if(res == 0)
    {
        Console.Write(current + " ");
    }
    
    current++;
}*/