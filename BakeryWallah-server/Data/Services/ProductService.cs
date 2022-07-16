using BakeryWallah.Business.Models;
using BakeryWallah.Business.Services;
using BakeryWallah.Models;
using BakeryWallah.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public ProductService(
            ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }
        public async Task<List<ProductViewmodel>> GetAllProducts()
        {
            if (_applicationDBContext != null)
            {
                return await (from patient in SelectMany.Products
                              from doctor in db.TblDoctor
                              from appointment in db.TblAppointment
                              from log in db.TblPatientLog
                              from testName in db.TblPrescriptionTest
                              from report in db.TblLabReport
                              from staff in db.TblStaff
                              where report.PatientId == patient.PatientId
                              where log.DoctorId == doctor.DoctorId
                              where log.AppointmentId == appointment.AppointmentId
                              where report.LogId == log.LogId
                              where testName.LogId == log.LogId
                              where report.StaffId == staff.StaffId

                              select new LabReportViewModel
                              {
                                  LogId = log.LogId,
                                  LabReportId = report.LabReportId,
                                  PatientId = patient.PatientId,
                                  PatientName = patient.PatientName,
                                  StaffId = staff.StaffId,
                                  StaffName = staff.StaffName,
                                  DoctorName = doctor.DoctorName,
                                  DateOfAppointment = appointment.DateofAppointment,
                                  TestOneName = testName.TestOne,
                                  TestTwoName = testName.TestTwo,
                                  TestThreeName = testName.TestThree,
                                  ObservedResultOne = report.ObservedResultOne,
                                  ObservedResultThree = report.ObservedResultThree,
                                  ObservedResultTwo = report.ObservedResultTwo


                              }
                                ).ToListAsync();
            }
            return null;
        }

        public ResponseModel AddProduct(Products products)
        {
            ResponseModel model = new ResponseModel();
            if (_applicationDBContext != null)
            {
                _applicationDBContext.Add<Products>(products);
                _applicationDBContext.SaveChanges();
                model.Messsage = "Product Added Successfully";
                model.IsSuccess = true;
            }
            return model;
        }
    }
}
