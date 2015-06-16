namespace Business.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public class Model : DbContext
    {
        public Model()
            : base("name=Model")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }

        
    }

    public class Employee
    {
        [Required]
        public int EmployeeId {get; set;}

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required ]
        public DateTime StartDate { get; set; }
    }

    public class Manager  : Employee
    {
        public List<int> DirectReports {get; set;}

        [Required]
        public int ManagerId { get; set; }
    }

}