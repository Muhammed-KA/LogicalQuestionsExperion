using System;
using System.Globalization;

public class Exercise1
{
    public static void Main()
    {
        string[] arr = new string[10];
        int i;
        string search;
        Console.Write("\n\nRead and Print Passengers List :\n");
        Console.Write("-----------------------------------------\n");

        Console.Write("Input 10 Passenger's  name :\n");

        for (i = 0; i < 10; i++)
        {
            Console.Write("Passenger - " + (i+1) + ":-");
            arr[i] = Console.ReadLine();
        }

        Console.Write("\n Passenger List: ");

        for (i = 0; i < 10; i++)
        {
            Console.Write("{0}  ", arr[i]);
        }

        Console.Write("\n \n ");

        Console.Write("Passengers List In Alphabetic Order:- \n \n ");

        Array.Sort(arr);

        for (i = 0; i < 10; i++)
        {
            Console.Write("{0}  ", arr[i]);
        }

        Console.Write("\n \n \n ");

        Console.Write("Passengers List In Reverse Alphabetic Order:- \n \n");

        Array.Reverse(arr);

        for (i = 0; i < 10; i++)
        {
            Console.Write("{0}  ", arr[i]);
        }
        Console.Write("\n \n");
        Array.Sort(arr);

        Console.WriteLine("Enter a Passenger name for search:- ");
        search = Console.ReadLine();
        var result = Array.Find(arr, element => element == search);
        if (result != null)
        {
            Console.WriteLine("Search Found:-");
            Console.Write(result, "\n");
        }
        else
        {
            Console.WriteLine("Search not found");
        }
        Console.WriteLine("\n Length of each elements:- \n");
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(arr[i].Length);
        }

        for (i = 0; i < arr.Length; i++)
        {
            var SplitElement = arr[i].Split(' ');
            Array.ForEach(SplitElement, Console.WriteLine);
        }

        Console.WriteLine("Duplicate names in Passenger:-");
        //Searches for duplicate element  
        for ( i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    Console.WriteLine(arr[j]);
            }
        }
    }
}
