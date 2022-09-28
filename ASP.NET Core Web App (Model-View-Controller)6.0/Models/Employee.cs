using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASP.NET_Core_Web_App__Model_View_Controller_6._0.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        public string Designation { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
    }
}
