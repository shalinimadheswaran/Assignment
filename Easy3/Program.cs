using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy3
{
    class EmployeePromotion
    {
        static void Main(string[] args)
        {
            List<String> EmployeePromotionList = new List<String>();
            String employeename;

            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion (Please enter blank to stop)");

            //A  while loop to fetch the input and store in collection(List)
            employeename = Console.ReadLine();

            while (!string.IsNullOrEmpty(employeename)) 
            {
                employeename = Console.ReadLine();
                EmployeePromotionList.Add(employeename);
            } 

            Console.WriteLine("The current size of the collection is {0}", EmployeePromotionList.Capacity);
            EmployeePromotionList.TrimExcess();
            Console.WriteLine("The size after removing the extra space is {0}", EmployeePromotionList.Capacity);
            Console.ReadKey();
        }
    }
}
