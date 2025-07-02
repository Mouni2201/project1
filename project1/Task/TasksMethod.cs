using System;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Reflection;
class TasksMethod
{

    static void Main()
    {
        string data = Method1(10);
        Console.WriteLine(data);

        getGradesForKid(66);
        getGradesForKid(99);

        switchcase('C');

        Location("goa", 6000, 4);
        Location("Chennai", 5000, 4);
        Location("chennai", 67900, 7);

    }
    //Prepare the Method with params with return types.
    static string Method1(int age)  //non void returntype
    {
        string employeeName = "Kushal";

        string Details = string.Format("EmployeeName: {0}, {1}", employeeName, age);
        return Details;
    }

    //Prepare the Methods with conditions (if elseif else)
    static void getGradesForKid(int grade)
    {
        if (grade >= 80 && grade <= 100)
        {
            Console.WriteLine("GradeA");
        }
        else if (grade >= 50 && grade <= 75)
        {
            Console.WriteLine("GradeB");
        }
        else if (grade >= 35 && grade < 50)
        {
            Console.WriteLine("gradeC");

        }

        else if (grade <= 35)
        {
            Console.WriteLine("fail");
        }

        else
        {
            Console.WriteLine("No data Available");
        }
    }
    //Prepare the methods with Conditions (switch case)

    static void switchcase(char grades)
    {

        switch (grades)
        {
            case 'A':
                Console.WriteLine("Execllent");
                break;


            case 'B':
                Console.WriteLine("Good");
                break;
            case 'C':
                Console.WriteLine("Average");
                break;

            case 'D':
                Console.WriteLine("poor or just Passed");
                break;

            case 'F':
                Console.WriteLine("Fail");
                break;

            default:
                Console.WriteLine("Invaild");
                break;


        }

    }


    //Prepare the Methods with if else if else and Switch case conditions.


    static void Location(string nameLocation, int cost, int days)
    {
        if(cost <=5000 && days == 4)
        {
            string details = string.Format("The cost{0} of location and days{1} are too medium", cost, days);
            Console.WriteLine(details);
        }
        else if(nameLocation =="goa"  && days == 4)
        {
            Console.WriteLine("the goa clocation is beautiful");
        }
        else
        {
            Console.WriteLine("Invalid Information");
        }

        switch (nameLocation)
        {
            case "AaraKu":
                Console.WriteLine("The Location is good");
                break;

            case "Ooty":
                Console.WriteLine("It is Located in chennai");
                break;

            case "goa":
                Console.WriteLine("the Goa location wather is beautiful");
                break;
            default:
                Console.WriteLine("The info is not correct");
                break;
        }
    }

}




