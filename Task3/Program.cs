Console.WriteLine("Введите число:");
string number = Console.ReadLine() ??"";
int num = Convert.ToInt32(number);
if(num % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число не чётное");
}
