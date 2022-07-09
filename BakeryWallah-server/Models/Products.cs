using BakeryWallah.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Models
{
    public class Products : IProducts
    {
        [Key]
        public int productId { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public string productDescription { get; set; }
        [ForeignKey("User")]
        [Required]
        public int bakerId { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public bool IsVeg { get; set; }
    }
}
