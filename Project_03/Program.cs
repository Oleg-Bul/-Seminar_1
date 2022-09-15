Console.WriteLine("Мы попали в игру угадай число");
int secret_number = new Random().Next(1,11);
int attempt = 5;
bool Win = false;
while (attempt > 0)
{
    Console.WriteLine("Введите число от 1 до 10");
    int user_number = int.Parse(Console.ReadLine());
    Console.WriteLine(user_number);
    if(user_number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if(user_number < secret_number)
    {
        Console.WriteLine("Секретное число больше");
        attempt--;
    }
    else if(user_number == secret_number)// = присвоить == сравнить
    {
        Console.WriteLine("Вы угадали");
        Win = true;
        break;
    }
    Console.WriteLine("Попробуй еще раз попыток осталось  " + attempt);
}
if(Win)
{
    Console.WriteLine("Вы победили, увидимся еще");
    Console.WriteLine("Осталось попыток  " + (attempt-1));
}else
{
   Console.WriteLine("Вы проиграли, секретное число было  " + secret_number);
   Console.WriteLine("Попробуй еще");
}