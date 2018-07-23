using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirstExample
{
    class CodeDbEntities:DbContext
    {
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public CodeDbEntities() : base("MyDB")
        {

        }
    }
}
