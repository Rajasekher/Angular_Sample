using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_Api.Models;

namespace Test_Api.Controllers
{
    public class Data_ApiController : ApiController
    {
        public static List<Employee>emp=new List<Employee>
        { 
            new Employee { EmpId = 401, EmpName = "Kiran", Salary = 65456 }, 
            new Employee { EmpId = 402, EmpName = "Cherry", Salary = 456887 }, 
            new Employee { EmpId = 403, EmpName = "TEj", Salary = 45145 }};

        public IEnumerable<Employee> Get()
        {
            return emp;
        }
    }
}
