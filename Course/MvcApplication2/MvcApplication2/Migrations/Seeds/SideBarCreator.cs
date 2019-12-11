using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Migrations.Seeds
{
    public class SideBarCreator
    {
        private readonly MvcApplication2.Models.CoursemanagerEntities _context;
        public SideBarCreator(MvcApplication2.Models.CoursemanagerEntities context)
        {
            _context = context;
        }

        public SideBarCreator()
        {
            // TODO: Complete member initialization
        }
        public void Seed()
        {
            var initialSideBars = new List<SideBars>
           {
             new SideBars
               {
               Name="班级管理",
               Contorller="Class",
               Action="Index"
             },
             new SideBars
               {
               Name="教师管理",
               Contorller="Teachers",
               Action="Index"
             },
             new SideBars
               {
               Name="学生管理",
               Contorller="Student",
               Action="Index"
             },
             new SideBars
               {
               Name="课程科目管理",
               Contorller="Course",
               Action="Index"
             },
             new SideBars
               {
               Name="课程安排",
               Contorller="CourseManager",
               Action="Index"
             },
             new SideBars
               {
               Name="顶部导航栏管理",
               Contorller="ActionLink",
               Action="Index"
             },
              new SideBars
               {
               Name="侧边栏管理",
               Contorller="SideBar",
               Action="Index"
             },
           };
           foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
              {
                continue ;
              }
                _context.SideBars.Add(bar);
            }
                _context .SaveChanges();
        }
    }  
}