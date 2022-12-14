using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Required CompanyName")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Required ContactName")]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "Required ContactTitle")]
        public string ContactTitle { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Required City")]
        public string City { get; set; }
        public string Region { get; set; }
    }

}
