using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DeMoMVC.Models
{
    [Table("Person")]
    public class Person 
    {
        [Key]
        public int PersonID { get; set;}
        public string Fullname { get; set;}
        public string Address { get; set;}
    }
}