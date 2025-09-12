using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Models
{
    // Model - Entity - Domain Model -POCO Class [Plaain Old CLR Object]
    // Properties Only
    internal class Employee
    {
        // Public Numeric Property Named as [Id - EmployeeId] => PK
        // Autamaticly Assumed to be PK of Table
        // Id Mapped to int PK with identity Constriant (1,1)
        public int Id { get; set; }
        // Nullable Ref Type
        // String? is Mapped to nvarchar(Max) Allow Null => 0.9
        public string? EmpName { get; set; }
        // Value Type
        // Not Allow Null
        // decimal is mapped to decimal(18,2) not allow null
        public decimal Salary { get; set; }
        // Value Type
        // int is Mapped to int not allow null
        public int Age { get; set; }
    }
}
