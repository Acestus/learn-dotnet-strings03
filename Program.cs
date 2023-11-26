/*
Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be b
between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
*/

using System;

Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
var input = Console.ReadLine();
if (String.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Invalid Time");
    return;
}
if (input.Length != 5)
{
    Console.WriteLine("Invalid Time");
    return;
}
if(input[2] != ':')
{
    Console.WriteLine("Invalid Time");
    return;
}
if(input[0] < '0' || input[0] > '2')
{
    Console.WriteLine("Invalid Time");
    return;
}
if(input[1] < '0' || input[1] > '9')
{
    Console.WriteLine("Invalid Time");
    return;
}
if(input[3] < '0' || input[3] > '5')
{
    Console.WriteLine("Invalid Time");
    return;
}
if(input[4] < '0' || input[4] > '9')
{
    Console.WriteLine("Invalid Time");
    return;
}
Console.WriteLine("Ok");

