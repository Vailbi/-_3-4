/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */
 

/* int number = Convert.ToInt32(Console.ReadLine());

int count = 0;


while (number!=0)
{
    number = number/10;
    count++;
    
    
}

Console.WriteLine(count);


 */



//Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
/* int num = new Random().Next(10,100);
int firstnum = num/10;
int secondnum = num%10;
Console.WriteLine(num);
if (firstnum>secondnum)
{
    Console.WriteLine(firstnum);
}
else
{
    Console.WriteLine(secondnum);
}
 */

/*  Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125 */


/* System.Console.WriteLine("Введите число");                         //дз
int N = Convert.ToInt32(Console.ReadLine());
double num = 1;
double result = 0;
while (num<=N)
{
    result= Math.Pow(num,3);
    num++;
    Console.WriteLine(result);
} */



/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.WriteLine("Введите x1");
double x1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
double y1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
double z1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2");
double x2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
double y2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
double z2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(square((x1-x2))+square((y1-y2))+square((z1-z2))));

double square (double a)
{
    a = Math.Pow(a,2);
    return a;
} */


/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
 */

/* Console.WriteLine("Введите число");
string number1 = Console.ReadLine();


if (number1[0]==number1[4] && number1[1]==number1[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 */