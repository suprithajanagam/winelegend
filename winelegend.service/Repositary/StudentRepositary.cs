using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Repositary
{
    public class StudentRepositary: IStudentService
    {
        private readonly WineLegendContext _dbcontext;
        public StudentRepositary()
        {
            this._dbcontext = new WineLegendContext();
        }
        public List<Student> GetStudents()
        {
            List<Student> students = _dbcontext.Students.ToList();
            return students.ToList();
        }

        public Student GetStudent(Guid id)
        {
            var _student = _dbcontext.Students.Where(x => x.StudentID == id).SingleOrDefault();
            return _student;
        }


        public void DeleteStudent(Guid id)
        {
            if(id!=null)
            {
                var student = _dbcontext.Students.Find(id);
                {
                    _dbcontext.Students.Remove(student);
                    _dbcontext.SaveChanges();

                }
            }
        }
        public void UpdateStudent(Guid id,Student student)
        {
            Student students = _dbcontext.Students.Where(x => x.StudentID == id).SingleOrDefault();
            {
                if (students != null)
                {
                    students.StudentName = student.StudentName;
                    students.Weight = student.Weight;
                    students.Photo = student.Photo;
                    students.Height = student.Height;
                   
                }
                _dbcontext.SaveChanges();
            }
            
        }

        public void create(Student student)
        {
            _dbcontext.Students.Add(student);
            _dbcontext.SaveChanges();
        }
    }
}