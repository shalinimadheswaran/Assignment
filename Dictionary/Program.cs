using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
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
        public void PrintEmployee()
        {
            Console.WriteLine("Please enter the employee ID ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, Employee> dictionaryEmployees = empList.ToDictionary(x => x.Id);

            foreach (KeyValuePair<int, Employee> keyValuePairEmployees in dictionaryEmployees)
            {
                if (keyValuePairEmployees.Key == employeeId)
                {
                    Console.WriteLine("Key = {0}", keyValuePairEmployees.Key);
                    Employee emp1 = keyValuePairEmployees.Value;
                    Console.WriteLine("Employee ID: {0}\n Name : {1}\n Age : {2}\n Salary : {3}",
                                   emp1.Id, emp1.Name, emp1.Age, emp1.Salary);
                }
            }
        }
        
        static void Main(string[] args)
        {

            Program programobject = new Program();
            programobject.AddEmployeeList();
            programobject.PrintEmployee();
            Console.ReadKey();
        }
    }
}












//if (dictionary.ContainsKey(employeeId))
//{
//    foreach (var contents in dictionary[employeeId])
//    {
//        Console.WriteLine(contents);
//    }
//}

//if (dictionary.TryGetValue(employeeId, out empList))
//{
//    foreach (var contents in empList)
//    {
//        Console.WriteLine(contents);
//    }
//}
