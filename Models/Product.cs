using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Core9.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }

    public class ProductList
    {
        public static List<Product> Products = new List<Product>();
    }
}
