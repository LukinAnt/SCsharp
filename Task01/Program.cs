/*
напишите программу, которая на вход принимает число и выдает его квадрат 
(число умноженное на само себя)
4-16
-3-9
-7-49
*/

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;
Console.WriteLine(result);
*/


/*
Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго

a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет
*/

/*
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/

/*
Task03
Напишите программу, которая будет выдавать название жгя недели по заданному номеру

3 -> среда
5 -> пятница
я- почемуто на семинаре пишут else if. а у меня и так работает
*/
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number ==1)
{
    Console.WriteLine("понедельник");
}
if (number ==2)
{
    Console.WriteLine("вторник");
}
if (number ==3)
{
    Console.WriteLine("среда");
}
if (number ==4)
{
    Console.WriteLine("четверг");
}
if (number ==5)
{
    Console.WriteLine("пятница");
}
if (number ==6)
{
    Console.WriteLine("суббота");
}
if (number ==7)
{
    Console.WriteLine("воскресенье");
}
if (number > 7)
{
    Console.WriteLine("нет такого дня");
}
*/

/*
Напишите программу, которая на вход принимает целое число N, 
а на выходе показывает все целые числа в промежутке от -N до N.
4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
2 => -2, -1, 0, 1, 2
*/
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


for (int i = -number; i <= number; i++)
{
Console.Write(i+" " );
}
*/

/*
Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру этого числа
 
456 => 10
782 => 9
918 => 17
*/

/*
Console.WriteLine("Введите техзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    Console.WriteLine(number%10);
}
else
Console.WriteLine("число не трехзначное");
*/
/*
2. Напишите программу, которая на вход принимает два числа 
и выдает какое число больше а какое меньше
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Введите два число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine($"больше первое число {number1}");
    Console.WriteLine($"меньше второе число {number2}");
}
else
{
    Console.WriteLine($"больше Второе число {number2}");
    Console.WriteLine($"меньше первое число {number1}");

}
*/


/*
4. Напишите программу, которая  на вход принимает три числа и выдает 
максимальное из этих чисел
*/
/*
Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number2 > max)
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}
Console.WriteLine(max);
*/


/*
6. Напишите программу, которая  на вход принимает число и выдает, 
является ли число четным(желится ли на 2 без остатка)
 4
 -3
 7
*/
/*
Console.WriteLine("Введите числo: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number % 2;
if(number2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нетт");
}
*/


/*
8. Напишите программу, которая на вход принимает число (N) и 
на выходе показывает все четные числа от 1 до N

 5->2 4
 8->2 4 6 8
*/

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i+=2)
{
Console.Write($"{i} ");
}
*/

// семинар 2

/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/
/*
int number = new Random().Next(10, 100);
Console.WriteLine(number);
int number1 = number / 10;
int number2 = number % 10;
int max = number1;
if(number2 > number1)
{
    max = number2;
}
    Console.WriteLine(max);


//мой вар ниже без max

if (number1  > number2)
{
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine(number2);
}
*/

/*
11. Напишите программу, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
/*
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int number1 = number / 100;
int number2 = number % 10;
Console.WriteLine(number1 * 10 + number2);

// а если сложить первое и третье то 
Console.WriteLine(number1 + number2);
*/

/*
12.Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/
/*
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok = number1 % number2;

if(ostatok == 0)
// или if(number1 % number2 ==0) и в выводе также 
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine(("некратно" + ostatok));
}
*/

/*
14.
14. Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 7 ==0 && number % 23 == 0)
{
        Console.WriteLine("да");
}
else
{
        Console.WriteLine("нет");
}
*/


/*
16.Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
/*
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
    //int kv = Math.Pow (number1, 2)
    // сначала число которое возводим а потом на сколько возводми

    if (Math.Pow(number1, 2) == number2 || Math.Pow(number2, 2) == number1)
{Console.WriteLine("yes");}
else{Console.WriteLine(("no"));}
*/

/*
Задача 4: Напишите программу, которая на вход принимает 
натуральное число N, а на выходе показывает его цифры через запятую.
*/
/*
Console.WriteLine("Введите натур число: N ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine("N");
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}
*/

/*
Задача 2: Напишите программу, которая принимает на вход координаты 
точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти 
плоскости, в которой находится эта точка.

Console.Write("Введите координаты точки X и Y через пробел:");
string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
Console.WriteLine("1");
else if (x < 0 && y > 0)
Console.WriteLine("2");
else if (x < 0 && y < 0)
Console.WriteLine("3");
else if (x > 0 && y < 0)
Console.WriteLine("4");
else
Console.WriteLine("Точка находится на оси координат");
*/

// семинар 3

/*
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да
*/
/*
int[] array = { 1, 3, 4, 19, 3 };
Console.WriteLine("Введите числа для нахождения массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int v = 0;

//foreach (int e in array)
//{if(e == x){v = x;}}

for (int i = 0; i < array.Length; i++)
{ if (array[i] ==x){v = x;}}
if(v == x)
{Console.WriteLine("да");}
else
{Console.WriteLine("нет");}
*/


/*
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]
*/
/*
int[] arr = new int[10];
for (int i = 0; i < 10; i++)
{
    arr[i] = new Random().Next (-10, 11);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    arr[i] = arr[i] * -1;
    Console.Write($"{arr[i]} ");
}
*/

/*
Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/
/*
int[] arr = new int[7];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next (1, 10);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();

int[] arr2 = new int[3];
for (int i = 0; i < arr.Length/2; i++)
{
    arr2[i] = arr[i] * arr[arr.Length - i - 1];
    Console.Write($" {arr2[i]} ");
}
*/

/*
int r = new Random().Next (1, 11);
int[] arr = new int[r];
for (int i = 0; i < arr.Length ; i++)
{
arr[i] = new Random().Next (1, 11);
Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();

int[] arr2 = new int[r/2];
for (int i = 0; i < arr.Length/2 ; i++)
{
arr2[i] = arr[i] * arr[arr.Length-i-1];
Console.Write($" {arr2[i]} ");
}
*/

/*
Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7]
*/
/*
int n = new Random().Next (100,1000);
Console.Write(n);
int[] arr3 = new int[3];
for (int i = 0; i < arr3.Length ; i++)
{
arr3[i] = n % 10;
Console.Write($" {arr3[i]} ");
n = n/10;
}
*/
/*
Задайте одномерный массив из 10 целых чисел от 1 до 100.
 Найдите количество элементов массива, значения которых 
 лежат в отрезке [10,90].
int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; 
// Создание массива
*/

// АВТОТЕСТ
/*
int[] arr = new int[10];
int count = 0;

for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (1, 101);
    Console.Write($"{arr[i]} ");
    if (arr[i] >= 10 && arr[i] <= 90)
        {count = count + 1;}
}
System.Console.WriteLine();
System.Console.WriteLine(count);
*/
/*
Задайте массив на 10 целых чисел. Напишите программу, которая определяет 
количество чётных чисел в массиве.

int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива

int[] arr = new int[10];
int count = 0;
for (int i = 2; i < arr.Length; i = +2)

{
Console.Write("{i} ");
}
*/
/*
int[] arr = new int[10];
int x = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next (0, 11);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();
for (int i = 1; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0)
    i = i++;
}
Console.WriteLine($" {arr[x]} ");
Console.WriteLine(arr[x]);
*/

/*Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.
*/
/*
Console.Write("Введите массив: ");
int n = Convert.ToInt32(Console.ReadLine());
double max=0;
double a;
double[] array= new double [n];
for (int i=0; i<array.Length;i++)
array [i]=new Random().NextDouble() *100;
double min = array[0];
for (int i=0; i<array.Length;i++)
{
if (max<array[i])
max=array[i];
}
Console.Write(max);
for (int i=0; i<array.Length;i++)
{
if (min>array[i])
min=array[i];
}
a=max-min;
Console.Write("  и  "+min);
Console.WriteLine("\n");
Console.WriteLine("разница: ");
Console.WriteLine(a);
*/

//сем4

