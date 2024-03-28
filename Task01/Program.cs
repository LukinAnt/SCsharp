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
