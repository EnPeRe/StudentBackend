using StudentBackend.Common.Logic;
using System;
using System.Collections.Generic;

namespace StudentBackend.Business.Logic.Contracts
{
    public interface IStudentBusinessLogic
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student Add(Student student);
        Student Update(Student student);
        void Delete(int id);

    }
}
