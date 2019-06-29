using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Migrations.Seeds
{
    public class UserCreator
    {
       private readonly MvcApplication2.Models.CoursemanagerEntities _context;
        public UserCreator(MvcApplication2.Models.CoursemanagerEntities context)
        {
            _context = context;
        }
         public void Seed()
        {
            var initialActionLinks = new List<Users>
           {
             new Users
             {
              
               Name="admin",
               Account="admin",
               Password="123456"
             }
           };
           foreach (var action in initialActionLinks)
            {
                if (_context.Users.Any(r => r.Name == action.Name))
              {
                continue ;
              }
                _context.Users.Add(action);
            }
                _context .SaveChanges();
        }
   }
}
