Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write ("Большее число, ");
    Console.WriteLine(a);
} 
else if(b>a)
{
   Console.Write ("Большее число, ");
   Console.WriteLine(b);
}  
else 
{
   Console.WriteLine("Числа равны");
} 
