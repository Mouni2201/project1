using System;

class DataTypeConversations

{
    static void Main()
    {
        //Implict

        //Implicit Type Conversion(Type Promotion)
        //It occurs when you convert a smaller data type into a larger data type without the risk of losing data.

        byte smallNumber = 5;
        int largeNumber = smallNumber;
        Console.WriteLine(largeNumber);  //Implicitconversation from byto to Int

        //Explict

        //int noOfEmployees = 400;
        //byte convertNoOfEmployees = noOfEmployees;  //can't convert type int to byte 

        int noOfEmployees = 400;
        byte convertNoOfEmployees = (byte)noOfEmployees;
        Console.WriteLine(convertNoOfEmployees);   //144


        double petrolPrice = 100;
        int intvalue = (int)petrolPrice;
        Console.WriteLine(intvalue);
        Console.WriteLine(intvalue.GetType());


        //int to string
        int number = 53;
        number.ToString();
        string strNumber = number.ToString();
        Console.WriteLine(strNumber);

        //string to int
        string strnumber = "410";
        int.Parse(strnumber);
        int Parsed = int.Parse(strnumber);
        Console.WriteLine(Parsed);
        
        string strnumber1 = "410";
        int convert = Convert.ToInt32(strnumber1);
        Console.WriteLine(convert);
        Console.WriteLine(convert.GetType());

        //value types = numeric types

        //string nullablestring = null;
        //int.Parse(nullablestring);
        //int output1 = int.Parse(nullablestring);
        //Console.WriteLine(output1);    //it will give exception error so wee use convert

        string nullablestring1 = null;
        Convert.ToInt32(nullablestring1);
        int output2 = Convert.ToInt32(nullablestring1);
        Console.WriteLine(output2);   //it will give zero value

        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime);






    }
}

