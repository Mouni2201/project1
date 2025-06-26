using System;

 class MethodswithReturnType
    {
    static void Main()
    {
        //void and non void(datatypes)
        string Nameing = Method1();
        Console.WriteLine(Nameing);


        int personAge = method2();
        Console.WriteLine(personAge);

    }

  static string Method1()  //string is non void 
    {
        string Name = "Mounica";
        return Name;
    }

    static int method2()
    {
        int age = 25;
        return age;
    }
    

    }

