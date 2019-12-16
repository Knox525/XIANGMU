using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication.Models.Seeds
{
    public class ActionLinkCreator
    {
        private  readonly WebApplication.Models.lclEntities  _context;

 
        public ActionLinkCreator(WebApplication.Models.lclEntities context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialActionLink = new List<ActionLink>
            {
                new ActionLink
                {
                   
                    Name = "主页",
                    Controller = "Home",
                    Action = "Index",
                }

            };
            foreach (var action in initialActionLink )
            {
                if (_context.ActionLink.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.ActionLink.Add(action);
            }
            _context.SaveChanges();
        }
    }
}