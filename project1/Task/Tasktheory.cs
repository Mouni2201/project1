using System;
using System.Data.SqlTypes;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

  class Tasktheory
    {


    static void Main()
    {

        string[] EmployeeNames = { "John", "Robert", "Chandra", "Peter" };
        //Diff b/w for and foreach ? Explain with example
        //for
        //You need index - based access or control flow(like i--). You know exactly how many iterations are needed.You plan to modify the collection while iterating.
        Console.WriteLine("****FOR*************");
        for (int i = 0; i < EmployeeNames.Length; i++)
        {
            Console.WriteLine(i);
        }

        //for(int employee=0; employee<EmployeeNames.Length; employee++)
        //{
        //    Console.WriteLine(employee);
        //}

        //foreach
        //You're looping over all items in a collection.You want clean, concise, and readable code.You don’t need index values.
        Console.WriteLine("****FOREACH*************");
        foreach (string name in EmployeeNames)
        {
            Console.WriteLine($"Name: {name}");
        }
        //Explain me what is the importance of the Looping system. ? Explain with Example
        //A looping system in programming lanaguage refers to the mechanism in which a set of statements are executed until a condition is met
        //1.for loop 2.foreach loop 3. While loop 4. do-while loop
        //while loop - In while loop, the condition is evaluated first. If it is true, then set of statements re executed or else loop body will no texecute atleast once

        //While
        //A while loop repeatedly executes a block of code as long as a condition is true.
        //It checks the condition before entering each iteration—so it's a pre-test loop.

        int a = 0;   // (initialize)
        int sum = 0; 
        while(a <= 10)   //condition
        {
            sum = sum + 1;   
            a++;
        }
        Console.WriteLine(sum);


        //do ..while
        //A do…while loop is an exit - controlled(post - test) loop.This means:

        //The loop body executes at least once, regardless of the condition.

        //Then the condition is evaluated; if true, the loop repeats, otherwise it stops.
        Console.WriteLine("**********Do While*****************");
        int b = 0;
        int diff = 10;
        do
        {
            diff = diff - 1;
            Console.WriteLine(diff);
            b++;
        }
        while (b <= 5);



        int c = 0;
        do
        {
            
            Console.WriteLine(c);
            c++;
        }
        while (c < 5);


        //What are the floating data types ? EXample
        //floating data types are double, decimal, float
        //Use float: when speed and memory are crucial and precision isn't.

        //Use double: for most everyday calculations.

        //Use decimal: when decimal accuracy is a must, such as in money computations.
        Console.WriteLine("*********float************");
        float f = 3.241f;
        Console.Write(f);

        Console.WriteLine("*********Double************");
        double price = 58.897d;
        Console.WriteLine("double price is:" + price);

        Console.WriteLine("*********Decimal************");
        decimal stock = 57900.9785m;
        Console.WriteLine(stock);


        //What are the Logical operators importance of that ? Explain with example
        //Use && / || for combining conditions with efficiency and clarity.

        //Use! to invert boolean expressions.


        bool result1 = true || true;
        Console.WriteLine(result1);

        bool result2 = false || false;
        Console.WriteLine(result2);

        bool result3 = (5 == 5) || (5 != 3);
        Console.WriteLine(result3);

        bool result4 = (5 == 5) || (5 == 3);
        Console.WriteLine(result4);

        bool result5 = (5 == 3) || (5 == 5);
        Console.WriteLine(result5);

        bool result6 = (5 == 3) || (5 == 4);
        Console.WriteLine(result6);

        //&&(operator)

        bool results1 = true && true;
        Console.WriteLine(results1);

        bool results2 = false && false;
        Console.WriteLine(results2);

        bool results3 = (5 == 5) && (5 != 3);
        Console.WriteLine(results3);

        bool results4 = (5 == 5) && (5 == 3);
        Console.WriteLine(results4);

        bool results5 = (5 == 3) && (5 == 5);
        Console.WriteLine(results5);

        bool results6 = (5 == 3) && (5 == 4);
        Console.WriteLine(results6);


        //!Operator


        //!true   //false
        //!false   //true


        bool opptrue = !true;
        Console.WriteLine(opptrue);

        bool oppfalse = !false;
        Console.WriteLine(oppfalse);


        //What is the nullable types ? Example
        //By default, value types(like int, bool, double) cannot be null.With nullable value types

        int? age = null;
        Console.WriteLine("Age is:", age);

        bool? value = false;
        Console.WriteLine(value.GetType());


        //What is implicit conversation type ? Example
        //In C#, implicit conversions happen automatically when converting a value from one type to another without risk of data loss or runtime failure. You don't need casting syntax — the compiler does it for you. Here's what you need to know:
        byte num = 12;
        int largenum = num;
        Console.WriteLine(largenum);

        //int small = 123;
        //long big = small;       // implicitly converts int → long
        //float fl = big;         // implicitly converts long → float


        short num1 = 67;
        long newnum1 = num1;
        Console.WriteLine(newnum1);

        





    }
}
