using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Business.Models
{
    public interface IProducts
    {
        int productId { get; set; }
        string productName { get; set; }
        string productDescription { get; set; }
        int bakerId { get; set; }
        bool IsAvailable { get; set; }
        bool IsActive { get; set; }
        int price { get; set; }
        bool IsVeg { get; set; }
    }
}
