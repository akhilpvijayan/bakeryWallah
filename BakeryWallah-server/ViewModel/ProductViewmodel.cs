using BakeryWallah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.ViewModel
{
    public class ProductViewmodel
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Baker { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
        public bool IsVeg { get; set; }
        public virtual Users Users { get; set; }
    }
}
