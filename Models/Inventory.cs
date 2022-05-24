using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team4_Project.Models
{
    public class Inventory
    {
        [Key]
        public int ItemID { get; set; }

        [Required(ErrorMessage = "Please enter a name for this item.")]
        public string ItemName { get; set;}

        [Required(ErrorMessage = "Please enter the type of item.")]
        public string ItemType { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal ItemPrice { get; set; }

        [Required(ErrorMessage = "Please enter a quantity greater than or equal to 0.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Quantity cannot be below 0.")]
        public int ItemQuantity { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
