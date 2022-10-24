// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16
System.Console.WriteLine("Введите любое число A");
double a = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число В");
int b = int.Parse(Console.ReadLine());
int bb = Math.Abs(b);
double result = a;
for(double i=0; i<bb-1; i++)
    {
        result = result * a;    
    }
System.Console.Write($"Число 'а' возведенное в натуральную степень 'b' равно: {result}");
