using System;

class DatatypeMinandMax
{
    static void Main()
    {
        //display the max and min values of numeric datatypes
        //byte.MinValue;
        Console.WriteLine("byte MinValue" + byte.MinValue);
        Console.WriteLine("byte MaxValue" + byte.MaxValue);

        //string interpolation ${}

        Console.WriteLine($"byte min value {byte.MinValue} and Max value {byte.MaxValue}");
        Console.WriteLine($"short min value {short.MinValue} and Max value {short.MaxValue}");
        Console.WriteLine($"ushort min value {ushort.MinValue} and Max value {ushort.MaxValue}");
        Console.WriteLine($"int min value {int.MinValue} and Max value {int.MaxValue}");
        Console.WriteLine($"uint min value {uint.MinValue} and Max value {uint.MaxValue}");
        Console.WriteLine($"long min value {long.MinValue} and Max value {long.MaxValue}");
        Console.WriteLine($"ulong min value {ulong.MinValue} and Max value {ulong.MaxValue}");
        Console.WriteLine($"decimal min value {decimal.MinValue} and Max value {decimal.MaxValue}");
        Console.WriteLine($"float min value {float.MinValue} and Max value {float.MaxValue}");
        Console.WriteLine($"double min value {double.MinValue} and Max value {double.MaxValue}");

        //boolean  datatype
        //used for to store true or false values
        Console.WriteLine("*********************Boolean datatypes************************");

        bool boolValue1 = true;
        bool boolValue2 = false;

        Console.WriteLine(boolValue1);
        Console.WriteLine(boolValue2);

        Console.WriteLine("*********************Character datatypes************************");
        char character = 'A';  //we use single quotes for single character
        Console.WriteLine(character);

        char anotherCharValue = ' ';
        Console.WriteLine(anotherCharValue);


        Console.WriteLine("********************String datatypes************************");

        string value = "Hello World";
        Console.WriteLine(value);








    }
}

