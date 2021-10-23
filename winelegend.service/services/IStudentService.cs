using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.service.services
{
     public interface IStudentService
    {
         List<Student> GetStudents();
        Student GetStudent(Guid id);
        void DeleteStudent(Guid id);
        void UpdateStudent(Guid id, Student student);
        void create(Student student);

    }
}
