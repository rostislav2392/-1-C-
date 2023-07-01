//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine ("данная программа сравнивает 3 целых числа");
Console.WriteLine ("после ввода числа нажимайте enter");
Console.WriteLine ("если после получения результатов вы хотите сравнить ещё 3 числа,то нажмите enter ");
Console.WriteLine ("для выхода из программы нажмите клавишу E на английской раскладке");
do
{Console.WriteLine("введите первое число");
string? N1=Console.ReadLine();
Console.WriteLine("введите второе число");
string? N2=Console.ReadLine();
Console.WriteLine("введите третье число");
string? N3=Console.ReadLine();
int chislo1 = Convert.ToInt32(N1);
int chislo2 = Convert.ToInt32(N2);
int chislo3 = Convert.ToInt32(N3);
int max = chislo1;
if (max < chislo2) 
{
    max=chislo2;
} 
if (max<chislo3)
{
    max=chislo3;
}

Console.WriteLine($"максимальное число {max}");
}

while  (Console.ReadKey().Key !=ConsoleKey.E);