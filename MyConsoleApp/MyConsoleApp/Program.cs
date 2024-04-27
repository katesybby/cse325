// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}."); 
Console.WriteLine($"There are 245 days until the next Christmas.");  //Today is April 24. Any other day and this will be incorrect.
Console.WriteLine($"There are {(new DateTime(DateTime.Today.Year, 12, 25) - DateTime.Today).Days} days until the next Christmas.");   //This subtracts the date of Christmas from todays date. I compiled this code from multiple different sites. 

