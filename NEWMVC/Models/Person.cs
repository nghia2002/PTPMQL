using System.ComponentModel.DataAnnotations;

namespace NEWMVC.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
    }
}