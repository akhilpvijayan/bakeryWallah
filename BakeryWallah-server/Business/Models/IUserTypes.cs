using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Business.Models
{
    public interface IUserTypes
    {
        int UserTypeId { get; set; }
        string UserType { get; set; }
        bool IsActive { get; set; }
    }
}
