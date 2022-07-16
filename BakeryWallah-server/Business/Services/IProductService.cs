using BakeryWallah.Business.Models;
using BakeryWallah.Models;
using BakeryWallah.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Business.Services
{
    public interface IProductService
    {
    Task<List<ProductViewmodel>> GetAllProducts();
    ResponseModel AddProduct(Products products);
    }
}
