using BakeryWallah.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Models
{
    public class UserTypes : IUserTypes
    {
        [Key]
        public int UserTypeId { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
