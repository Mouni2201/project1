using System;
using System.Diagnostics;
class VarAndDynamic
{
    static void Main()
    {
        //int age = 20;
        //age = 30;  // here we can reassign
        ////System.Console.WriteLine(age);   //this command is used when using system didn't use.
        //Console.WriteLine(age);   //30
        //Console.WriteLine(age.GetType()); //System.Int32 



        //string companyName = "DXC";
        //companyName = "TCS";
        //Console.WriteLine(companyName.GetType());  //System.Int32
        //Console.WriteLine(companyName);  //tcs


        //double price = 17.89;
        //// price = "ASDGEHTUJG";  // it will throw
        //price = 50.99;
        //Console.WriteLine(price);  //50.99  the console the latest price
        //Console.WriteLine(price.GetType());


        ////var - references, varaible name;

        ////when var is using you should give some value compulsory
        ////var first;  

        ////in var we can give any type of values
        //var number = 10;   //compiler int
        //var name = "Kushal";  //compiler string
        //var pricetag = 10.99;  //compiler double

        //Console.WriteLine(number);
        //Console.WriteLine(name);
        //Console.WriteLine(pricetag);


        //var v_name = "Kushal";
        //Console.WriteLine($"v_name before medhansh {v_name.Length}");
        //v_name = "Medhansh";   //can't redeclared as well
        //Console.WriteLine(v_name);  //Medhansh   and it will take latest refernce value
        //Console.WriteLine(v_name.GetType());
        //Console.WriteLine(v_name.Length);

        //var itemName = "Chocolate";
        ////itemName = 10;  it will give error like can't convert int to string
        //Console.WriteLine(itemName);
        //Console.WriteLine(itemName.GetType());
        //Console.WriteLine(itemName.Length);


        //dynamic
        Console.WriteLine("****************************Dynamic************************");
        dynamic d_number = 10;
        Console.WriteLine(d_number);
        Console.WriteLine(d_number.GetType());


        dynamic d_name = "Sravani";
        Console.WriteLine($"d_name before Mounica {d_name.Length}");
        d_name = "Mounica";
        Console.WriteLine(d_name.GetType());
        Console.WriteLine($"d_name{d_name.Length}");

        dynamic d_price = 16.78d;
        Console.WriteLine(d_price);
        Console.WriteLine(d_price.GetType());

        dynamic d_price1 = 10.90;
        d_price1 = "misard";    
        Console.WriteLine(d_price1.GetType());

        d_name = 56.55;
        Console.WriteLine(d_name.GetType());  //here we can reassign the name and we can change the datatype using same name



        








        










    }

}

