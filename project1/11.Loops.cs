using System;
class loops
{
    static void Main()
    {
        //while syntax
        //while()
        //{

        //}

  
  
            int i = 0;
            int sum = 0;
            Console.WriteLine($"value before addition: {i}");
            while (i < 5)
            {
                //console.writeline(i);
                i = i + 1;
                //sum = sum + i;
                Console.WriteLine($"value after addition: {i}");
            }

            int[] numbers = { 12, 45, 67 };
            int sum1 = 0;
            int count = 0;
            while (count < numbers.Length)

            {
            Console.WriteLine($"Counting stage {count}");
            Console.WriteLine($"Numbers list {numbers[count]}");
            Console.WriteLine($"Before Counting, total amount {sum}");

            sum = sum + numbers[count];
                count++;

            }

            Console.WriteLine($"After Counting, total amount {sum}");


            while (count < 10)    //we won't get output as the length is only 3

            {
                Console.WriteLine($"Counting stage {count}");
                Console.WriteLine($"Numbers list {numbers[count]}");
                Console.WriteLine($"Before Counting, total amount {sum}");

                sum = sum + numbers[count];
                count++;

            }

            Console.WriteLine($"After Counting, total amount {sum}");



        }
    } 