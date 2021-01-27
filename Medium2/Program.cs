using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium2
{
    class Program
    {
        int input;
        Employee emp = new Employee();
        List<Employee> empList = new List<Employee>();
        public void AddEmployeeList()
        {
            do
            {
                emp.TakeEmployeeDetailsFromUser();
                empList.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
                //dictionary.Add(emp.Id, empList);
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                input = Convert.ToInt32(Console.ReadLine());
            } while (input != 0);
        }
        public void SortAndPrintEmployee()
        {
            empList.Sort();
            Console.WriteLine("The sorted employee list\n");
            foreach (var item in empList)
            {
                Console.WriteLine("Employee ID: {0}\nName: {1}\nAge: {2}\nSalary:{3}\n--------------\n", item.Id, item.Name, item.Age, item.Salary);

            }
        }
        public void PrintEmployee()
        {
            Console.WriteLine("Please enter the employee ID\n");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            var result = from item in empList where item.Id == employeeId select item;
            foreach (Employee empobj in result)
            {
                Console.WriteLine(empobj);
            }
        }
        static void Main(string[] args)
        {
            Program programobject = new Program();
            programobject.AddEmployeeList();
            programobject.SortAndPrintEmployee();
            programobject.PrintEmployee();
            Console.ReadKey();
        }
    }
}
