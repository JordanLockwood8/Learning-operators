using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Operators
    {
        public static int Add(params int[] ints)
        {
            return ints.Sum();
        }
        public static int Sub(int num1, int num2)
        {
            var sub = num1 - num2;
            return sub;

        }
        public static int Mul(int num1, int num2)
        {
            var mul = num1 * num2;
            return mul;
        }
        /*        public static object Div()
                {
                    var a = 17;
                    var b = 4;
                    var quotent = a / b;
                    var remainder = a % b;
                    Console.WriteLine($"a/b is {quotent} remainder{remainder}");
                    return Div;
                }*/
        public static double AreaOfCircle(double radius)
        {  
            //var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}

