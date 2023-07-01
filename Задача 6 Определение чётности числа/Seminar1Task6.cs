//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine ("данная программа определяет, является ли число чётным");
Console.WriteLine ("после ввода числа нажимайте enter");
Console.WriteLine ("для ввода нового числа нажмите enter");
Console.WriteLine ("для выхода из программы нажмите клавишу E на английской раскладке");
do
{Console.WriteLine("введите число");
string? N1=Console.ReadLine();
int chislo1 = Convert.ToInt32(N1);
if ( chislo1 % 2 == 0)
{
 Console.WriteLine("число чётное" );
} 
else
{
 Console.WriteLine("число нечётное" );
}
}
while  (Console.ReadKey().Key !=ConsoleKey.E);