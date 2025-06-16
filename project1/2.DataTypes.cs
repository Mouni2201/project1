using System;
using System.CodeDom;



class Datatypes

    {
    static void Main()
    {
        Console.WriteLine("*************DataTYPES***************");


        //numeric Data types: byte, short, ushort, int, uint, long, ulong, float, decimal, double

        //byte : Represents unsigned integers ranging from 0 to 255

        byte numberOfMatches = 35;
        Console.WriteLine("NumberOfMatches:" + numberOfMatches);


        //short : Represents stores smal signed integer from -32,768 to 32767

        short Shops = 500;
        Console.WriteLine("No.of Shops Own:" + Shops);
        short Temperature = -1500;
        Console.WriteLine("Short Value:" + Temperature);



        //ushort: Stores small positive integer Range from 0 to 65,535

        ushort PopulationinVillage = 58000;
        Console.WriteLine("Population in Village:" +  PopulationinVillage);

        //int: Default datatype for integer ranging from -2,147,483,648 to 2,147,483,647
        int AreaLength = 214748364;
        Console.WriteLine("Area of Length:" + AreaLength);

        //Unit: Stores Positive whole numbers only ranging from 0 to 4,294,967,295

        uint distance = 300000000u;
        Console.WriteLine("uint Value:" + distance);


        //long: used for very large or small integer range from -9,223,372,036,845,775,808 to -9,223,372,036,845,775,807

        long worldPopulation = 800000000000000000L;
        Console.WriteLine("Long value Population in world:" + worldPopulation);

        //ulong: large positive number range from 0 to 18,446,744,073,709,551,615

        ulong bankbalance = 10000000000000000L;
        Console.WriteLine("bankbalance:" + bankbalance);


        /*floating Datatypes(fractional values allowed
        decimal :+- 79,228,168,514,264,337,593,543,950,335
        float: +- 3.40282347E+38F
        double: +- 1.7976931348623157E+308*/

        decimal Price = 199.99m;  //m is decimal value
        Console.WriteLine("Price:" + Price);

        float pi = 3.14159999f;   //f is float value
        Console.WriteLine("Pi vlaue:" + pi);

        double stockPrice = 987.65d;  //d is decimal
        Console.WriteLine("StockPrice:" + stockPrice);











    }

}


