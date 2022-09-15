int number = 12;
Console.WriteLine("Месяцев в году " + number + number );

string n = number.ToString();

Console.WriteLine("Введите ваше имя");
string name = Console.ReadLine();// Отдает все только строкой
Console.WriteLine("Hello, " + name);
Console.WriteLine("Сколько вам лет?");
int age =int.Parse(Console.ReadLine());
Console.WriteLine("Вам" + age + "лет");
Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(a + b);

if(a > b)
{
     Console.WriteLine("Число a больше числа b");
}
else if(a < b)
{
   Console.WriteLine("Число b больше числа a"); 
}
else
{
    Console.WriteLine("Число a, равно числу b");
}

