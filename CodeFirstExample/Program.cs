using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo e1 = new EmployeeInfo { Name = "Deepa", Dept = "HR", Salary = 45000 };
            EmployeeInfo e2 = new EmployeeInfo { Name = "Martin", Dept = "Finance", Salary = 39000 };
            EmployeeInfo e3 = new EmployeeInfo { Name = "Sheila", Dept = "R&D", Salary = 47000 };
            CodeDbEntities db = new CodeDbEntities();
            db.EmployeeInfos.Add(e1);
            db.EmployeeInfos.Add(e2);
            var res = db.SaveChanges();
            if (res > 0)
                Console.WriteLine("Data Inserted");
            }
    }
}
