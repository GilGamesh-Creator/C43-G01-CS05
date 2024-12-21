using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Net;
using System.Reflection;
using System.IO;
using System;
using static Assignment05.Program;
using System.Text;

namespace Assignment05
{
    internal class Program
    {
        #region Q1
        //Passing by Value:  When you pass a value type(like int, float, bool) by value, a copy of the variable's data is given to the function. Changes inside the function don't affect the original variable.
        //Passing by Reference: When you pass a value type by reference(using the ref keyword), the function receives the memory address of the original variable.Changes made inside the function directly modify the original variable.
        public class Example
        {
            static void ModifyValue(int x) // Pass by value
            {
                x = 100;
            }
                        static void ModifyReference(ref int x) // Pass by reference
            {
                x = 100;
            }
                        public static void Main(string[] args)
            {
                int num1 = 50;
                ModifyValue(num1);
                Console.WriteLine(num1); // Output: 50 (original value unchanged)

                int num2 = 50;
                ModifyReference(ref num2);
                Console.WriteLine(num2); // Output: 100 (original value modified)
            }
        }
        #endregion
        #region Q2
        //By Value: The reference is passed as a copy; changes to object members affect the original object, but reassigning the reference does not.
        //By Reference: The reference itself is passed; reassigning it changes the original object.
        class Sample
        {
            public int Value { get; set; }
        }

        class Program2
        {
            static void ModifyByValue(Sample obj)
            {
                obj.Value = 20; // Changes original object
                obj = new Sample { Value = 30 }; // Does not affect the original reference
            }

            static void ModifyByReference(ref Sample obj)
            {
                obj.Value = 20; // Changes original object
                obj = new Sample { Value = 30 }; // Affects the original reference
            }

            static void Main()
            {
                Sample sample = new Sample { Value = 10 };

                ModifyByValue(sample);
                Console.WriteLine("After ModifyByValue: " + sample.Value);

                ModifyByReference(ref sample);
                Console.WriteLine("After ModifyByReference: " + sample.Value); 
            }
        }
        #endregion
        #region Q3
        public class Program3
        {
            static (int sum, int difference) Calculate(int a, int b, int c, int d)
            {
                int sum = a + b + c + d;
                int difference = (a + b) - (c + d);
                return (sum, difference); // Return both results as a tuple
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("Enter four numbers:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                int num4 = int.Parse(Console.ReadLine());

                var result = Calculate(num1, num2, num3, num4);
                Console.WriteLine($"Sum: {result.sum}, Difference: {result.difference}");
            }
        }
        #endregion
        #region Q4
        public class Program4
        {
            static int SumOfDigits(int num)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;
            }

            public static void Main(string[] args)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                int sum = SumOfDigits(number);
                Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            }
        }
        #endregion
        #region Q5
        public class Program5
        {
            static bool IsPrime(int num)
            {
                if (num <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }

            public static void Main(string[] args)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
        }
        #endregion
        #region Q6
        public class Program6
        {
            static void MinMaxArray(int[] arr, out int min, out int max)
            {
                min = arr[0];
                max = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                    if (arr[i] > max) max = arr[i];
                }
            }

            public static void Main(string[] args)
            {
                int[] myArray = { 5, 2, 9, 1, 7 };
                MinMaxArray(myArray, out int minValue, out int maxValue);
                Console.WriteLine($"Minimum: {minValue}, Maximum: {maxValue}");
            }
        }
        #endregion
        #region Q7
        public class Program7
        {
            static long Factorial(int n)
            {
                if (n == 0) return 1;

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

            public static void Main(string[] args)
            {
                Console.Write("Enter a non-negative integer: ");
                int num = int.Parse(Console.ReadLine());
                long factorial = Factorial(num);
                Console.WriteLine($"Factorial of {num} is {factorial}");
            }
        }
        #endregion
        #region Q8
        public class Program8
        {
            static string ChangeChar(string str, int position, char newChar)
            {
                if (position < 0 || position >= str.Length)
                {
                    return "Invalid position.";
                }

                StringBuilder sb = new StringBuilder(str);
                sb[position] = newChar;
                return sb.ToString();
            }

            public static void Main(string[] args)
            {
                string text = "hello";
                string modifiedText = ChangeChar(text, 1, 'a');
                Console.WriteLine(modifiedText); // Output: hallo
            }
        }
        #endregion
    }
}
