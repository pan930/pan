using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Migrations.Seeds
{
    public class ActionLinkCreator
    {
        private readonly MvcApplication2.Models.CoursemanagerEntities _context;
        public ActionLinkCreator(MvcApplication2.Models.CoursemanagerEntities context)
        {
            _context = context;
        }

        public ActionLinkCreator()
        {
            // TODO: Complete member initialization
        }
        public void Seed()
        {
            var initialActionLinks = new List<ActionLinks>
           {
             new ActionLinks
             {
               Id=1,
               Name="主页",
               Contorller="Home",
               Action="Index"
             }
           };
           foreach (var action in initialActionLinks)
            { 
              if ( _context.ActionLinks.Any(r=>r.Name==action.Name))
              {
                continue ;
              }
                _context.ActionLinks.Add(action);
            }
                _context .SaveChanges();
        }
    }  
 }
