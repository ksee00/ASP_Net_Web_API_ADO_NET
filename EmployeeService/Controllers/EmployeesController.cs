using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;


namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<employeesData> Get()
        {
            using (TESTEntities entities = new TESTEntities())
            {
                return entities.employeesDatas.ToList();
            }
        }

        public employeesData Get(int id)
        {
            using (TESTEntities entities = new TESTEntities())
            {
                return entities.employeesDatas.FirstOrDefault(e => e.Id == id);

            }
        }
    }
}
