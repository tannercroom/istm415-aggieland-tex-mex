using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team4_Project.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a street address.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter a city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state.")]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"\d{5}-?(\d{4})?$", //must be 5 or 9 digits only
            ErrorMessage = "Please enter a valid zip code.")]
        public long ZipCode { get; set; }

        [Required] //must be 10 digits only
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Please enter a ten-digit phone number.")]
        public long Phone { get; set; }

        [Required] //must be a valid email address (must include an '@' and '.' after the '@')
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
