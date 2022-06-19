using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("GetAllEmployees")]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _unitOfWork.Employee.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public Employee GetById(int id)
        {
            return _unitOfWork.Employee.GetById(id);
        }

        [HttpPost("SaveEmployee")]
        public Employee SaveEmployee(Employee employee)
        {
            return _unitOfWork.Employee.Add(employee);
        }

        [HttpPost("UpdateEmployee")]
        public Employee UpdateEmployee(Employee employee)
        {
            return _unitOfWork.Employee.Update(employee);
        }

        [HttpPost("DeleteEmployee")]
        public void DeleteEmployee(Employee employee)
        {
            _unitOfWork.Employee.Remove(employee);
        }


        public string Get()
        {
            return "API is Running!";
        }
    }
}
