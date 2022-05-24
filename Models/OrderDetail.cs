using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team4_Project.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        public int? OrderID { get; set; }
        public virtual Order Order { get; set; }

        public int ItemID { get; set; }
        public Inventory Item { get; set; }

        public int OrderQuantity { get; set; }

        public decimal OrderDetailSubtotal { get; set; }
    }
}
