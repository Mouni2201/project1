using System;



internal class Basic
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("This is my first c# code");
        Console.WriteLine("--------------------------------------------------------");
        getStudentDetails();
        getPlayerDetails();
    }

    static void getStudentDetails()
    {
        Console.WriteLine("Please enter Student Name:");
        String Name = Console.ReadLine();
        Console.WriteLine("Student Name is:" + Name);

        Console.WriteLine("Please enter Group of Student:");
        String Group = Console.ReadLine();
        Console.WriteLine($"Student Group is: {Group}");

        Console.WriteLine("--------------------------------------------------------");
    }

    static void getPlayerDetails()
    {
        Console.WriteLine("Enter first Name:");
        String FirstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name");
        String LastName = Console.ReadLine();
        Console.WriteLine("Player Name is:" + FirstName + " " + LastName);

    }


}
