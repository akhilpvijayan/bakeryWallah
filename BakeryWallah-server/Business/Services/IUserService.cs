using BakeryWallah.Business.Models;
using BakeryWallah.Models;
using BakeryWallah.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Business.Services
{
    public interface IUserService
    {
        IEnumerable<IUsers> GetAllUsers();
        ResponseModel AddUser(Users users);
    }
}
