using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy1
{
    class EmployeePromotion
    {
        static void Main(string[] args)
        {
            //A List to store the employees name
            List<String> EmployeePromotionList = new List<String>();
            String employeename;

            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion (Please enter blank to stop)");

            //A while loop to fetch the input and store in collection(List)
            employeename = Console.ReadLine();
            while (!string.IsNullOrEmpty(employeename))
            {
                EmployeePromotionList.Add(employeename);
                employeename = Console.ReadLine();
            }

            //Displaying the names in the same order as of input
            foreach (var name in EmployeePromotionList)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
