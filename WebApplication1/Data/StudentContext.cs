using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentContext")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}