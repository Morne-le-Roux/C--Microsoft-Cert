Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration == 1)
        {
            Console.WriteLine($"Your subscription within a day!. /n Renew now and save 20%!");
        }
    }
    else
    {
        Console.WriteLine($"Your subscription will end in {daysUntilExpiration} days. /n Renew now and save 10%!");
    }
}
else
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

