// Task 25. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Write("***\n__Задача №25: возведение числа A в натуральную степень B__\n");
Console.Write("Введите число A: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = 1;
if (b1 < 1)
Console.Write("Число B должно быть натуральным\n");
else
{
while (b1!=0)
{
c1 = c1 * a1;
b1 = b1 - 1;
}
Console.Write($"Число A в натуральной степени B равно {c1}\n");
}

//Task 27. Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
Console.Write("***\n__Задача №27: сумма цифр в числе__\n");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a)}\n");

int Sum(int a)
{
int sum = 0;
while (a > 0)
{
sum += a % 10;
a /= 10;
}
return sum;
}

//Task 29. Напишите программу, которая задаёт массив из m элементов
// и выводит их на экран.
Console.Write("***\n__Задача №29: массив из m элементов__\n");
Console.Write("Введите число элементов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[m];
randomArray[0] = new Random().Next(1,99);
Console.Write($"Ваш массив на {m} элементов: {randomArray[0]}");// Вывод первого элемента массива
for (int i = 1; i < m; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(", " + randomArray[i]);//Вывод последующих элементов с запятой перед ним
}


