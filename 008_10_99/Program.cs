int number = new Random().Next(10, 99);
char[]numbers = number.TocharArray();
if(numbers[0] > numbers[1])
{
    Console.Write(numbers[0]);
}
else if(numbers[0] <= numbers[1])
{
    Console.Write(number[1]);
}