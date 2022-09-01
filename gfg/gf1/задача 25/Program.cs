// Напишите цикл, 
//который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Введите число  ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число  ");
double b = double.Parse(Console.ReadLine());
double i = 1;
double sum = 0;
while (i<=b) {
   sum = Math.Pow(a,i);
    i++;
   
}
Console.WriteLine (a+","+b+"=>"+ sum);
