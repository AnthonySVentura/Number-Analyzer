
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine(" Hello " + name + " what is a number between 1 and 100 ");
    int num = int.Parse(Console.ReadLine());
    

    if (num % 2 == 1 && num < 60)
    {
        Console.WriteLine(num + " is odd and less than 60.");
    }
    else if (num % 2 == 0 && num >= 2 && num <= 24)
    {
        Console.WriteLine(num + " is even and less than 25");
    }
    else if (num % 2 == 0 && num >= 26 && num <= 60)
    {
        Console.WriteLine(num + " is even and between 26 and 60 inclusive");
    }
    else if (num % 2 == 0 && num > 60)
    {
        Console.WriteLine(num + " is even and greater than 60");
    }
    else if (num % 2 == 1 && num > 60)
    {
        Console.WriteLine(num + " is odd and greater than 60");
    }