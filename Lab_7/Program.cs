namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee(1, "Alice", "Female", 50000),
                new Employee(2, "Bob", "Female", 75000),
                new Employee(3, "Robert", "Male", 35000),
                new Employee(4, "Anna", "Female", 40000),
                new Employee(5, "Noah", "Male", 150000),
            };


            Stack<Employee> employeeStack = new Stack<Employee>();
            Console.WriteLine("Alla anställda:");
            foreach (var employee in employees)
            {
                employeeStack.Push(employee);
                Console.WriteLine(employee);
                Console.WriteLine($"Antal i stacken: {employeeStack.Count}");
            }

            Console.WriteLine();

            foreach (var employee in employees)
            {
                employeeStack.Pop();
                Console.WriteLine(employee);
                Console.WriteLine($"Antal i stacken: {employeeStack.Count}");
            }

            foreach (var employee in employees)
            {
                employeeStack.Push(employee);
            }
        }
    }
}
