using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;


class Task
{

    static void Main()
    {
        //        Employees Data : 
        //1.  “John, Robert, Chandra, Peter”
        //2. [“John”, “Robert”, “Chandra”, Peter”]



        //Prepare the String Array 

        string[] EmployeeNames = { "John", "Robert", "Chandra", "Peter" };
        //Console.WriteLine(EmployeeNames);

        string[] EmployeeName = new string[4];
        EmployeeName[0] = "John";
        EmployeeName[1] = "Robert";
        EmployeeName[2] = "Chandra";
        EmployeeName[3] = "Peter";
        Console.WriteLine(EmployeeName[0]);
        Console.WriteLine(EmployeeName[1]);
        Console.WriteLine(EmployeeName[2]);
        Console.WriteLine(EmployeeName[3]);



        //Get the Third Employee from the Array
        Console.WriteLine("Third employee from the Array:" + EmployeeName[2]); // print chandra

        //Check weather Second and Third employee Equals or not from the Array
        //foreach(string Employee in EmployeeNames)
        // {
        if (EmployeeName[1] == EmployeeName[2])
        {
            Console.WriteLine("Both seconda nd Third employee are equal");
        }
        else
        {
            Console.WriteLine("both are not Equal");
        }
        //}


        //Check the employee whose name starts with “J” from the Array
        //foreach (string Employee in EmployeeNames)
        //{
        //    if (Employee[0] == 'J')
        //    {
        //        Console.WriteLine(Employee);
        //    }
        //}

        //another way
        foreach (string Employee in EmployeeNames)
        {
            if (Employee.StartsWith("J"))
            {
                Console.WriteLine(Employee);
            }
        }

        //Convert Employees List into single String
        //{ "John", "Robert", "Chandra", "Peter" }; to ---> John,Robert,Chandra,Peter
        Console.WriteLine("*****Convert Employees List into single String********");
        string result = string.Join(",", EmployeeNames);
        Console.WriteLine(result);


        //Replace the “Robert” with “Peter” in String
        Console.WriteLine("************Replace the “Robert” with “Peter” in String**********");

        string result1 = result.Replace("Robert", "Peter");
        Console.WriteLine(result1);

        string result2 = result1.Replace("Peter", "Robert");
        Console.WriteLine(result2);

        //Get the Employee whose name length is more that 4 charcters from the array
        Console.WriteLine("**********Get the Employee whose name length is more that 4 charcters from the array******");
        foreach(string Employee in EmployeeNames)
        {
            if (Employee.Length > 4)
            {
                Console.WriteLine(Employee);
            }
        }

        //Diff b/w for and foreach ? Explain with example
        //for
        //You need index - based access or control flow(like i--). You know exactly how many iterations are needed.You plan to modify the collection while iterating.
        Console.WriteLine("****FOR*************");
        for(int i =0; i<EmployeeNames.Length; i++)
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
            Console.WriteLine($"Name: { name}");
        }
        //Explain me what is the importance of the Looping system. ? Explain with Example
        //A looping system in programming lanaguage refers to the mechanism in which a set of statements are executed until a condition is met
        //1.for loop 2.foreach loop 3. While loop 4. do-while loop
        //while loop - In while loop, the condition is evaluated first. If it is true, then set of statements re executed or else loop body will no texecute atleast once










    }
}
