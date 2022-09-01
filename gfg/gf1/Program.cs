// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

int sum = 0;

int b = a;
while(a>10){
    b = a%10;     
    sum = sum + b;
    a=a/10;
}  
   
 sum = sum+a;


Console.WriteLine("Cумма всех введенных чисел"+"=>"+ sum);