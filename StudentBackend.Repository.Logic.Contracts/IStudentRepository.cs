using StudentBackend.Common.Logic;
using System;
using System.Collections.Generic;

namespace StudentBackend.Repository.Logic.Contracts
{
    public interface IStudentRepository
    {
        Student Add(Student student);
        Student GetById(int id);
        //Student GetByGuid(Guid guid);
        List<Student> GetAll();
        Student Update(Student student);
        void Delete(int id);
        int DeleteAll();
    }
}
