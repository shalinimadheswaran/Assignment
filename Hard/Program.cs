using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hard
{
    class Program
    {
        int input;
        Employee emp = new Employee();
        List<Employee> empList = new List<Employee>();
        public void AddEmployeeDetails()
        {
            do
            {
                emp.TakeEmployeeDetailsFromUser();
                empList.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
                //dictionary.Add(emp.Id, empList);
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                input = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if ((input != 0) && (input != 1))
                        throw new Exception();
                }
                catch (Exception e)
                {
                    Console.WriteLine("-----Invalid Input-----\nTo continue entering employee details enter 1,to exit enter 0");
                    input = Convert.ToInt32(Console.ReadLine());
                }

                if (input == 0)
                    break;
            } while (input == 1);

        }

        public void ModifyEmployeeDetails()
        {
            Console.WriteLine("Please enter the employee ID\n");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            foreach (var item1 in empList)
            {
                if (!(item1.Id == employeeId))
                {
                    PrintEmployee(employeeId);
                }
                else
                {
                    Console.WriteLine("Please enter valid ID");
                    ModifyEmployeeDetails();
                }
            }
            Console.WriteLine("**Please enter the updated employee details**\n");
            Employee emp1 = new Employee();
            emp1.ModifyEmployeeDetailsFromUser();
            var details = empList.FirstOrDefault(e => e.Id == employeeId);
            if (details != null)
            {
                details.Name = emp1.Name;
                details.Age = emp1.Age;
                details.Salary = emp1.Salary;
            }
        }

        public void PrintEmployee(int employeeId)
        {
            foreach(var item1 in empList)
            {
                if (!(item1.Id==employeeId))
                {
                    Console.WriteLine("Enter Vaild EmployeeID");
                    Console.WriteLine("Please enter the employee ID\n");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    PrintEmployee(empId);

                }
                else
                {
                    var result = from item in empList where item.Id == employeeId select item;
                    foreach (Employee empobj in result)
                    {
                        Console.WriteLine(empobj);
                    }
                }
            }
            
            
        }
        public void PrintAllEmployees()
        {
            foreach (var e in empList)
            {
                Console.WriteLine(e);
            }

        }
       
        void DisplayMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("Please enter the option\n 1.Add an employee\n2.Modify an employee detail\n3.Print all employee's details\n4.Print an employee detail\n5.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployeeDetails();
                        break;
                    case 2:
                        ModifyEmployeeDetails();
                        break;
                    case 3:
                        PrintAllEmployees();
                        break;
                    case 4:
                        Console.WriteLine("Please enter the employee ID\n");
                        int employeeId = Convert.ToInt32(Console.ReadLine());
                        PrintEmployee(employeeId);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("-----------Please enter from the options 1-5-----------");
                        break;
                }
            } while (choice != 5);
        }
        static void Main(string[] args)
        {
            Program programobject = new Program();
            programobject.DisplayMenu();
        }
    }
}