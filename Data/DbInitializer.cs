using Web.Models;
using System;
using System.Linq;

namespace Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WebContext context)
        {
            context.Database.EnsureCreated();

            if (context.Peoples.Any())
            {
                return;   
            }

            var peoples = new People[]
            {
            new People{Name="Alex",DisplayName="Alex01",Skill="wery whell"},
            };
            foreach (People s in peoples)
            {
                context.Peoples.Add(s);
            }
            context.SaveChanges();


        }
    }
}