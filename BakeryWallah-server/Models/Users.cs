using BakeryWallah.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Models
{
    public class Users : IUsers
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserAddress { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public long Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Zip { get; set; }
        public long CreditCardNumber { get; set; }
        [Required]
        public int UserTypeId { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
