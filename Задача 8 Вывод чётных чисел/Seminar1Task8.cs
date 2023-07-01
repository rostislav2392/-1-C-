//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine ("данная программа показывает все чётные числа от 1 до вводимого числа");
Console.WriteLine ("после ввода числа нажимайте enter");
Console.WriteLine ("если после получения результатов вы хотите остаться в программе, нажмите enter ");
Console.WriteLine ("для выхода из программы нажмите клавишу E на английской раскладке");
do
{Console.WriteLine("введите число");
string? N1=Console.ReadLine();
int chislo1 = Convert.ToInt32(N1);
int I=1; 

while (I <= chislo1)
{
    if (I%2==0)
    {
    Console.WriteLine(I);
    }
    I++;
}
 
}
while  (Console.ReadKey().Key !=ConsoleKey.E);