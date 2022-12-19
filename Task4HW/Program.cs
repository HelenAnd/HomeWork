// // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите переменную a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите переменную b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите переменную c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if ( a > b ) 
    max = a; 

if ( c > max )
    max = c;

Console.WriteLine(" max = " + max);
