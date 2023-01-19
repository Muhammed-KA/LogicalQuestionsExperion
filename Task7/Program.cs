Console.WriteLine("Enter the passenger details");

Console.Write("Name:");

string? fName = Console.ReadLine();

Console.WriteLine("Enter the miles traveled");

int milesTraveled = Convert.ToInt32(Console.ReadLine());

int freqFlightPoints;

if (milesTraveled > 10000 && milesTraveled < 20000)
{
    freqFlightPoints = 10;
}
else if (milesTraveled > 20000 && milesTraveled < 50000)
{
    freqFlightPoints = 20;
}
else if (milesTraveled > 50000 && milesTraveled < 100000)
{
    freqFlightPoints = 30;
}
else if(milesTraveled > 100000)
{
    freqFlightPoints = 50;
}
else
{
    freqFlightPoints = 0;
}

Console.WriteLine($"\n{fName}");
Console.WriteLine("miles traveled: {0} ", milesTraveled);
Console.WriteLine("flight points: {0}", freqFlightPoints);