
using System;
using System.Globalization;
class Methodexamples
{
    static void Main()
    {
        string employee = getEmployeeDetails(10);
        Console.WriteLine(employee);

        int employeID = getAgeByName("Mounica");
        Console.WriteLine(employeID);

        printEmpNamebyId(10);

        printEmpDetailsbyNameandAge("Kushal", 2);

        string[] empNames = getEmployeeNames();
        Console.WriteLine(empNames);

        int length = getEmpNamesLengthByEmpNames(empNames);
        Console.WriteLine($"Employees length{length}");


        int[] Numbers = { 10, 20 };
        int details = getUpdatednumber(Numbers);
       foreach(int number in details)
        {
            Console.WriteLine(number);
        }
    }

    static string getEmployeeDetails(int id)
    {
        string employeeDetails = $"employee name is john and his id id {id}";
        return employeeDetails;
    }

    static int getAgeByName(string Name)
    {
        Console.WriteLine($"My Name is {Name}");
        int employeeId = 117;
        return employeeId;
    }


    static void printEmpNamebyId(int id)
    {
        Console.WriteLine($"Emp Name is John and is is {id}");

    }

    static void printEmpDetailsbyNameandAge(string Name, int age)
    {
        Console.WriteLine($"Name is {Name} and his id is {age}");
    }


    static string[] getEmployeeNames()
    {
    string[] names = { "Dog", "cat" };
    return names;
    }

static int getEmpNamesLengthByEmpNames(string[] names)
    {
        int length = names.Length;
        return length;
    }


    static int[] getUpdatednumber(string[] Names)
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = Numbers[i] = 2;
        }
        return Numbers;
    }
    {

    }


}

