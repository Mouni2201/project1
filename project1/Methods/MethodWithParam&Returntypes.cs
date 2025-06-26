using System;
using System.Globalization;
using System.Web;


class MethodWithParam_Returntypes
    {
    
    static void Main()
    {
        string data = Method1(2);
        Console.WriteLine(data);

        int sum = Add(11, 33);
        Console.WriteLine(sum);

        string employeeDetails = getEmployeeDetails(10);
        Console.WriteLine(employeeDetails);

        int agebyName = getAgebyName("Mounica");
        Console.WriteLine(agebyName);
    }

    static string Method1(int age)  //non void returntype
    {
        string employeeName = "Kushal";

        string Details = string.Format("EmployeeName: {0}, {1}", employeeName, age);
        return Details;
    }

    static int Add(int x, int y)
    {
        return x + y;
    }


    static string getEmployeeDetails(int id)
    {
        string employeeDetails = ($"employee name is John and his Id is {id}");
        return employeeDetails;
    }

    static int getAgebyName(string Name)
    {
        Console.WriteLine($"My name is  {Name}");
        int employeeId = 11727424;
        return employeeId;
    }

}

