using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            // LINQ Systax
            // LinQSystax();

            // Lambda Expressions
            // LambdaExpressions();

            // Min function
            // MinFunction();

            // Max function
            // MaxFunction();

            // Sum function
            // SumFunction();

            // Count function 
            // CountFunction();

            // Average function
            // AverageFunction();
        }

        public static void AverageFunction()
        {
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            double count = Num.Average();

            Console.WriteLine("Average is {0}", count);
            Console.ReadLine();
        }

        public static void CountFunction()
        {
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int count = Num.Count();

            Console.WriteLine("Count element is {0}", count);
            Console.ReadLine();
        }

        public static void SumFunction()
        {
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = Num.Sum();

            Console.WriteLine("Sum is {0}", sum);
            Console.ReadLine();
        }

        public static void MaxFunction()
        {
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = Num.Max();

            Console.WriteLine("Max is {0}", max);
            Console.ReadLine();
        }

        public static void MinFunction()
        {
            int[] Num = { 1,2,3,4,5,6,7,8,9};
            int min = Num.Min();

            Console.WriteLine("Min is {0}", min);
            Console.ReadLine();
        }

        public static void LambdaExpressions()
        {
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10};

            IEnumerable<int> evenNumber = numbers.Where(x => x % 2 == 0);
            foreach(var item in evenNumber)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================");
            IEnumerable<int> oddNumber = numbers.Where(x => x % 2 != 0);
            foreach(var item in oddNumber)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void LinQSystax()
        {
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // IEnumerable<int> result = from numbers in Num where numbers > 3 select numbers;
            IEnumerable<int> result = Num.Where(x => x > 3).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
