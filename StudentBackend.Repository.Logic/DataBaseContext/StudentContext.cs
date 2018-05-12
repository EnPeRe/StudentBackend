using Microsoft.EntityFrameworkCore;
using StudentBackend.Common.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBackend.Repository.Logic.DataBaseContext
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfiguration.GetConnectionString(GetType()));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
