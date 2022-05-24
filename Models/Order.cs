using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team4_Project.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Please enter the ID of the Employee who entered the order.")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Please select either Credit Card or Cash as a Payment Type.")]
        public string PaymentType { get; set;}

        public string CardName { get; set; }

        public long? CardNumber { get; set; }

        public int? CVV { get; set; }

        public DateTime? CardExpirationDate { get; set; }

        [Required(ErrorMessage = "Please enter the subtotal of the transaction.")]
        public decimal Subtotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
