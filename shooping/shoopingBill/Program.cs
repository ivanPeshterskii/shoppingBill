string product = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

double price = default; 

static double milk(double count, double price)
{
    price = count * 2.00;
    return price;
}

static double eggs(double count, double price)
{
    return price = count * 0.50; 
}

static double flour(double count, double price)
{
    return price = count * 1.70;
}

static double sugar(double count, double price)
{
    return price = count * 2.10;
}

if (product == "milk")
{
    double result = milk(count,price);
    Console.WriteLine($"{result:f2}");
}

else if (product == "eggs")
{
    double result = eggs(count, price);
    Console.WriteLine($"{result:f2}");
}

else if (product == "flour")
{
    double result = flour(count, price);
    Console.WriteLine($"{result:f2}");
}

else if (product == "sugar")
{
    double result = sugar(count, price);
    Console.WriteLine($"{result:f2}");
}