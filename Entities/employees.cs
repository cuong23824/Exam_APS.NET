using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Entities
{
    [Table("Employee_Tbl")]
    public class employees
    {
        [Key] public int employeesCode { get; set; }
        [Required] public string employeesName { get; set; }
        [Required] public int departmenCode { get; set; }
        

    }
}
