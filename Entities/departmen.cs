using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Entities
{
    [Table("Departmen_Tbl")]
    public partial class departmen
    {
        public String departmenName { get; set; }
        public int departmenCode { get; set; }
    
    }
}
