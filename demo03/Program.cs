using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo
            #region Value Types Casting
            #region Implicit Casting
            //int x = 4; // bytes
            //long y = /(long)/ x;
            #endregion

            #region Explicit Casting - unSafe Casting
            /*long x = 1010101010; // 8 bytes

            int y;
            checked
            {
                y = (int)x; 
            }
            Console.WriteLine(y);*/

            //int x = 88;
            //double y = /(double)/ x;

            //double x = 88.8;
            //int y = (int)x;
            //Console.WriteLine(y);
            #endregion

            #region Parse Casting [convert from string to any data type]
            //int number = int.Parse(Console.ReadLine());
            /*
            Console.WriteLine("Enter Data User");

            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your Salary : ");
            double salary = double.Parse(Console.ReadLine());


            Console.WriteLine("Name : " + name + ", Age : " + age + ", Salary : " + salary);  
            */
            #endregion

            #region Convert Casting [convert from any data type to any data type]
            /*Console.WriteLine("Enter Data User");

            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Name : " + name + ", Age : " + age + ", Salary : " + salary);*/
            #endregion
            #endregion

            #region Operators
            #region Unary Operators [++, --]
            int x = 5;
            //x++;
            //++x;
            //Console.WriteLine(++x);
            //Console.WriteLine(x);

            //Console.WriteLine(--x);
            //Console.WriteLine(x--);
            //Console.WriteLine(x);
            #endregion
            #endregion

            #region Binary Operators
            /*int sum, mul, sub, div, mod;

            int a = 8;
            int b = 5;

            sum = a + b;
            sub = a - b;
            mod = a % b;
            div = a / b;
            mul = a * b;
            Console.WriteLine(mul);*/
            #endregion

            #region Assignment Operators
            /*int x = 10;

            x += 10; // x = x + 10 
            x -= 10;
            x *= 10;
            x /= 10;
            x %= 10;*/
            #endregion

            #region Relational Operators
            /*int a = 5;
            int b = 5;

            Console.WriteLine(a < b);*/
            #endregion

            #region Logical Operator [Short Circut]
            //Console.WriteLine(!true);

            //Console.WriteLine(true && false);
            // true && true = true
            // true && false = false
            // false && true = false
            // false && false = false

            //nsole.WriteLine(true || false);
            // true || true = true
            // true || false = true
            // false ||true = true
            // false ||false = false
            #endregion

            #region Bitwise Operators [Long Circut]
            //Console.WriteLine(true && false);
            // true && true = true
            // true && false = false
            // false && true = false
            // false && false = false

            //nsole.WriteLine(true || false);
            // true || true = true
            // true || false = true
            // false ||true = true
            // false ||false = false
            #endregion

            #region Ternary Operators [Conditional Operator]
            /* int z = 4;
            string message = z > 4 ? "x Greater than 4" : "x less than or equal 4";
            Console.WriteLine(message);*/
            #endregion

            #region Operator Periorety
            /*
             * Unary => Prefix 
             * ()
             * * / % 
             * + -
             */
            /*
            int a = 20;
            int b = 15;
            int c = 10;
            int d = 5;

            int result;

            result = (a + b) * c / d;
            Console.WriteLine(result);*/
            #endregion

            #region String Formatting
            // Equation = x + y = Result
            // Equation = 10 + 5 = 15
            //int x = 5;
            //int y = 10;
            //int Result = x + y;

            //Console.WriteLine("Equation : " + x + " + " + y + " = " + Result);
            // string => immutable datatype
            // string name = "Ahmed";
            // name = "Ali";

            #region 1.Composite format
            //string message = string.Format("Equation = {0} + {1} = {2}", x, y, Result);
            //Console.WriteLine(message);
            //Console.ReadLine("Equation = {0} + {1} = {2}", x, y, Result);
            #endregion

            #region 2.String Manipolition
            // string interpolation => $
            //Console.WriteLine($"Equation = {x} + {y} = {Result}");
            #endregion

            #endregion

            #region IF Else - Switch Case
            //Console.WriteLine("Enter Month Number");
            //int MonthNumber = int.Parse(Console.ReadLine());
            // 1 => Month is Jan
            // 2 => Month is Feb
            // 3=> Month is Mar
            // Invalid Input

            /*
            if(MonthNumber == 1)
                { Console.WriteLine("Month is Jan"); }
            else if(MonthNumber == 2)
                { Console.WriteLine("Month is Feb"); }
            else if(MonthNumber == 3)
                { Console.WriteLine("Month is Mar"); }
            else
                { Console.WriteLine("Invalid Input"); }
            */

            /*
            switch (MonthNumber)
            {
                case 1:
                    Console.WriteLine("Month is Jan");
                    break;
                case 2:
                    Console.WriteLine("Month is Feb");
                    break;
                case 3:
                    Console.WriteLine("Month is Mar");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            */

            //Console.WriteLine("Enter Name : ");
            //string name = Console.ReadLine();

            /*
            if (name == "Mostafa")
            { Console.WriteLine("Hello Mostafa"); }
            else if (name == "Aliaa")
            { Console.WriteLine("Hello Aliaa"); }
            else if (name == "Ahmed")
            { Console.WriteLine("Hello Ahmed"); }
            */
            /*
            switch (name)
            {
                case "Mostafa":
                    Console.WriteLine("Hello Mostafa");
                    break;

                case "Aliaa":
                    Console.WriteLine("Hello Aliaa");
                    break;

                case "Ahmed":
                    Console.WriteLine("Hello Ahmed");
                    break;
            }     
            */
            #endregion

            #region GoTo
            Console.WriteLine("Enter Option");
            // 3000 => "Option 01", "Option 02", "Option 03"
            // 2000 => "Option 01", "Option 02"
            // 1000 => "Option 01"

            /*
            int Option = int.Parse(Console.ReadLine());

            switch (Option) {
                case 3000:
                    Console.WriteLine("Option 03");
                    goto case 2000;
                case 2000:
                    Console.WriteLine("Option 02");
                    goto case 1000;
                case 1000:
                    Console.WriteLine("Option 01");
                    break;
            }
            */
            #endregion
        }
    }
}
