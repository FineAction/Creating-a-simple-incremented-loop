for (int value = 1; value < 25; value++)
{
    Console.WriteLine($"{value}{(IsEven(value) ? "even" : "odd")}");
}
 bool IsEven(int value)
{
    var IsEven = false;
    if (value % 2 == 0)
    {
        IsEven = true;
    }
    else
    {
        IsEven = false;
    }
    return IsEven;
}

//Console.WriteLine($"{value}: {IsEven(value)}");