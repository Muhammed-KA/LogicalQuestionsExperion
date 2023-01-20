//10. Accept the 10 boarding pass numbers and allocate to a counter to check-in Qs. Each Q can accommodate max 3 people. Allocate randomly if the Q has space. Max three counters are there.

int[] BoardingPassArray = new int[10];
int[] CheckInArray1 = new int[3];
int[] CheckInArray2 = new int[3];
int[] CheckInArray3 = new int[3];

Console.WriteLine("Enter Flight Boarding Number:-");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Flight Boarding Number{i + 1}:-");
    BoardingPassArray[i] = Convert.ToInt32(Console.ReadLine());
}

int j = 0;
int k = 0;
int l = 0;

for (int i = 0; i < 10; i++)
{

    if (i < 3)
    {
        if (j < 3)
        {
            CheckInArray1[j] = BoardingPassArray[i];
            j++;
        }

    }
    else if (i is >= 3 and < 6)
    {
        if (k < 3)
        {
            CheckInArray2[k] = BoardingPassArray[i];
            k++;
        }

    }
    else if (i >= 6 && i < 10)
    {
        if (l < 3)
        {
            CheckInArray3[l] = BoardingPassArray[i];
            l++;
        }


    }


}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Counter 1- {0}", CheckInArray1[i]);
    Console.WriteLine("Counter 2- {0}", CheckInArray2[i]);
    Console.WriteLine("Counter 3- {0}", CheckInArray3[i]);
}
