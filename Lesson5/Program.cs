// Task 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("***Task 34***\nВведите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] finalArray = createArr(m);

int[] createArr(int m)
{
int[] randomArray = new int[m];
randomArray[0] = new Random().Next(99,999);
Console.Write(randomArray[0]);
for (int i = 1; i < m; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(", " + randomArray[i]);
}
return randomArray;
}

int getCount(int[] finalArray)
{
int count = 0;
for (int i = 0; i < finalArray.Length; i++)
{
if (finalArray[i] % 2 == 0)
count += 1;
}
return count;
}

Console.Write($"\nКоличество чётных чисел в массиве: {getCount(finalArray)}");

// Task 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("\n***Task 36***\nВведите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] newArray = createRandomArr(a);

int[] createRandomArr(int a)
{
int[] randomArray = new int[a];
randomArray[0] = new Random().Next(1,9);
Console.Write(randomArray[0]);
for (int i = 1; i < a; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(", " + randomArray[i]);
}
return randomArray;
}

int getSum(int[] newArray)
{
int sum = 0;
for (int i = 1; i < newArray.Length; i += 2)
{
sum += newArray[i];
}
return sum;
}

Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {getSum(newArray)}");

// Task 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

Console.Write("\n***Task 38***\nВведите количество элементов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
double[] doubleArray = createDoubleArr(b);

double[] createDoubleArr(int b)
{
double[] randomArray = new double[b];
Random rand = new Random();
randomArray[0] = rand.NextDouble();
Console.Write($"{randomArray[0]:F2}");
for (int i = 1; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write($", {randomArray[i]:F2}");
}
return randomArray;
}


double getDiffMaxMin(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i++;
}
return max - min;
}
Console.Write($"\nРазница между максимальным и минимальным элементами массива: {getDiffMaxMin(doubleArray):F2}");
