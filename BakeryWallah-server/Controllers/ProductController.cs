using BakeryWallah.Business.Services;
using BakeryWallah.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(
            IProductService productService)
            : base()
        {
            _productService = productService;
        }
        #region get all users
        [HttpGet]
        [ProducesResponseType(typeof(Products), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllUsers()
        {
            return Ok(_productService.GetAllProducts());
        }
        #endregion
        #region add users
        [HttpPost]
        [ProducesResponseType(typeof(Products), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddProduct(Products products)
        {
            return Ok(_productService.AddProduct(products));
        }
        #endregion

    }
}
