// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine ("данная программа сравнивает два целых числа");
Console.WriteLine ("после ввода числа нажимайте enter");
Console.WriteLine ("если после получения результатов вы хотите сравнить ещё два числа,то нажмите enter ");
Console.WriteLine ("для выхода из программы нажмите клавишу E на английской раскладке");
do
{Console.WriteLine("введите первое число");
string? N1=Console.ReadLine();
Console.WriteLine("введите второе число");
string? N2=Console.ReadLine();
int chislo1 = Convert.ToInt32(N1);
int chislo2 = Convert.ToInt32(N2);
if (chislo1 > chislo2)
{
 Console.WriteLine($"максимальное число {chislo1} минимальное число {chislo2}" );
} 
else
{
 Console.WriteLine($"максимальное число {chislo2} минимальное число {chislo1}" );
}
}
while  (Console.ReadKey().Key !=ConsoleKey.E);
