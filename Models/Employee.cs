using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team4_Project.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }
       
        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a position.")]
        public string Position { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
