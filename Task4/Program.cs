var today = DateTime.Today;
Console.WriteLine("Type in your D.O.B in DD-MM-YYYY format:");
var Bday = Console.ReadLine();
var myDate = Convert.ToDateTime(Bday);
var age = today.Year - myDate.Year;
if (myDate.Date > today.AddYears(-age)) age--;
Console.WriteLine($"You are {age} years old");
var ageHours = age * 8220;
Console.WriteLine($"You are {ageHours} Hours old");
var ageDays = age * 365;
Console.WriteLine($"You are {ageDays} days old");
var ageWeeks = age * 52.176;
Console.WriteLine($"You are {ageWeeks} Weeks old");
var ageMonths = age * 30.4;
Console.WriteLine($"You are {ageMonths} Months old");
if (DateTime.IsLeapYear(myDate.Year))
{
    Console.WriteLine("Leap Year!");
}
else
{
    Console.WriteLine("Not a Leap Year!");
}