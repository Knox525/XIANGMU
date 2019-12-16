using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public partial class classs
    {
        public string TeacherName
        {
            get
            {
                if (!TeacherId.HasValue)
                {
                    return "";
                }
                lclEntities db = new lclEntities();
                var teacher = db.teacher.Where(t => t.id == TeacherId.Value).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
    }
}