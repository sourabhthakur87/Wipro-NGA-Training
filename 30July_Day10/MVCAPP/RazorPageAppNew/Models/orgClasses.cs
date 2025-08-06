﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageAppNew.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("org")]
        public int OrgId { get; set; }
        public Organization org { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("dept")]
        public int DeptId { get; set; }
        public Department dept { get; set; }
    }

}


//update-database -context ApplicationDbContext
// add-migration -context addcontext
//update-database -context OrgContext

