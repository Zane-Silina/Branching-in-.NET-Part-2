// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter the day number.");
int daynumber = int.Parse(Console.ReadLine());

switch(daynumber){
    case <= 0:
        Console.WriteLine("Invalid input - can't be less than zero.");
        break;
    case (<= 31):
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: January");
        break;
    case <= 59:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: February");
        break;
    case <= 90:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: March");
        break;
    case <= 120:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: April");
        break ;
    case <= 151:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: May");
        break;
    case <= 181:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: June");
        break;
    case <= 212:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: July");
        break;
    case <= 243:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: August");
        break;
    case <= 273:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: September");
        break;
    case <= 304:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: October");
        break;
    case <= 334:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: November");
        break;
    case <= 365:
        Console.WriteLine($"The day number is: {daynumber}");
        Console.WriteLine("It is: December");
        break;
    case > 365:
        Console.WriteLine("Invalid input - can't be more than 365.");
        break;
        }



