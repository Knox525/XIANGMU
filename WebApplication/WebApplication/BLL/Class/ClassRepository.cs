using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.BLL.Class
{
    public class ClassRepository : IClassRepository
    {
        protected lclEntities db = new lclEntities();
        public List<CourseDetail> GetClassCourse(int id)
        {
            var query =
                  from cm in db.CourseManagements
                  join c in db.classs
                  on cm.ClassId equals c.id
                 
                  
                  join t in db.teacher
                  on cm.TeacherId equals t.id
                  where cm.ClassId == id
                  select new CourseDetail
                  {
                      ClassName = c.Name,
                     
                      TeacherName = t.Name
                  };
            return query.ToList();
        }
    }
}