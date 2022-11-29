/*#4
#numbers = [int(input("Введите первое число: ")), int(input("Введите второе число: ")), int(input("Введите тертье число: "))]   
#maxnumber = numbers[0]
#count = 0
#while count < len(numbers):
#    if numbers[count] > maxnumber:
#        maxnumber = numbers[count]
#    count += 1
#print(maxnumber)*/
int[] numbers = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
int maxnumber = numbers[0];
int count = 0;

while(count < numbers.Length)
{
    if(numbers[count] > maxnumber)
    {
        maxnumber = numbers[count];
    }
    count++;
}

Console.WriteLine(maxnumber);