using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1-	Write a program that allows the user to enter a number then print it.
            */
            #region Q1
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("===================");
            Console.WriteLine("The number you entered is : " + number);
            #endregion

            /*
            2-	Write C# program that converts a string to an integer, but the string contains 
            non-numeric characters. And mention what will happen 
             */
            #region Q2
            string s = "20Mohamed";
            int integer = Convert.ToInt32(s);
            Console.WriteLine(integer);
            // Run time error, String format is not valid to be converted.
            // To convert string to integer, it must be only numbers '2510'
            #endregion

            /*
             3-	Write C# program that Perform a simple arithmetic operation with floating-point
             numbers And mention what will happen
             */
            #region Q3
            int num4 = 5;

            decimal num1 = 2.0m;
            Console.WriteLine(2 * num4 + num1);

            float num2 = 2.0f;
            Console.WriteLine(2 * num4 + num2);

            double num3 = 2.0;
            Console.WriteLine(2 * num4 + num3);
            /*
             double, float ==> if the result do not have fractions, the result is integer
             decimal ==> the result is always with floating point
            */
            #endregion

            /*
             4-	Write C# program that Extract a substring from a given string.
             */
            #region Q4
            string name = "Mohamed Abobakr";
            string result = name.Substring(0, 7);
            Console.WriteLine(result);
            #endregion

            /*
            5-	Write C# program that Assigning one value type variable to another
            and modifying the value of one variable and mention what will happen
             */
            #region Q5
            int x = 5;
            int y = 2;
            Console.WriteLine(x + " " + y); // 5 2

            x = y;
            Console.WriteLine(x + " " + y); // 2 2

            y = 3;
            Console.WriteLine(x + " " + y); // 2 3
            #endregion

            /*
             6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable 
             and mention what will happen
             */
            #region Q6
            object Obj1 = new object();
            object Obj2 = new object();

            // Each object will have a different value
            // Different addresses, Different References
            Console.WriteLine(Obj1.GetHashCode());
            Console.WriteLine(Obj2.GetHashCode());

            // They will have the same value
            // Same Address, Different References
            Obj2 = Obj1;
            Console.WriteLine(Obj1.GetHashCode());
            Console.WriteLine(Obj2.GetHashCode());
            #endregion

            /*
             7-	Write C# program that take two string variables and print them as one variable 
             */
            #region Q7
            Console.Write("Enter Your First Name : ");
            string fName = Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            string lName = Console.ReadLine();

            Console.Write("Your Name : " + fName + " " + lName);
            #endregion

            /*
             8-	Which of the following statements is correct about the C#.NET code snippet given below?
             */
            #region Q8
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d);

            // b)	A value 1 will be assigned to d.
            #endregion

            /*
             9-	Which of the following is the correct output for the C# code given below?
             */
            #region Q9
            Console.WriteLine(13 / 2 + " " + 13 % 2);

            // d)	6 1
            #endregion

            /*
             10- What will be the output of the C# code given below?
             */
            #region 10
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            // d)	7 7
            #endregion
        }
    }
}
