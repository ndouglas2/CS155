using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
            //write into SQL database using entity framework
            //Console.WriteLine("Enter employee first name ");
            //string fname = Console.ReadLine();
            //Console.WriteLine("Enter employee last name ");
            //string lname = Console.ReadLine();
            //Console.WriteLine("Enter employee gender ");
            //string gender = Console.ReadLine();
            //Console.WriteLine("Enter employee salary ");
            //int salary = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter department ID ");
            //int deptId = Int32.Parse(Console.ReadLine());

            //using (var context = new CS155Entities())
            //{
            //    var employee = new Employee()
            //    {
            //        FirstName = fname,
            //        LastName = lname,
            //        Gender = gender,
            //        Salary = salary,
            //        DepartmentId = deptId

            //    };
            //    context.Employees.Add(employee);
            //    context.SaveChanges(); 
            //}

            //Reading from SQL database using entity framework
            using (var context = new CS155Entities())
            {
                foreach (var emp in context.Employees)
                {
                    Console.Write(" " + emp.FirstName + "    " + emp.LastName + "   " + emp.Gender + "  " + emp.Salary + "  " + emp.Department.Name);
                    Console.WriteLine();

                };
                Console.ReadKey();
            }

        }
    }
}
