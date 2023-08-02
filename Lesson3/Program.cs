//Task19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

int num, r, sum = 0,t;
Console.Write("Задача №1\n");
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num > 9999 && num < 100000)
{
    for(t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if(t == sum)
    {
    Console.Write($"{t} является палиндромом.\n");
    } else
    Console.Write($"{t} не является палиндромом.\n");
} else
Console.Write("Введите пятизначное число!");


// Task 21.Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.Write("Задача №2\n");
int InputN(string message)
{
System.Console.Write($"{message}> ");
int value;
if (int.TryParse(Console.ReadLine(), out value))
{
return value;
}
System.Console.WriteLine("Вы ввели не число");
Environment.Exit(1);
return 0;

}

int x1 = InputN ("Введите координату X точки A");
int y1 = InputN ("Введите координату Y точки A");
int z1 = InputN ("Введите координату Z точки A");
int x2 = InputN ("Введите координату X точки B");
int y2 = InputN ("Введите координату Y точки B");
int z2 = InputN ("Введите координату Z точки B");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltax = x2 - x1;
int deltay = y2 - y1;
int deltaz = z2 - z1;
return Math.Sqrt(deltax * deltax + deltay * deltay + deltaz * deltaz);
}
System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2} \n");


// Task 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Задача №3\n");
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i = 1;i <= n; i++)
{
int k = i * i * i;
Console.Write($"{k}, ");
}