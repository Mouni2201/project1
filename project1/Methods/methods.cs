using System;

  class methods
    {
    static void Main()
    {
        xyz(); //here iam calling xyz only in that xyz the two methods are calling andf two are printed.

    }
    static void Method1()   //void type
    {

        Console.WriteLine("The Earth is a planet");  //definition
    }

    static void Method2()
    {
        Console.WriteLine("The seasons are Winter, Summer, Rainy");
    }

    static void xyz()
    {

        Method1();
        Method2();
    }

    static void abc()
    {
        Method1();
    }

    static void callMethod()
    {
        Method2();
    }
}

