using BakeryWallah.Business.Models;
using BakeryWallah.Business.Services;
using BakeryWallah.Models;
using BakeryWallah.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Data.DataServices
{
    public class UserService : IUserService
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public UserService(
            ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }
        public IEnumerable<IUsers> GetAllUsers()
        {
            return _applicationDBContext.Set<Users>().ToList();
        }
        public ResponseModel AddUser(Users user)
        {
            ResponseModel model = new ResponseModel();
            if (_applicationDBContext != null)
            {
                _applicationDBContext.Add<Users>(user);
                _applicationDBContext.SaveChanges();
                model.Messsage = "User Added Successfully";
                model.IsSuccess = true;
            }
            return model;
        }
        public ResponseModel AddUserTypes(UserTypes userType)
        {
            ResponseModel model1 = new ResponseModel();
            if (_applicationDBContext != null)
            {
                _applicationDBContext.Add<UserTypes>(userType);
                _applicationDBContext.SaveChanges();
                model1.Messsage = "UserType Added Successfully";
                model1.IsSuccess = true;
            }
            return model1;
        }
    }
}
