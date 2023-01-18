Console.WriteLine("Store either in odd or even position in  an array");
Console.WriteLine("Enter The Limit");
int limit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Numbers");
double[] myArray = new double[limit]; for (int i = 2; i < limit; i = i + 2)
{
    myArray[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 2; i < myArray.Length; i = i + 2)
{
    Console.WriteLine($"{myArray[i]} in position {i}");
}