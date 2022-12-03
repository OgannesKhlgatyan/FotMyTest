bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if(isParsed == false)
    {
        Console.WriteLine("Пиши числа!");
    }
}