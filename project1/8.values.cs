using System;
class values

{
    static void Main()
    {
        //value type (convert to)  -> refernce type (boxing)
        //reference type(convert to) -> value type (unboxing)

        //boxing is the process of converting a value to refernce type (object)

        //unboxing is the process of converting a refernce to value type 


        //int a = 10;  //directly constain data
        //string b = "Hello";  // b holds a refernce to string hello in memory

        //boxing
        int num1 = 42;
        object obj = num1;  //boxing : here object created the refernce for storing the num1 data.
        Console.WriteLine($"object value is {obj}");


        //unboxing
        int num2 = (int)obj;
        Console.WriteLine(num2);







    }
}

