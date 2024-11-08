using Lab_7;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Del1
            Stack<Employee> employeeStack = new Stack<Employee>();
            Employee employee1 = new Employee(1, "Bob", "Kvinna", 60000);
            Employee employee2 = new Employee(2, "Lauri", "Kvinna", 70000);
            Employee employee3 = new Employee(3, "Noah", "Man", 100000);
            Employee employee4 = new Employee(4, "Greta", "Kvinna", 50000);
            Employee employee5 = new Employee(5, "Hans", "Man", 45000);
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (var employee in employeeStack)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Items in stack: {employeeStack.Count}");
            }
            Console.WriteLine("");

            while (employeeStack.Count > 0)
            {
                var employee = employeeStack.Pop();
                Console.WriteLine(employee);
                Console.WriteLine($"Items in stack: {employeeStack.Count}");
            }
            Console.WriteLine("");

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine($"StackCount after pushing all items to the stack: {employeeStack.Count}");

            Console.WriteLine("");

            var firstPeek = employeeStack.Peek();
            var secondPeek = employeeStack.Peek();
            Console.WriteLine(firstPeek);
            Console.WriteLine(secondPeek);

            Console.WriteLine("");

            bool foundEmployee = employeeStack.Contains(employee3);
            if (foundEmployee) 
            {
                Console.WriteLine($"Employee nr {employee3.Id} is in stack.");
            }
            else
            {
                Console.WriteLine("employee nr 3 does not exist in the stack");
            }
            Console.WriteLine("");

            //Del2
            List<Employee> employeeList = new List<Employee>();
            foreach (var employee in employeeStack)
            {
                employeeList.Add(employee);
            }
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine($"Employee2 object exists in list");
            }
            else
            {
                Console.WriteLine($"Employee2 object does not exist in the list");
            }

            Console.WriteLine("");
            Console.WriteLine("Frist male in the list: ");
            Console.WriteLine(employeeList.Find(employee => employee.Gender == "Man"));
            Console.WriteLine("");

            Console.WriteLine("All males in the list: ");
            foreach (var employee in employeeList.FindAll(employee => employee.Gender == "Man"))
            {
                Console.WriteLine(employee);
            }
        }
    }
}