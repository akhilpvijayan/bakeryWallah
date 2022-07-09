using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Business.Models
{
    public interface IUsers
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserAddress { get; set; }

        string UserName { get; set; }
        string UserPassword { get; set; }
        string City { get; set; }
        string State { get; set; }
        long Phone { get; set; }
        string Email { get; set; }
        int Zip { get; set; }
        long CreditCardNumber { get; set; }
        int UserTypeId { get; set; }
        bool IsActive { get; set; }
    }
}
