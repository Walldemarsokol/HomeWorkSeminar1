Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if(max < number2)
{
    max = number2;
}
else
{
    max = number1;
}

if(max > number3)
{
    Console.WriteLine($"Максимальное число из трех будет {max}");
}
else
{
    Console.WriteLine($"Максимальное число из трех будет {number3}");
}