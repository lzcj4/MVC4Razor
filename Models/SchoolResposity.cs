using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4Razor.Models
{
    public class SchoolResposity
    {
        private SchoolDataContext context;

        public SchoolResposity()
            : this(new SchoolDataContext())
        {
        }

        public SchoolResposity(SchoolDataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Class> GetClasses()
        {
            return this.context.Classes.AsEnumerable();
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return this.context.Teachers.AsEnumerable();
        }

        public IEnumerable<Student> GetStudents()
        {
            return this.context.Students.AsEnumerable();
        }

        public bool DeleteClass(int id)
        {
            var c = this.GetClasses().FirstOrDefault(item => item.Id == id);
            if (c != null)
            {
                this.context.Classes.DeleteOnSubmit(c);
                this.context.SubmitChanges();
            }
            return c != null;
        }

        public bool DeleteTeacher(int id)
        {
            var t = this.GetTeachers().FirstOrDefault(item => item.Id == id);
            if (t != null)
            {
                this.context.Teachers.DeleteOnSubmit(t);
                this.context.SubmitChanges();
            }
            return t != null;
        }

        public bool DeleteStudent(int id)
        {
            var s = this.GetStudents().FirstOrDefault(item => item.Id == id);
            if (s != null)
            {
                this.context.Students.DeleteOnSubmit(s);
                this.context.SubmitChanges();
            }
            return s != null;
        }

    }
}