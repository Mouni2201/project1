using System;


class Operators

{
    // Arithmetic Operators
    // + : Adds two operands. Example: 5 + 3 results in 8.
    // - : Subtracts the second operand from the first. Example: 10 - 4 results in 6.
    // * : Multiplies two operands. Example: 3 * 4 results in 12.
    // / : Divides the first operand by the second. Example: 10.0 / 3.0 results in approximately 3.3333.
    // % : Returns the remainder of a division operation. Example: 10 % 3 results in 1.

    // Comparison Operators it return the boolean
    // == : Checks if two operands are equal. Example: 5 == 5 results in true.
    // != : Checks if two operands are not equal. Example: 5 != 3 results in true.
    // > : Checks if the first operand is greater than the second. Example: 8 > 5 results in true.
    // < : Checks if the first operand is less than the second. Example: 3 < 7 results in true.
    // >= : Checks if the first operand is greater than or equal to the second. Example: 8 >= 8 results in true.
    // <= : Checks if the first operand is less than or equal to the second. Example: 3 <= 7 results in true.

    // Logical Operators
    // && : Returns true if both operands are true. Example: true && true results in true.
    // || : Returns true if at least one of the operands is true. Example: true || false results in true.
    // ! : Inverts the boolean value. Example: !true results in false.
    static void Main()
    {

        //Arithmetic (+,-,*,/,% )

        //Console.WriteLine(3 + 5);

        //byte sum = 5 + 4;
        //int difference = 8 - 9;
        //int product = 3 * 5;
        //double result = 10.4 / 2.3;
        //double remainder = 10 % 4;

        //string.Format("sum is {0}", sum);
        //string.Format("sum is {0} difference {1} product {2} result {3} remainder {4}", sum, difference, product, result, remainder);
        //string output = string.Format("sum is {0} difference {1} product {2} result {3} remainder {4}", sum, difference, product, result, remainder);
        //Console.WriteLine(output);


        //int a = 25;
        //int b = 10;

        //Console.WriteLine("Addition:" + (a + b));
        //Console.WriteLine("Substraction:" + (a - b));
        //Console.WriteLine("Multiply:" + (a * b));
        //Console.WriteLine("Divison:" + (a / b));
        //Console.WriteLine("Module:" + (a % b));  //remainder


        //*********************** Comparison Operators*********************
        //Console.WriteLine(5 == 5);

        //bool isEquals = (5 == 5);
        ////Console.WriteLine(isEquals); //true

        //bool isnotEquals = (5 != 3);
        //bool isGreater = (5 > 2);
        //bool isLess = (5 < 9);
        //bool isGreaterEquals = (5 >= 5);
        //bool isLessEquals = (5 <= 9);


        //string SI = $"isEquals {isEquals}, isnotEquals {isnotEquals}, isGreater {isGreater}, isLess {isLess}, isGreaterEquals {isGreaterEquals}, isLessEquals {isLessEquals}";
        //Console.WriteLine(SI);



        string userName = "Kushal";
        int lengthOfUserName = 6;

        //userName.Length == lengthOfUserName;
        bool isCorrect = (userName.Length == lengthOfUserName);
        Console.WriteLine(isCorrect);

        string[] currencyItems = { "$10", "$20", "$30" };
        int noOfCurrencyItems = 8;
        bool currency = (currencyItems.Length == noOfCurrencyItems);
        Console.WriteLine(currency);



        //**********************logical Operators***************************************
        //And Operator(&&)

        //bool result1 = true && true;
        //Console.WriteLine(result1);

        //bool result2 = false && false;
        //Console.WriteLine(result2);

        //bool result3 = (5 == 5) && ( 5 != 3);
        //Console.WriteLine(result3);

        //bool result4 = (5 == 5) && (5 == 3);
        //Console.WriteLine(result4);

        //bool result5 = (5 == 3) && (5 == 5);
        //Console.WriteLine(result5);

        //bool result6 = (5 == 3) && (5 == 4);
        //Console.WriteLine(result6);

        //OR Operator(||)

        //bool result1 = true || true;
        //Console.WriteLine(result1);

        //bool result2 = false || false;
        //Console.WriteLine(result2);

        //bool result3 = (5 == 5) || (5 != 3);
        //Console.WriteLine(result3);

        //bool result4 = (5 == 5) || (5 == 3);
        //Console.WriteLine(result4);

        //bool result5 = (5 == 3) || (5 == 5);
        //Console.WriteLine(result5);

        //bool result6 = (5 == 3) || (5 == 4);
        //Console.WriteLine(result6);


        //Not Operator(!)

        //!true   //false
        //!false //true


        //bool opptrue = !true;
        //Console.WriteLine(opptrue);

        //bool oppfalse = !false;
        //Console.WriteLine(oppfalse);


        //nullable type

        //int age = null;  //convert null to int because it is non-nullable value type
        //int? age = null;
        //Console.WriteLine("Age is:", age);

        //int? age2 = 20;
        //Console.WriteLine("Age is:", age2);   //null

        //bool? nullValue = null;
        //Console.WriteLine("nullValue is:", nullValue);

    }
}

