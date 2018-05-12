using StudentBackend.Business.Logic.Contracts;
using StudentBackend.Common.Logic;
using StudentBackend.Repository.Logic.Contracts;
using System;
using System.Collections.Generic;

namespace StudentBackend.Business.Logic
{
    public class StudentBusinessLogic : IStudentBusinessLogic
    {
        private readonly IStudentRepository studentrepository;


        public StudentBusinessLogic(IStudentRepository studentrepository)
        {
            this.studentrepository = studentrepository;
        }

        public List<Student> GetAll()
        {
            return this.studentrepository.GetAll();
        }

        public Student GetById(int id)
        {
            return this.studentrepository.GetById(id);
        }

        public Student Add(Student student)
        {
            return this.studentrepository.Add(student);
        }

        public Student Update(Student student)
        {
            return this.studentrepository.Update(student);
        }

        public void Delete(int id)
        {
            this.studentrepository.Delete(id);
        }
    }
}
