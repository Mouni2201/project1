using System;
using System.Security.Cryptography;



class Strings

{
    static void Main()
    {
        string courseName = "Csharp";
        Console.WriteLine(courseName);  //Csharp

        //add quotes 
        string courseName1 = "\"Csharp\"";
        Console.WriteLine(courseName1);    //"Csharp

        string courseName2 = "One.Two.Three";
        Console.WriteLine(courseName2);
        //if you want the string dot one by one;
        string strings = "One.\nTwo.\nThree";
        Console.WriteLine(strings);

        string myProject = "C:\\Js-training\\C#\\project1";
        Console.WriteLine(myProject);

        string myProject1 = @"C:\Js-training\C#\project1";
        Console.WriteLine(myProject1);


        //string Interpolation

        string name = "Kushal";
        int age = 1;
        Console.WriteLine($"My name is {name} and the age is {age} year old");
        string details = $"My name is { name } and the age is { age } year old";
        Console.WriteLine(details);

        //length***************************************************
        string text = "Taj Mahal is very beautiful";
        //Console.WriteLine(text.Length);
        int Length = text.Length;  //here can't give another datatype like bool because return type is integer.
        //Console.WriteLine(Length);
        Console.WriteLine($"{text.Length}");


        //LowerCase to UpperCase**********************************
        string input = "Hello World";
        // Console.WriteLine(input.ToLower());
        string Lowercase = input.ToLower();
        Console.WriteLine(Lowercase);
        
        string Uppercase = input.ToUpper();
        Console.WriteLine(Uppercase);


        //Trim**************************
        string Id = "    Aadhar     ";
        Console.WriteLine(Id);
        Console.WriteLine(Id.Trim());

        string Id1 = "*****PanCard*****";
        Console.WriteLine(Id1.Trim('*'));
        Console.WriteLine(Id1.TrimStart('*'));
        Console.WriteLine(Id1.TrimEnd('*'));

        //padLeft and padRight *********************************

        string Id2 = "Csharp";
        Console.WriteLine(Id2.PadLeft(10));
        Console.WriteLine(Id2.PadRight(10));

        string Id3 = "JavaScript";
        string padRight_Addstaars_Id3 = Id3.PadRight(15, '*');
        Console.WriteLine(padRight_Addstaars_Id3);
        string padLeft_Addstaars_Id3 = Id3.PadLeft(15, '*');
        Console.WriteLine(padLeft_Addstaars_Id3);


        //string comparison *****************************************

        string password = "Qwert@22*";
        password.Equals("Mounica@22*");

        bool Equalsto = password.Equals("Mounica@22*");
        Console.WriteLine(Equalsto);


        string anotherPassword = "Asdfg@22*";
        anotherPassword.Equals("Asdfg@22*");
        bool Equals = anotherPassword.Equals("Asdfg@22*");

        Console.WriteLine(Equals);

        //substring*********************************************

        string sentence = "Taj Mahal is very beautiful and loacated in Delhi";
        //sentence.Substring(10);
        string substrings = sentence.Substring(10); 
        Console.WriteLine(substrings); //here print after 10 charater (is very beautiful and loacated in Delhi)
        string substringlength = sentence.Substring(10, 25);
        Console.WriteLine(substringlength);


        //split*************************

        string data = "apple, Banana, Custard";
        data.Split(',');
        string[] datadetails = data.Split(',');
        Console.WriteLine(datadetails);

        //Replace*******************************************

        string original = "The TajMahal is in White color";

        original.Replace("White", "Milk");

        string replaced = original.Replace("White", "Milk");
        Console.WriteLine(replaced);

        //Format******************************************
        /*interpolation*/

        int quantity = 50;
        double price = 10.99;

        string.Format("I Purchased {0} items for {1}" , quantity, price);
        string Receipt = string.Format("I Purchased {0} items for {1}", quantity, price);
        Console.WriteLine(Receipt);

        string Receipts = string.Format("I Purchased {0} items for {1}", quantity, quantity*price);
        Console.WriteLine(Receipts);

















    }

}

