using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;

namespace Business.Processes
{
    public class EmployeeProcesses : BaseProcesses
    {
        public bool AddEmployee(Employee newEmployee)
        {
            try
            {
                dataBase.Employees.Add(newEmployee);
                dataBase.SaveChanges();
                return true;
            }
            catch{
                return false;
            }
        }

        public bool UpdateEmployee(int id, Employee updatedEmployee)
        {
            try
            {
                dataBase.Employees.Find(id).FirstName = updatedEmployee.FirstName;
                dataBase.Employees.Find(id).LastName = updatedEmployee.LastName;
                dataBase.Employees.Find(id).StartDate = updatedEmployee.StartDate;
                dataBase.Employees.Find(id).Title = updatedEmployee.Title;

                dataBase.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                dataBase.Employees.Remove(dataBase.Employees.Find(id));
                dataBase.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
