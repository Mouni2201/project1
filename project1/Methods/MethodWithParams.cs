using System;


class MethodWithParams
{
    static void Main()
    {
        //Method1(2);  for void calling
        
        Method2();
        Method3(11727414);
        Method3("empID223");
        Method3(false);
        
    }

    static void Method2()
    {
        Console.WriteLine($"Medhash is brother of Kushal");
    }

    static void Method3(dynamic empID)
    {
        Console.WriteLine($"DynamicId is {empID}");
    }

    
    }

