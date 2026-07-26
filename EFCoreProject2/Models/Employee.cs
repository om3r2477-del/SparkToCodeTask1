using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int EmployeeSsn { get; set; }
        public string EmpName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }

        //worksfor 1 to M
        [ForeignKey("D")]
        public int DepartmentId { get; set; }
        public  Department D { get; set; }

        //Dependent 1 to 1
        public Dependent Dependent { get; set; }

        //works on m to m
        public List<Project> projects { get; set; }

        public List<empProj> empProjs { get; set; }

        // manage 
        [InverseProperty("Employee")]
        public Department ManageDepart { get; set; }

        //supervition
        [InverseProperty("supervisor")]
        public List<Employee> supervisee { get; set; }
        [ForeignKey("supervisor")]
        public int supervisorId { get; set; }
        public Employee supervisor { get; set; }


    }
}
