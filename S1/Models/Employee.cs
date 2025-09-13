using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Models
{
    #region By Convention
    // Model - Entity - Domain Model -POCO Class [Plaain Old CLR Object]
    // Properties Only
    //internal class Employee
    //{
    //    // Public Numeric Property Named as [Id - EmployeeId] => PK
    //    // Autamaticly Assumed to be PK of Table
    //    // Id Mapped to int PK with identity Constriant (1,1)
    //    public int Id { get; set; }
    //    // Nullable Ref Type
    //    // String? is Mapped to nvarchar(Max) Allow Null => 0.9
    //    public string? EmpName { get; set; }
    //    // Value Type
    //    // Not Allow Null
    //    // decimal is mapped to decimal(18,2) not allow null
    //    public decimal Salary { get; set; }
    //    // Value Type
    //    // int is Mapped to int not allow null
    //    public int Age { get; set; }
    //} 
    #endregion
    #region Data Annotation
    [Table("Employees")]
    internal class Employee
    {
        // Public Numeric Property Named as [Id - EmployeeId] => PK
        // Autamaticly Assumed to be PK of Table
        // Id Mapped to int PK with identity Constriant (1,1)
        [Key]
        public int EmpId { get; set; }
        // Nullable Ref Type
        // String? is Mapped to nvarchar(Max) Allow Null => 0.9
        [Required]
        [Column("EmployeeName", TypeName = "Varchar")]
        //[MaxLength(50,ErrorMessage ="Name Of Employee Must be Less than 51 char")]
        //[MinLength(3,ErrorMessage ="Name Of Employee Must be More than 3 char")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name Of Employee Must be Less than 51 char and Name Of Employee Must be More than 3 char")]
        //[Length(3,50)]
        public string Name { get; set; }
        // Value Type
        // Not Allow Null
        // decimal is mapped to decimal(18,2) not allow null
        [Column("EmployeeSalary", TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        // Value Type
        // int is Mapped to int not allow null
        [Range(25, 40)]
        [AllowedValues(25, 30, 22, 50, 60)]
        [DeniedValues(25, 30, 22, 50, 60)]
        public int Age { get; set; }
        [Phone] // check value before Store in DB
        [DataType(DataType.PhoneNumber)] // to display Value as PhoneNumber
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [NotMapped]
        public int Deduction {  get; set; }

    } 
    #endregion
}
