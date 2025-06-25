using System;

//<summary>

//<summary>
class ConditionalStatements

{
    static void Main()
    {
        if (true)
        {
            Console.WriteLine("Mounica age is 25 now");
        }
        if (10>5)
        {
            Console.WriteLine("10 is greater than 5");
        }


        int age = 25;
        Console.WriteLine(age == 25);
        Console.WriteLine(age > 25);
        Console.WriteLine(age < 25);
        Console.WriteLine(age <= 25);
        Console.WriteLine(age >= 25);
        Console.WriteLine(age != 25);


        int Age = 80;
        if (Age > 40)
        {
            Console.WriteLine("80 is greater than 40");

        }
        if((Age > 49) && (Age > 60))
        {
            Console.WriteLine("age is here greater than 49 and 60");

        }

        if((Age > 5) || (Age > 60))
        {
            Console.WriteLine("Here age is greater than 5 and 60");
        }


        string employeeName = "Kushal";
        if(employeeName == "Kushal") 
        {
            Console.WriteLine("Kushla is working");
            Console.WriteLine("Kushla is from UK");
            Console.WriteLine("Kushla is very smart Kid");
            Console.WriteLine("Kushla age is 2 years ols now");

        }

        string employeName = "Medhansh";
        if (employeName == "Kushal")
        {
            Console.WriteLine("Kushla is working");
            Console.WriteLine("Kushla is from UK");
            Console.WriteLine("Kushla is very smart Kid");
            Console.WriteLine("Kushla age is 2 years ols now");

        }
        else
        {
            Console.WriteLine("He is not Kushal");
        }


        string Name = "Medhansh";
        if (Name == "Kushal")
        {
            Console.WriteLine("Kushal is working");
            Console.WriteLine("Kushal is from UK");
            Console.WriteLine("Kushal is very smart Kid");
            Console.WriteLine("Kushal age is 2 years ols now");

        }

        else if (Name == "Ram")
        {
            Console.WriteLine("Ram is working");
            Console.WriteLine("Ram is from UK");
            Console.WriteLine("Ram is very smart Kid");
            Console.WriteLine("Ram age is 2 years ols now");
        }

        else if(Name == "Nandan")
        {
            Console.WriteLine("NAndan is working");
            Console.WriteLine("Nandan is from UK");
            Console.WriteLine("Nandan is very smart Kid");
            Console.WriteLine("Nandan age is 2 years ols now");
        }

        else
        {
            Console.WriteLine("None of the above");
        }




        int num = 3;
        if (num > 5)
        {
            Console.WriteLine("Number 3 is greater than 5");

        }
        else if(num == 5)
        {
            Console.WriteLine("Number is equal to 5");
        }

        else
        {
            Console.WriteLine("Please try again later your input is wrong");
        }


        string bankName = "HDFC";
        int amount = 100000;
        if (bankName == "HDFC" && amount == 100000)
        {
            Console.WriteLine($"you are having {amount}Rs in {bankName}");
            string.Format($"you are having{0}rs in {1}", bankName, amount);
        }

        else
        {
            Console.WriteLine("Something is Wrong");
        }


        Console.WriteLine("-------------------------Switch case--------------------------------------");

        int day = 5;
        string dayName;
        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;

            case 2:
                dayName = "Tuesday";
                break;

            case 3:
                dayName = "Wednesday";
                break;

            case 4:
                dayName = "Thursday";
                break;

            case 5:
                dayName = "Friday";
                break;

            case 6:
                dayName = "Saturday";
                break;

            case 7:
                dayName = "Sunday";
                break;

            default:
            dayName= "Unknown";
                break;




        }
        Console.WriteLine(dayName);


        string role = "Software";
        string salary;

        switch (role)
        {
            case "Software":
                salary= "25k";
                break;

            case "Govt":
            salary= "35k";
                break;

            case "hardware":
                salary= "18k";
                break;

            default:
                salary = "unknown";
                break;

               
        }
        Console.WriteLine(salary);





        string roles = "Software";
        string location = "India";
        string salaries;

        switch (roles)
        {
            case "Fresher":
                if(location == "India")
                {
                    salaries = "25k";
                }
                else if(location == "UK")
                {
                    salaries = "$25000";
                }
                else
                {
                    salaries = "location is not available";
                }
                    break;

            case "Govt":
                salaries = "35k";
                break;

            case "hardware":
                salaries = "18k";
                break;

            default:
                salaries = "unknown";
                break;


        }
        Console.WriteLine(salaries);


        Console.WriteLine("--------------------------------------------------------------");

        string employeerole = Console.ReadLine();
        string employeelocation = "Pune";

        switch (employeerole)
        {
            case "fresher":
                if(employeelocation == "banglore")
                {
                    Console.WriteLine("Employee is fresher and working in banglore");

                }
                else if(employeelocation == "Pune")
                {
                    Console.WriteLine("Employee is fresher and working in pune");
                }
                else
                {
                    Console.WriteLine("No Location");
                }
                break;

            case "Software":
                if(employeelocation == "banglore")
                {
                    Console.WriteLine("Software Employee works in banglore");
                }

                else if(employeelocation == "Pune")
                {
                    Console.WriteLine("Software Employee works in Pune");
                }
                else
                {
                    Console.WriteLine("Unknown location");
                }
                break;

        }



        int num1 = 22;
        //string result = num1 > 5 ? "Greater than 5" : "Not greater than 5";
        string results = num1 < 5 ? "Greater than 5" : "Not greater than 5";
        
        Console.WriteLine(results);


        
    }
}

