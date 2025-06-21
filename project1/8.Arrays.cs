using System;

class Arrays


{
    static void Main()
    {
        //creating set of integer values is int array with fixed size
        int[] number = new int[2];
        number[0] = 1;
        number[1] = 22;
        //number[2] = 21;  //exception error
        Console.WriteLine(number);  //system int32
        Console.WriteLine(number[0]);
        Console.WriteLine(number[1]);
        Console.WriteLine($"0th inderx of the number  {number[0]}");
        Console.WriteLine($"1st index of the number {number[1]}");

        string[] place = new string[4];
        place[0] = "OOTY";
        place[1] = "Hyd";
        place[3] = "Banglore";
        Console.WriteLine(place[0]);
        Console.WriteLine(place[1]);
        Console.WriteLine(place[3]);

        //creating set of integer values is int array without fixed size

        int[] numberContainer = new int[] { 20, 50, 100, 200 };
        Console.WriteLine($"0th index of the number {numberContainer[0]}");
        Console.WriteLine($"1st index of the number {numberContainer[1]}");
        Console.WriteLine($"2nd index of the number {numberContainer[2]}");

        int value = numberContainer[3];
        Console.WriteLine(value);


        string data = "apple, banana, cherry";
        string[] fruitslist = data.Split(',');
        Console.WriteLine(fruitslist);  //system.string[]
        //foreach pick each and every value and can't use for single values
        foreach (string fruit in fruitslist)
        {
            Console.WriteLine(fruit);
        }


        int[] currencyNotes = { 20, 50, 100, 500 };
        foreach(int currency in currencyNotes)
        {
            Console.WriteLine(currency);
        }

        //foreach (int currency in currencyNotes)
        //{
        //    int addcoin = 5;
        //    int updatedcurrency = currencyNotes + addcoin;
        //    Console.WriteLine(updatedcurrency);
        //}




    }
}

