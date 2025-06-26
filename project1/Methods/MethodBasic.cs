using System;


class MethodBasic
    {
    //static method
    //method is a block which we are going to re-use that.
    //this is main entry
    static void Main()
    {
        Method1();    //method1 calling in main method
        Method2();
    }

    static void Method1()   //void type
    {
         
        Console.WriteLine("The Earth is a planet");  //definition
    }

    static void Method2()
    {
        Console.WriteLine("The seasons are Winter, Summer, Rainy");
    }



    
    }

