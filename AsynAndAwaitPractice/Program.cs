using System.IO.Pipes;

namespace AsynAndAwaitPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> listEmployees = new List<Employee>()
        {

            new Employee{ ID = 101, Name = "Mark"},
            new Employee{ ID = 102, Name = "Mary"},
            new Employee{ ID = 103, Name = "John"},
            new Employee{ ID = 104, Name = "Jonny"},
        };

            //AnonymousMethods
            //step 2 create an instance of a delegate that points to FindEmployee function
            Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

            //step3 we passed the delegate instance parameter to the find method
            Employee employee1 = listEmployees.Find( emp => FindEmployee(emp) );
            Console.WriteLine($"ID is {employee1.ID} and the name is {employee1.Name}");

            //Lambda expression
            //below the input type is not explicitly defined 
            //Employee employee = listEmployees.Find(Emp => Emp.ID == 104);

            //below the input type is explicitly defined its not really required tho
            Employee employee = listEmployees.Find((Employee Emp) => Emp.ID == 104);
            Console.WriteLine($"ID is {employee.ID} and the name is {employee.Name} ");

            int count = listEmployees.Count( Emp => Emp.Name.StartsWith("M"));
            Console.WriteLine(count);


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*Console.WriteLine("Hello, World!");
            var adding = (int x, int y) => x + y;
            var addSum = adding(10, 10);
            Console.WriteLine(addSum);

            var books = new List<string> { "YOLO", "huh" };
            var book = books.SingleOrDefault (p => p == "huh");
            Console.WriteLine(book);*/
        }


        //step 1: create a function
        public static bool FindEmployee( Employee Emp)
        {
            return Emp.ID == 102;
        }

        public interface ITaxCalculator
        {
            int Calculate(int x, int y);
        }


    }
}