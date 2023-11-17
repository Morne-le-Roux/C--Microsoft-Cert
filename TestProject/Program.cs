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
            discountPercentage = 20;
            Console.WriteLine($"Your subscription within a day!. \nRenew now and save {discountPercentage}%!");
        }
    }
    else
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription will end in {daysUntilExpiration} days. \nRenew now and save {discountPercentage}%!");
    }
}
else
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

