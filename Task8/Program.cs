using System.Transactions;

Console.WriteLine("Display  nth Passenger details.");

Console.Write("\n Enter the number of passengers:-");

int val = Convert.ToInt32(Console.ReadLine());

double[] myArray = new double[val];

string?[] myStringArray = new string[val];

int position;

Console.WriteLine("\n Enter the destinations");

for (int i = 0; i < val; i++)
{
    Console.Write($"Destination{i + 1}:-");
    myStringArray[i] = Console.ReadLine();
}

Console.WriteLine("\n Enter the fares");

for (int i = 0; i < val; i++)
{
    Console.Write($"Fare{i + 1}:-");
    myArray[i] = Convert.ToDouble(Console.ReadLine());
}


Console.Write("\n Enter the position which you want to search:-");

position = Convert.ToInt32(Console.ReadLine());

if ((position > myArray.Length) || (position > myStringArray.Length))
{

    Console.WriteLine("There is no element in that position");
}
else
{
    Console.WriteLine($"Destination: {myStringArray[position - 1]}");
    Console.WriteLine($"Fare = {myArray[position - 1]}");
}
