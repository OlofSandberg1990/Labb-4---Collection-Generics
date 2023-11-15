using Microsoft.VisualBasic.FileIO;

namespace Labb_4___Collection_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CallStack();
            Console.ReadKey();
            Console.Clear();                        //made two static methods and called them

            CallList();
            Console.ReadKey();
            

        }

        static void CallStack()
        {

            Employee emp1 = new Employee(1001, "Olof", "Male", 38700);
            Employee emp2 = new Employee(1002, "Ulf", "Male", 28500);
            Employee emp3 = new Employee(1003, "Ida", "Woman", 49440);
            Employee emp4 = new Employee(1004, "Robert", "Male", 14000);
            Employee emp5 = new Employee(1005, "Lisa", "Woman", 75000);

            Stack<Employee> myStack = new Stack<Employee>();
            myStack.Push(emp1);
            myStack.Push(emp2);
            myStack.Push(emp3);
            myStack.Push(emp4);
            myStack.Push(emp5);

            foreach (Employee emp in myStack)
            {
                Console.WriteLine($"Items left in the stack : {myStack.Count}");
                Console.WriteLine($"{emp.ID} - {emp.Name} - {emp.Gender} - {emp.Salary}\n");


            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrive using pop method");

            while (myStack.Count > 0)
            {
                Employee temporaryEmp = myStack.Pop();

                Console.WriteLine($"{temporaryEmp.ID} - {temporaryEmp.Name} - {temporaryEmp.Gender} - {temporaryEmp.Salary}");
                Console.WriteLine($"Items left in the stack : {myStack.Count}\n");

            }

            myStack.Push(emp1);
            myStack.Push(emp2);
            myStack.Push(emp3);
            myStack.Push(emp4);
            myStack.Push(emp5);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrive using peek method");

            for (int i = 0; i < 2; i++)
            {
                Employee temporaryEmp = myStack.Peek();
                Console.WriteLine($"{temporaryEmp.ID} - {temporaryEmp.Name} - {temporaryEmp.Gender} - {temporaryEmp.Salary}");
                Console.WriteLine($"Items left in the stack : {myStack.Count}\n");

            }

            Console.WriteLine("----------------------------");

            if (myStack.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in the stack");
            } else
            {
                Console.WriteLine("Emp3 is not in the stack");
            }




        }

        static void CallList()
        {
            Employee emp1 = new Employee(1001, "Olof", "Male", 38700);
            Employee emp2 = new Employee(1002, "Ulf", "Male", 28500);
            Employee emp3 = new Employee(1003, "Ida", "Woman", 49440);
            Employee emp4 = new Employee(1004, "Robert", "Male", 14000);
            Employee emp5 = new Employee(1005, "Lisa", "Woman", 75000);

            List<Employee> myList = new List<Employee>();
            myList.Add(emp1);
            myList.Add(emp2);
            myList.Add(emp3);
            myList.Add(emp4);
            myList.Add(emp5);

            if (myList.Contains(emp2))
            {
                Console.WriteLine("Employee2 exists in the list\n");

            } else
            {
                Console.WriteLine("Employee does not exists in the list\n");
            }

            Employee temporaryEmp = myList.Find(e => e.Gender == "Male");
            Console.WriteLine("First male in the list is : ");
            Console.WriteLine($"{temporaryEmp.ID} - {temporaryEmp.Name} - {temporaryEmp.Gender} - {temporaryEmp.Salary}");

            List<Employee> allMales = myList.FindAll(e => e.Gender == "Male");


            Console.WriteLine("\nAll the males in the list :");
            foreach (Employee emp in allMales)
            {
                Console.WriteLine($"{emp.ID} - {emp.Name} - {emp.Gender} - {emp.Salary}");
            }


        }

    }
}