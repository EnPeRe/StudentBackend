using Microsoft.EntityFrameworkCore;
using StudentBackend.Common.Logic;
using StudentBackend.Common.Logic.Contracts;
using StudentBackend.Repository.Logic.Contracts;
using StudentBackend.Repository.Logic.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StudentBackend.Repository.Logic
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext studentContext;
        private readonly IMyLog logger;

        public StudentRepository(StudentContext studentContext, IMyLog logger)
        {
            this.studentContext = studentContext;
            this.logger = logger;
            this.logger.Init(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public Student Add(Student student)
        {
            this.logger.Debug("Adding a Student");
            using (var context = this.studentContext)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return student;
            }
        }

        public List<Student> GetAll()
        {
            this.logger.Debug("Listing all Student");
            using (var context = this.studentContext)
            {
                return context.Students.ToList();
            }
        }

        public Student Update(Student student)
        {
            logger.Debug("Editing student");
            using (var context = this.studentContext)
            {
                var studentToUpdate = context.Students
                    .Find(student.IdAlumno);
                studentToUpdate.Apellido = student.Apellido;
                studentToUpdate.Nombre = student.Nombre;
                studentToUpdate.FechaNacimiento = student.FechaNacimiento;
                studentToUpdate.HoraRegistro = student.HoraRegistro;
                studentToUpdate.Dni = student.Dni;
                studentToUpdate.Edad = student.Edad;
                context.SaveChanges();
                return student;
            }
        }

        public void Delete(int id)
        {
            logger.Debug("Deleting student");
            using (var context = this.studentContext)
            {
                var studentToDelete = context.Students
                    .Find(id);
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
            }
        }

        public Student GetById(int id)
        {
            using (var ctxStudent = this.studentContext)
            {
                return ctxStudent.Students.Find(id);
            }
        }

        public int DeleteAll()
        {
            using (var ctxStudent = this.studentContext)
            {
                return ctxStudent.Database.ExecuteSqlCommand("TRUNCATE TABLE [Student]");
            }
        }
    }
}
