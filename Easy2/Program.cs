using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy2
{
    class EmployeePromotion
    {
        static void Main(string[] args)
        {
            //A List to store the employees name
            List<String> EmployeePromotionList = new List<String>();
            String employeename;

            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion (Please enter blank to stop)");

            //A  while loop to fetch the input and store in collection(List)
            employeename = Console.ReadLine();
            while (!string.IsNullOrEmpty(employeename))
            {
                EmployeePromotionList.Add(employeename);
                employeename = Console.ReadLine();               
            } 

            Console.WriteLine("Please enter the name of the employee to check promotion position");
            String employeeName = Console.ReadLine();
            int position = EmployeePromotionList.IndexOf(employeeName);
            Console.WriteLine("{0} is in the position {1} for promotion",employeeName,position+1);
            Console.ReadKey();
        }
    }
}
