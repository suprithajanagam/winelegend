using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.web.Services
{
    public interface IStudentService
    {
       Task<bool> Save(Student student);

        void Delete(Guid Id);

        void Update(Guid Id, Student student);

        Student Get(Guid Id);

        Task<List<Student>> Get(string str = "");

    }
}
