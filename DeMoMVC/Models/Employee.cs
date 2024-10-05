using System.ComponentModel.DataAnnotations;

namespace DeMoMVC.Models
{
    public class Employee
    {
        [Key]
        public string Fullname { get; set; }
        public string  Address { get; set; }
        public int EmployeeID { get; set; }

    }
}