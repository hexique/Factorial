while (true)
{
    long counter = 1;
    long result = 1;
    Console.WriteLine("Введите число:");
    long number = long.Parse(Console.ReadLine());
    while (counter != number)
    {
        counter += 1;
        result *= counter;
        if (counter == number)
        {
            Console.WriteLine($"Результат: {result}");
            break;
        }
    }
}