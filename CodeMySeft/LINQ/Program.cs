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
            LinQSystax();

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

            // Select and SelectMany
            // SelectAndSelectMany();

            // Select function
            // SelectFunction();

            // SelectMany function
            // SelectManyFunction();

            // Where function
            // WhereFunction();

            // Where function query syntax
            // WhereFunctionQuery();
        }

        public static void WhereFunction()
        {
            string[] coutries = { "India", "Australia", "USA", "Argentina", "Peru", "China" };
            IEnumerable<string> result = coutries.Where(x => x.StartsWith("China"));
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void WhereFunctionQuery()
        {
            string[] coutries = { "India", "Australia", "USA", "Argentina", "Peru", "China" };
            IEnumerable<string> result = from x in coutries where x.StartsWith("A") select x;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("END WITH");
            result = from x in coutries where x.StartsWith("P") where x.EndsWith("u") select x;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void SelectManyFunction()
        {
            List<Student1> Objstudent = new List<Student1>()

            {
                new Student1() { Name = "Ravi Varma", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                new Student1() { Name = "Vikram Sharma", Gender = "Male", Subjects = new List<string> { "Social Studies", "Chemistry" } },
                new Student1() { Name = "Harish Dutt", Gender = "Male", Subjects = new List<string> { "Biology", "History", "Geography" } },
                new Student1() { Name = "Akansha Wadhwani", Gender = "Female", Subjects = new List<string> { "English", "Zoology", "Botany" } },
                new Student1() { Name = "Vikrant Seth", Gender = "Male", Subjects = new List<string> { "Civics", "Drawing" } }
            };

            var result = Objstudent.SelectMany(x => x.Subjects);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void SelectFunction()
        {
            List<Student> listStudent = new List<Student>()
            {
                new Student() { StudentId = 1, Name = "Suresh", Marks = 500 },
                new Student() { StudentId = 2, Name = "Rohini", Marks = 300 },
                new Student() { StudentId = 3, Name = "Madhav", Marks = 400 },
                new Student() { StudentId = 4, Name = "Sateesh", Marks = 550 },
                new Student() { StudentId = 5, Name = "Praveen", Marks = 600 },
                new Student() { StudentId = 6, Name = "Sudheer", Marks = 700 },
                new Student() { StudentId = 7, Name = "Prasad", Marks = 550 }
            };

            var result = listStudent.Select(x => new { a=x.Marks, b=x.Name, c = x.StudentId});

            foreach (var item in result)
            {
                Console.WriteLine("The StudentName is {0} ID is {1} Marks is {2}", item.a, item.b, item.c);
            }

            Console.ReadLine();
        }

        public static void SelectAndSelectMany()
        {
            /*
             * SelectMany có thể truy xuất collection trong collection.
             * Select thì phải dùng thêm một foreach nữa mới lấy được giá trị collection con
             * */
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee { Name = "Deepak", Skills = new List<string> { "C", "C++", "Java" } };
            Employee emp2 = new Employee { Name = "Karan", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };

            Employee emp3 = new Employee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            // Query using Select()
            IEnumerable<List<String>> resultSelect = employees.Select(e => e.Skills);

            Console.WriteLine("**************** Select ******************");

            // Two foreach loops are required to iterate through the results
            // because the query returns a collection of arrays.
            foreach (List<String> skillList in resultSelect)
            {
                foreach (string skill in skillList)
                {
                    Console.WriteLine(skill);
                }
                Console.WriteLine();
            }

            // Query using SelectMany()
            IEnumerable<string> resultSelectMany = employees.SelectMany(emp => emp.Skills);

            Console.WriteLine("**************** SelectMany ******************");

            // Only one foreach loop is required to iterate through the results 
            // since query returns a one-dimensional collection.
            foreach (string skill in resultSelectMany)
            {
                Console.WriteLine(skill);
            }
            Console.WriteLine();
            Console.WriteLine("**************** SelectMany multiple collection ******************");
            List<EmployeeMulti> employeesMulti = new List<EmployeeMulti>();
            EmployeeMulti emp4 = new EmployeeMulti { Name = "Deepak", Skill = new Skill { ID = "1", Skills = new List<string> { "111","222"} } };
            employeesMulti.Add(emp4);
            IEnumerable<string> resultSelectManyMulti = employeesMulti.SelectMany(emp => emp.Skill.Skills);
            foreach(var skill in resultSelectManyMulti)
            {
                Console.WriteLine(skill);
            }

            Console.ReadKey();
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
            //int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //// IEnumerable<int> result = from numbers in Num where numbers > 3 select numbers;
            //IEnumerable<int> result = Num.Where(x => x > 3).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int> result = from numbers in Num
                                      where numbers > 3
                                      select numbers;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
