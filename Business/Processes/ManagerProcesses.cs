using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;

namespace Business.Processes
{
    public class ManagerProcesses : BaseProcesses
    {
        public bool AssignEmployee(int managerId, int employeeId)
        {
            try
            {
                dataBase.Managers.Find(managerId).DirectReports.Add(employeeId);
                dataBase.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public List<Employee> RetrieveReportees(int managerId)
        //{
        //    //var query = from manager in dataBase.Managers
        //    //            join employee in dataBase.Employees 
        //    //            on manager.DirectReports.Contains(
        //    //            employee.EmployeeId) into reportingEmployees
        //    //            select new Employee()
        //    //            ;
            

        //    //return query.ToList();
 
        //}
    }
}
