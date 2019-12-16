using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models.Seeds
{
    public class SideBarCreator
    {
        private readonly WebApplication.Models.lclEntities _context;


        public SideBarCreator(WebApplication.Models.lclEntities context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialSideBars = new List<SideBars>
            {
                new SideBars
                {

                    Name = "班级管理",
                    Controller = "classses",
                    Action = "Index",
                },
                  new SideBars
                {

                    Name = "老师管理",
                    Controller = "teachers",
                    Action = "Index",
                },
                    new SideBars
                {

                    Name = "学生管理",
                    Controller = "students",
                    Action = "Index",
                },
                      new SideBars
                {

                    Name = "课程科目管理",
                    Controller = "Course",
                    Action = "Index",
                },
                        new SideBars
                {

                    Name = "课程安排",
                    Controller = "CourseManagements",
                    Action = "Index",
                },
                          new SideBars
                {

                    Name = "顶部导航栏",
                    Controller = "ActionLink",
                    Action = "Index",
                },
                            new SideBars
                {

                    Name = "侧边栏管理",
                    Controller = "SideBars",
                    Action = "Index",
                },

            };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}
    

    
